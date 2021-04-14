using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cviceni05
{
    public partial class FormNejlepsiKluby : Form
    {
        public FormNejlepsiKluby()
        {
            InitializeComponent();
            
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SetClubs(FotbalovyKlub[] kluby, int nejviceBodu)
        {
            labelGoly.Text = $"Body: {nejviceBodu} ";
            foreach (var polozka in kluby)
            {
                if (FotbalovyKlub.None==polozka) {
                    continue;
                }
                listView1.Items.Add(polozka.ToString());
            }           
        }

        private void FormNejlepsiKluby_Load(object sender, EventArgs e)
        {

        }
    }
}
