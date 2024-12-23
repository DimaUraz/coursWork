namespace Game
{
    partial class MainMenuForm
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
            this.contactsButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.difficultyComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // contactsButton
            // 
            this.contactsButton.BackColor = System.Drawing.Color.Orange;
            this.contactsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.contactsButton.Location = new System.Drawing.Point(318, 181);
            this.contactsButton.Name = "contactsButton";
            this.contactsButton.Size = new System.Drawing.Size(166, 44);
            this.contactsButton.TabIndex = 0;
            this.contactsButton.Text = "CONTACTS";
            this.contactsButton.UseVisualStyleBackColor = false;
            this.contactsButton.Click += new System.EventHandler(this.contactsButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.GreenYellow;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.startButton.Location = new System.Drawing.Point(318, 58);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(166, 44);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.OrangeRed;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.exitButton.Location = new System.Drawing.Point(318, 231);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(166, 44);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // difficultyComboBox
            // 
            this.difficultyComboBox.FormattingEnabled = true;
            this.difficultyComboBox.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.difficultyComboBox.Location = new System.Drawing.Point(339, 108);
            this.difficultyComboBox.Name = "difficultyComboBox";
            this.difficultyComboBox.Size = new System.Drawing.Size(121, 21);
            this.difficultyComboBox.TabIndex = 3;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.difficultyComboBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.contactsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button contactsButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ComboBox difficultyComboBox;
    }
}