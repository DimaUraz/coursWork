namespace Game
{
    partial class Contacts
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contacts));
            this.githubButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.vkButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // githubButton
            // 
            this.githubButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.githubButton.Location = new System.Drawing.Point(272, 186);
            this.githubButton.Name = "githubButton";
            this.githubButton.Size = new System.Drawing.Size(244, 51);
            this.githubButton.TabIndex = 2;
            this.githubButton.Text = "GitHub";
            this.githubButton.UseVisualStyleBackColor = true;
            this.githubButton.Click += new System.EventHandler(this.githubButton_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.backButton.Location = new System.Drawing.Point(272, 243);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(244, 54);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Back To Menu";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(10, 10);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(1, 1);
            this.axWindowsMediaPlayer1.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox1.Location = new System.Drawing.Point(665, 417);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 21);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Urazov Dmitry 4341";
            // 
            // vkButton
            // 
            this.vkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.vkButton.Location = new System.Drawing.Point(272, 129);
            this.vkButton.Name = "vkButton";
            this.vkButton.Size = new System.Drawing.Size(244, 51);
            this.vkButton.TabIndex = 7;
            this.vkButton.Text = "vk";
            this.vkButton.UseVisualStyleBackColor = true;
            this.vkButton.Click += new System.EventHandler(this.vkButton_Click);
            // 
            // Contacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vkButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.githubButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Contacts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Button githubButton;
        private System.Windows.Forms.Button backButton;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button vkButton;
    }
}
