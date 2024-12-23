namespace Game
{
    partial class GameForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.road = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.road1 = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.labelLose = new System.Windows.Forms.Label();
            this.restartButton = new System.Windows.Forms.Button();
            this.coin = new System.Windows.Forms.PictureBox();
            this.coinCounter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.road)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.road1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).BeginInit();
            this.SuspendLayout();
            // 
            // road
            // 
            this.road.Image = ((System.Drawing.Image)(resources.GetObject("road.Image")));
            this.road.Location = new System.Drawing.Point(0, 0);
            this.road.Name = "road";
            this.road.Size = new System.Drawing.Size(840, 650);
            this.road.TabIndex = 0;
            this.road.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(323, 518);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(70, 120);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 15;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // road1
            // 
            this.road1.Image = ((System.Drawing.Image)(resources.GetObject("road1.Image")));
            this.road1.Location = new System.Drawing.Point(0, -650);
            this.road1.Name = "road1";
            this.road1.Size = new System.Drawing.Size(840, 650);
            this.road1.TabIndex = 2;
            this.road1.TabStop = false;
            // 
            // enemy1
            // 
            this.enemy1.Image = ((System.Drawing.Image)(resources.GetObject("enemy1.Image")));
            this.enemy1.Location = new System.Drawing.Point(196, -130);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(70, 120);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy1.TabIndex = 3;
            this.enemy1.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.Image = ((System.Drawing.Image)(resources.GetObject("enemy2.Image")));
            this.enemy2.Location = new System.Drawing.Point(579, -270);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(70, 120);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy2.TabIndex = 4;
            this.enemy2.TabStop = false;
            // 
            // labelLose
            // 
            this.labelLose.AutoSize = true;
            this.labelLose.BackColor = System.Drawing.Color.White;
            this.labelLose.Font = new System.Drawing.Font("Lucida Sans Typewriter", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLose.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelLose.Location = new System.Drawing.Point(327, 48);
            this.labelLose.Name = "labelLose";
            this.labelLose.Size = new System.Drawing.Size(185, 39);
            this.labelLose.TabIndex = 5;
            this.labelLose.Text = "YOU LOSE";
            // 
            // restartButton
            // 
            this.restartButton.BackColor = System.Drawing.Color.White;
            this.restartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restartButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20F, System.Drawing.FontStyle.Bold);
            this.restartButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.restartButton.Location = new System.Drawing.Point(354, 103);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(132, 41);
            this.restartButton.TabIndex = 6;
            this.restartButton.Text = "RESTART";
            this.restartButton.UseVisualStyleBackColor = false;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // coin
            // 
            this.coin.BackColor = System.Drawing.Color.Transparent;
            this.coin.Image = ((System.Drawing.Image)(resources.GetObject("coin.Image")));
            this.coin.Location = new System.Drawing.Point(472, -500);
            this.coin.Name = "coin";
            this.coin.Size = new System.Drawing.Size(40, 40);
            this.coin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin.TabIndex = 7;
            this.coin.TabStop = false;
            // 
            // coinCounter
            // 
            this.coinCounter.AutoSize = true;
            this.coinCounter.BackColor = System.Drawing.Color.White;
            this.coinCounter.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18F, System.Drawing.FontStyle.Bold);
            this.coinCounter.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.coinCounter.Location = new System.Drawing.Point(12, 9);
            this.coinCounter.Name = "coinCounter";
            this.coinCounter.Size = new System.Drawing.Size(124, 27);
            this.coinCounter.TabIndex = 8;
            this.coinCounter.Text = "COINS: 0";
            // 
            // GameForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(840, 650);
            this.Controls.Add(this.coinCounter);
            this.Controls.Add(this.coin);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.labelLose);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.road);
            this.Controls.Add(this.road1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.road)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.road1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox road;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox road1;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.Label labelLose;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.PictureBox coin;
        private System.Windows.Forms.Label coinCounter;
    }
}

