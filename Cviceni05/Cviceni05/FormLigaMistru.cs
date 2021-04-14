using System;
using System.Windows.Forms;
using static Cviceni05.Hraci;

namespace Cviceni05
{
    public partial class FormLigaMistru : Form
    {
        public Hraci hraci;
        public Hrac TempPlayer;

        private PocetHracuChangeEventHandler handler;

        public FormLigaMistru()
        {
            InitializeComponent();
            hraci = new Hraci();
            hraci.Pridej(new Hrac("Cristiano Ronaldo", FotbalovyKlub.RealMadrid, 10));
            hraci.Pridej(new Hrac("Erling Haaland", FotbalovyKlub.Barcelona, 6));
            hraci.Pridej(new Hrac("Karim Benzema", FotbalovyKlub.RealMadrid, 4));
            hraci.Pridej(new Hrac("Lionel Messi", FotbalovyKlub.Barcelona, 8));
            dataGridView1.DataSource = hraci.PoleHracu;

            handler = delegate () {
                listView1.Items.Add("Proběhla změna počtu nebo informace o hráčích");
            };
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormHrac formHrac = new FormHrac();
            formHrac.ShowDialog();
            hraci.Pridej(formHrac.PomocnyHrac);
            dataGridView1.Refresh();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            hraci.Vymaz(dataGridView1.CurrentCell.RowIndex);
            dataGridView1.Refresh();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Hrac hrac = hraci.PoleHracu[dataGridView1.CurrentCell.RowIndex];
            FormHrac formHrac = new FormHrac();
            formHrac.SetText(hrac);
            formHrac.ShowDialog();
            hraci.PoleHracu[dataGridView1.CurrentCell.RowIndex] = formHrac.PomocnyHrac;
            dataGridView1.Refresh();
        }

        private void buttonBest_Click(object sender, EventArgs e)
        {
            FormNejlepsiKluby formNejKluby = new FormNejlepsiKluby();
            FotbalovyKlub[] kluby;
            int pocet = 0;
            hraci.NajdiNejlepsiKluby(out kluby,out pocet);
            formNejKluby.SetClubs(kluby,pocet);
            formNejKluby.Show();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            hraci.PocetZmenen += handler;
            listView1.Items.Add("zaregistrován handler");
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            hraci.PocetZmenen -= handler;
            listView1.Items.Add("zrušena registrace handleru");
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormLigaMistru_Load(object sender, EventArgs e)
        {

        }
    }
}
