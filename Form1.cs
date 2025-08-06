using Hospital97.Conexao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital97
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (var conexao = ConexaoBD.ObterConexao())
                {
                    MessageBox.Show("✅ Conexão bem-sucedida com o MySQL!", "Sucesso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Erro na conexão:\n" + ex.Message, "Erro");
            }
        }
    }
}
