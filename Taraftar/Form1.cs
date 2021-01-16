using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taraftar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int saniye = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye = Convert.ToInt32(label1.Text);
            saniye++;
            label1.Text = saniye.ToString();

            if (saniye % 10 == 0)
            {
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Yellow;
                button3.BackColor = Color.Red;
                button4.BackColor = Color.Yellow;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Yellow;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Yellow;
            }

            if (saniye % 10 == 5)
            {
                button1.BackColor = Color.Yellow;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Yellow;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Yellow;
                button6.BackColor = Color.Red;
                button7.BackColor = Color.Yellow;
                button8.BackColor = Color.Red;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            timer2.Enabled = true;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            saniye = Convert.ToInt32(label1.Text);
            saniye++;
            label1.Text = saniye.ToString();

            if (saniye % 10 == 0)
            {
                button1.BackColor = Color.Black;
                button2.BackColor = Color.White;
                button3.BackColor = Color.Black;
                button4.BackColor = Color.White;
                button5.BackColor = Color.Black;
                button6.BackColor = Color.White;
                button7.BackColor = Color.Black;
                button8.BackColor = Color.White;
            }

            if (saniye % 10 == 5)
            {
                button1.BackColor = Color.White;
                button2.BackColor = Color.Black;
                button3.BackColor = Color.White;
                button4.BackColor = Color.Black;
                button5.BackColor = Color.White;
                button6.BackColor = Color.Black;
                button7.BackColor = Color.White;
                button8.BackColor = Color.Black;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            timer3.Enabled = true;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            saniye = Convert.ToInt32(label1.Text);
            saniye++;
            label1.Text = saniye.ToString();

            if (saniye % 10 == 0)
            {
                button1.BackColor = Color.Black;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Black;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Black;
                button6.BackColor = Color.Red;
                button7.BackColor = Color.Black;
                button8.BackColor = Color.Red;
            }

            if (saniye % 10 == 5)
            {
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Black;
                button3.BackColor = Color.Red;
                button4.BackColor = Color.Black;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Black;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Black;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = true;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            saniye = Convert.ToInt32(label1.Text);
            saniye++;
            label1.Text = saniye.ToString();

            if (saniye % 10 == 0)
            {
                button1.BackColor = Color.Yellow;
                button2.BackColor = Color.Navy;
                button3.BackColor = Color.Yellow;
                button4.BackColor = Color.Navy;
                button5.BackColor = Color.Yellow;
                button6.BackColor = Color.Navy;
                button7.BackColor = Color.Yellow;
                button8.BackColor = Color.Navy;
            }

            if (saniye % 10 == 5)
            {
                button1.BackColor = Color.Navy;
                button2.BackColor = Color.Yellow;
                button3.BackColor = Color.Navy;
                button4.BackColor = Color.Yellow;
                button5.BackColor = Color.Navy;
                button6.BackColor = Color.Yellow;
                button7.BackColor = Color.Navy;
                button8.BackColor = Color.Yellow;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        
    }
}
