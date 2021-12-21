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
namespace Viereck
{
    public partial class FormViereck : Form
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
        public FormViereck(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            this.umfangviereck = form1.umfangviereck;
            this.flächeviereck = form1.flächeviereck;
            this.eingabe3 = form1.eingabe3;
            this.eingabe4 = form1.eingabe4;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label6.Text = ""+eingabe3+"";
            label5.Text = "" + eingabe4;
            label9.Text = "" + umfangviereck;
            label7.Text = "" + flächeviereck;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormViereck_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.show();
        }
        public void show()
        {
            this.show();
        }
    }
}
