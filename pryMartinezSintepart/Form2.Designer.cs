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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
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
            lblUsuario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblUsuario.Location = new Point(22, 39);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(65, 21);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblContraseña.Location = new Point(22, 84);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(92, 21);
            lblContraseña.TabIndex = 1;
            lblContraseña.Text = "Contraseña";
            lblContraseña.Click += label2_Click;
            // 
            // lblMódulo
            // 
            lblMódulo.AutoSize = true;
            lblMódulo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblMódulo.Location = new Point(22, 137);
            lblMódulo.Name = "lblMódulo";
            lblMódulo.Size = new Size(68, 21);
            lblMódulo.TabIndex = 2;
            lblMódulo.Text = "Mòdulo";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = SystemColors.MenuHighlight;
            txtUsuario.Location = new Point(148, 31);
            txtUsuario.MaxLength = 10;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(141, 23);
            txtUsuario.TabIndex = 3;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // txtContraseña
            // 
            txtContraseña.Enabled = false;
            txtContraseña.Location = new Point(148, 84);
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
            lstModulo.Location = new Point(148, 137);
            lstModulo.Name = "lstModulo";
            lstModulo.Size = new Size(141, 23);
            lstModulo.TabIndex = 6;
            // 
            // cmdAceptar
            // 
            cmdAceptar.Enabled = false;
            cmdAceptar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdAceptar.Location = new Point(265, 197);
            cmdAceptar.Name = "cmdAceptar";
            cmdAceptar.Size = new Size(80, 32);
            cmdAceptar.TabIndex = 7;
            cmdAceptar.Text = "Aceptar";
            cmdAceptar.UseVisualStyleBackColor = true;
            cmdAceptar.Click += button1_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(165, 197);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(84, 32);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(354, 246);
            Controls.Add(btnCancelar);
            Controls.Add(cmdAceptar);
            Controls.Add(lstModulo);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(lblMódulo);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
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