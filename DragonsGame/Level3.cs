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
    public partial class Level3 : Form
    {
        //LEVEL 3 İÇİN;
        //ENGEL SAYIYISI:7,
        //ENGEL HIZI:20

        Button levelUpButton = new Button();//YENİ
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
            engeller = new PictureBox[10];


            
            engelBaslangicKonumlari = new Point[]
            {
           new Point(790, 0), //ev12 TERS* 790 
           new Point(1090, -20), //ev11 TERS* 300
           new Point(1850, 320), //ev13 DÜZ* 760
           new Point(2480, 0), //ev14 TERS* 630
           new Point(3290, 250), //ev15 DÜZ 810
           new Point(3700, 260), //ev16 DÜZ 410
           new Point(4490, 0), //ev17 TERS 790

           new Point(5200, 380), //ev18 DÜZ 710
           new Point(5800, 0), //ev19 TERS 600
           new Point(6180, 0) //en20 TERS 380


            };

            for (int i = 0; i < 10; i++)
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
                        engeller[i].Image = Properties.Resources.ev11;
                        engeller[i].Size = new Size(220, 450);
                        break;

                    case 1:
                        engeller[i].Image = Properties.Resources.ev12;
                        engeller[i].Size = new Size(380, 280);
                        break;
                    case 2:
                        engeller[i].Image = Properties.Resources.ev13;
                        engeller[i].Size = new Size(240, 410);
                        break;
                    case 3:
                        engeller[i].Image = Properties.Resources.ev14;
                        engeller[i].Size = new Size(350, 420);
                        break;
                    case 4:
                        engeller[i].Image = Properties.Resources.ev15;
                        engeller[i].Size = new Size(370, 470);
                        break;
                    case 5:
                        engeller[i].Image = Properties.Resources.ev16;
                        engeller[i].Size = new Size(340, 460);
                        break;
                    case 6:
                        engeller[i].Image = Properties.Resources.ev17;
                        engeller[i].Size = new Size(250, 340);
                        break;
                    case 7:
                        engeller[i].Image = Properties.Resources.ev18;
                        engeller[i].Size = new Size(250, 340);
                        break;
                    case 8:
                        engeller[i].Image = Properties.Resources.ev19;
                        engeller[i].Size = new Size(250, 370);
                        break;
                    case 9:
                        engeller[i].Image = Properties.Resources.ev20;
                        engeller[i].Size = new Size(250, 340);
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
            for (int i = 0; i < 10; i++)
            {
                engeller[i].Left -= engelHizi;

                if (engeller[i].Right < 0)
                {
                    engelGecisSayisi++;
                    score++;

                    int prevEngelIndex = (i == 0) ? 9 : i - 1; 
                    int newX = engeller[prevEngelIndex].Right + sabitMesafe; 
                    engeller[i].Location = new Point(newX, engeller[i].Location.Y);


                    if (engelGecisSayisi >= 7) // YENİ
                    {
                        timer.Stop();
                        levelUpButton.Visible = true;
                        //System.Media.SoundPlayer playeR = new System.Media.SoundPlayer(@"C:\Users\DELL\Desktop\c#uygulama\DragonsGame\DragonsGame\ses\levelup.wav");
                        //playeR.Play();

                    }

                }


                bool carpismaVar = false;

                for (int a = 0; a < 10; a++)
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

        private void LevelUpButton_Click(object sender, EventArgs e)
        {

            Level4 level4 = new Level4();
            level4.Show();
            this.Hide();
        }



        private void endgame()
        {
            //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\DELL\Desktop\c#uygulama\dragonGame\dragonGame\ses\dead.wav");
            //player.Play();

            timer.Stop();
            MessageBox.Show("   " + "SCORE:" + score + "\nGAME OVER!");
            Application.Exit();
        }
        public Level3()
        {
            InitializeComponent();

            levelUpButton.Text = "LEVEL UP";
            levelUpButton.Size = new Size(130, 50);
            levelUpButton.Location = new Point(660, 370);
            levelUpButton.Font = new Font("Constantia", 12, FontStyle.Bold);
            levelUpButton.Click += new EventHandler(LevelUpButton_Click);
            levelUpButton.Visible = false;
            this.Controls.Add(levelUpButton);
            InitializeGame();
            this.KeyDown += new KeyEventHandler(gamekeydown);
            this.KeyUp += new KeyEventHandler(gamekeyup);
            this.Focus();
        }
    }
}
