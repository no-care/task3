using Laba_1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication12
{
    public partial class Form1 : Form
    {

        int i = 0;

        circle[] circ;
        public Form1()
        {
            InitializeComponent();
            circ = new circle[100];
            circ[i] = new circle(Convert.ToSingle(textBox1.Text), Convert.ToSingle(textBox2.Text), Convert.ToSingle(textBox3.Text));
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            for (int l = 0; l < i + 1; l ++ )
            {
                circ[l].show(e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            circ[i] = new circle();
            circ[i].setX(Convert.ToSingle(textBox1.Text));
            circ[i].setY(Convert.ToSingle(textBox2.Text));
            circ[i].setR(Convert.ToSingle(textBox3.Text));
            pictureBox1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            circ[i].changeSpeed(Convert.ToSingle(textBox1.Text), Convert.ToSingle(textBox2.Text));
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!circ[i].moveTo(Convert.ToSingle(textBox1.Text), Convert.ToSingle(textBox2.Text))) { timer1.Enabled = false; }
            pictureBox1.Refresh();
        }
    }
}
