namespace Game
{
    partial class PauseForm
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
            this.resumeButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resumeButton
            // 
            this.resumeButton.BackColor = System.Drawing.Color.LightBlue;
            this.resumeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.resumeButton.Location = new System.Drawing.Point(289, 118);
            this.resumeButton.Name = "resumeButton";
            this.resumeButton.Size = new System.Drawing.Size(229, 56);
            this.resumeButton.TabIndex = 0;
            this.resumeButton.Text = "Resume";
            this.resumeButton.UseVisualStyleBackColor = false;
            this.resumeButton.Click += new System.EventHandler(this.resumeButton_Click);
            // 
            // restartButton
            // 
            this.restartButton.BackColor = System.Drawing.Color.LightBlue;
            this.restartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.restartButton.Location = new System.Drawing.Point(289, 180);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(229, 56);
            this.restartButton.TabIndex = 1;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = false;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.BackColor = System.Drawing.Color.LightBlue;
            this.mainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.mainMenuButton.Location = new System.Drawing.Point(289, 242);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(229, 56);
            this.mainMenuButton.TabIndex = 2;
            this.mainMenuButton.Text = "Main Menu";
            this.mainMenuButton.UseVisualStyleBackColor = false;
            this.mainMenuButton.Click += new System.EventHandler(this.mainMenuButton_Click);
            // 
            // PauseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainMenuButton);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.resumeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PauseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PauseForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button resumeButton;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Button mainMenuButton;
    }
}