using Hospital97.Activacao;
using Hospital97.UI;
using System;
using System.Windows.Forms;

namespace Hospital97.Activacao_HWID
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
            Shown += SplashForm_Shown;
        }

        private void SplashForm_Shown(object sender, EventArgs e)
        {
            VerificarLicenca();
        }

        private void VerificarLicenca()
        {
            if (!LicencaManager.LicencaValida())
            {
                MessageBox.Show("Licença inválida ou expirada. Active o produto.", "Hospital97", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Hide();
                new ActivacaoForm().Show();
            }
            else
            {
                Hide();
                new LoginForm().Show(); // substitui conforme tua tela principal
            }

            if (LicencaManager.HorarioManipulado())
            {
                MessageBox.Show("⚠️ Manipulação de horário detectada. Licença bloqueada, altere o horário para o correcto.");
                Application.Exit();
            }

        }

        private void SplashForm_Load(object sender, EventArgs e)
        {

        }
    }
}
