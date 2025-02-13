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
    public partial class SingIn : Form
    {
        public SingIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Sigin.Sigin_send(textBox1.Text, textBox2.Text))
            {
                Ekran1 ekran1 = new Ekran1();
                ekran1.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("merhaba");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
