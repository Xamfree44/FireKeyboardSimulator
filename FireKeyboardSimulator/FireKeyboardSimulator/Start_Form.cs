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
        Core1 Learn;
        Core_2 SpeedUp;
        Core_3 Records;
        Core_4 Endless;
        public Start_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Core1 f = new Core1(this.textBox1.Text);
                f.Show();
            }
        }
    }
}
