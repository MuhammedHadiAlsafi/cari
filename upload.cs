using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cari
{
    internal class upload
    {
        static public int de = 10;
        static public void create(FlowLayoutPanel fl, int s){ 
        for (int i = 0; i < s; i++)
            {
                Button btn = new Button();
                btn.Size = new Size(fl.Width/7,fl.Height/5);
                btn.Text = i.ToString();
                fl.Controls .Add(btn);
            }
        }
        static public void createM(FlowLayoutPanel fl)
        {
            for (int i = 12; i < 20; i++)
            {
                Button btn = new Button();
                btn.Size = new Size(fl.Width / 7, fl.Height / 5);
                btn.Text = "Masa \n"+i.ToString();
                fl.Controls.Add(btn);
            }
        }
    }
}
