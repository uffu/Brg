using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Xml;

namespace GroupCreator
{
    class SaveLoad
    {
        public const string DEFAULT_XML_FILE = "words.xml";
        public class Load
        {
            private static word getWordFromXmnNode(XmlNode node) { return new word() { text = node.InnerText, count = int.Parse(node.Attributes["count"].Value) }; }
            public static List<word> Words() { return Words(DEFAULT_XML_FILE); }
            public static List<word> Words(string fileName)
            {
                List<word> w = new List<word>();

                XmlDocument xml = new XmlDocument();
                xml.Load(fileName);

                foreach (XmlNode wNode in xml["db"]["words"])
                    w.Add(getWordFromXmnNode(wNode));

                return w;
            }

            public static List<group> Groups() { return Groups(DEFAULT_XML_FILE); }
            public static List<group> Groups(string fileName)
            {
                List<group> groups = new List<group>();

                XmlDocument xml = new XmlDocument();
                xml.Load(fileName);


                foreach (XmlNode gNode in xml["db"]["groups"])
                {
                    group g = new group();
                    g.name = gNode.Attributes["name"].Value;
                    g.backColor = Color.FromName(gNode.Attributes["color"].Value);
                    foreach (XmlNode wNode in gNode.ChildNodes)
                        g.words.Add(getWordFromXmnNode(wNode));
                    groups.Add(g);
                }
                return groups;
            }

        }


        public class Save
        {
            public static void Data(List<group> groups, List<word> words) { Data(groups, words, DEFAULT_XML_FILE, true); }
            public static void Data(List<group> groups, List<word> words, string fileName, bool backup)
            {
                if (backup)
                {
                    if (File.Exists(fileName))
                        File.Move(fileName, fileName.Replace(".xml", DateTime.Now.ToString("_yyyyMMdd_HHmmss") + ".xml"));
                }

                XmlDocument xml = new XmlDocument();
                xml.AppendChild(xml.CreateXmlDeclaration("1.0", null, null));

                XmlElement root = xml.CreateElement("db");
                XmlElement wNode = xml.CreateElement("words");
                XmlElement gNode = xml.CreateElement("groups");

                xml.AppendChild(root);

                root.AppendChild(wNode);
                root.AppendChild(gNode);

                foreach(word w in words)
                {
                    XmlElement wElem = xml.CreateElement("word");
                    XmlAttribute wAttrbCount = xml.CreateAttribute("count");
                    wElem.Attributes.Append(wAttrbCount);
                    wAttrbCount.Value = w.count.ToString();
                    wElem.InnerText = w.text;

                    wNode.AppendChild(wElem);
                }

                foreach(group g in groups)
                {
                    XmlElement gElem = xml.CreateElement("group");
                    XmlAttribute gAttrbName = xml.CreateAttribute("name");
                    XmlAttribute gAttrbColor = xml.CreateAttribute("color");
                    gElem.Attributes.Append(gAttrbName);
                    gElem.Attributes.Append(gAttrbColor);

                    gAttrbName.Value = g.name;
                    gAttrbColor.Value = g.backColor.Name;

                    foreach (word w in g.words)
                    {
                        XmlElement wElem = xml.CreateElement("word");
                        XmlAttribute wAttrbCount = xml.CreateAttribute("count");
                        wElem.Attributes.Append(wAttrbCount);
                        wAttrbCount.Value = w.count.ToString();
                        wElem.InnerText = w.text;

                        gElem.AppendChild(wElem);
                    }
                    gNode.AppendChild(gElem);
                }

                xml.Save(fileName);
            }

            public static void Data_auto(List<group> groups, List<word> words) { Data(groups, words, "autosave.xml", false); }
        }
    }
}
