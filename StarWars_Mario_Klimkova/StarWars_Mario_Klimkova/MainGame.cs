using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarWars_Mario_Klimkova
{
    public partial class MainGame : Form
    {

        private bool right, left, jump;
        private bool hasTheSaber = false;
        private int force, speed;
        private int score = 0;
        private int life;


        public MainGame()
        {
            InitializeComponent();
            levelMenu.Visible = false;
            pausedGame.Visible = false;
            Movement.Tick += MovementHandler;
            Animation.Tick += AnimationHandler;

            //zde se osetruje zmena pozai a zmena skinu hrace
            if (OptionPage.bckg != null)
            {
                BackgroundImage = OptionPage.bckg;
            }

            if (OptionPage.skin != null)
            {
                player.Image = OptionPage.skin;
            }

        }

        /// <summary>
        /// sleduje pocet zivotu (meni prislusny obrazek) a pokud zivoty dojdou, ukonci hru
        /// </summary>
        private void LifeStatus()
        {
            if (life == 1)
            {
                life1.Image = Properties.Resources.life_white;
            }
            if (life == 2)
            {
                life2.Image = Properties.Resources.life_white;
            }
            if (life == 3)
            {
                life3.Image = Properties.Resources.life_white;
                levelMenu.Visible = true;
                levelMenu.BringToFront();
                Animation.Stop();
                Movement.Stop();

            }
        }

        /// <summary>
        /// urcuje vysledek hry
        /// osetruje srazku s nepritelem, sbirani minci a ukoncuju hru, pri splneni vsech podminek
        /// </summary>
        private void GameResult()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "enemy")
                {
                    foreach (Control y in this.Controls)
                    {
                        if (y is PictureBox && y.Tag == "coin")
                        {
                            if (player.Bounds.IntersectsWith(y.Bounds))
                            {
                                y.Dispose();
                                score++;
                                scoreLabel.Text = "Score: " + score;
                            }

                            if (player.Bounds.IntersectsWith(x.Bounds))
                            {
                                player.Location = new Point(32, 269);
                                life += 1;
                                LifeStatus();
                            }
                            
                            if (x.Bounds.IntersectsWith(y.Bounds))
                            {
                                x.BackColor = Color.Transparent;
                                y.BackColor = Color.Transparent;
                            }
                        }
                    }
                }
            }

            if (player.Bounds.IntersectsWith(saber.Bounds))
            {
                saber.Visible = false;
                hasTheSaber = true;
            }

            if (player.Bounds.IntersectsWith(door.Bounds) && hasTheSaber == true && scoreLabel.Text == "Score: 20")
            {
                door.Image = Properties.Resources.door_open;
                overLabel.Text = "You Win!";
                levelMenu.BackColor = Color.Green;
                levelMenu.Visible = true;
                levelMenu.BringToFront();
                Animation.Stop();
                Movement.Stop();
            }
        }

        /// <summary>
        /// pohyb nepratel po mape
        /// </summary>
        private void EnemyMovement()
        {
            if (en_1.Left > 500)
            {
                speed -= 1;
            }
            if (en_1.Left < 200)
            {  
                speed = 1;
            }
            en_1.Left += speed;
            en_2.Left += speed;
        }

        /// <summary>
        /// prida delegat k timeru pohybu (zajistuje beh hry)
        /// vola dve dalsi metody pro nepratele a vysledek hry
        /// umoznuje pohyb a skok hrace a take osetruje dopad a srazku hrace s platformou
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MovementHandler(object sender, EventArgs e)
        {
            EnemyMovement();
            GameResult();
            if (right == true)
            {
                if (player.Left < 850)
                {
                    player.Left += 2;
                }
            }

            if (left == true)
            {
                if (player.Left > 10)
                {
                    player.Left -= 2;
                }
            }

            if (jump == true)
            {
                player.Top -= 3;
                force = 3;
            }
            if (jump == false)
            {
                player.Top += force;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "platform")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !jump)
                    {
                        player.Top = x.Top - player.Height;
                        force = 0;
                    }
                    if (!player.Bounds.IntersectsWith(x.Bounds) && right || left)
                    {
                        force = 3;
                    }
                    if (player.Bounds.IntersectsWith(x.Bounds) && jump)
                    {
                        player.Top = x.Top + (player.Height - 5);
                        jump = false;
                    }
                    if (player.Top + player.Height < 10)
                    {
                        player.Top += 3;
                    }
                }
            }
        }

        /// <summary>
        /// prida delegat k timeru animace
        /// meni vzhled hrace podle pohybu doleva a doprava
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnimationHandler(object sender, EventArgs e)
        {
            if (player.Image == Properties.Resources.player || player.Image == Properties.Resources.player_left)
            {
                if (right == true)
                {
                    player.Image = Properties.Resources.player;

                }

                if (left == true)
                {
                    player.Image = Properties.Resources.player_left;
                }
            }
        }

        /// <summary>
        /// metoda obsluhujici stisk danych klaves (pohyb, skok, pause, resume a informace)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Game_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    right = true;
                    break;
                case Keys.Left:
                    left = true;
                    break;
                case Keys.Space:
                    jump = true;
                    break;
                case Keys.P:
                    Animation.Stop();
                    Movement.Stop();
                    pausedGame.Visible = true;
                    break;
                case Keys.Enter:
                    pausedGame.Visible = false;
                    Animation.Start();
                    Movement.Start();
                    break;
                case Keys.N:
                    MessageBox.Show("------INFORMATION------\n" +
                        "Use left and right arrow for moving and space for jumping.\n" +
                        "You have to collect all the coins and the saber and then get to the door, before you ran out of lives.\n" +
                        "P is for pause and Enter for resume.\n" +
                        "You can also use N to show this information box.\n");
                    break;
            }
        }

        /// <summary>
        /// metoda obsluhujici pokud klavesy jiz nejsou stisknute (pohyb a skok), meni se vzhled hrace
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Game_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    right = false;
                    if (OptionPage.skin == null)
                    {
                        player.Image = Properties.Resources.player;
                    }
                    break;
                case Keys.Left:
                    left = false;
                    if (OptionPage.skin == null)
                    {
                        player.Image = Properties.Resources.player_left;
                    }
                    break;
                case Keys.Space:
                    jump = false;
                    break;
            }
        }

        private void MainGame_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// metoda pro ukonceni aplikace
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// metoda pro restartovani hry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void restartLbl_Click(object sender, EventArgs e)
        {
            MainGame newWindow = new MainGame();
            newWindow.Show();
            this.Hide();
        }

        /// <summary>
        /// metoda pro znovuotevreni menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backToMenuLbl_Click(object sender, EventArgs e)
        {
            StartPage newWindow = new StartPage();
            newWindow.Show();
            this.Hide();
        }
    }
}
