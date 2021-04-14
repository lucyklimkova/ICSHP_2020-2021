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
    public partial class FormHrac : Form
    {
        public Hrac PomocnyHrac { get; set; }
        public FormHrac()
        {
            InitializeComponent();
            comboBoxKlub.DataSource = Enum.GetValues(typeof(FotbalovyKlub));
            
        }

        public void SetText(Hrac hrac)
        {
            textBoxJmeno.Text = hrac.Jmeno;
            comboBoxKlub.SelectedItem = hrac.FotbalovyKlub;
            numericUpDownGoly.Value = hrac.Goly;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Hrac hrac = new Hrac(textBoxJmeno.Text,(FotbalovyKlub)comboBoxKlub.SelectedItem,(int)numericUpDownGoly.Value);
            PomocnyHrac = hrac;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormHrac_Load(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }
    }
}
