using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cari
{
    public partial class Ekran1 : Form
    {
        public Ekran1()
        {
            InitializeComponent();
        }

        private void s_Click(object sender, EventArgs e)
        {
            Ekran2 ekran2 = new Ekran2();
            ekran2.Show();
        }

        private void Ekran1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Kullanıcıdan onay al
            DialogResult result = MessageBox.Show(
                "Uygulamayı kapatmak istediğinize emin misiniz?",
                "Kapatma Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
            {
                // Kapatma işlemini iptal et
                e.Cancel = true;
            }
            else
            {
                // Uygulamayı tamamen kapat
                Application.Exit();
            }
        }


    }
}
