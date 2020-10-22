using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_4
{
    public partial class timeConversionForm : Form
    {
        public timeConversionForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            enterTimeTextBox.Text = " ";
            timeCalculated.Text = " ";
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int time;
            int currentTime;
            int elapsedSec;
            int elapsedMin;
            int elapsedHour;
            int elapsedDay;

            if (int.TryParse(enterTimeTextBox.Text, out time)) {
                
                elapsedSec = time % 60;
                currentTime = time / 60;
                elapsedMin = currentTime % 60;
                currentTime = currentTime / 60;
                elapsedHour = currentTime % 24;
                currentTime = currentTime / 24;
                elapsedDay = currentTime % 24;

                timeCalculated.Text = elapsedDay.ToString() + " days, " + elapsedHour.ToString() + " hours, " + elapsedMin.ToString() 
                    + " minutes, " + elapsedSec.ToString() + " seconds";
            } else
            {
                MessageBox.Show("Not a valid input");
            }
        }
    }
}
