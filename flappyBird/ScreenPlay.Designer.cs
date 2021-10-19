
namespace flappyBird
{
    partial class ScreenPlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenPlay));
            this.Score = new System.Windows.Forms.Label();
            this.topPipe = new System.Windows.Forms.PictureBox();
            this.botPipe = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.gameOver = new System.Windows.Forms.Label();
            this.bird = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.topPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            this.SuspendLayout();
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.Color.Transparent;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(12, 9);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(144, 37);
            this.Score.TabIndex = 0;
            this.Score.Text = "Score: 0";
            this.Score.UseWaitCursor = true;
            this.Score.Click += new System.EventHandler(this.Score_Click);
            // 
            // topPipe
            // 
            this.topPipe.BackColor = System.Drawing.Color.Transparent;
            this.topPipe.Image = ((System.Drawing.Image)(resources.GetObject("topPipe.Image")));
            this.topPipe.Location = new System.Drawing.Point(803, 9);
            this.topPipe.Name = "topPipe";
            this.topPipe.Size = new System.Drawing.Size(100, 174);
            this.topPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topPipe.TabIndex = 1;
            this.topPipe.TabStop = false;
            this.topPipe.UseWaitCursor = true;
            // 
            // botPipe
            // 
            this.botPipe.BackColor = System.Drawing.Color.Transparent;
            this.botPipe.Image = ((System.Drawing.Image)(resources.GetObject("botPipe.Image")));
            this.botPipe.Location = new System.Drawing.Point(516, 273);
            this.botPipe.Name = "botPipe";
            this.botPipe.Size = new System.Drawing.Size(100, 208);
            this.botPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.botPipe.TabIndex = 2;
            this.botPipe.TabStop = false;
            this.botPipe.UseWaitCursor = true;
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(-1, 405);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(940, 76);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            this.ground.UseWaitCursor = true;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // gameOver
            // 
            this.gameOver.AutoSize = true;
            this.gameOver.BackColor = System.Drawing.Color.White;
            this.gameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOver.Location = new System.Drawing.Point(291, 134);
            this.gameOver.Name = "gameOver";
            this.gameOver.Size = new System.Drawing.Size(337, 55);
            this.gameOver.TabIndex = 6;
            this.gameOver.Text = "Game Over !!!";
            this.gameOver.UseWaitCursor = true;
            // 
            // bird
            // 
            this.bird.BackColor = System.Drawing.Color.Transparent;
            this.bird.Image = ((System.Drawing.Image)(resources.GetObject("bird.Image")));
            this.bird.Location = new System.Drawing.Point(147, 156);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(73, 52);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bird.TabIndex = 7;
            this.bird.TabStop = false;
            this.bird.UseWaitCursor = true;
            // 
            // ScreenPlay
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(935, 480);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.gameOver);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.botPipe);
            this.Controls.Add(this.topPipe);
            this.Name = "ScreenPlay";
            this.Text = " ";
            this.UseWaitCursor = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.topPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label Score;
        protected System.Windows.Forms.PictureBox topPipe;
        protected System.Windows.Forms.PictureBox botPipe;
        protected System.Windows.Forms.PictureBox ground;
        protected System.Windows.Forms.Timer gameTimer;
        protected System.Windows.Forms.Label gameOver;
        protected System.Windows.Forms.PictureBox bird;
    }
}

