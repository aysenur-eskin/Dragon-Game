using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;
using System.Reflection.Emit;
 //LEVEL 1 İÇİN;
//ENGEL SAYIYISI:5,
//ENGEL HIZI:15


namespace DragonsGame
{
    public partial class Level1 : Form
    {
        Button levelUpButton = new Button();
        int engelGecisSayisi = 0;
        int engelHizi = 15;
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

        private void InitializeGame() //OYUNU BAŞLAT
        {
            timer = new Timer();
            timer.Interval = 20; 
            timer.Tick += new EventHandler(gameTimerEvent); 
            timer.Start();
            engeller = new PictureBox[17];



           
            engelBaslangicKonumlari = new Point[]
            {
           new Point(100,400), //ev1 DÜZ
           new Point(550, -20),  //ev2 TERS
           new Point(1000, 0),  //ev3 TERS
           new Point(1400, 460),  //ev4 DÜZ
           new Point(1900, 0),//ev5 TERS
           new Point(2400, 360),  //ev6 DÜZ 340
           new Point(2950, 0), //ev7 TERS 550
           new Point(3550, 350), //ev8 DÜZ 600
           new Point(3850, 248), //ev9 DÜZ 300
           new Point(4200, 440), //ev10 DÜZ 350
           new Point(4990, 0), //ev11 TERS 790
           new Point(5290, 0), //ev12 TERS  300
           new Point(6050, 320), //ev13 DÜZ 760
           new Point(6680, 0), //ev14 TERS 630
           new Point(7490, 256), //ev15 DÜZ 810
           new Point(7900, 268), //ev16 DÜZ 410
           new Point(8690, 0) //ev17 TERS 790
            };

            for (int i = 0; i < 17; i++)
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
                        
                        engeller[i].Image = Properties.Resources.ev1;
                        engeller[i].Size = new Size(220, 330);
                        break;
                    case 1:
                        
                        engeller[i].Image = Properties.Resources.ev2;
                        engeller[i].Size = new Size(120, 250);
                        break;
                    case 2:
                        
                        engeller[i].Image = Properties.Resources.ev3;
                        engeller[i].Size = new Size(200, 330);
                        break;
                    case 3:
                       
                        engeller[i].Image = Properties.Resources.ev4;
                        engeller[i].Size = new Size(140, 270);
                        break;
                    case 4:
                        
                        engeller[i].Image = Properties.Resources.ev5;
                        engeller[i].Size = new Size(140, 250);
                        break;
                    case 5:
                        engeller[i].Image = Properties.Resources.ev6;
                        engeller[i].Size = new Size(210, 370);
                        break;
                    case 6:
                        engeller[i].Image = Properties.Resources.ev7;
                        engeller[i].Size = new Size(210, 370);
                        break;
                    case 7:
                        engeller[i].Image = Properties.Resources.ev8;
                        engeller[i].Size = new Size(230, 390);
                        break;
                    case 8:
                        engeller[i].Image = Properties.Resources.ev91; //EV9
                        engeller[i].Size = new Size(270, 480);
                        break;
                    case 9:
                        engeller[i].Image = Properties.Resources.ev10;
                        engeller[i].Size = new Size(350, 300);
                        break;
                    case 10:
                        engeller[i].Image = Properties.Resources.ev11;
                        engeller[i].Size = new Size(220, 450);
                        break;
                    case 11:
                        engeller[i].Image = Properties.Resources.ev12;
                        engeller[i].Size = new Size(380, 280);
                        break;
                    case 12:
                        engeller[i].Image = Properties.Resources.ev13;
                        engeller[i].Size = new Size(240, 410);
                        break;
                    case 13:
                        engeller[i].Image = Properties.Resources.ev14;
                        engeller[i].Size = new Size(350, 420);
                        break;
                    case 14:
                        engeller[i].Image = Properties.Resources.ev15;
                        engeller[i].Size = new Size(370, 470);
                        break;
                    case 15:
                        engeller[i].Image = Properties.Resources.ev16;
                        engeller[i].Size = new Size(340, 460);
                        break;
                    case 16:
                        engeller[i].Image = Properties.Resources.ev17;
                        engeller[i].Size = new Size(250, 340);
                        break;


                } //switch sonu
            } //for sonu


        } //InitializeGame fonksiyonu sonu


        private void gameTimerEvent(object sender, EventArgs e)
        {
            dragon.BorderStyle = BorderStyle.None ;
            dragon.BackColor = Color.Transparent;
            dragon.Image = Properties.Resources.ejderha2;
            dragon.SizeMode = PictureBoxSizeMode.StretchImage;
            dragon.Size = new Size(120, 80);
            this.Controls.Add(dragon);
            dragon.BringToFront();
           
            dragon.Top += yerCekimi; 
          

            scoreText.Text = "SCORE:" + score;
  
            int sabitMesafe = rastgeleKonum.Next(250, 401);                        
            for (int i = 0; i < 17; i++)
            {
                engeller[i].Left -= engelHizi;

                if (engeller[i].Right < 0)
                {
                    engelGecisSayisi++;
                    score++;
         
                    int prevEngelIndex = (i == 0) ? 16 : i - 1; 
                    int newX = engeller[prevEngelIndex].Right + sabitMesafe; 
                    engeller[i].Location = new Point(newX, engeller[i].Location.Y);
                    
                    
                    if (engelGecisSayisi >= 5) 
                    {
    
                        timer.Stop();
                        levelUpButton.Visible = true;
                        //System.Media.SoundPlayer playeRr = new System.Media.SoundPlayer(@"C:\Users\DELL\Desktop\c#uygulama\DragonsGame\DragonsGame\ses\levelup.wav");
                        //playeRr.Play();


                    }
                        
                }


                bool carpismaVar = false;

                for (int a = 0; a < 17; a++)
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

            Level2 level2 = new Level2();
            level2.Show();
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

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        public Level1()
        {
            

            levelUpButton.Text = "LEVEL UP";
            levelUpButton.Size = new Size(180, 70);
            levelUpButton.Location = new Point(880,450);
            levelUpButton.Font= new Font("Constantia", 12, FontStyle.Bold);
            levelUpButton.Click += new EventHandler(LevelUpButton_Click);
            levelUpButton.Visible = false;
            this.Controls.Add(levelUpButton);
           
             

            InitializeComponent();
            InitializeGame();
            this.KeyDown += new KeyEventHandler(gamekeydown);
            this.KeyUp += new KeyEventHandler(gamekeyup);
            this.Focus();
         
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
