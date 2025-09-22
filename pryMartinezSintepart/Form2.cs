using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMartinezSintepart
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmBienvenida frmBienvenida = new FrmBienvenida();
            frmBienvenida.ShowDialog();


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            lstModulo.SelectedIndex = -1;



        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
                txtContraseña.Enabled = false;
            else
                txtContraseña.Enabled = true;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            cmdAceptar.Enabled = false;
            txtUsuario.TextChanged += ValidarCampos;
            txtContraseña.TextChanged += ValidarCampos;
            lstModulo.TextChanged += ValidarCampos;



        }

        private void ValidarCampos(object? sender, EventArgs e)
        {
           if(!string.IsNullOrWhiteSpace(txtUsuario.Text)&&
                ! string.IsNullOrWhiteSpace(txtContraseña.Text)&&
                ! string.IsNullOrWhiteSpace(lstModulo.Text))
            {
                cmdAceptar.Enabled = true;
            }
            else
            {
                cmdAceptar.Enabled= false;  
            }
        }
    }
}
