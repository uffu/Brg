namespace GroupCreator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button_save = new System.Windows.Forms.Button();
            this.button_new_group = new System.Windows.Forms.Button();
            this.button_load = new System.Windows.Forms.Button();
            this.ucGroups = new GroupCreator.UCGroups();
            this.ucWords = new GroupCreator.UCWords();
            this.SuspendLayout();
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(153, 8);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 6;
            this.button_save.Text = "Kaydet";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_new_group
            // 
            this.button_new_group.Location = new System.Drawing.Point(12, 8);
            this.button_new_group.Name = "button_new_group";
            this.button_new_group.Size = new System.Drawing.Size(75, 23);
            this.button_new_group.TabIndex = 7;
            this.button_new_group.Text = "Yeni Grup";
            this.button_new_group.UseVisualStyleBackColor = true;
            this.button_new_group.Click += new System.EventHandler(this.button_new_group_Click);
            // 
            // button_load
            // 
            this.button_load.Location = new System.Drawing.Point(333, 8);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(75, 23);
            this.button_load.TabIndex = 6;
            this.button_load.Text = "Geri Yükle";
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // ucGroups
            // 
            this.ucGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucGroups.Location = new System.Drawing.Point(-4, 37);
            this.ucGroups.Name = "ucGroups";
            this.ucGroups.Size = new System.Drawing.Size(555, 414);
            this.ucGroups.TabIndex = 5;
            // 
            // ucWords
            // 
            this.ucWords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucWords.Dock = System.Windows.Forms.DockStyle.Right;
            this.ucWords.Location = new System.Drawing.Point(557, 0);
            this.ucWords.Name = "ucWords";
            this.ucWords.Size = new System.Drawing.Size(230, 451);
            this.ucWords.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 451);
            this.Controls.Add(this.button_new_group);
            this.Controls.Add(this.button_load);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.ucGroups);
            this.Controls.Add(this.ucWords);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Kelimeler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private UCWords ucWords;
        private UCGroups ucGroups;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_new_group;
        private System.Windows.Forms.Button button_load;
    }
}

