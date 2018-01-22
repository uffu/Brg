using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GroupCreator
{
    public class word
    {
        public string text;
        public int count;
    }
    public class group
    {
        public string name;
        public List<word> words = new List<word>();
        public Color backColor;
    }

    public class _Label
    {
        public static Label createLabel(word w)
        {
            Label label = new Label();
            label.Text = w.count.ToString() + "_" + w.text;
            label.Font = new Font("Cambria", 12);
            label.AutoEllipsis = true;
            label.Width = 200;
            label.MouseDown += Label_MouseDown;

            ToolTip t = new ToolTip();
            t.SetToolTip(label, label.Text);

            return label;
        }


        private static void Label_MouseDown(object sender, MouseEventArgs e)
        {
            Label label = (Label)sender;
            label.DoDragDrop(label, DragDropEffects.Move);
        }
    }

}
    

