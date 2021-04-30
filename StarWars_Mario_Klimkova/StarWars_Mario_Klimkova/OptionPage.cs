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
    public partial class OptionPage : Form
    {
        public static Image bckg;
        public static Image skin;

        public OptionPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// metoda po kliknuti nacte obrazek noveho pozadi pro aktualni hru
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changeBacground_Click(object sender, EventArgs e)
        {
            var FD = new System.Windows.Forms.OpenFileDialog();
            FD.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileToOpen = FD.FileName;

                System.IO.FileInfo File = new System.IO.FileInfo(FD.FileName);
                bckg = Image.FromFile(FD.FileName);
            }
        }

        /// <summary>
        /// metoda po kliknuti zobrazi informace o hre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void information_Click(object sender, EventArgs e)
        {
            MessageBox.Show("------INFORMATION ABOUT THIS GAME------\n" +
                    "Star Wars Mario is an platform jumping game." +
                    "Use left and right arrow for moving and space for jumping.\n" +
                    "You have to collect all the coins and the saber and then get to the door, before you ran out of lives.\n" +
                    "P is for pause and Enter for resume.\n" +
                    "You can also use N to show information box during the game.\n");
        }

        /// <summary>
        /// metoda po kliknuti nacte novy skin hrac do hry 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changeSkin_Click(object sender, EventArgs e)
        {
            var FD = new System.Windows.Forms.OpenFileDialog();
            FD.Filter = "png files|*.png";
            if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileToOpen = FD.FileName;

                System.IO.FileInfo File = new System.IO.FileInfo(FD.FileName);
                skin = Image.FromFile(FD.FileName);
            }
        }
    }
}
