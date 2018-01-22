namespace GroupCreator
{
    partial class UCWords
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCWords));
            this.panel = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox_search = new GroupCreator.AutoCompleteTextbox();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.AutoScroll = true;
            this.panel.Location = new System.Drawing.Point(0, 33);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(148, 332);
            this.panel.TabIndex = 0;
            // 
            // textBox_search
            // 
            this.textBox_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_search.AutoCompleteList = ((System.Collections.Generic.List<string>)(resources.GetObject("textBox_search.AutoCompleteList")));
            this.textBox_search.CaseSensitive = false;
            this.textBox_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_search.Location = new System.Drawing.Point(4, 1);
            this.textBox_search.MinTypedCharacters = 2;
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.SelectedIndex = -1;
            this.textBox_search.Size = new System.Drawing.Size(126, 26);
            this.textBox_search.TabIndex = 1;
            // 
            // UCWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.panel);
            this.Name = "UCWords";
            this.Size = new System.Drawing.Size(148, 365);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panel;
        private AutoCompleteTextbox textBox_search;
    }
}
