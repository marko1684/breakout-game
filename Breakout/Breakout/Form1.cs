using System;
using System.Drawing;
using System.Windows.Forms;

namespace Breakout
{
    public partial class Form1 : Form
    {
        int vBrzina, hBrzina;
        int brojRedova = 5;
        int brojKolona = 6;
        int skor = 0;
        int nivo = 1;
        PictureBox[,] blokovi;

        public Form1()
        {
            vBrzina = 2;
            hBrzina = 2;
            postaviBlokove();
            InitializeComponent();
        }

        //postavljanje blokova za rusenje
        private void postaviBlokove()
        {
            int blokVisina = 25;
            int blokSirina = 100;
            blokovi = new PictureBox[brojRedova, brojKolona];

            for(int x = 0; x < brojRedova; x++)
            {
                for(int y = 0; y < brojKolona; y++)
                {
                    blokovi[x, y] = new PictureBox();
                    blokovi[x, y].Width = blokSirina;
                    blokovi[x, y].Height = blokVisina;
                    blokovi[x, y].Top = blokVisina * x;
                    blokovi[x, y].Left = blokSirina * y;
                    blokovi[x, y].BackColor = Color.Green;
                    blokovi[x, y].BorderStyle = BorderStyle.Fixed3D;
                    this.Controls.Add(blokovi[x, y]);
                }
            }
        }
        // Na pomeranje misa po formi pomera se ploca
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            picPloca.Left = e.X- picPloca.Width / 2;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            //dodirivanje kockice i ivica forme
            picKockica.Top += vBrzina;
            picKockica.Left += hBrzina;
            if(picKockica.Bottom > ClientRectangle.Height)
            {
                vBrzina = -vBrzina;
            }
            if(picKockica.Top < 0)
            {
                vBrzina = -vBrzina;
            }
            if( picKockica.Right > ClientRectangle.Width)
            {
                hBrzina = -hBrzina;
            }
            if (picKockica.Left < 0)
            {
                hBrzina = -hBrzina;
            }

            // dodirivanje kockice i ploce
            if (picKockica.Bounds.IntersectsWith(picPloca.Bounds) == true)
            {
                vBrzina = -vBrzina;
            }

            //dodirivanje kockice i blokova

            for(int x = 0; x < brojRedova; x++)
            {
                for(int y = 0; y < brojKolona; y++)
                {
                    if(picKockica.Bounds.IntersectsWith(blokovi[x,y].Bounds) && blokovi[x, y].Visible == true)
                    {
                        blokovi[x, y].Visible = false;
                        vBrzina = -vBrzina;
                        skor += (nivo * 100);
                        labelSkor.Text = "bodovi" + " " + skor.ToString();
                    }
                }
            }

            // provera levela
            int brojBlokova = brojKolona * brojRedova;
            for (int x = 0; x < brojRedova; x++)
            {
                for (int y = 0; y < brojKolona; y++)
                {
                    if(blokovi[x,y].Visible == false)
                    {
                        brojBlokova--;
                    }
                }
                if (brojBlokova == 0)
                {
                    string[] s = labelNivo.Text.Split(' ');
                    nivo = Convert.ToInt32(s[1]) + 1;
                    labelNivo.Text = s[0] + " " + nivo.ToString();

                    // ponovo se postavljaju kockice
                    for (int i = 0; i < brojRedova; i++)
                    {
                        for (int j = 0; j < brojKolona; j++)
                        {
                            blokovi[i, j].Visible = true;
                        }

                        // kockica se postavlja na sredinu forme i nastavlja se sledeci nivo
                        picKockica.Top = ClientRectangle.Height / 2;
                        picKockica.Left = ClientRectangle.Width / 2 - picKockica.Width / 2;

                        // horizontalna i vertikalna brzina kockice se povecavaju za 1
                        vBrzina++;
                        hBrzina++;
                    }
                }
            }

            // Game over
   
            if(picKockica.Top > picPloca.Top)
            {       
                timer1.Stop();
                MessageBox.Show("GAME OVER!!! \nVas skor je " + skor.ToString());
            }
        }
    }
}
