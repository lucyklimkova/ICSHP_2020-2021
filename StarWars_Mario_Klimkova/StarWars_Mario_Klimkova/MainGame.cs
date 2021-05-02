using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarWars_Mario_Klimkova
{
    public partial class MainGame : Form
    {

        private bool right, left, jump, paused;
        private bool hasTheSaber = false;
        private int speed;
        private int score = 0;
        private int life = 0;
        private int option;
        private int force = 5;

        public MainGame()
        {
            InitializeComponent();
            levelMenu.Visible = false;
            pausedGame.Visible = false;

            //zde se osetruje zmena pozadi a zmena skinu hrace
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
            if (life == 0)
            {
                life1.Image = Properties.Resources.life;
                life2.Image = Properties.Resources.life;
                life3.Image = Properties.Resources.life;

            }
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
                option = 0;
                levelMenu.Visible = true;
                levelMenu.BringToFront();
                Animation.Stop();
                Movement.Stop();

            }
        }

        /// <summary>
        /// urcuje vysledek hry
        /// osetruje srazku s nepritelem, sbirani minci a ukoncuju hru, pri splneni vsech podminek
        /// obsahuje take ukazatel score
        /// </summary>
        private void GameResult()
        {
            foreach (Control pBEnemy in this.Controls)
            {
                if (pBEnemy is PictureBox && (string) pBEnemy.Tag == "enemy")
                {
                    foreach (Control pBCoin in this.Controls)
                    {
                        if (pBCoin is PictureBox && (string) pBCoin.Tag == "coin")
                        {
                            if (player.Bounds.IntersectsWith(pBCoin.Bounds))
                            {
                                pBCoin.Dispose();
                                score++;
                                scoreLabel.Text = "Score: " + score;
                            }

                            if (player.Bounds.IntersectsWith(pBEnemy.Bounds))
                            {
                                left = false;
                                right = false;
                                jump = false;
                                player.Location = new Point(32, 269);
                                life += 1;
                                LifeStatus();
                            }
                            
                            if (pBEnemy.Bounds.IntersectsWith(pBCoin.Bounds))
                            {
                                pBEnemy.BackColor = Color.Transparent;
                                pBCoin.BackColor = Color.Transparent;
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

            if (player.Bounds.IntersectsWith(door.Bounds) && hasTheSaber == true && score >= 20)
            {
                door.Image = Properties.Resources.door_open;
                option = 1;
                overLabel.Text = "You Win!";
                restartLbl.Text = "Level 2";
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
        private void EnemyMovement(PictureBox enemy1, PictureBox enemy2)
        {
            if (enemy1.Left > 500)
            {
                speed -= 1;
            }
            if (enemy1.Left < 200)
            {  
                speed = 1;
            }
            enemy1.Left += speed;
            enemy2.Left += speed;
        }

        /// <summary>
        /// reaguje na timer Movement (zajistuje beh hry)
        /// vola dve dalsi metody pro nepratele (jejich pohyb) a vysledek hry
        /// umoznuje pohyb a skok hrace a take osetruje dopad a srazku hrace s platformou
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MovementHandler(object sender, EventArgs e)
        {
            EnemyMovement(en_1, en_2);
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
                if (x is PictureBox && (string) x.Tag == "platform")
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
        /// reaguje na timer Animation
        /// meni vzhled hrace podle pohybu doleva a doprava, neosetruje to u jineho skinu hrace
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnimationHandler(object sender, EventArgs e)
        {
            if (OptionPage.skin == null)
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
        /// metoda slouzici pro ulozeni stavu hry do textoveho souboru
        /// vola dalši metodu, ktera analyzuje data pro ulozeni do stringu
        /// </summary>
        private void SaveGamePressedS()
        {
            if (paused == true)
            {
                string saveDataToFile = AddGamePropertiesToSaveString(player.Location.X, player.Location.Y, life, score, hasTheSaber, en_1, en_2, saber);

                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "txt files (*.txt)|*.txt";
                saveDialog.FilterIndex = 2;
                saveDialog.RestoreDirectory = true;

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter writer = new StreamWriter(saveDialog.OpenFile());
                    foreach (char c in saveDataToFile)
                    {
                        writer.Write(c);
                    }
                    writer.Dispose();
                    writer.Close();
                }
            }
        }

        /// <summary>
        /// metoda pro nacteni hry z textoveho souboru
        /// vyuziva dalsi metodu ktera nacte data do hry ze stringu
        /// </summary>
        private void LoadGamePressedL()
        {
            if (paused)
            {
                string stringDataFromFile = "";
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "txt files (*.txt)|*.txt";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var fileStream = openFileDialog.OpenFile();
                        using (StreamReader reader = new StreamReader(fileStream))
                        {
                            while (!reader.EndOfStream)
                            {
                                stringDataFromFile += reader.ReadLine();
                            }
                        }
                        LoadDataFromAFile(stringDataFromFile);
                    }
                }
            }
        }


        /// <summary>
        /// metoda rozdeli data ze stringu do promennych hry a nachysta hru ke spusteni
        /// </summary>
        private void LoadDataFromAFile(string s)
        {
            try {
            string[] coins;
            string[] properties = s.Split(new[] { ';' });
            player.Location = new Point(Int32.Parse(properties[0]), Int32.Parse(properties[1]));
            life = Int32.Parse(properties[2]);
            score = Int32.Parse(properties[3]);
            scoreLabel.Text = "Score: " + score;
            hasTheSaber = Boolean.Parse(properties[4]);
            if (hasTheSaber == false)
            {
                saber.Location = new Point(Int32.Parse(properties[5]), Int32.Parse(properties[6]));
                en_1.Location = new Point(Int32.Parse(properties[7]), Int32.Parse(properties[8]));
                en_2.Location = new Point(Int32.Parse(properties[9]), Int32.Parse(properties[10]));
                coins = properties[11].Split(new[] { '+' });
            } else
            {
                saber.Visible = false;
                en_1.Location = new Point(Int32.Parse(properties[5]), Int32.Parse(properties[6]));
                en_2.Location = new Point(Int32.Parse(properties[7]), Int32.Parse(properties[8]));
                coins = properties[9].Split(new[] { '+' });
            }

            LifeStatus();
            EnemyMovement(en_1, en_2);
            foreach (Control pB in Controls)
            {
                if (pB is PictureBox && (string) pB.Tag == "coin")
                {
                    pB.Show();
                    pB.Visible = false;
                }
            }

            for (int i = 0; i < coins.Length - 1; i++)
            {
                string[] location = coins[i].Split(new[] { ',' });
                Point p = new Point(Int32.Parse(location[0]), Int32.Parse(location[1]));

                foreach (Control pB in Controls)
                {
                    if (pB is PictureBox && (string) pB.Tag == "coin")
                    {
                        if (pB.Location == p)
                        {
                            pB.Visible = true;
                        }
                    }
                }
            }

            foreach (Control pB in Controls)
            {
                if (pB is PictureBox && (string) pB.Tag == "coin" && pB.Visible == false)
                {
                    pB.Dispose();
                }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        /// <summary>
        /// metoda ulozi herni data do stringu, neuklada novy skin a pozadi
        /// </summary>
        public string AddGamePropertiesToSaveString(int playerX, int playerY, int life, int score, bool hasTheSaber, PictureBox enemy1, PictureBox enemy2, PictureBox saber)
        {
            string saveString = string.Empty;
            saveString += playerX + ";\n";
            saveString += playerY + ";\n";
            saveString += life + ";\n";
            saveString += score + ";\n";
            saveString += hasTheSaber + ";\n";
            if (hasTheSaber == false)
            {
                saveString += saber.Location.X + ";\n";
                saveString += saber.Location.Y + ";\n";
            }
            saveString += enemy1.Location.X + ";\n";
            saveString += enemy1.Location.Y + ";\n";
            saveString += enemy2.Location.X + ";\n";
            saveString += enemy2.Location.Y + ";";

            foreach (Control pB in this.Controls)
            {
                if (pB is PictureBox && (string) pB.Tag == "coin")
                {
                    saveString += "\n" + pB.Location.X + "," + pB.Location.Y + "+";
                }
            }
            return saveString;
        }

        /// <summary>
        /// metoda obsluhujici stisk danych klaves (pohyb, skok, pause, resume, informace, save a load hry)
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
                    paused = true;
                    pausedGame.Visible = true;
                    break;
                case Keys.Enter:
                    pausedGame.Visible = false;
                    paused = false;
                    Animation.Start();
                    Movement.Start();
                    break;
                case Keys.I:
                    MessageBox.Show("------INFORMATION------\n" +
                        "Use left and right arrow for moving and space for jumping.\n" +
                        "You have to collect all the coins and the saber and then get to the door, before you ran out of lives.\n" +
                        "P is for pause and Enter for resume.\n" +
                        "Save your game, when paused using S key.\n" +
                        "Load your saved game by using L key.\n" +
                        "You can also use I to show this information box.");
                    break;
                case Keys.S:
                    SaveGamePressedS();
                    break;
                case Keys.L:
                    LoadGamePressedL();
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
        /// metoda pro restartovani hry nebo spusteni druheho levelu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void restartLbl_Click(object sender, EventArgs e)
        {
            if(option == 0)
            {
                MainGame newWindow = new MainGame();
                newWindow.Show();
                this.Hide();
            } else if (option == 1)
            {
                SecondLevel newWindow = new SecondLevel();
                newWindow.Show();
                this.Hide();
            }

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
