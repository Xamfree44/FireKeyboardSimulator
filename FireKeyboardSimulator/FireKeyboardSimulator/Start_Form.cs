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
        Form1 Learn;
        public Start_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Form1 f = new Form1(this.textBox1.Text);
                f.Show();
            }
            if (radioButton2.Checked)
            {
                Form1 f = new Form1(this.textBox1.Text);
                f.Show();
            }
        }
    }
}
