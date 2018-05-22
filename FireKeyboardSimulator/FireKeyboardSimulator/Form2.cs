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
    public partial class Form2 : Form
    {
        string data;
        public Form2(string data)
        {
            InitializeComponent();
            this.data = data;

            label1.Text = data;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button21.Enabled = false;
            button22.Enabled = false;
            button23.Enabled = false;
            button24.Enabled = false;
            button25.Enabled = false;
            button26.Enabled = false;
            button27.Enabled = false;
            button28.Enabled = false;
            button29.Enabled = false;
            button30.Enabled = false;
            button31.Enabled = false;
            button32.Enabled = false;
            button33.Enabled = false;
            button34.Enabled = false;
            button35.Enabled = false;
            button36.Enabled = false;
            button37.Enabled = false;
            button38.Enabled = false;
            button39.Enabled = false;
            button40.Enabled = false;
            button41.Enabled = false;
            button42.Enabled = false;
            button43.Enabled = false;
            button44.Enabled = false;
            button45.Enabled = false;
            button46.Enabled = false;
            button47.Enabled = false;

            label1.BackColor = Color.White;

            button1.BackColor = Color.MediumPurple;   // Purple Buttons
            button12.BackColor = Color.MediumPurple;
            button13.BackColor = Color.MediumPurple;
            button14.BackColor = Color.MediumPurple;
            button42.BackColor = Color.MediumPurple;
            button43.BackColor = Color.MediumPurple;
            button44.BackColor = Color.MediumPurple;
            button47.BackColor = Color.MediumPurple;

            button2.BackColor = Color.MediumSeaGreen; // Green Buttons
            button11.BackColor = Color.MediumSeaGreen;
            button24.BackColor = Color.MediumSeaGreen;
            button33.BackColor = Color.MediumSeaGreen;
            button22.BackColor = Color.MediumSeaGreen;
            button23.BackColor = Color.MediumSeaGreen;
            button32.BackColor = Color.MediumSeaGreen;
            button41.BackColor = Color.MediumSeaGreen;
            button10.BackColor = Color.MediumSeaGreen;
            button45.BackColor = Color.MediumSeaGreen;
            button46.BackColor = Color.MediumSeaGreen;

            button3.BackColor = Color.RoyalBlue; // Blue Buttons
            button4.BackColor = Color.RoyalBlue;
            button15.BackColor = Color.RoyalBlue;
            button25.BackColor = Color.RoyalBlue;
            button34.BackColor = Color.RoyalBlue;
            button9.BackColor = Color.RoyalBlue;
            button21.BackColor = Color.RoyalBlue;
            button31.BackColor = Color.RoyalBlue;
            button40.BackColor = Color.RoyalBlue;

            button5.BackColor = Color.IndianRed; // Red Buttons
            button6.BackColor = Color.IndianRed;
            button16.BackColor = Color.IndianRed;
            button17.BackColor = Color.IndianRed;
            button18.BackColor = Color.IndianRed;
            button26.BackColor = Color.IndianRed;
            button27.BackColor = Color.IndianRed;
            button28.BackColor = Color.IndianRed;
            button35.BackColor = Color.IndianRed;
            button36.BackColor = Color.IndianRed;

            button7.BackColor = Color.Peru; // Orange Buttons
            button8.BackColor = Color.Peru;
            button19.BackColor = Color.Peru;
            button20.BackColor = Color.Peru;
            button29.BackColor = Color.Peru;
            button30.BackColor = Color.Peru;
            button37.BackColor = Color.Peru;
            button38.BackColor = Color.Peru;
            button39.BackColor = Color.Peru;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1)
            {
                button1.Enabled = true;
                button1.BackColor = Color.MediumSlateBlue;
            }
            if (e.KeyCode == Keys.D2)
            {
                button2.Enabled = true;
                button2.BackColor = Color.SeaGreen;
            }
            if (e.KeyCode == Keys.D3)
            {
                button3.Enabled = true;
                button3.BackColor = Color.CornflowerBlue;
            }
            if (e.KeyCode == Keys.D4)
            {
                button4.Enabled = true;
                button4.BackColor = Color.CornflowerBlue;
            }
            if (e.KeyCode == Keys.D5)
            {
                button5.Enabled = true;
                button5.BackColor = Color.LightCoral;
            }
            if (e.KeyCode == Keys.D6)
            {
                button6.Enabled = true;
                button6.BackColor = Color.LightCoral;
            }
            if (e.KeyCode == Keys.D7)
            {
                button7.Enabled = true;
                button7.BackColor = Color.SandyBrown;
            }
            if (e.KeyCode == Keys.D8)
            {
                button8.Enabled = true;
                button8.BackColor = Color.SandyBrown;
            }
            if (e.KeyCode == Keys.D9)
            {
                button9.Enabled = true;
                button9.BackColor = Color.CornflowerBlue;
            }
            if (e.KeyCode == Keys.D0)
            {
                button10.Enabled = true;
                button10.BackColor = Color.SeaGreen;
            }
            if (e.KeyCode == Keys.Q)
            {
                button11.Enabled = true;
                button11.BackColor = Color.SeaGreen;
            }
            if (e.KeyCode == Keys.W)
            {
                button15.Enabled = true;
                button15.BackColor = Color.CornflowerBlue;
            }
            if (e.KeyCode == Keys.E)
            {
                button16.Enabled = true;
                button16.BackColor = Color.LightCoral;
            }
            if (e.KeyCode == Keys.R)
            {
                button17.Enabled = true;
                button17.BackColor = Color.LightCoral;
            }
            if (e.KeyCode == Keys.T)
            {
                button18.Enabled = true;
                button18.BackColor = Color.LightCoral;
            }
            if (e.KeyCode == Keys.Y)
            {
                button19.Enabled = true;
                button19.BackColor = Color.SandyBrown;
            }
            if (e.KeyCode == Keys.U)
            {
                button20.Enabled = true;
                button20.BackColor = Color.SandyBrown;
            }
            if (e.KeyCode == Keys.I)
            {
                button21.Enabled = true;
                button21.BackColor = Color.CornflowerBlue;
            }
            if (e.KeyCode == Keys.O)
            {
                button22.Enabled = true;
                button22.BackColor = Color.SeaGreen;
            }
            if (e.KeyCode == Keys.P)
            {
                button23.Enabled = true;
                button23.BackColor = Color.SeaGreen;
            }
            if (e.KeyCode == Keys.A)
            {
                button24.Enabled = true;
                button24.BackColor = Color.SeaGreen;
            }
            if (e.KeyCode == Keys.S)
            {
                button25.Enabled = true;
                button25.BackColor = Color.CornflowerBlue;
            }
            if (e.KeyCode == Keys.D)
            {
                button26.Enabled = true;
                button26.BackColor = Color.LightCoral;
            }
            if (e.KeyCode == Keys.F)
            {
                button27.Enabled = true;
                button27.BackColor = Color.LightCoral;
            }
            if (e.KeyCode == Keys.G)
            {
                button28.Enabled = true;
                button28.BackColor = Color.LightCoral;
            }
            if (e.KeyCode == Keys.H)
            {
                button29.Enabled = true;
                button29.BackColor = Color.SandyBrown;
            }
            if (e.KeyCode == Keys.J)
            {
                button30.Enabled = true;
                button30.BackColor = Color.SandyBrown;
            }
            if (e.KeyCode == Keys.K)
            {
                button31.Enabled = true;
                button31.BackColor = Color.CornflowerBlue;
            }
            if (e.KeyCode == Keys.L)
            {
                button32.Enabled = true;
                button32.BackColor = Color.SeaGreen;
            }
            if (e.KeyCode == Keys.Z)
            {
                button33.Enabled = true;
                button33.BackColor = Color.SeaGreen;
            }
            if (e.KeyCode == Keys.X)
            {
                button34.Enabled = true;
                button34.BackColor = Color.CornflowerBlue;
            }
            if (e.KeyCode == Keys.C)
            {
                button35.Enabled = true;
                button35.BackColor = Color.LightCoral;
            }
            if (e.KeyCode == Keys.V)
            {
                button36.Enabled = true;
                button36.BackColor = Color.LightCoral;
            }
            if (e.KeyCode == Keys.B)
            {
                button37.Enabled = true;
                button37.BackColor = Color.SandyBrown;
            }
            if (e.KeyCode == Keys.N)
            {
                button38.Enabled = true;
                button38.BackColor = Color.SandyBrown;
            }
            if (e.KeyCode == Keys.M)
            {
                button39.Enabled = true;
                button39.BackColor = Color.SandyBrown;
            }
            if (e.KeyCode == Keys.OemMinus)
            {
                button45.Enabled = true;
                button45.BackColor = Color.SeaGreen;
            }
            if (e.KeyCode == Keys.Oemplus)
            {
                button46.Enabled = true;
                button46.BackColor = Color.SeaGreen;
            }
            if (e.KeyCode == Keys.Back)
            {
                button47.Enabled = true;
                button47.BackColor = Color.MediumSlateBlue;
            }
            if (e.KeyCode == Keys.Tab)
            {
                button12.Enabled = true;
                button12.BackColor = Color.MediumSlateBlue;
            }
            if (e.KeyCode == Keys.CapsLock)
            {
                button13.Enabled = true;
                button13.BackColor = Color.MediumSlateBlue;
            }
            if (e.Modifiers == Keys.LShiftKey)
            {
                button14.Enabled = true;
                button14.BackColor = Color.MediumSlateBlue;
            }
            if (e.KeyCode == Keys.RShiftKey)
            {
                button42.Enabled = true;
                button42.BackColor = Color.MediumSlateBlue;
            }
            if (e.KeyCode == Keys.OemPipe)
            {
                button44.Enabled = true;
                button44.BackColor = Color.MediumSlateBlue;
            }
            if (e.KeyCode == Keys.Enter)
            {
                button43.Enabled = true;
                button43.BackColor = Color.MediumSlateBlue;
            }
            if (e.KeyCode == Keys.Oemcomma)
            {
                button40.Enabled = true;
                button40.BackColor = Color.CornflowerBlue;
            }
            if (e.KeyCode == Keys.OemPeriod)
            {
                button41.Enabled = true;
                button41.BackColor = Color.SeaGreen;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1)
            {
                button1.Enabled = false;
                button1.BackColor = Color.MediumPurple;
            }
            if (e.KeyCode == Keys.D2)
            {
                button2.Enabled = false;
                button2.BackColor = Color.MediumSeaGreen;
            }
            if (e.KeyCode == Keys.D3)
            {
                button3.Enabled = false;
                button3.BackColor = Color.RoyalBlue;
            }
            if (e.KeyCode == Keys.D4)
            {
                button4.Enabled = false;
                button4.BackColor = Color.RoyalBlue;
            }
            if (e.KeyCode == Keys.D5)
            {
                button5.Enabled = false;
                button5.BackColor = Color.IndianRed;
            }
            if (e.KeyCode == Keys.D6)
            {
                button6.Enabled = false;
                button6.BackColor = Color.IndianRed;
            }
            if (e.KeyCode == Keys.D7)
            {
                button7.Enabled = false;
                button7.BackColor = Color.Peru;
            }
            if (e.KeyCode == Keys.D8)
            {
                button8.Enabled = false;
                button8.BackColor = Color.Peru;
            }
            if (e.KeyCode == Keys.D9)
            {
                button9.Enabled = false;
                button9.BackColor = Color.RoyalBlue;
            }
            if (e.KeyCode == Keys.D0)
            {
                button10.Enabled = false;
                button10.BackColor = Color.MediumSeaGreen;
            }
            if (e.KeyCode == Keys.Q)
            {
                button11.Enabled = false;
                button11.BackColor = Color.MediumSeaGreen;
            }
            if (e.KeyCode == Keys.W)
            {
                button15.Enabled = false;
                button15.BackColor = Color.RoyalBlue;
            }
            if (e.KeyCode == Keys.E)
            {
                button16.Enabled = false;
                button16.BackColor = Color.IndianRed;
            }
            if (e.KeyCode == Keys.R)
            {
                button17.Enabled = false;
                button17.BackColor = Color.IndianRed;
            }
            if (e.KeyCode == Keys.T)
            {
                button18.Enabled = false;
                button18.BackColor = Color.IndianRed;
            }
            if (e.KeyCode == Keys.Y)
            {
                button19.Enabled = false;
                button19.BackColor = Color.Peru;
            }
            if (e.KeyCode == Keys.U)
            {
                button20.Enabled = false;
                button20.BackColor = Color.Peru;
            }
            if (e.KeyCode == Keys.I)
            {
                button21.Enabled = false;
                button21.BackColor = Color.RoyalBlue;
            }
            if (e.KeyCode == Keys.O)
            {
                button22.Enabled = false;
                button22.BackColor = Color.MediumSeaGreen;
            }
            if (e.KeyCode == Keys.P)
            {
                button23.Enabled = false;
                button23.BackColor = Color.MediumSeaGreen;
            }
            if (e.KeyCode == Keys.A)
            {
                button24.Enabled = false;
                button24.BackColor = Color.MediumSeaGreen;
            }
            if (e.KeyCode == Keys.S)
            {
                button25.Enabled = false;
                button25.BackColor = Color.RoyalBlue;
            }
            if (e.KeyCode == Keys.D)
            {
                button26.Enabled = false;
                button26.BackColor = Color.IndianRed;
            }
            if (e.KeyCode == Keys.F)
            {
                button27.Enabled = false;
                button27.BackColor = Color.IndianRed;
            }
            if (e.KeyCode == Keys.G)
            {
                button28.Enabled = false;
                button28.BackColor = Color.IndianRed;
            }
            if (e.KeyCode == Keys.H)
            {
                button29.Enabled = false;
                button29.BackColor = Color.Peru;
            }
            if (e.KeyCode == Keys.J)
            {
                button30.Enabled = false;
                button30.BackColor = Color.Peru;
            }
            if (e.KeyCode == Keys.K)
            {
                button31.Enabled = false;
                button31.BackColor = Color.RoyalBlue;
            }
            if (e.KeyCode == Keys.L)
            {
                button32.Enabled = false;
                button32.BackColor = Color.MediumSeaGreen;
            }
            if (e.KeyCode == Keys.Z)
            {
                button33.Enabled = false;
                button33.BackColor = Color.MediumSeaGreen;
            }
            if (e.KeyCode == Keys.X)
            {
                button34.Enabled = false;
                button34.BackColor = Color.RoyalBlue;
            }
            if (e.KeyCode == Keys.C)
            {
                button35.Enabled = false;
                button35.BackColor = Color.IndianRed;
            }
            if (e.KeyCode == Keys.V)
            {
                button36.Enabled = false;
                button36.BackColor = Color.IndianRed;
            }
            if (e.KeyCode == Keys.B)
            {
                button37.Enabled = false;
                button37.BackColor = Color.Peru;
            }
            if (e.KeyCode == Keys.N)
            {
                button38.Enabled = false;
                button38.BackColor = Color.Peru;
            }
            if (e.KeyCode == Keys.M)
            {
                button39.Enabled = false;
                button39.BackColor = Color.Peru;
            }
            if (e.KeyCode == Keys.OemMinus)
            {
                button45.Enabled = false;
                button45.BackColor = Color.MediumSeaGreen;
            }
            if (e.KeyCode == Keys.Oemplus)
            {
                button46.Enabled = false;
                button46.BackColor = Color.MediumSeaGreen;
            }
            if (e.KeyCode == Keys.Back)
            {
                button47.Enabled = false;
                button47.BackColor = Color.MediumPurple;
            }
            if (e.KeyCode == Keys.Tab)
            {
                button12.Enabled = false;
                button12.BackColor = Color.MediumPurple;
            }
            if (e.KeyCode == Keys.CapsLock)
            {
                button13.Enabled = false;
                button13.BackColor = Color.MediumPurple;
            }
            if (e.KeyCode == Keys.LShiftKey)
            {
                button14.Enabled = false;
                button14.BackColor = Color.MediumPurple;
            }
            if (e.KeyCode == Keys.RShiftKey)
            {
                button42.Enabled = false;
                button42.BackColor = Color.MediumPurple;
            }
            if (e.KeyCode == Keys.OemPipe)
            {
                button44.Enabled = false;
                button44.BackColor = Color.MediumPurple;
            }
            if (e.KeyCode == Keys.Enter)
            {
                button43.Enabled = false;
                button43.BackColor = Color.MediumPurple;
            }
            if (e.KeyCode == Keys.Oemcomma)
            {
                button40.Enabled = false;
                button40.BackColor = Color.RoyalBlue;
            }
            if (e.KeyCode == Keys.OemPeriod)
            {
                button41.Enabled = false;
                button41.BackColor = Color.MediumSeaGreen;
            }
        }
    }
}