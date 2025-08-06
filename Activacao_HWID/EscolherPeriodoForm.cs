using Hospital97.Activacao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital97.Activacao_HWID
{
    public partial class EscolherPeriodoForm : Form
    {
        public EscolherPeriodoForm()
        {
            InitializeComponent();
        }

        private void EscolherPeriodoForm_Load(object sender, EventArgs e)
        {
            // Popular ComboBox
            cmbPeriodo.Items.AddRange(new string[] { "1 minuto", "5 minutos", "1 dia", "15 dias", "30 dias", "90 dias", "180 dias", "1 ano" });
            cmbPeriodo.SelectedIndex = 0;

            // Mostrar HWID
            //lblHWID.Text = "Identificador do dispositivo: " + HardwareUtils.GetHardwareID();
        }

        private void btnGerarChaveFinal_Click_1(object sender, EventArgs e)
        {
            string hwid = HardwareUtils.GetHardwareID();
            string periodo = cmbPeriodo.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(periodo))
            {
                MessageBox.Show("Selecione um período.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string chaveFinal = LicencaManager.GerarChave(hwid, periodo);
            txtChaveGerada.Text = chaveFinal;
        }

        private void btnCopiarChave_Click_1(object sender, EventArgs e)
        {
            try
{
                // Usa diretamente o método correto STA-safe
                
                Clipboard.SetText(txtChaveGerada.Text);
                MessageBox.Show("Chave copiada para a área de transferência.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
             {
                MessageBox.Show($"Erro ao copiar: {ex.Message}", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            ActivacaoForm activacao = new ActivacaoForm();
            activacao.Show();
        }
    }
}

