using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireKeyboardSimulator
{
    public partial class Start_Form : Form
    {
        Form1 f_1;
        Form2 f_2;
        Form3 f_3;
        Form4 f_4;
        public Start_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Form1 f_1 = new Form1(this.textBox1.Text);
                f_1.Show();
            }
            if (radioButton2.Checked)
            {
                Form2 f_2 = new Form2(this.textBox1.Text);
                f_2.Show();
            }
            if (radioButton3.Checked)
            {
                Form3 f_3 = new Form3(this.textBox1.Text);
                f_3.Show();
            }
            if (radioButton4.Checked)
            {
                Form4 f_4 = new Form4(this.textBox1.Text);
                f_4.Show();
            }
        }
    }
}
