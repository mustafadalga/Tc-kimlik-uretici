using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TcKimlikOlusturucu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void btnuret_Click(object sender, EventArgs e)
        {
            int i=1,uretilen,tektop=0,cifttop=0;
            string tc="";
            while (i<10)
            {
                uretilen = rnd.Next(10);
                if ((i == 1 || i == 9) && (uretilen != 0))
                {
                    if (i%2==0)
                    {
                        cifttop += uretilen;
                        tc += uretilen;
                        i++;
                    }
                    else
                    {
                        tektop += uretilen;
                        tc += uretilen;
                        i++;
                    }
                }
                else if (i > 1 && i < 9)
                {
                    if (i % 2 == 0)
                    {
                        cifttop += uretilen;
                        tc += uretilen;
                        i++;
                    }
                    else
                    {
                        tektop += uretilen;
                        tc += uretilen;
                        i++;
                    }
                }
            }
            tc += ((7 * tektop - cifttop) % 10).ToString() + (tektop + cifttop + (7 * tektop - cifttop) % 10) % 10;
            textBox1.Text = tc;
        }
        private void btnkopyala_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="")
            {
                Clipboard.SetText(textBox1.Text);
            }
        }
    }
}
