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
    public partial class Form2 : Form
    {
        Thread th2;
        int Easy = 0;
        int Medium = 0;
        int Hard = 0;
        int timeleft;
        public Form2(int easy, int medium, int hard)
        {
            InitializeComponent();
            Easy = easy;
            Medium = medium;
            Hard = hard;
            if (Easy == 1)
            {
                this.Text = "EASY";
            }
            else if (Medium == 1)
            {
                this.Text = "MEDIUM";
            }
            else if (Hard == 1)
            {
                this.Text = "HARD";
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Easy == 1)
            {
                label1.Text = "0";
                label2.Text = "YOU HAVE A MINUTE TO CLICK AS FAST AS YOU CAN";
                timeleft = 60;
                if (!File.Exists(@"C:\CLICKER\EASY.txt"))
                {
                    string num = "0";
                    File.AppendAllText(@"C:\CLICKER\EASY.txt", num);
                }
                string text = File.ReadAllText(@"C:\CLICKER\EASY.txt");
                label4.Text = text;
            }
            else if (Medium == 1)
            {
                label1.Text = "0";
                label2.Text = "YOU HAVE A 30 SECONDS TO CLICK AS FAST AS YOU CAN";
                timeleft = 30;
                if (!File.Exists(@"C:\CLICKER\MEDIUM.txt"))
                {
                    string num = "0";
                    File.AppendAllText(@"C:\CLICKER\MEDIUM.txt", num);
                }
                string text = File.ReadAllText(@"C:\CLICKER\MEDIUM.txt");
                label4.Text = text;
            }
            else if (Hard == 1)
            {
                label1.Text = "0";
                label2.Text = "YOU HAVE A 15 SECONDS TO CLICK AS FAST AS YOU CAN";
                timeleft = 15;
                if (!File.Exists(@"C:\CLICKER\HARD.txt"))
                {
                    string num = "0";
                    File.AppendAllText(@"C:\CLICKER\HARD.txt", num);
                }
                string text = File.ReadAllText(@"C:\CLICKER\HARD.txt");
                label4.Text = text;
            }
        }

        private void MENU(object obj)
        {
            Application.Run(new Form1());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeleft > 0)
            {
                timeleft = timeleft - 1;
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("TIMES UP \nSCORE: " + label1.Text);
                button1.Enabled = false;
                button2.Enabled = true;
                if (Convert.ToInt16(label1.Text) > Convert.ToInt16(label4.Text))
                {
                    label4.Text = label1.Text;
                    string text = label4.Text;


                    if (Easy == 1)
                    {
                        File.WriteAllText(@"C:\CLICKER\EASY.txt", text);
                    }
                    else if (Medium == 1)
                    {
                        File.WriteAllText(@"C:\CLICKER\MEDIUM.txt", text);
                    }
                    else if (Hard == 1)
                    {
                        File.WriteAllText(@"C:\CLICKER\HARD.txt", text);
                    }
                }

            }
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            timer1.Start();
            label1.Text = (Convert.ToInt16(label1.Text) + 1).ToString();
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Text = "0";
            button1.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            if (Easy == 1)
            {
                timeleft = 60;
            }
            else if (Medium == 1)
            {
                timeleft = 30;
            }
            else if (Hard == 1)
            {
                timeleft = 15;
            }
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            string num = "0";
            if (Easy == 1)
            {
                File.WriteAllText(@"C:\CLICKER\EASY.txt", num);
                label4.Text = num;
            }
            else if (Medium == 1)
            {
                File.WriteAllText(@"C:\CLICKER\MEDIUM.txt", num);
                label4.Text = num;
            }
            else if (Hard == 1)
            {
                File.WriteAllText(@"C:\CLICKER\HARD.txt", num);
                label4.Text = num;
            }
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            th2 = new Thread(MENU);
            th2.SetApartmentState(ApartmentState.STA);
            th2.Start();
        }
    }
}
