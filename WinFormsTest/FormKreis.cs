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
namespace Kreis_Skizze
{
    public partial class FormKreis : Form
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
        public FormKreis(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            this.flächekreis = form1.flächekreis;
            this.umfangkreis = form1.umfangkreis;
            this.eingabe3 = form1.eingabe3;
            this.eingabe4 = form1.eingabe4;
            this.eingabe6 = form1.eingabe6;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Fläche=" + flächekreis + "";
            label2.Text = "u= " + umfangkreis + "";
            label3.Text = "r= " + eingabe3 + "";
            label4.Text = "d= " + 2 * eingabe3 + "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Show();
        }
        public void show()
        {
            this.show();
        }
    }
}
