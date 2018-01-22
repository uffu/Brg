using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GroupCreator
{


    public class Tools
    {
        public static List<word> getWordsFromTXT()
        {
            List<word> list = new List<word>();
            foreach (string line in File.ReadAllLines("words.txt"))
            {
                string[] s = line.Split('#');
                list.Add(new word() { count = int.Parse(s[0]), text = s[1].ToLower() });
            }
            return list;
        }



        public static Color[] colors = {
            Color.DeepSkyBlue,
            Color.Cyan,
            Color.LightGreen,
            Color.Gold,
            Color.DarkGreen,
            Color.MidnightBlue,
            Color.LightSeaGreen,
            Color.RoyalBlue,
            Color.Fuchsia,
            Color.BlueViolet,
            Color.Firebrick,
            Color.Gray,
            Color.Maroon,
            Color.HotPink,
            Color.Yellow,
            Color.OrangeRed,
            Color.MediumSlateBlue,
            Color.Lime,
            Color.Red,
            Color.MediumPurple,
            Color.SpringGreen,
            Color.DeepPink,
            Color.Tomato,
            Color.Olive,
            Color.Silver,
            Color.MediumBlue,
            Color.Khaki
        };
        

        public static List<word> getWordsFromPanel(FlowLayoutPanel panel)
        {
            List<word> w = new List<word>();
            foreach (Control c in panel.Controls)
                if (c is Label)
                {
                    string[] s = c.Text.Split('_');
                    w.Add(new word() { text = s[1], count = int.Parse(s[0]) });
                }
            return w;
        }

        public static void ReorderLabels(ref FlowLayoutPanel panel)
        {
            List<Label> orderedLabels = new List<Label>();
            foreach (Control c in panel.Controls)
                if (c is Label)
                    orderedLabels.Add((Label)c);

            orderedLabels = orderedLabels
                .OrderByDescending(o => int.Parse(o.Text.Split('_')[0])).ToList();

            for (int i = 0; i < orderedLabels.Count; i++)
                panel.Controls.SetChildIndex(orderedLabels[i], i);

        }
    }
}
