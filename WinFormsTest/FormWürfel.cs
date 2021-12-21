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
namespace Würfel
{
    public partial class FormWürfel : Form
    {
        public double flächekreis;
        public double umfangkreis;
        public double volumenKugel;
        public double flächeviereck;
        public double umfangviereck;
        public double volumenViereck;
        public double flächedreieck;
        public double umfangdreieck;
        public double hälfteVonGrundseite;
        public double volumenDreieck;
        public string eingabe1;
        public string eingabe2;
        public double eingabe3;
        public double eingabe4;
        public string eingabe5;
        public double eingabe6;

        public bool rechnungfläche;
        public bool rechnungumfang;
        public bool rechnungVolumen;

        public bool gültigeeingabe = false;
        public Form1 form1;
        public FormWürfel(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            this.eingabe6 = form1.eingabe6;
            this.eingabe3 = form1.eingabe3;
            this.eingabe4 = form1.eingabe4;
            this.volumenViereck = form1.volumenViereck;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label6.Text = "" + eingabe6;
            label7.Text = "" + eingabe3;
            label8.Text = "" + eingabe4;
            label9.Text = "" + volumenViereck;
        }

        private void FormWürfel_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Show();
        }
        public void show()
        {
            this.show();
        }
    }
}
