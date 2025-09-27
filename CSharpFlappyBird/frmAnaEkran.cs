using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Windows.Forms;

namespace CSharpFlappyBird

{

    public partial class frmAnaEkran : Form

    {

        private BindingList<SkorBilgisi> skorListesi;

        public frmAnaEkran()

        {

            InitializeComponent();

            skorListesi = new BindingList<SkorBilgisi>();

            gridControl1.DataSource = skorListesi;

        }

        private void btnOyunaBasla_Click(object sender, EventArgs e)

        {

            frmPlay frmPlay = new frmPlay();

            frmPlay.ShowDialog();

        }

        private void labelControl2_Click(object sender, EventArgs e)

        {

        }

        private void btnSkorKaydet_Click(object sender, EventArgs e)

        {

            if (string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSkor.Text))

            {

                MessageBox.Show("Lütfen ad ve skor giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;

            }

            skorListesi.Add(new SkorBilgisi

            {

                Ad = txtAd.Text,

                Skor = Convert.ToInt32(txtSkor.Text)

            });

            txtAd.Clear();

            txtSkor.Clear();

            txtAd.Focus();

        }

    }



    public class SkorBilgisi

    {

        public string Ad { get; set; }

        public int Skor { get; set; }

    }

}