using Contactos.RecursosLocalizables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contactos
{
    public partial class Form1 : Form
    {
        public int speedLeft = 4;
        public int speedTop = 4;
        public int points = 0;

        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;

            this.Bounds = Screen.PrimaryScreen.Bounds;

            pbRacket.Top = pPlayground.Bottom - (pPlayground.Bottom / 10);
            pbRacket.Left = pPlayground.Left+ (pPlayground.Width / 2);
        }

        private void aplicarIdioma(string idioma)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(idioma);
            this.msMenu.Text = StringResources.msMenu;
            this.msLenguages.Text = StringResources.msLenguages;
            this.lblScore.Text = StringResources.lblScore ;
            this.msLEnglish.Text = StringResources.msLEnglish;
            this.msLSpanish.Text = StringResources.msLSpanish;
            this.msMNewGame.Text = StringResources.msMNewGame;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape) { this.Close(); }
            if (e.KeyCode == Keys.Right )
            {
                if (pbRacket.Right >= pPlayground.Right)
                {

                }else
                {
                    pbRacket.Left += 35;
                } 
            }
            if (e.KeyCode == Keys.Left)
            {
                if (pbRacket.Left <= pPlayground.Left)
                {
                }
                else {
                    pbRacket.Left -= 35;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //pbRacket.Left = Cursor.Position.X - (pbRacket.Width / 2);

            pbBall.Left += speedLeft;
            pbBall.Top += speedTop;

            if (pbBall.Bottom >= pbRacket.Top && pbBall.Bottom <= pbRacket.Bottom && pbBall.Left >= pbRacket.Left && pbBall.Right <= pbRacket.Right)
            {
                speedTop += 2;
                speedLeft += 2;
                speedTop *= -1;
                points += 1;
                lblPoints.Text = points+"";
            }
            if(pbBall.Left <= pPlayground.Left)
            {
                speedLeft *= -1;
            }
            if (pbBall.Right >= pPlayground.Right)
            {
                speedLeft *= -1;
            }
            if (pbBall.Top <= pPlayground.Top)
            {
                speedTop *= -1;
            }
            if(pbBall.Bottom >= pPlayground.Bottom)
            {
                timer1.Enabled = false;
            }
        }

        private void msLEnglish_Click(object sender, EventArgs e)
        {
            aplicarIdioma("ES-US");
        }

        private void msLSpanish_Click(object sender, EventArgs e)
        {
            aplicarIdioma("ES-CO");
        }

        private void msMNewGame_Click(object sender, EventArgs e)
        {
            pbBall.Top = 50;
            pbBall.Left = 50;
            speedLeft = 4;
            speedTop = 4;
            points = 0;
            lblPoints.Text = 0+"";
            timer1.Enabled = true;
        }
    }
}
