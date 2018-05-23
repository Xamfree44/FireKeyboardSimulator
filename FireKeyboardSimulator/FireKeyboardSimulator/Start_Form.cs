﻿using System;
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
        static string data = "";
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
            if (smallLett.Checked) data += "a";
            if (bigLett.Checked) data += "A";
            if (numb.Checked) data += "1";
            if (punctuation.Checked) data += "-";

            for (; data.Length < 6;) data += "U";

            if (LearnButton.Checked)
            {
                Form1 f_1 = new Form1(data);
                f_1.Show();
            }
            if (SpeedUpButton.Checked)
            {
                Form2 f_2 = new Form2(data);
                f_2.Show();
            }
            if (ScoreButton.Checked)
            {
                Form3 f_3 = new Form3(data);
                f_3.Show();
            }
            if (EndlessButton.Checked)
            {
                Form4 f_4 = new Form4(data);
                f_4.Show();
            }
            data = "";
        }
    }
}
