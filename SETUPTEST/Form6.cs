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
    public partial class Form6 : Form
    {
        Thread th6;
        public Form6()
        {
            InitializeComponent();
        }

        private void MENU(object obj)
        {
            Application.Run(new Form1());
        }

        private void CHANGELOG(object obj)
        {
            Application.Run(new Form7());
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // label1 will provide the user with the developer of the program
            label1.Text = "DEVELOPER: SOYAB NANDHLA \n \nThis program was created only by me and will get constant updates if more features are wanted. \nFeatures can be suggested by conatacting me and bugs will need to be emailed to me if found, preferably with screenshots. \nThe donate button gives me support in what I can do and helps me in other bigger projects in the future.";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("SORRY, NOT IMPLEMENTED YET!", "WARNING!");
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            th6 = new Thread(MENU);
            th6.SetApartmentState(ApartmentState.STA);
            th6.Start();
        }

        private void button3_Click(object sender, MouseEventArgs e)
        {
            this.Close();
            th6 = new Thread(CHANGELOG);
            th6.SetApartmentState(ApartmentState.STA);
            th6.Start();
        }
    }
}
