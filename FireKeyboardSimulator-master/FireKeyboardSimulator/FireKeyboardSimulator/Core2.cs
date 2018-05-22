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
    public partial class Core_2 : Form
    {
        
        public Core_2(string data)
        {
            InitializeComponent();
            this.data = data;
            label1.Text = data;
            
        }
        string data;
        void CoreMechanics(int ctrl)
        {

            switch (ctrl)
            {
                case (1):

                    break;
                case (2): break;
                case (3): break;
                case (4): break;
                case (5): break;
            }

        }
    }
}
