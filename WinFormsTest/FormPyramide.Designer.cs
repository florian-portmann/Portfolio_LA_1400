
namespace Pyramide
{
    partial class FormPyramide
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPyramide));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Höhe = new System.Windows.Forms.Label();
            this.Grundfläche = new System.Windows.Forms.Label();
            this.Volumen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(352, 63);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(589, 342);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Höhe
            // 
            this.Höhe.AutoSize = true;
            this.Höhe.Location = new System.Drawing.Point(561, 197);
            this.Höhe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Höhe.Name = "Höhe";
            this.Höhe.Size = new System.Drawing.Size(55, 25);
            this.Höhe.TabIndex = 1;
            this.Höhe.Text = "Höhe";
            // 
            // Grundfläche
            // 
            this.Grundfläche.AutoSize = true;
            this.Grundfläche.Location = new System.Drawing.Point(451, 335);
            this.Grundfläche.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Grundfläche.Name = "Grundfläche";
            this.Grundfläche.Size = new System.Drawing.Size(107, 25);
            this.Grundfläche.TabIndex = 2;
            this.Grundfläche.Text = "Grundfläche";
            // 
            // Volumen
            // 
            this.Volumen.AutoSize = true;
            this.Volumen.Location = new System.Drawing.Point(534, 380);
            this.Volumen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Volumen.Name = "Volumen";
            this.Volumen.Size = new System.Drawing.Size(82, 25);
            this.Volumen.TabIndex = 3;
            this.Volumen.Text = "Volumen";
            // 
            // FormPyramide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 462);
            this.Controls.Add(this.Volumen);
            this.Controls.Add(this.Grundfläche);
            this.Controls.Add(this.Höhe);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPyramide";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPyramide_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Höhe;
        private System.Windows.Forms.Label Grundfläche;
        private System.Windows.Forms.Label Volumen;
    }
}

