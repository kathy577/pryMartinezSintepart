namespace pryMartinezSintepart
{
    partial class FrmBienvenida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBienvenida));
            lblBienvenida = new Label();
            imagen = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)imagen).BeginInit();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Bernard MT Condensed", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenida.ForeColor = Color.DarkRed;
            lblBienvenida.Location = new Point(49, 44);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(439, 44);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "Bienvenido a Sinterpart SRL";
            lblBienvenida.Click += label1_Click;
            // 
            // imagen
            // 
            imagen.Image = (Image)resources.GetObject("imagen.Image");
            imagen.Location = new Point(121, 120);
            imagen.Name = "imagen";
            imagen.Size = new Size(300, 170);
            imagen.TabIndex = 1;
            imagen.TabStop = false;
            // 
            // FrmBienvenida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(527, 324);
            Controls.Add(imagen);
            Controls.Add(lblBienvenida);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmBienvenida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bienvenida";
            Load += FrmBienvenida_Load;
            ((System.ComponentModel.ISupportInitialize)imagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenida;
        private PictureBox imagen;
    }
}
