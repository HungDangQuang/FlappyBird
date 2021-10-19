
namespace flappyBird
{
    partial class ScreenOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenOptions));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.botPipe = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.Easy = new System.Windows.Forms.Button();
            this.Difficult = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(641, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // botPipe
            // 
            this.botPipe.BackColor = System.Drawing.Color.Transparent;
            this.botPipe.Image = ((System.Drawing.Image)(resources.GetObject("botPipe.Image")));
            this.botPipe.Location = new System.Drawing.Point(45, 250);
            this.botPipe.Name = "botPipe";
            this.botPipe.Size = new System.Drawing.Size(100, 263);
            this.botPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.botPipe.TabIndex = 3;
            this.botPipe.TabStop = false;
            this.botPipe.UseWaitCursor = true;
            // 
            // bird
            // 
            this.bird.BackColor = System.Drawing.Color.Transparent;
            this.bird.Image = ((System.Drawing.Image)(resources.GetObject("bird.Image")));
            this.bird.Location = new System.Drawing.Point(145, 147);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(73, 52);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bird.TabIndex = 8;
            this.bird.TabStop = false;
            this.bird.UseWaitCursor = true;
            // 
            // Easy
            // 
            this.Easy.BackColor = System.Drawing.Color.MintCream;
            this.Easy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Easy.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Easy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Easy.Location = new System.Drawing.Point(367, 156);
            this.Easy.Name = "Easy";
            this.Easy.Size = new System.Drawing.Size(150, 58);
            this.Easy.TabIndex = 14;
            this.Easy.Text = "Easy";
            this.Easy.UseVisualStyleBackColor = false;
            this.Easy.UseWaitCursor = true;
            this.Easy.Click += new System.EventHandler(this.Easy_Click);
            // 
            // Difficult
            // 
            this.Difficult.BackColor = System.Drawing.Color.MintCream;
            this.Difficult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Difficult.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Difficult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Difficult.Location = new System.Drawing.Point(367, 234);
            this.Difficult.Name = "Difficult";
            this.Difficult.Size = new System.Drawing.Size(150, 58);
            this.Difficult.TabIndex = 13;
            this.Difficult.Text = "Difficult";
            this.Difficult.UseVisualStyleBackColor = false;
            this.Difficult.UseWaitCursor = true;
            this.Difficult.Click += new System.EventHandler(this.Difficult_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(803, 285);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 228);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.UseWaitCursor = true;
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(-3, 411);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(953, 102);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 16;
            this.ground.TabStop = false;
            this.ground.UseWaitCursor = true;
            // 
            // ScreenOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(952, 510);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Easy);
            this.Controls.Add(this.Difficult);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.botPipe);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ScreenOptions";
            this.Text = "ScreenOptions";
            this.Load += new System.EventHandler(this.ScreenOptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox botPipe;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.Button Easy;
        private System.Windows.Forms.Button Difficult;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox ground;
    }
}