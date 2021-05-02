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
            InformationBox box = new InformationBox();
            box.Show();
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


        /// <summary>
        /// metoda uschova okno options
        /// </summary>
        private void close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void OptionPage_Load(object sender, EventArgs e)
        {

        }
    }
}
