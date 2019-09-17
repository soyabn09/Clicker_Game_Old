using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SETUPTEST
{
    public partial class Form7 : Form
    {
        Thread th7;
        public Form7()
        {
            InitializeComponent();
        }

        private void CREDITS(object obj)
        {
            Application.Run(new Form6());
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, MouseEventArgs e)
        {
            this.Close();
            th7 = new Thread(CREDITS);
            th7.SetApartmentState(ApartmentState.STA);
            th7.Start();
        }
    }
}
