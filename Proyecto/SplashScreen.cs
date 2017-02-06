using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class SplashScreen : Form
    {
        int timeLeft;
        public SplashScreen()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
            }
            else
            {
                timer1.Stop();
                new Login().Show();
                this.Hide();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timeLeft = 20;
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
