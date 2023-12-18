using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernDgitalClock
{
    public partial class DgitalClock : Form
    {
        public DgitalClock()
        {
            InitializeComponent();
            redButton.FlatStyle = FlatStyle.Flat;
            yellowButton.FlatStyle = FlatStyle.Flat;
            greenButton.FlatStyle = FlatStyle.Flat;
            dBlueButton.FlatStyle = FlatStyle.Flat;
            indigoButton.FlatStyle = FlatStyle.Flat;
            styleButton.FlatStyle = FlatStyle.Flat; 
            styleButton2.FlatStyle = FlatStyle.Flat; 
            styleButton3.FlatStyle = FlatStyle.Flat;  
        }

        private void ClockLabel_Click(object sender, EventArgs e)
        {

        }

        private void DgitalClock_Load(object sender, EventArgs e)
        {
           clcokTimer.Start();
        }

        private void clcokTimer_Tick(object sender, EventArgs e)
        {
            ClockLabel.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            ClockLabel.ForeColor = Color.Red;

        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            ClockLabel.ForeColor = Color.Green;
        }

        private void indigoButton_Click(object sender, EventArgs e)
        {
            ClockLabel.ForeColor = Color.Indigo;
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            ClockLabel.ForeColor = Color.Yellow;
        }

        private void dBlueButton_Click(object sender, EventArgs e)
        {
            ClockLabel.ForeColor = Color.DodgerBlue;
        }

        private void styleButton_Click(object sender, EventArgs e)
        {
            ClockLabel.Font = new Font("Impact",90, FontStyle.Regular);

        }

        private void styleButton2_Click(object sender, EventArgs e)
        {
            ClockLabel.Font = new Font("Cooper Black", 90, FontStyle.Regular);

        }

        private void styleButton3_Click(object sender, EventArgs e)
        {
            ClockLabel.Font = new Font("Rockwell", 90, FontStyle.Regular);

        }
    }
}
