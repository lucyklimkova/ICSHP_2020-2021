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

namespace Cviceni05
{
    public partial class FormUloz : Form
    {
        Hraci hraci;
        public FormUloz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Uloz();
            this.Close();
        }

        public void NactiTeamy(FotbalovyKlub[] kluby, Hraci hraci)
        {
            foreach (var item in kluby)
            {
                listView1.Items.Add(item.ToString());
            }
            this.hraci = hraci;
        }

        private void Uloz()
        {
            String[] hraciString = null;
            String[] kluby = new String[listView1.SelectedItems.Count];
            int index = 0;

            foreach (ListViewItem item in listView1.SelectedItems)
            {
                kluby[index] = item.Text;
                index++;
            }

            hraciString = new String[hraci.Pocet];
            for (int i = 0; i < hraci.Pocet; i++)
            {
                if (hraci[i] == null)
                {
                    continue;
                }
                if (kluby.Contains(hraci[i].FotbalovyKlub.ToString()))
                {
                    hraciString[i] += hraci[i].ToString();
                }
            }

            int citac = 0;
            foreach (var item in hraciString)
            {
                if (item == null)
                {
                    citac++;
                }
            }

            String[] hraciStringSeznam = new String[hraci.Pocet - citac];
            index = 0;
            foreach (var item in hraciString)
            {
                if (item != null)
                {
                    hraciStringSeznam[index] = item;
                    index++;
                }
            }

            File.WriteAllLines("C:/Kluby.txt", hraciStringSeznam);
        }

        private void FormUloz_Load(object sender, EventArgs e)
        {


        }
    }
}
