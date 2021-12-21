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
namespace Kugel_Skizze
{
    public partial class FormKugel : Form
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
        public FormKugel(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            this.eingabe3 = form1.eingabe3;
            this.volumenKugel = form1.volumenKugel;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "V= " + volumenKugel + "";
            label2.Text = "r= " + eingabe3 + "";
            label3.Text = "d=" + 2 * eingabe3 + "";
        }

    }
}
