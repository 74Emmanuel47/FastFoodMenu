using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            firstCustomControl1.BringToFront();
            secondCustomControl1.SendToBack();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            indicator.Location = new Point(indicator.Location.X, btnHome.Location.Y);
            firstCustomControl1.BringToFront();
        }

        private void btnEatIn_Click(object sender, EventArgs e)
        {
            secondCustomControl1.BringToFront();
            indicator.Location = new Point(indicator.Location.X, btnEatIn.Location.Y);
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
