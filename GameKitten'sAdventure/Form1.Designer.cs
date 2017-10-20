namespace GameKitten_sAdventure
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelNewGame = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelDownloadGame = new System.Windows.Forms.Label();
            this.labelAbout = new System.Windows.Forms.Label();
            this.labelAboutText = new System.Windows.Forms.Label();
            this.labelBack = new System.Windows.Forms.Label();
            this.labelAutor = new System.Windows.Forms.Label();
            this.labelLevel1 = new System.Windows.Forms.Label();
            this.labelLevel2 = new System.Windows.Forms.Label();
            this.labelLevel3 = new System.Windows.Forms.Label();
            this.labelLevel4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNewGame
            // 
            this.labelNewGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelNewGame.AutoSize = true;
            this.labelNewGame.BackColor = System.Drawing.Color.Transparent;
            this.labelNewGame.Font = new System.Drawing.Font("DPix_8pt", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNewGame.ForeColor = System.Drawing.Color.White;
            this.labelNewGame.Location = new System.Drawing.Point(555, 351);
            this.labelNewGame.Name = "labelNewGame";
            this.labelNewGame.Size = new System.Drawing.Size(346, 71);
            this.labelNewGame.TabIndex = 0;
            this.labelNewGame.Text = "Новая игра";
            this.labelNewGame.Click += new System.EventHandler(this.labelNewGame_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = global::GameKitten_sAdventure.Properties.Resources.cat;
            this.pictureBox1.ImageLocation = "10;100";
            this.pictureBox1.InitialImage = global::GameKitten_sAdventure.Properties.Resources.cat;
            this.pictureBox1.Location = new System.Drawing.Point(613, 210);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelDownloadGame
            // 
            this.labelDownloadGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelDownloadGame.AutoSize = true;
            this.labelDownloadGame.BackColor = System.Drawing.Color.Transparent;
            this.labelDownloadGame.Font = new System.Drawing.Font("DPix_8pt", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDownloadGame.ForeColor = System.Drawing.Color.White;
            this.labelDownloadGame.Location = new System.Drawing.Point(496, 422);
            this.labelDownloadGame.Name = "labelDownloadGame";
            this.labelDownloadGame.Size = new System.Drawing.Size(458, 71);
            this.labelDownloadGame.TabIndex = 2;
            this.labelDownloadGame.Text = "Загрузить игру";
            this.labelDownloadGame.Click += new System.EventHandler(this.labelDownloadGame_Click);
            // 
            // labelAbout
            // 
            this.labelAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelAbout.AutoSize = true;
            this.labelAbout.BackColor = System.Drawing.Color.Transparent;
            this.labelAbout.Font = new System.Drawing.Font("DPix_8pt", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAbout.ForeColor = System.Drawing.Color.White;
            this.labelAbout.Location = new System.Drawing.Point(601, 493);
            this.labelAbout.Name = "labelAbout";
            this.labelAbout.Size = new System.Drawing.Size(249, 71);
            this.labelAbout.TabIndex = 3;
            this.labelAbout.Text = "Об игре";
            this.labelAbout.Click += new System.EventHandler(this.labelAbout_Click);
            // 
            // labelAboutText
            // 
            this.labelAboutText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelAboutText.AutoSize = true;
            this.labelAboutText.BackColor = System.Drawing.Color.Transparent;
            this.labelAboutText.Font = new System.Drawing.Font("DPix_8pt", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAboutText.ForeColor = System.Drawing.Color.White;
            this.labelAboutText.Location = new System.Drawing.Point(277, 337);
            this.labelAboutText.MaximumSize = new System.Drawing.Size(1000, 0);
            this.labelAboutText.Name = "labelAboutText";
            this.labelAboutText.Size = new System.Drawing.Size(926, 156);
            this.labelAboutText.TabIndex = 4;
            this.labelAboutText.Text = "Игра Kitten\'s Adventure (Приключение котика) предназначена для обучения детей мла" +
    "дшей и средней школы основам программирования и составлению алгоритмов в виде ув" +
    "лекательной игры.";
            this.labelAboutText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAboutText.Visible = false;
            // 
            // labelBack
            // 
            this.labelBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelBack.AutoSize = true;
            this.labelBack.BackColor = System.Drawing.Color.Transparent;
            this.labelBack.Font = new System.Drawing.Font("DPix_8pt", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBack.ForeColor = System.Drawing.Color.White;
            this.labelBack.Location = new System.Drawing.Point(601, 508);
            this.labelBack.Name = "labelBack";
            this.labelBack.Size = new System.Drawing.Size(202, 71);
            this.labelBack.TabIndex = 5;
            this.labelBack.Text = "Назад";
            this.labelBack.Visible = false;
            this.labelBack.Click += new System.EventHandler(this.labelBack_Click);
            // 
            // labelAutor
            // 
            this.labelAutor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAutor.AutoSize = true;
            this.labelAutor.BackColor = System.Drawing.Color.Transparent;
            this.labelAutor.Font = new System.Drawing.Font("DPix_8pt", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAutor.ForeColor = System.Drawing.Color.White;
            this.labelAutor.Location = new System.Drawing.Point(1198, 729);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(250, 46);
            this.labelAutor.TabIndex = 6;
            this.labelAutor.Text = "© Julia Black";
            // 
            // labelLevel1
            // 
            this.labelLevel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelLevel1.AutoSize = true;
            this.labelLevel1.BackColor = System.Drawing.Color.Transparent;
            this.labelLevel1.Font = new System.Drawing.Font("DPix_8pt", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLevel1.ForeColor = System.Drawing.Color.White;
            this.labelLevel1.Location = new System.Drawing.Point(141, 378);
            this.labelLevel1.Name = "labelLevel1";
            this.labelLevel1.Size = new System.Drawing.Size(211, 71);
            this.labelLevel1.TabIndex = 7;
            this.labelLevel1.Text = "Level I";
            this.labelLevel1.Visible = false;
            this.labelLevel1.Click += new System.EventHandler(this.labelLevel1_Click);
            // 
            // labelLevel2
            // 
            this.labelLevel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelLevel2.AutoSize = true;
            this.labelLevel2.BackColor = System.Drawing.Color.Transparent;
            this.labelLevel2.Font = new System.Drawing.Font("DPix_8pt", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLevel2.ForeColor = System.Drawing.Color.White;
            this.labelLevel2.Location = new System.Drawing.Point(458, 378);
            this.labelLevel2.Name = "labelLevel2";
            this.labelLevel2.Size = new System.Drawing.Size(232, 71);
            this.labelLevel2.TabIndex = 8;
            this.labelLevel2.Text = "Level II";
            this.labelLevel2.Visible = false;
            this.labelLevel2.Click += new System.EventHandler(this.labelLevel2_Click);
            // 
            // labelLevel3
            // 
            this.labelLevel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelLevel3.AutoSize = true;
            this.labelLevel3.BackColor = System.Drawing.Color.Transparent;
            this.labelLevel3.Font = new System.Drawing.Font("DPix_8pt", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLevel3.ForeColor = System.Drawing.Color.White;
            this.labelLevel3.Location = new System.Drawing.Point(775, 378);
            this.labelLevel3.Name = "labelLevel3";
            this.labelLevel3.Size = new System.Drawing.Size(253, 71);
            this.labelLevel3.TabIndex = 9;
            this.labelLevel3.Text = "Level III";
            this.labelLevel3.Visible = false;
            this.labelLevel3.Click += new System.EventHandler(this.labelLevel3_Click);
            // 
            // labelLevel4
            // 
            this.labelLevel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelLevel4.AutoSize = true;
            this.labelLevel4.BackColor = System.Drawing.Color.Transparent;
            this.labelLevel4.Font = new System.Drawing.Font("DPix_8pt", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLevel4.ForeColor = System.Drawing.Color.White;
            this.labelLevel4.Location = new System.Drawing.Point(1109, 378);
            this.labelLevel4.Name = "labelLevel4";
            this.labelLevel4.Size = new System.Drawing.Size(259, 71);
            this.labelLevel4.TabIndex = 10;
            this.labelLevel4.Text = "Level IV";
            this.labelLevel4.Visible = false;
            this.labelLevel4.Click += new System.EventHandler(this.labelLevel4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameKitten_sAdventure.Properties.Resources.StartScreenWitchoutCat;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1460, 784);
            this.Controls.Add(this.labelLevel4);
            this.Controls.Add(this.labelLevel3);
            this.Controls.Add(this.labelLevel2);
            this.Controls.Add(this.labelLevel1);
            this.Controls.Add(this.labelAutor);
            this.Controls.Add(this.labelBack);
            this.Controls.Add(this.labelAboutText);
            this.Controls.Add(this.labelAbout);
            this.Controls.Add(this.labelDownloadGame);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelNewGame);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1478, 831);
            this.MinimumSize = new System.Drawing.Size(1478, 831);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitten\'s Adventure";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNewGame;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelDownloadGame;
        private System.Windows.Forms.Label labelAbout;
        private System.Windows.Forms.Label labelAboutText;
        private System.Windows.Forms.Label labelBack;
        private System.Windows.Forms.Label labelAutor;
        private System.Windows.Forms.Label labelLevel1;
        private System.Windows.Forms.Label labelLevel2;
        private System.Windows.Forms.Label labelLevel3;
        private System.Windows.Forms.Label labelLevel4;
    }
}

