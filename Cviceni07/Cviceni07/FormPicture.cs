using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cviceni07
{
    public partial class FormPicture : Form
    {
        public FormPicture()
        {
            InitializeComponent();
        }
        private Bitmap ZmenVelikostObrazku(Bitmap bmp)
        {
            var ratioX = (double)pictureBox.Width / bmp.Width;
            var ratioY = (double)pictureBox.Height / bmp.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(bmp.Width * ratio);
            var newHeight = (int)(bmp.Height * ratio);

            return new Bitmap(bmp, newWidth, newHeight);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "pcx files (*.pcx)|*.pcx";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    DecoderPcx decoder = new DecoderPcx();
                    pictureBox.Image = ZmenVelikostObrazku(decoder.NactiObrazek(openFileDialog.FileName));
                }
            }
        }

        private void FormPicture_Load(object sender, EventArgs e)
        {

        }
    }
}
