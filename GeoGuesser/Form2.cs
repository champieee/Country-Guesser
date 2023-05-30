using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoGuesser
{
    public partial class Form2 : Form
    {
        private Form firstForm;
        public static String diff = "Easy"; 

        public Form2()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (firstForm == null)
                firstForm = new Form1();

            Hide();
            firstForm.Show();
        }

        private void hardDiff_Click(object sender, EventArgs e)
        {
            diff = "Hard"; 
            diffLabel.Text = diff;
        }

        private void medDiff_Click(object sender, EventArgs e)
        {
            diff = "Med";
            diffLabel.Text = diff;
        }

        private void easyDiff_Click(object sender, EventArgs e)
        {
            diff = "Easy";
            diffLabel.Text = diff;
        }
    }
}
