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
    public partial class Form5 : Form
    {
        Thread th5;

        int timeleft;
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            label1.Text = "0";
            label2.Text = "YOU CAN APPLY ANY AMOUNT OF TIME TO YOUR SELF";
            timeleft = 60;
            textBox1.Text = "60";
            if (!File.Exists(@"C:\TEST INC\CUSTOM.txt"))
            {
                string num = "0";
                File.AppendAllText(@"C:\TEST INC\CUSTOM.txt", num);
            }
            string text = File.ReadAllText(@"C:\TEST INC\CUSTOM.txt");
            label4.Text = text;
        }

        private void MENU(object obj)
        {
            Application.Run(new Form1());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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



                    File.WriteAllText(@"C:\TEST INC\CUSTOM.txt", text);
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
            button5.Enabled = false;
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Text = "0";
            button1.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;

            try
            {
                timeleft = Convert.ToInt16(textBox1.Text);

                if (timeleft >= 3601)
                {
                    MessageBox.Show("The number is above 1 hour \nNumber reset to default");
                    timeleft = 60;
                    textBox1.Text = "60";
                }
                else if (timeleft <= 0)
                {
                    MessageBox.Show("The number is below 0 \nNumber reset to default");
                    timeleft = 60;
                    textBox1.Text = "60";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("That is not a valid number \nNumber reset to default");
                timeleft = 60;
                textBox1.Text = "60";
            }
            catch (OverflowException)
            {
                MessageBox.Show("The number is too low or too high \nNumber reset to default");
                timeleft = 60;
                textBox1.Text = "60";
            }
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            string num = "0";
            File.WriteAllText(@"C:\TEST INC\CUSTOM.txt", num);
            label4.Text = num;
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            th5 = new Thread(MENU);
            th5.SetApartmentState(ApartmentState.STA);
            th5.Start();
        }

        private void button5_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                timeleft = Convert.ToInt16(textBox1.Text);

                if (timeleft >= 3601)
                {
                    MessageBox.Show("The number is above 1 hour \nNumber reset to default");
                    timeleft = 60;
                    textBox1.Text = "60";
                }
                else if (timeleft <= 0)
                {
                    MessageBox.Show("The number is below 0 \nNumber reset to default");
                    timeleft = 60;
                    textBox1.Text = "60";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("That is not a valid number \nNumber reset to default");
                timeleft = 60;
                textBox1.Text = "60";
            }
            catch (OverflowException)
            {
                MessageBox.Show("The number is too low or too high \nNumber reset to default");
                timeleft = 60;
                textBox1.Text = "60";
            }
        }
    }
}
