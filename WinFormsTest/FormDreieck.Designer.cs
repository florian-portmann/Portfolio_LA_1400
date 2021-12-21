
namespace DreieckPyramide
{
    partial class FormDreieck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDreieck));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flächedreieck = new System.Windows.Forms.Label();
            this.Höhedreieck = new System.Windows.Forms.Label();
            this.Hypotenuse = new System.Windows.Forms.Label();
            this.SeiteDreieck = new System.Windows.Forms.Label();
            this.SeiteDreieck2 = new System.Windows.Forms.Label();
            this.UmfangDreieck = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(186, 102);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(623, 354);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // flächedreieck
            // 
            this.flächedreieck.AutoSize = true;
            this.flächedreieck.Location = new System.Drawing.Point(219, 413);
            this.flächedreieck.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.flächedreieck.Name = "flächedreieck";
            this.flächedreieck.Size = new System.Drawing.Size(61, 25);
            this.flächedreieck.TabIndex = 1;
            this.flächedreieck.Text = "Fläche";
            this.flächedreieck.Click += new System.EventHandler(this.label1_Click);
            // 
            // Höhedreieck
            // 
            this.Höhedreieck.AutoSize = true;
            this.Höhedreieck.Location = new System.Drawing.Point(491, 255);
            this.Höhedreieck.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Höhedreieck.Name = "Höhedreieck";
            this.Höhedreieck.Size = new System.Drawing.Size(111, 25);
            this.Höhedreieck.TabIndex = 2;
            this.Höhedreieck.Text = "Höhedreieck";
            this.Höhedreieck.Click += new System.EventHandler(this.label2_Click);
            // 
            // Hypotenuse
            // 
            this.Hypotenuse.AutoSize = true;
            this.Hypotenuse.Location = new System.Drawing.Point(450, 363);
            this.Hypotenuse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Hypotenuse.Name = "Hypotenuse";
            this.Hypotenuse.Size = new System.Drawing.Size(108, 25);
            this.Hypotenuse.TabIndex = 3;
            this.Hypotenuse.Text = "Hypotenuse";
            this.Hypotenuse.Click += new System.EventHandler(this.label3_Click);
            // 
            // SeiteDreieck
            // 
            this.SeiteDreieck.AutoSize = true;
            this.SeiteDreieck.Location = new System.Drawing.Point(219, 219);
            this.SeiteDreieck.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SeiteDreieck.Name = "SeiteDreieck";
            this.SeiteDreieck.Size = new System.Drawing.Size(108, 25);
            this.SeiteDreieck.TabIndex = 4;
            this.SeiteDreieck.Text = "SeiteDreieck";
            this.SeiteDreieck.Click += new System.EventHandler(this.label4_Click);
            // 
            // SeiteDreieck2
            // 
            this.SeiteDreieck2.AutoSize = true;
            this.SeiteDreieck2.Location = new System.Drawing.Point(666, 240);
            this.SeiteDreieck2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SeiteDreieck2.Name = "SeiteDreieck2";
            this.SeiteDreieck2.Size = new System.Drawing.Size(108, 25);
            this.SeiteDreieck2.TabIndex = 5;
            this.SeiteDreieck2.Text = "SeiteDreieck";
            // 
            // UmfangDreieck
            // 
            this.UmfangDreieck.AutoSize = true;
            this.UmfangDreieck.Location = new System.Drawing.Point(219, 378);
            this.UmfangDreieck.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UmfangDreieck.Name = "UmfangDreieck";
            this.UmfangDreieck.Size = new System.Drawing.Size(134, 25);
            this.UmfangDreieck.TabIndex = 6;
            this.UmfangDreieck.Text = "UmfangDreieck";
            // 
            // FormDreieck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 480);
            this.Controls.Add(this.UmfangDreieck);
            this.Controls.Add(this.SeiteDreieck2);
            this.Controls.Add(this.SeiteDreieck);
            this.Controls.Add(this.Hypotenuse);
            this.Controls.Add(this.Höhedreieck);
            this.Controls.Add(this.flächedreieck);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormDreieck";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDreieck_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label flächedreieck;
        private System.Windows.Forms.Label Höhedreieck;
        private System.Windows.Forms.Label Hypotenuse;
        private System.Windows.Forms.Label SeiteDreieck;
        private System.Windows.Forms.Label SeiteDreieck2;
        private System.Windows.Forms.Label UmfangDreieck;
    }
}

