using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Vetrenko
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            
            //if (pct.Right != this.Right)
            if (pct.Left<pct.Width)
            { 
                pct.Left = pct.Left + 10;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (tmr.Enabled == false)
            {
                tmr.Enabled = true;
                btnStart.Text = "Старт";
            }
            else
            {
                tmr.Enabled = false;
                btnStart.Text = "Стоп";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pct_Click(object sender, EventArgs e)
        {

        }
    }
}
