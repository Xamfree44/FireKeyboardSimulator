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
    public partial class Core1 : Form
    {
        Random rnd = new Random();
        public Core1(string data)
        {
            InitializeComponent();
            this.data = data;
            for (int i = 0; i < 10; i++)
                CoreMechanics(1);
        }
        string data;
        void CoreMechanics(int ctrl)
        {

            switch (ctrl)
            {
                case (1):
                    Char[] pwdChars = new Char[26] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
                    label1.Text += pwdChars[rnd.Next(0, 25)];
                    break;
                case (2):
                    Char[] pwdChars2 = new Char[36] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                    label1.Text = String.Empty;
                    break;
                case (3): break;
                case (4): break;
                case (5): break;
            }

        }

        private void Core1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (label1.Text[0] == e.KeyChar)
            {
                label1.Text = label1.Text.Remove(0, 1);
                label1.ForeColor = Color.Green;
            }
            else label1.ForeColor = Color.Red;
        }
    }
}
