using System;
using System.Drawing;
using System.Windows.Forms;

namespace StarWars_Mario_Klimkova
{
    public partial class OptionPage : Form
    {
        public static Image bckg;
        public static Image skin;
        public static string picname;

        public OptionPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// metoda po kliknuti nacte obrazek noveho pozadi pro aktualni hru
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeBacground_Click(object sender, EventArgs e)
        {
            var FD = new OpenFileDialog
            {
                Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png"
            };
            if (FD.ShowDialog() == DialogResult.OK)
            {
                _ = FD.FileName;
                _ = new System.IO.FileInfo(FD.FileName);
                bckg = Image.FromFile(FD.FileName);
            }
        }

        /// <summary>
        /// metoda po kliknuti zobrazi informace o hre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Information_Click(object sender, EventArgs e)
        {
            InformationBox box = new InformationBox();
            box.Show();
        }

        /// <summary>
        /// metoda po kliknuti nacte novy skin hrac do hry 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeSkin_Click(object sender, EventArgs e)
        {
            var FD = new OpenFileDialog
            {
                Filter = "png files|*.png"
            };
            if (FD.ShowDialog() == DialogResult.OK)
            {
                picname = FD.FileName;
                _ = new System.IO.FileInfo(FD.FileName);
                skin = Image.FromFile(FD.FileName);
            }
        }


        /// <summary>
        /// metoda uschova okno options
        /// </summary>
        private void Close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
