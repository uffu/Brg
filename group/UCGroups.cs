using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupCreator
{
    public partial class UCGroups : UserControl
    {
        public UCGroups()
        {
            InitializeComponent();
        }
        public void setWordsPanel(FlowLayoutPanel wordsPanel) { WordsPanel = wordsPanel; }
        private FlowLayoutPanel WordsPanel;

        public void populateGroups(List<group> Groups)
        {
            panel.Controls.Clear();

            foreach (group g in Groups)
                createGroup(g.name, g.backColor, g.words);
        }


        public List<group> getGroups()
        {
            List<group> g = new List<group>();
            foreach (Control c in panel.Controls)
                if (c is UCGroup)
                {
                    UCGroup gr = (UCGroup)c;
                    g.Add(new group() { name = gr.getName(), backColor = gr.getBackColor(), words = gr.getWords() });                    
                }
            return g;
        }


        private int ColorIndex = -1;
        private bool colorCheck = true;
        private bool checkGroupColor(Color c)
        {
            foreach (Control control in panel.Controls)
                if (control is UCGroup)
                {
                    UCGroup g = (UCGroup)control;
                    Color color = g.getBackColor();
                    if (color == c)
                        return false;
                }
            return true;
        }
        public void CreateNewGroup()
        {
            ColorIndex++;
            if (ColorIndex >= Tools.colors.Length)
            {
                ColorIndex %= Tools.colors.Length;
                colorCheck = false;
            }
            else
                while (!checkGroupColor(Tools.colors[ColorIndex]) && colorCheck)
                    ColorIndex++;
           
            createGroup("", Tools.colors[ColorIndex], null);            
        }
        

        private void createGroup(string name, Color backColor, List<word> Words)
        {
            UCGroup gr = new UCGroup();
            gr.setWordsPanel(WordsPanel);

            gr.setBackColor(backColor);
            gr.setName(name);
            gr.setWords(Words);           

            panel.Controls.Add(gr);
        }
    }
}
