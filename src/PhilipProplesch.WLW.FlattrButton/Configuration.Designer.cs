namespace PhilipProplesch.WLW.FlattrButton
{
    partial class Configuration
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
            this.Save = new System.Windows.Forms.Button();
            this.IdLabel = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.TextBox();
            this.DisplayModeLabel = new System.Windows.Forms.Label();
            this.DisplayMode = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(197, 10);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 49);
            this.Save.TabIndex = 0;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(12, 15);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(44, 13);
            this.IdLabel.TabIndex = 1;
            this.IdLabel.Text = "Your Id:";
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(91, 12);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(100, 20);
            this.Id.TabIndex = 2;
            // 
            // DisplayModeLabel
            // 
            this.DisplayModeLabel.AutoSize = true;
            this.DisplayModeLabel.Location = new System.Drawing.Point(12, 41);
            this.DisplayModeLabel.Name = "DisplayModeLabel";
            this.DisplayModeLabel.Size = new System.Drawing.Size(73, 13);
            this.DisplayModeLabel.TabIndex = 3;
            this.DisplayModeLabel.Text = "Display mode:";
            // 
            // DisplayMode
            // 
            this.DisplayMode.FormattingEnabled = true;
            this.DisplayMode.Items.AddRange(new object[] {
            "Normal",
            "Compact"});
            this.DisplayMode.Location = new System.Drawing.Point(91, 38);
            this.DisplayMode.Name = "DisplayMode";
            this.DisplayMode.Size = new System.Drawing.Size(100, 21);
            this.DisplayMode.TabIndex = 5;
            this.DisplayMode.Text = "Normal";
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 70);
            this.Controls.Add(this.DisplayMode);
            this.Controls.Add(this.DisplayModeLabel);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.Save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Configuration";
            this.Text = "Flattr button";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.Label DisplayModeLabel;
        private System.Windows.Forms.ComboBox DisplayMode;
    }
}