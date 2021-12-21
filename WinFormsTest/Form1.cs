using System;
using System.Windows.Forms;
using DreieckPyramide;
using Kreis_Skizze;
using Kugel_Skizze;
using Pyramide;
using testintro;
using Viereck;

namespace WinFormsTest
{
    public partial class Form1 : Form
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
        public IntroForm introform;
        public Form1(IntroForm introform)
        {
            InitializeComponent();
            this.introform = introform;
        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int comboBox1Index = comboBox1.SelectedIndex;
            Object selectItem = comboBox1.SelectedItem;


            if (comboBox1Index == 0)
            {
                label2.Visible = true;
                label3.Visible = false;
                textBox1.Visible = true;
                textBox2.Visible = false;

                label2.Text = "Radius";
                label3.Text = "";
                button1.Enabled = true;
                button1.Visible = true;

                button2.Visible = false;
                button3.Visible = false;
            }

            if (comboBox1Index == 1)
            {
                label2.Visible = true;
                label3.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;

                label2.Text = "Länge";
                label3.Text = "Breite";

                button2.Enabled = true;
                button2.Visible = true;

                button1.Visible = false;
                button3.Visible = false;
            }

            if (comboBox1Index == 2)
            {
                label2.Visible = true;
                label3.Visible = true;


                textBox1.Visible = true;
                textBox2.Visible = true;

                label2.Text = "Grundseite";
                label3.Text = "Höhe";
                label6.Text = "Höhe der Grundfläche";

                button3.Enabled = true;
                button3.Visible = true;

                button1.Visible = false;
                button2.Visible = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {


            while (gültigeeingabe == false)
            {
                try
                {
                    eingabe1 = textBox1.Text;
                    eingabe3 = Convert.ToDouble(eingabe1);
                    gültigeeingabe = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Ungültige Eingabe");
                    textBox1.Text = "";
                    return;
                }
            }

            flächekreis = eingabe3 * eingabe3 * Math.PI;
            umfangkreis = eingabe3 * 2 * Math.PI;
            volumenKugel = eingabe3 * eingabe3 * eingabe3 * Math.PI * 4 / 3;

            if (rechnungfläche == true)
            {
                FormKreis greeter = new FormKreis(this);
                greeter.flächekreis = flächekreis;
                greeter.Show(this);
                this.Hide();


                label4.Visible = true;
                label4.Text = "Fläche: " + flächekreis + "";
                gültigeeingabe = false;
            }
            if (rechnungumfang == true)
            {
                FormKreis greeter = new FormKreis(this);
                greeter.umfangkreis = umfangkreis;
                greeter.Show(this);
                this.Hide();

                label4.Visible = true;
                label4.Text = "Umfang: " + umfangkreis + "";
                gültigeeingabe = false;
            }
            if (rechnungVolumen == true)
            {
                FormKugel greeter = new FormKugel(this);
                greeter.volumenKugel = volumenKugel;
                greeter.Show(this);
                this.Hide();

                label4.Visible = true;
                label4.Text = "Volumen: " + volumenKugel + "";
                gültigeeingabe = false;
            }

            button1.Enabled = false;
            button1.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            while (gültigeeingabe == false)
            {
                try
                {
                    eingabe1 = textBox1.Text;
                    eingabe3 = Convert.ToDouble(eingabe1);

                    eingabe2 = textBox2.Text;
                    eingabe4 = Convert.ToDouble(eingabe2);

                    if (rechnungVolumen == true)
                    {
                        eingabe5 = textBox3.Text;
                        eingabe6 = Convert.ToDouble(eingabe5);
                    }

                    gültigeeingabe = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Ungültige Engabe");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    return;
                }
            }

            flächeviereck = eingabe3 * eingabe4;
            umfangviereck = 2 * (eingabe3 + eingabe4);
            volumenViereck = eingabe3 * eingabe4 * eingabe6;

            if (rechnungfläche == true)
            {
                FormViereck greeter = new FormViereck(this);
                greeter.flächeviereck = flächeviereck;
                greeter.Show(this);
                this.Hide();

                label4.Visible = true;
                label4.Text = "Fläche: " + flächeviereck + "";
                gültigeeingabe = false;
            }
            if (rechnungumfang == true)
            {
                FormViereck greeter = new FormViereck(this);
                greeter.flächeviereck = flächeviereck;
                greeter.Show(this);
                this.Hide();

                label4.Visible = true;
                label4.Text = "Umfang: " + umfangviereck + "";
                gültigeeingabe = false;
            }
            if (rechnungVolumen == true)
            {

                label4.Visible = true;
                label4.Text = "Volumen: " + volumenViereck + "";
                gültigeeingabe = false;
            }

            button2.Enabled = false;
            button2.Visible = false;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {



            while (gültigeeingabe == false)
            {
                try
                {
                    eingabe1 = textBox1.Text;
                    eingabe3 = Convert.ToDouble(eingabe1);

                    eingabe2 = textBox2.Text;
                    eingabe4 = Convert.ToDouble(eingabe2);

                    if (rechnungVolumen == true)
                    {
                        eingabe5 = textBox3.Text;
                        eingabe6 = Convert.ToDouble(eingabe5);
                    }

                    gültigeeingabe = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Ungültige Eingabe");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    return;
                }
            }

            flächedreieck = eingabe3 * eingabe4 / 2;
            hälfteVonGrundseite = eingabe3 / 2;
            umfangdreieck = eingabe3 + 2 * Math.Sqrt(hälfteVonGrundseite * hälfteVonGrundseite + eingabe4 * eingabe4);
            volumenDreieck = (eingabe3 * eingabe4 / 2) * eingabe6 / 3;

            if (rechnungfläche == true)
            {
                FormDreieck greeter = new FormDreieck(this);
                greeter.Flächedreieck = flächedreieck;
                greeter.Show(this);
                this.Hide();

                label4.Visible = true;
                label4.Text = "Fläche: " + flächedreieck + "";
                gültigeeingabe = false;
            }
            if (rechnungumfang == true)
            {
                FormDreieck greeter = new FormDreieck(this);
                greeter.Flächedreieck = flächedreieck;
                greeter.Show(this);
                this.Hide();

                label4.Visible = true;
                label4.Text = "Fläche: " + umfangdreieck + "";
                gültigeeingabe = false;
            }
            if (rechnungVolumen == true)
            {
                FormPyramide greeter = new FormPyramide(this);
                greeter.volumenDreieck = volumenDreieck;
                greeter.Show(this);
                this.Hide();

                label4.Visible = true;
                label4.Text = "Volumen: " + volumenDreieck + "";
                gültigeeingabe = false;
            }

            button3.Enabled = false;
            button3.Visible = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int comboBox2Index = comboBox2.SelectedIndex;
            Object selectItem = comboBox2.SelectedItem;


            if (comboBox2Index == 0)
            {
                rechnungfläche = true;
                rechnungumfang = false;
                rechnungVolumen = false;
                label6.Visible = false;
                textBox3.Visible = false;
            }
            if (comboBox2Index == 1)
            {
                rechnungfläche = false;
                rechnungumfang = true;
                rechnungVolumen = false;
                label6.Visible = false;
                textBox3.Visible = false;
            }
            if (comboBox2Index == 2)
            {
                rechnungfläche = false;
                rechnungumfang = false;
                rechnungVolumen = true;
                label6.Visible = true;
                textBox3.Visible = true;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        public void show()
        {
            this.show();
        }
    }
}
