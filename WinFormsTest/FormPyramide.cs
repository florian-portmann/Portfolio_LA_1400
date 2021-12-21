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
namespace Pyramide
{
    public partial class FormPyramide : Form
    {
        public double flächekreis;
        public double umfangkreis;
        public double volumenKugel;
        public double flächeviereck;
        public double umfangviereck;
        public double volumenViereck;
        public double Flächedreieck;
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
        public FormPyramide(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            this.Flächedreieck = form1.flächedreieck;
            this.eingabe6 = form1.eingabe6;
            this.volumenDreieck = form1.volumenDreieck;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Grundfläche.Text = "Fläche: " + Flächedreieck + "";
            Höhe.Text = "Höhe: " + eingabe6 + "";
            Volumen.Text = "Volumen: " + volumenDreieck + "";
        }
        

        private void FormPyramide_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.show();
        }
        public void show()
        {
            this.show();
        }
    }
}
