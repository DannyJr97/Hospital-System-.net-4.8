using System;
using System.Windows.Forms;
using System.IO;
using Hospital97.Activacao_HWID;
using Hospital97.UI;

namespace Hospital97.Activacao
{
    public partial class ActivacaoForm : Form
    {
        public ActivacaoForm()
        {
            InitializeComponent();
        }

        private void btnInserirChave_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnGerarChave_Click_2(object sender, EventArgs e)
        {
        }

        private void btnInserirChave2_Click(object sender, EventArgs e)
        {
            string chave = txtChaveInserida.Text.Trim();

            if (LicencaManager.ValidarChave(chave))
            {
                File.WriteAllText("licenca.lic", chave);
                MessageBox.Show("Sistema ativado com sucesso!", "Ativação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                LoginForm login = new LoginForm();
                login.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chave inválida ou incompatível com este dispositivo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGerarChave2_Click(object sender, EventArgs e)
        {
            GeradorAdminForm adminForm = new GeradorAdminForm();
            adminForm.Show();
            this.Hide(); // ou .Close() se for fluxo direto
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnColar_Click(object sender, EventArgs e)
        {
            txtChaveInserida.Text = Clipboard.GetText();
        }

        private void txtChaveInserida_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnInserirChave2.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
