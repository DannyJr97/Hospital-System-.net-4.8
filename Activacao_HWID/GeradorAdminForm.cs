using Hospital97.Activacao;
using Hospital97.Activacao_HWID;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital97
{
    public partial class GeradorAdminForm : Form
    {
        public GeradorAdminForm()
        {
            InitializeComponent();
        }

        private void GeradorAdminForm_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string senhaDigitada = txtSenhaAdmin.Text.Trim();
            bool valida = LicencaManager.SenhaAdminValida(senhaDigitada);

            if (valida)
            {
                MessageBox.Show("✔️ Senha correcta. Acesso permitido.");
                this.Close();
                EscolherPeriodoForm Gerar = new EscolherPeriodoForm();
                Gerar.Show();
            }
            else
            {
                MessageBox.Show("❌ Senha inválida. Tente novamente.");
            }
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
                RecuperacaoForm recuperar = new RecuperacaoForm();
                recuperar.Show();

        }

        private void txtSenhaAdmin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnConfirmar.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
