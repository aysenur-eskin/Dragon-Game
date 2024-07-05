using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragonsGame
{
    public partial class Level4 : Form
    {

        //LEVEL 4;
        //ENGEL SAYISI: 10
        //ENGEL HIZI 20
        int engelGecisSayisi = 0;
        int engelHizi = 20;
        int yerCekimi = 20;
        int score = 0;

        PictureBox dragon = new PictureBox();
        Random rastgeleKonum = new Random();
        private PictureBox[] engeller;
        private Timer timer = new Timer();
        private Point[] engelBaslangicKonumlari;
        void gamekeydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                yerCekimi = -20;
                //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\DELL\Desktop\c#uygulama\dragonGame\dragonGame\ses\jump2.wav");
                //player.Play();
            }
        }

        void gamekeyup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                yerCekimi = 20;
            }
        }

        private void InitializeGame()
        {
            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += new EventHandler(gameTimerEvent);
            timer.Start();

            engeller = new PictureBox[12];
           
            engelBaslangicKonumlari = new Point[]
            {
           new Point(710, 380), //ev18 DÜZ 710
           new Point(1310, 0), //ev19 TERS 600
           new Point(1690, 0), //eV20 TERS 380
           new Point(2400, 300), //ev21 DÜZ
           new Point(3300, 0), //ev22 TERS 
           new Point(4000, 270), //ev23  DÜZ6
           new Point(4800, 390), //ev24 DÜZ7
           new Point(5500, 0), //ev25  TERS8
           new Point(6300, 370), //ev26 DÜZ9
           new Point(7200, 0), //ev27  TERS10
           new Point(7800, 360), //ev28 TERS11
           new Point(8100, 360) //ev29 TERS12
           
            };

            for (int i = 0; i < 12; i++)
            {
                engeller[i] = new PictureBox();
                engeller[i].BorderStyle = BorderStyle.None;
                engeller[i].SizeMode = PictureBoxSizeMode.StretchImage;
                engeller[i].BackColor = Color.Transparent;
                Controls.Add(engeller[i]);
                engeller[i].Location = engelBaslangicKonumlari[i];

                switch (i)
                {

                    case 0:
                        engeller[i].Image = Properties.Resources.ev18;
                        engeller[i].Size = new Size(250, 340);
                        break;
                    case 1:
                        engeller[i].Image = Properties.Resources.ev19;
                        engeller[i].Size = new Size(250, 370);
                        break;
                    case 2:
                        engeller[i].Image = Properties.Resources.ev20;
                        engeller[i].Size = new Size(250, 340);
                        break;

                    case 3:
                        engeller[i].Image = Properties.Resources.ev21;
                        engeller[i].Size = new Size(350, 420);
                        break;
                    case 4:
                        engeller[i].Image = Properties.Resources.ev22;
                        engeller[i].Size = new Size(300, 400);
                        break;
                    case 5:
                        engeller[i].Image = Properties.Resources.ev23;
                        engeller[i].Size = new Size(340, 460);
                        break;
                    case 6:
                        engeller[i].Image = Properties.Resources.ev24;
                        engeller[i].Size = new Size(250, 340);
                        break;
                    case 7:
                        engeller[i].Image = Properties.Resources.ev25;
                        engeller[i].Size = new Size(250, 340);
                        break;
                    case 8:
                        engeller[i].Image = Properties.Resources.ev26;
                        engeller[i].Size = new Size(450, 370);
                        break;
                    case 9:
                        engeller[i].Image = Properties.Resources.ev27;
                        engeller[i].Size = new Size(300, 360);
                        break;
                    case 10:
                        engeller[i].Image = Properties.Resources.ev28;
                        engeller[i].Size = new Size(250, 360);
                        break;
                    case 11:
                        engeller[i].Image = Properties.Resources.ev29;
                        engeller[i].Size = new Size(250, 360);
                        break;

                } //switch sonu
            } //for sonu

        } //InitializeGame fonksiyonu sonu
        private void gameTimerEvent(object sender, EventArgs e)
        {
            dragon.BorderStyle = BorderStyle.None;
            dragon.BackColor = Color.Transparent;
            dragon.Image = Properties.Resources.ejderha2;
            dragon.SizeMode = PictureBoxSizeMode.StretchImage;
            dragon.Size = new Size(120, 80);
            this.Controls.Add(dragon);
            dragon.BringToFront();

            dragon.Top += yerCekimi; 

            scoreText.Text = "SCORE:" + score;
            int sabitMesafe = rastgeleKonum.Next(250, 401);                     
            for (int i = 0; i < 12; i++)
            {
                engeller[i].Left -= engelHizi;

                if (engeller[i].Right < 0)
                {
                    engelGecisSayisi++;
                    score++;

                    int prevEngelIndex = (i == 0) ? 11 : i - 1; 
                    int newX = engeller[prevEngelIndex].Right + sabitMesafe; 
                    engeller[i].Location = new Point(newX, engeller[i].Location.Y);


                    if (engelGecisSayisi >= 10) // YENİ
                    {
                        timer.Stop();
                        MessageBox.Show("Kazandınız!", "Tebrikler!"); 
                        //System.Media.SoundPlayer playerr = new System.Media.SoundPlayer(@"C:\Users\DELL\Desktop\c#uygulama\DragonsGame\DragonsGame\ses\levelup.wav");
                        //playerr .Play();
                        this.Close();
                        
                    }

                }


                bool carpismaVar = false;

                for (int a = 0; a < 12; a++)
                {
                    if (dragon.Bounds.IntersectsWith(engeller[i].Bounds))
                    {

                        carpismaVar = true;
                        break;
                    }
                }

                if (carpismaVar)
                {

                    endgame();
                }
            }
        }//gameTimerEvent SONU


        private void endgame()
        {
           // System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\DELL\Desktop\c#uygulama\dragonGame\dragonGame\ses\dead.wav");
            //player.Play();
            timer.Stop();
            MessageBox.Show("   " + "SCORE:" + score + "\nGAME OVER!");
            Application.Exit();
        }



        public Level4()
        {
            InitializeComponent();
            InitializeGame();
            this.KeyDown += new KeyEventHandler(gamekeydown);
            this.KeyUp += new KeyEventHandler(gamekeyup);
            this.Focus();
        }
    }
}
