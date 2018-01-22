namespace GroupCreator
{
    partial class UCGroup
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
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.button_close = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.FlowLayoutPanel();
            this.label_count = new System.Windows.Forms.Label();
            this.button_resize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_name.Location = new System.Drawing.Point(3, 10);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(135, 32);
            this.textBox_name.TabIndex = 0;
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.Color.Salmon;
            this.button_close.Location = new System.Drawing.Point(217, 10);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(30, 32);
            this.button_close.TabIndex = 1;
            this.button_close.Text = "X";
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // panel
            // 
            this.panel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel.AutoScroll = true;
            this.panel.Location = new System.Drawing.Point(0, 50);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(250, 150);
            this.panel.TabIndex = 2;
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_count.Location = new System.Drawing.Point(144, 18);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(16, 18);
            this.label_count.TabIndex = 3;
            this.label_count.Text = "0";
            // 
            // button_resize
            // 
            this.button_resize.BackColor = System.Drawing.Color.GreenYellow;
            this.button_resize.Location = new System.Drawing.Point(181, 10);
            this.button_resize.Name = "button_resize";
            this.button_resize.Size = new System.Drawing.Size(30, 32);
            this.button_resize.TabIndex = 4;
            this.button_resize.Text = "<>";
            this.button_resize.UseVisualStyleBackColor = false;
            this.button_resize.Click += new System.EventHandler(this.button_resize_Click);
            // 
            // UCGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_resize);
            this.Controls.Add(this.label_count);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.textBox_name);
            this.Name = "UCGroup";
            this.Size = new System.Drawing.Size(250, 200);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.FlowLayoutPanel panel;
        private System.Windows.Forms.Label label_count;
        private System.Windows.Forms.Button button_resize;
    }
}
