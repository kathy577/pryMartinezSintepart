namespace pryMartinezSintepart
{
    partial class frmLogin
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
            lblUsuario = new Label();
            lblContraseña = new Label();
            lblMódulo = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            lstModulo = new ComboBox();
            cmdAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(170, 97);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(170, 142);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(67, 15);
            lblContraseña.TabIndex = 1;
            lblContraseña.Text = "Contraseña";
            lblContraseña.Click += label2_Click;
            // 
            // lblMódulo
            // 
            lblMódulo.AutoSize = true;
            lblMódulo.Location = new Point(174, 195);
            lblMódulo.Name = "lblMódulo";
            lblMódulo.Size = new Size(49, 15);
            lblMódulo.TabIndex = 2;
            lblMódulo.Text = "Mòdulo";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = SystemColors.MenuHighlight;
            txtUsuario.Location = new Point(296, 89);
            txtUsuario.MaxLength = 10;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(141, 23);
            txtUsuario.TabIndex = 3;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // txtContraseña
            // 
            txtContraseña.Enabled = false;
            txtContraseña.Location = new Point(296, 134);
            txtContraseña.MaxLength = 10;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(141, 23);
            txtContraseña.TabIndex = 4;
            txtContraseña.TextChanged += textBox2_TextChanged;
            // 
            // lstModulo
            // 
            lstModulo.DropDownStyle = ComboBoxStyle.DropDownList;
            lstModulo.FormattingEnabled = true;
            lstModulo.Items.AddRange(new object[] { "ADM", "SIST", "COM", "VTA" });
            lstModulo.Location = new Point(296, 187);
            lstModulo.Name = "lstModulo";
            lstModulo.Size = new Size(141, 23);
            lstModulo.TabIndex = 6;
            // 
            // cmdAceptar
            // 
            cmdAceptar.Enabled = false;
            cmdAceptar.Location = new Point(507, 93);
            cmdAceptar.Name = "cmdAceptar";
            cmdAceptar.Size = new Size(75, 23);
            cmdAceptar.TabIndex = 7;
            cmdAceptar.Text = "Aceptar";
            cmdAceptar.UseVisualStyleBackColor = true;
            cmdAceptar.Click += button1_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(509, 156);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 370);
            Controls.Add(btnCancelar);
            Controls.Add(cmdAceptar);
            Controls.Add(lstModulo);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(lblMódulo);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Name = "frmLogin";
            Text = "Login";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label lblContraseña;
        private Label lblMódulo;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private ComboBox lstModulo;
        private Button cmdAceptar;
        private Button btnCancelar;
    }
}