using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital97.DAL;

namespace Hospital97.UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            pictureBoxLogo.Size = new Size(150, 150);

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtUsuario;
        }

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {

            string usuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text;

            bool LoginValido = UsuarioDAL.ValidarLogin(usuario, senha);
            if (LoginValido)
            {
                this.Hide();
                MenuForm2222 main = new MenuForm2222();
                main.Show();
            }
            else
            {
                lblErro.Text = "❌ Usuário ou senha inválidos.";
                lblErro.Visible = true;
            }

        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Down){
            txtSenha.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) {
                btnEntrar.PerformClick();
                e.SuppressKeyPress=true;
            }
            
        }

        private void txtSenha_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) {
                txtUsuario.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkbox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkbox1.Checked == true)
            {
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar= true;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
