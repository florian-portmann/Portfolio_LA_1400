using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WinFormsTest;
namespace testintro
{
    public partial class IntroForm : Form
    {
        int time1Left;
        public IntroForm()
        {
            InitializeComponent();
        }

        private void IntroForm_Load (object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();

            time1Left = 11;
            timer1.Tick += timer1_Tick;

            // start things
            pictureBox1.Enabled = true;
            pictureBox1.Visible = true;
            timer1.Start();
            
        }
        void timer1_Tick(object sender, EventArgs e)
        {
            time1Left--;

            if (time1Left <= 0)
            {
                timer1.Stop();
                pictureBox1.Visible = false;
                pictureBox1.Enabled = false;
                Form1 greeter = new Form1(this);
                greeter.Show(this);
                this.Hide();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
