
namespace cola3Ejemplo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnExtraer = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtn5 = new System.Windows.Forms.TextBox();
            this.txtn4 = new System.Windows.Forms.TextBox();
            this.txtn3 = new System.Windows.Forms.TextBox();
            this.txtn2 = new System.Windows.Forms.TextBox();
            this.txtn1 = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Elementos en cola";
            // 
            // btnExtraer
            // 
            this.btnExtraer.Location = new System.Drawing.Point(523, 82);
            this.btnExtraer.Name = "btnExtraer";
            this.btnExtraer.Size = new System.Drawing.Size(80, 26);
            this.btnExtraer.TabIndex = 5;
            this.btnExtraer.Text = "EXTRAER";
            this.btnExtraer.UseVisualStyleBackColor = true;
            this.btnExtraer.Click += new System.EventHandler(this.btnExtraer_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(415, 82);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(89, 26);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtn5
            // 
            this.txtn5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtn5.Location = new System.Drawing.Point(144, 227);
            this.txtn5.MaximumSize = new System.Drawing.Size(49, 49);
            this.txtn5.MinimumSize = new System.Drawing.Size(49, 49);
            this.txtn5.Name = "txtn5";
            this.txtn5.Size = new System.Drawing.Size(49, 49);
            this.txtn5.TabIndex = 19;
            // 
            // txtn4
            // 
            this.txtn4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtn4.Location = new System.Drawing.Point(194, 227);
            this.txtn4.MaximumSize = new System.Drawing.Size(49, 49);
            this.txtn4.MinimumSize = new System.Drawing.Size(49, 49);
            this.txtn4.Name = "txtn4";
            this.txtn4.Size = new System.Drawing.Size(49, 49);
            this.txtn4.TabIndex = 18;
            // 
            // txtn3
            // 
            this.txtn3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtn3.Location = new System.Drawing.Point(244, 227);
            this.txtn3.MaximumSize = new System.Drawing.Size(49, 49);
            this.txtn3.MinimumSize = new System.Drawing.Size(49, 49);
            this.txtn3.Name = "txtn3";
            this.txtn3.Size = new System.Drawing.Size(49, 49);
            this.txtn3.TabIndex = 17;
            // 
            // txtn2
            // 
            this.txtn2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtn2.Location = new System.Drawing.Point(294, 227);
            this.txtn2.MaximumSize = new System.Drawing.Size(49, 49);
            this.txtn2.MinimumSize = new System.Drawing.Size(49, 49);
            this.txtn2.Name = "txtn2";
            this.txtn2.Size = new System.Drawing.Size(49, 49);
            this.txtn2.TabIndex = 16;
            // 
            // txtn1
            // 
            this.txtn1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtn1.Location = new System.Drawing.Point(344, 227);
            this.txtn1.MaximumSize = new System.Drawing.Size(49, 49);
            this.txtn1.MinimumSize = new System.Drawing.Size(49, 49);
            this.txtn1.Name = "txtn1";
            this.txtn1.Size = new System.Drawing.Size(49, 49);
            this.txtn1.TabIndex = 15;
            // 
            // txttotal
            // 
            this.txttotal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txttotal.Location = new System.Drawing.Point(303, 59);
            this.txttotal.MaximumSize = new System.Drawing.Size(49, 49);
            this.txttotal.MinimumSize = new System.Drawing.Size(49, 49);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(49, 49);
            this.txttotal.TabIndex = 20;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-50, 150);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-50, 150);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(53, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(-50, 150);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(53, 45);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::cola3Ejemplo.Properties.Resources.perfil3;
            this.pictureBox5.Location = new System.Drawing.Point(-50, 150);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(53, 45);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 22;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-50, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtn5);
            this.Controls.Add(this.txtn4);
            this.Controls.Add(this.txtn3);
            this.Controls.Add(this.txtn2);
            this.Controls.Add(this.txtn1);
            this.Controls.Add(this.btnExtraer);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExtraer;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtn5;
        private System.Windows.Forms.TextBox txtn4;
        private System.Windows.Forms.TextBox txtn3;
        private System.Windows.Forms.TextBox txtn2;
        private System.Windows.Forms.TextBox txtn1;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

