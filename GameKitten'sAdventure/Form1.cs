using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace GameKitten_sAdventure
{
    public partial class Form1 : Form
    {
        PrivateFontCollection font;

        private void fontsProjects()
        {
            this.font = new PrivateFontCollection();
            font.AddFontFile("font/Dpix_8pt.ttf");
        }
        private void fonts()
        {
            this.labelLevel4.Font = new System.Drawing.Font(font.Families[0], 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLevel3.Font = new System.Drawing.Font(font.Families[0], 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLevel2.Font = new System.Drawing.Font(font.Families[0], 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLevel1.Font = new System.Drawing.Font(font.Families[0], 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAutor.Font = new System.Drawing.Font(font.Families[0], 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBack.Font = new System.Drawing.Font(font.Families[0], 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAbout.Font = new System.Drawing.Font(font.Families[0], 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDownloadGame.Font = new System.Drawing.Font(font.Families[0], 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNewGame.Font = new System.Drawing.Font(font.Families[0], 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAboutText.Font = new System.Drawing.Font(font.Families[0], 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        }
        public Form1()
        {
            InitializeComponent();
            fontsProjects();
            fonts();
            labelAutor.SetBounds(this.Width - labelAutor.Width - 30, this.Height - 100, labelAutor.Width, labelAutor.Height);
            pictureBox1.SetBounds(this.Width / 2 - pictureBox1.Width + 50, this.Height / 2 - 160, pictureBox1.Width, pictureBox1.Height);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelNewGame_Click(object sender, EventArgs e)
        {
            FormGame formGame = new FormGame(new Level1());
            formGame.Show();
            this.Hide();
        }

        private void labelDownloadGame_Click(object sender, EventArgs e)
        {
            labelAbout.Visible = false;
            labelDownloadGame.Visible = false;
            labelNewGame.Visible = false;
            labelLevel1.Visible = true;
            labelLevel2.Visible = true;
            labelLevel3.Visible = true;
            labelBack.Visible = true;
            labelLevel4.Visible = true;
        }

        private void labelAbout_Click(object sender, EventArgs e)
        {
            labelDownloadGame.Visible = false;
            labelNewGame.Visible = false;
            labelAbout.Visible = false;
            labelAboutText.Visible = true;
            labelBack.Visible = true;
            labelAutor.Visible = true;
        }

        private void labelBack_Click(object sender, EventArgs e)
        {
            labelLevel1.Visible = false;
            labelLevel2.Visible = false;
            labelLevel3.Visible = false;
            labelLevel4.Visible = false;

            labelDownloadGame.Visible = true;
            labelNewGame.Visible = true;
            labelAbout.Visible = true;
            labelAboutText.Visible = false;
            labelBack.Visible = false;
        }
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                //|| this.WindowState == FormWindowState.Maximized)
               // pictureBox1.SetBounds(400,400,435, 142);
            }
        }

        private void labelLevel2_Click(object sender, EventArgs e)
        {
            FormGame formGame = new FormGame(new Level2());
            formGame.Show();
            this.Hide();
        }

        private void labelLevel1_Click(object sender, EventArgs e)
        {
            FormGame formGame = new FormGame(new Level1());
            formGame.Show();
            this.Hide();
        }

        private void labelLevel3_Click(object sender, EventArgs e)
        {
            FormGame formGame = new FormGame(new Level3());
            formGame.Show();
            this.Hide();
        }

        private void labelLevel4_Click(object sender, EventArgs e)
        {
            FormGame formGame = new FormGame(new Level4());
            formGame.Show();
            this.Hide();
        }
    }
}
