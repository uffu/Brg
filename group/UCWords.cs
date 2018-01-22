using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GroupCreator
{
    public partial class UCWords : UserControl
    {
        public UCWords()
        {
            InitializeComponent();              

            panel.AllowDrop = true;
            panel.DragDrop += panel_DragDrop;
            panel.DragEnter += panel_DragEnter;
            panel.ControlAdded += panel_ControlAdded;
            panel.ControlRemoved += panel_ControlRemoved;

            textBox_search.init();
            textBox_search.AutoCompleteList = new List<string>();
            textBox_search.MinTypedCharacters = 3;
            textBox_search.CaseSensitive = false;
            textBox_search.OnItemSelected += textBox_search_OnItemSelected;

            HighlightedLabelTimer.Interval = 7000;
            HighlightedLabelTimer.Tick += LabelHighlightTimer_Tick;
        }



        public FlowLayoutPanel getWordsPanel() { return panel; }

        public void populateWords(List<word> Words)
        {
            // remove handle so it wont be called again and again
            panel.ControlAdded -= panel_ControlAdded;
            panel.Controls.Clear();

            List<word> sorted = Words.OrderByDescending(o => o.count).ToList();
            foreach (word w in sorted)
            {
                Label label = _Label.createLabel(w);
                panel.Controls.Add(label);
                textBox_search.AutoCompleteList.Add(label.Text);

            }

            panel.ControlAdded += panel_ControlAdded;
        }


        public List<word> getWords()
        {
            return Tools.getWordsFromPanel(panel);
        }





        

        private void Label_MouseDown(object sender, MouseEventArgs e)
        {
            Label label = (Label)sender;
            label.DoDragDrop(label, DragDropEffects.Move);
        }



        private void panel_DragDrop(object sender, DragEventArgs e)
        {
            ((Label)e.Data.GetData(typeof(Label))).Parent = (Panel)sender;
        }
        private void panel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
        private void panel_ControlAdded(object sender, ControlEventArgs e)
        {
            Tools.ReorderLabels(ref panel);
            textBox_search.AutoCompleteList.Add(e.Control.Text);
        }
        private void panel_ControlRemoved(object sender, ControlEventArgs e)
        {
            Tools.ReorderLabels(ref panel);
            textBox_search.AutoCompleteList.Remove(e.Control.Text);
        }

        private Label HighlightedLabel;
        private Timer HighlightedLabelTimer = new Timer();
        private void textBox_search_OnItemSelected(object sender, ItemSelectedEventArgs e)
        {
            foreach (Control c in panel.Controls)
                if (c is Label)
                {
                    Label label = (Label)c;
                    if (label.Text == e.Item)
                    {
                        panel.ScrollControlIntoView(label);                      
                        label.BackColor = System.Drawing.Color.GreenYellow;
                        HighlightedLabel = label;
                        HighlightedLabelTimer.Start();
                        return;
                    }
                }
        }
        private void LabelHighlightTimer_Tick(object sender, EventArgs e)
        {
            HighlightedLabel.BackColor = System.Drawing.Color.Transparent;
            HighlightedLabelTimer.Stop();
            /*
            foreach (Control c in panel.Controls)
                if (c is Label)
                {
                    Label label = (Label)c;
                    label.BackColor = System.Drawing.Color.Transparent;
                }
             */
        }

    }
}
