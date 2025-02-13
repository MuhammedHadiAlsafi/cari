using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cari;

namespace cari
{
    public partial class Ekran2 : Form
    {
        
        public Ekran2()
        {
            InitializeComponent();
    }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ekran2_Load(object sender, EventArgs e)
        {
            upload.createM(liste);
            upload.create(liste,upload.de);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            upload.de++;
            liste.Controls.Clear();
            upload.create(liste, upload.de);
            button1.Text = upload.de.ToString();*/
            Satiş satis = new Satiş();
            satis.Show();
        }

        private void liste_SizeChanged(object sender, EventArgs e)
        {
            liste.Controls.Clear();
            upload.create(liste, upload.de);
            button1.Text = upload.de.ToString();
        }
    }
}
