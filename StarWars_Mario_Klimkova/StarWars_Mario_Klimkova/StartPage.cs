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
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// metody pro zmenu obrazku pri najeti mysi na dany picture box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startBttn_MouseHover(object sender, EventArgs e)
        {
            startBttn.Image = Properties.Resources.start_hover;
        }

        private void optionBttn_MouseHover(object sender, EventArgs e)
        {
            optionBttn.Image = Properties.Resources.option_hover;
        }

        private void exitBttn_MouseHover(object sender, EventArgs e)
        {
            exitBttn.Image = Properties.Resources.exit_hover;
        }

        /// <summary>
        /// metody pro zmenu obrazku picture boxu pri presunu mysi z picture boxu pryc
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startBttn_MouseLeave(object sender, EventArgs e)
        {
            startBttn.Image = Properties.Resources.start_normal;
        }

        private void optionBttn_MouseLeave(object sender, EventArgs e)
        {
            optionBttn.Image = Properties.Resources.option_normal;
        }

        private void exitBttn_MouseLeave(object sender, EventArgs e)
        {
            exitBttn.Image = Properties.Resources.exit_normal;
        }

        /// <summary>
        /// metoda, ktera spousti hru
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startBttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainGame game = new MainGame();
            game.ShowDialog();
        }

        /// <summary>
        /// metoda spousti option dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void optionBttn_Click(object sender, EventArgs e)
        {
            OptionPage option = new OptionPage();
            option.ShowDialog();
        }

        /// <summary>
        /// metoda pro ukonceni aplikace
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitBttn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Start_Page_Load(object sender, EventArgs e)
        {

        }
    }
}
