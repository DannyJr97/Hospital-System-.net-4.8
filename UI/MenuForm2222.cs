using System;
using System.Windows.Forms;

namespace Hospital97.UI
{
    public partial class MenuForm2222 : Form
    {
        // Flags de expansão por menu
        bool menuAtendimentoExpand = false;
        bool menuClinicaExpand = false;
        bool menuPacMedExpand = false;
        bool menuFarmExpand = false;
        bool menuFinancasExpand = false;
        bool menuDefinicoesExpand = false;
        bool menuMobilidadeExpand = false;
        bool sidebarExpand = true;

        public MenuForm2222()
        {
            InitializeComponent();
        }

        private void MenuForm2222_Load(object sender, EventArgs e)
        {
            // Padronização dos intervalos de todos os timers
            MenuTransitionClinica.Interval = 10;
            MenuTransitionPacientesDoutores.Interval = 10;
            MenuTransitionFarmaciaMedicamentos.Interval = 10;
            MenuTransitionFinancas.Interval = 10;
            MenuTransitionDefinicoes.Interval = 10;
            MenuOperacoesMobilidade.Interval = 10;
            sidebarTransition.Interval = 10;
        }

        // Método genérico para animar qualquer menu
        private void AnimarMenu(Panel container, Timer timer, ref bool expandFlag, int alturaFechada = 83, int alturaAberta = 225, int passo = 50)
        {
            if (!timer.Enabled)
                timer.Start();

            if (expandFlag)
            {
                container.Height -= passo;
                if (container.Height <= alturaFechada)
                {
                    container.Height = alturaFechada;
                    timer.Stop();
                    expandFlag = false;
                }
            }
            else
            {
                container.Height += passo;
                if (container.Height >= alturaAberta)
                {
                    container.Height = alturaAberta;
                    timer.Stop();
                    expandFlag = true;
                }
            }
        }

        // Click handlers
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void btnFecharMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtendimento_Click(object sender, EventArgs e)
        {
            AnimarMenu(menuContainer0, MenuTransitionAtendimento, ref menuAtendimentoExpand);
        }

        private void btnClinica_Click(object sender, EventArgs e)
        {
            AnimarMenu(menuContainer1, MenuTransitionClinica, ref menuClinicaExpand);           
        }

        private void btnPacientesDoutores_Click(object sender, EventArgs e)
        {
            AnimarMenu(menuContainer2, MenuTransitionPacientesDoutores, ref menuPacMedExpand);
        }

    private void btnPacientesDoutores_Click_2(object sender, EventArgs e)
        {
        }

        private void btnFarmaciaMedicamentos_Click(object sender, EventArgs e)
        {
            AnimarMenu(menuContainer3, MenuTransitionFarmaciaMedicamentos, ref menuFarmExpand);
        }

        private void btnFinancas_Click_1(object sender, EventArgs e)
        {
            AnimarMenu(menuContainer4, MenuTransitionFinancas, ref menuFinancasExpand);
        }

        private void btnDefinicoes_Click_2(object sender, EventArgs e)
        {
            AnimarMenu(menuContainer8, MenuTransitionDefinicoes, ref menuDefinicoesExpand);
        }

        private void btnOperacoesMobilidade_Click(object sender, EventArgs e)
        {
            AnimarMenu(menuContainer5, MenuOperacoesMobilidade, ref menuMobilidadeExpand);
        }

        // Tick handlers dos menus expansíveis (100% padronizados)
        private void MenuTransitionClinica_Tick(object sender, EventArgs e)
        {
            AnimarMenu(menuContainer1, MenuTransitionClinica, ref menuClinicaExpand);

        }

        private void MenuTransitionPacientesDoutores_Tick(object sender, EventArgs e)
        {
            AnimarMenu(menuContainer2, MenuTransitionPacientesDoutores, ref menuPacMedExpand);

        }

        private void MenuTransitionFarmaciaMedicamentos_Tick(object sender, EventArgs e)
        {
            AnimarMenu(menuContainer3, MenuTransitionFarmaciaMedicamentos, ref menuFarmExpand);
        }

        private void MenuTransitionFinancas_Tick(object sender, EventArgs e)
        {
            AnimarMenu(menuContainer4, MenuTransitionFinancas, ref menuFinancasExpand);
        }

        private void MenuTransitionDefinicoes_Tick(object sender, EventArgs e)
        {
            AnimarMenu(menuContainer8, MenuTransitionDefinicoes, ref menuDefinicoesExpand);
        }

        private void MenuOperacoesMobilidade_Tick(object sender, EventArgs e)
        {
            AnimarMenu(menuContainer5, MenuOperacoesMobilidade, ref menuMobilidadeExpand);
        }

        // Tick handler do sidebar lateral
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 65)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 280)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void AbrirFormularioInterno(Form formulario)
        {
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            panelCentral.Controls.Clear();
            panelCentral.Controls.Add(formulario);
            formulario.Show();
        }


        private void button22_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm sair = new LoginForm();
            sair.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            AnimarMenu(menuContainer1, MenuTransitionClinica, ref menuClinicaExpand);
            AbrirFormularioInterno(new MenuForm());
        }

        private void btnpacientes_Click(object sender, EventArgs e)
        {
            AbrirFormularioInterno(new LoginForm());
        }

        private void btndoutores_Click(object sender, EventArgs e)
        {
            AbrirFormularioInterno(new ClinicaForm());
        }

        
    }
}

