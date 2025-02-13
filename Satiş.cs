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
    public partial class Satiş : Form
    {
        public Satiş()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel2_Resize(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_SizeChanged(object sender, EventArgs e)
        {
            button4.Size = new System.Drawing.Size(flowLayoutPanel2.Width,flowLayoutPanel2.Height/10);
            button5.Size = new System.Drawing.Size(flowLayoutPanel2.Width, flowLayoutPanel2.Height / 10);
            button6.Size = new System.Drawing.Size(flowLayoutPanel2.Width, flowLayoutPanel2.Height / 10);
        }
    }
}
