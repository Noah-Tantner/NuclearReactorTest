using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace NuclearReactorTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NuclearTitle_Click(object sender, EventArgs e)
        {

        }

        private void Reactor1Label_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            
            
                reactor1StateLabel.BackColor = Color.Red;
                reactor2StateLabel.BackColor = Color.Red;
            
            outputLabel.Text = "Meltdown Happening!!!!!";
            Refresh();
            Thread.Sleep(1000);
                reactor1StateLabel.BackColor = Color.White;
                reactor2StateLabel.BackColor = Color.White;

            Refresh();
            Thread.Sleep(1000);
        }

        private void reactor2StateLabel_Click(object sender, EventArgs e)
        {

        }

        private bool timer(int time)
        { int timeZero = 0;
            if (timeZero != time)
            {
                timeZero++;
                return false;
            }
            else 
            {
                timeZero = 0;
                return true;
                 
            }
        }
    }
}
