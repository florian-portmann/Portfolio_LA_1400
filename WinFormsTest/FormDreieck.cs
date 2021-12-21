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
namespace DreieckPyramide
{
    public partial class FormDreieck : Form
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
        
        public FormDreieck(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            this.eingabe3 = form1.eingabe3;
            this.eingabe4 = form1.eingabe4;
            this.Flächedreieck = form1.flächedreieck;
            this.umfangdreieck = form1.umfangdreieck;
            this.hälfteVonGrundseite = form1.hälfteVonGrundseite;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Hypotenuse.Text = "Hypotenuse: "+ eingabe3 + "";
            Höhedreieck.Text = "Höhe: " + eingabe4 + "";
            flächedreieck.Text = "Fläche: " + Flächedreieck + "";
            UmfangDreieck.Text = "Umfang: " + umfangdreieck + "";
            SeiteDreieck.Text = "Seite: " + Math.Sqrt(eingabe3 * eingabe3 + eingabe4 * eingabe4) +"";
            SeiteDreieck2.Text = "Seite: " + Math.Sqrt(hälfteVonGrundseite * hälfteVonGrundseite + eingabe4 * eingabe4) + "";
        }

        private void FormDreieck_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.show();
        }
        public void show()
        {
            this.show();
        }
    }
}
