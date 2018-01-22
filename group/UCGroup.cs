using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GroupCreator
{
    public partial class UCGroup : UserControl
    {
        private const int HEIGHT_PANEL = 150;
        private const int HEIGHT_TOP = 50;
        public UCGroup()
        {
            InitializeComponent();

            panel.AllowDrop = true;
            panel.DragDrop += panel_DragDrop;
            panel.DragEnter += panel_DragEnter;
            panel.ControlAdded += panel_ControlAdded;
            panel.ControlRemoved += panel_ControlRemoved;
        }        

        public void setWordsPanel(FlowLayoutPanel wordsPanel) { WordsPanel = wordsPanel; }
        private FlowLayoutPanel WordsPanel;

        public void setName(string name) { textBox_name.Text = name; }
        public void setBackColor(Color color) { this.BackColor = color; }
        public void setWords(List<word> Words)
        {
            if (Words == null) return;
            foreach (word w in Words)
                panel.Controls.Add(_Label.createLabel(w));
        }

        public List<word> getWords()
        { return Tools.getWordsFromPanel(panel); }
        public string getName() { return textBox_name.Text; }
        public Color getBackColor() { return this.BackColor; }




        private void updateCount()
        {
            int sum = 0;
            foreach (Control c in panel.Controls)
                if (c is Label)
                    sum += int.Parse(c.Text.Split('_')[0]);
            label_count.Text = sum.ToString();
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
            updateCount();
        }
        private void panel_ControlRemoved(object sender, ControlEventArgs e)
        {
            updateCount();
        }




        private void button_close_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show(
                "Toplam " + label_count.Text + " kisinin soyledigi, '" + textBox_name.Text + "' gidecek. Emin misni?? Gitsin mi??",
                "Gidiyo",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning);
            if (confirmation != DialogResult.Yes) return;

            panel.ControlRemoved -= panel_ControlRemoved;

            for (int i = panel.Controls.Count - 1; i >= 0; i--)
                if (panel.Controls[i] is Label)
                    panel.Controls[i].Parent = WordsPanel;

            this.Parent.Controls.Remove(this);
        }



        private bool isLarge = false;
        private void Control_DoubleClick(object sender, EventArgs e)
        { ResizeGroup(); OnDoubleClick(e); }
        private void UCGroup_DoubleClick(object sender, EventArgs e)
        { ResizeGroup(); }
        private void panel_DoubleClick(object sender, EventArgs e)
        { ResizeGroup(); }
        private void button_resize_Click(object sender, EventArgs e)
        { ResizeGroup(); }
        private void ResizeGroup()
        {
            if (isLarge)
            {
                Height = HEIGHT_PANEL + HEIGHT_TOP;
                panel.Height = HEIGHT_PANEL;
                button_resize.Text = "<>";
                isLarge = false;
            }
            else
            {
                Height = panel.DisplayRectangle.Height + HEIGHT_TOP;
                panel.Height = panel.DisplayRectangle.Height;
                button_resize.Text = "><";
                isLarge = true;
            }
        }

        
    }
}
