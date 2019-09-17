using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace SETUPTEST
{
    public partial class Form1 : Form
    {
        Thread th;
        int easy = 0;
        int medium = 0;
        int hard = 0;
        int test = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "MAIN MENU";

            Directory.CreateDirectory("C:\\TEST INC");
        }

        private void GAME(object obj)
        {
            Application.Run(new Form2(easy, medium, hard));
        }

        private void CUSTOM(object obj)
        {
            Application.Run(new Form5());
        }

        private void CREDITS(object obj)
        {
            Application.Run(new Form6());
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            easy = 1;
            medium = 0;
            hard = 0;
            this.Close();
            th = new Thread(GAME);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            easy = 0;
            medium = 1;
            hard = 0;
            this.Close();
            th = new Thread(GAME);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            easy = 0;
            medium = 0;
            hard = 1;
            this.Close();
            th = new Thread(GAME);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            th = new Thread(CUSTOM);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button5_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            th = new Thread(CREDITS);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
