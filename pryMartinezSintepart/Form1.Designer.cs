﻿namespace pryMartinezSintepart
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblBienvenida = new Label();
            imagen = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)imagen).BeginInit();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Bernard MT Condensed", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenida.ForeColor = Color.DarkRed;
            lblBienvenida.Location = new Point(206, 82);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(418, 41);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "Bienvenida a Sinterpart SRL";
            lblBienvenida.Click += label1_Click;
            // 
            // imagen
            // 
            imagen.Image = (Image)resources.GetObject("imagen.Image");
            imagen.Location = new Point(258, 155);
            imagen.Name = "imagen";
            imagen.Size = new Size(301, 160);
            imagen.TabIndex = 1;
            imagen.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(imagen);
            Controls.Add(lblBienvenida);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)imagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenida;
        private PictureBox imagen;
    }
}
