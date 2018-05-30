/*

            FireKeybordSimulator
                    by
       Emil Antonov & Vladimir Khmara
              Copyright © 2018

*/

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
    public partial class Start_Page : Form
    {
        static string data = "";
        Training f_1;
        Advanced f_2;
        Highscore f_3;
        Endless f_4;

        public Start_Page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (smallLett.Checked) data += "a";
            if (bigLett.Checked) data += "A";
            if (numb.Checked) data += "1";
            if (punctuation.Checked) data += "-";

            for (; data.Length < 6;) data += "U";

            if (LearnButton.Checked)
            {
                f_1 = new Training(data);
                f_1.Show();
            }
            if (SpeedUpButton.Checked)
            {
                f_2 = new Advanced(data);
                f_2.Show();
            }
            if (ScoreButton.Checked)
            {
                f_3 = new Highscore(data);
                f_3.Show();
            }
            if (EndlessButton.Checked)
            {
                f_4 = new Endless(data);
                f_4.Show();
            }
            data = "";
        }
    }
}
