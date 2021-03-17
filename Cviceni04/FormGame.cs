using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cviceni04
{
    enum Mode 
    { 
        RandLetter, FirstLetter, Words 
    }
    public partial class FormGame : Form
    {
        Random random = new Random();
        Stats stats = new Stats();
        Words words = new Words();
        Mode mode;

        public FormGame()
        {
            InitializeComponent();
            stats.UpdatedStats += OnUpdateStats;
            timer1.Stop();
            timer1.Tick += OnTimerTick;
        }

        private void OnUpdateStats(object sender, EventArgs e)
        {
            correctLabel.Text = $"Correct: {stats.Correct}";
            missedLabel.Text = $"Missed: {stats.Missed}";
            accurancyLabel.Text = $"Accuracy: {stats.Accuracy} %";
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            if(mode != Mode.Words)
            {
                if (gameListBox.Items.Count > 6)
                {
                    GameOver();
                } else
                {
                    gameListBox.Items.Add((Keys)random.Next(65, 91));
                }
            }
        }

        private void GameOver()
        {
            timer1.Stop();
            gameListBox.KeyDown -= OnKeyDown;
            gameListBox.Items.Clear();
            gameListBox.Items.Add("Game over");
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (mode == Mode.RandLetter)
            {
                if (gameListBox.Items.Contains(e.KeyCode))
                {
                    gameListBox.Items.Remove(e.KeyCode);
                    gameListBox.Refresh();
                    updateTimer();
                    stats.Update(true);
                }
                else
                {
                    stats.Update(false);
                }
            } else if ( mode == Mode.Words)
            {
                if ((Keys)gameListBox.Items[0] == e.KeyCode)
                {
                    gameListBox.Items.RemoveAt(0);
                    gameListBox.Refresh();
                    stats.Update(true);
                    if (gameListBox.Items.Count == 0)
                    {
                        string word = words.GetRandomWord();
                        foreach (var c in word)
                        {
                            gameListBox.Items.Add((Keys) char.ToUpper(c));
                        }
                    }
                }
                else
                {
                    GameOver();
                }


            } else
            {
                if ((Keys)gameListBox.Items[0] == e.KeyCode)
                {
                    gameListBox.Items.RemoveAt(0);
                    gameListBox.Refresh();
                    updateTimer();
                    stats.Update(true);
                }
                else
                {
                    stats.Update(false);
                }
            }
            int difficulty = 800 - timer1.Interval;
            difficultProgressBar.Value = difficulty;

        }

        private void updateTimer()
        {
            if (timer1.Interval > 400)
                timer1.Interval -= 60;

            if (timer1.Interval > 250)
                timer1.Interval -= 15;

            if (timer1.Interval > 150)
                timer1.Interval -= 8;
        }

        private void StartNewGame()
        {
            gameListBox.Items.Clear();
            stats.clearStats();

            if(mode == Mode.Words)
            {
                string word = words.GetRandomWord();
                foreach (var c in word) 
                {
                    gameListBox.Items.Add((Keys)char.ToUpper(c));
                }
            } else
            {
                timer1.Interval = 800;
                timer1.Start();
            }

            gameListBox.KeyDown += OnKeyDown;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void matchAnyLetterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = Mode.RandLetter;
            StartNewGame();
        }

        private void matchFirstLetterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = Mode.FirstLetter;
            StartNewGame();
        }

        private void matchWordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = Mode.Words;
            StartNewGame();
        }

        private void difficultyLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
