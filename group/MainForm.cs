using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GroupCreator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ucGroups.setWordsPanel(ucWords.getWordsPanel());

            LoadData();

            AutoSaveTimer.Interval = 2 * 60 * 1000;
            AutoSaveTimer.Tick += AutoSaveTimer_Tick;
            AutoSaveTimer.Start();
        }

        private void AutoSaveTimer_Tick(object sender, EventArgs e)
        {
            SaveLoad.Save.Data_auto(ucGroups.getGroups(), ucWords.getWords());
        }

        private Timer AutoSaveTimer = new Timer();

        private void LoadData()
        {
            //Words = Tools.getWordsFromTXT();
            List<word> Words = SaveLoad.Load.Words();
            ucWords.populateWords(Words);

            List<group> Groups = SaveLoad.Load.Groups();
            ucGroups.populateGroups(Groups);
        }

        private void SaveData()
        {
            SaveLoad.Save.Data(ucGroups.getGroups(), ucWords.getWords());
        }
        

     
        private void button_new_group_Click(object sender, EventArgs e)
        { ucGroups.CreateNewGroup(); }
        private void button_save_Click(object sender, EventArgs e)
        { SaveData(); }
        private void button_load_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show(
               "Geri yukleme? Kaydetmedigin bilgiler gider bak. Emin misin?",
               "Geri yukleme",
               MessageBoxButtons.YesNoCancel,
               MessageBoxIcon.Warning);
            if (confirmation != DialogResult.Yes) return;

            LoadData();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AutoSaveTimer.Stop();
            AutoSaveTimer_Tick(null, null);
        }
    }
}
