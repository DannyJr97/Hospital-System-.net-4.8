using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital97.DAL;
using Hospital97.Modelos;

namespace Hospital97.UI
{
    public partial class PacientesForm : Form
    {
        private string fotoBase64Atual = "";
        public PacientesForm()
        {
            InitializeComponent();
        }

        private void PacientesForm_Load(object sender, EventArgs e)
        {

        }

        private Paciente GetPacienteDoForm()
        {
            return new Paciente
            {
                PrimeiroNome = txtPrimeiroNome.Text.Trim(),
                NomeMeio = txtNomeMeio.Text.Trim(),
                Apelido = txtApelido.Text.Trim(),
                DataNascimento = DatePickBirth.Value.Date,
                Sexo = cboSexo.SelectedItem?.ToString(),
                Religiao = cboReligiao.SelectedItem?.ToString(),
                Telefone = txtTelefone.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Morada = TxtMorada.Text.Trim(),
                DocumentoIdentidade = txtBilheteIdentidade.Text.Trim(),
                Alergias = txtAlergias.Text.Trim(),
                DoencaCronica = txtDoencasCronicas.Text.Trim(),
                NomeParente = txtNomeParente.Text.Trim(),
                TelefoneParente = txtTelefoneParente.Text.Trim(),
                EmailParente = txtEmailParente.Text.Trim(),
                FotoBase64 = fotoBase64Atual // variável que você pode definir ao carregar a imagem
            };
        }

        private void PreencherFormComPaciente(Paciente p)
        {
            txtPrimeiroNome.Text = p.PrimeiroNome;
            txtNomeMeio.Text = p.NomeMeio;
            txtApelido.Text = p.Apelido;
            DatePickBirth.Value = p.DataNascimento;
            cboSexo.SelectedItem = p.Sexo;
            cboReligiao.SelectedItem = p.Religiao;
            txtTelefone.Text = p.Telefone;
            txtEmail.Text = p.Email;
            TxtMorada.Text = p.Morada;
            txtBilheteIdentidade.Text = p.DocumentoIdentidade;
            txtAlergias.Text = p.Alergias;
            txtDoencasCronicas.Text = p.DoencaCronica;
            txtNomeParente.Text = p.NomeParente;
            txtTelefoneParente.Text = p.TelefoneParente;
            txtEmailParente.Text = p.EmailParente;

            if (!string.IsNullOrEmpty(p.FotoBase64))
            {
                var bytes = Convert.FromBase64String(p.FotoBase64);
                using (var ms = new MemoryStream(bytes))
                {
                    pictureBoxFoto.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pictureBoxFoto.Image = null;
            }
        }
        private void LimparCampos()
        {
            txtPrimeiroNome.Clear();
            txtNomeMeio.Clear();
            txtApelido.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            TxtMorada.Clear();
            txtBilheteIdentidade.Clear();
            txtAlergias.Clear();
            txtDoencasCronicas.Clear();
            txtNomeParente.Clear();
            txtTelefoneParente.Clear();
            txtEmailParente.Clear();
            cboSexo.SelectedIndex = -1;
            cboReligiao.SelectedIndex = -1;
            DatePickBirth.Value = DateTime.Today;
            pictureBoxFoto.Image = null;
            fotoBase64Atual = "";
        }



        private void btnSalvar_Click(object sender, EventArgs e)
        {

            var paciente = GetPacienteDoForm();
            PacienteDAL.Inserir(paciente); // ou Atualizar se estiver editando
            MessageBox.Show("Paciente salvo com sucesso!");
            LimparCampos();
            //RecarregarLista();
        }

        private void btnCarregarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Imagens (*.jpg;*.png)|*.jpg;*.png";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string caminho = dialog.FileName;
                pictureBoxFoto.Image = Image.FromFile(caminho);

                byte[] imagemBytes = File.ReadAllBytes(caminho);
                fotoBase64Atual = Convert.ToBase64String(imagemBytes);
            }
        }

        private void DatePickBirth_ValueChanged(object sender, EventArgs e)
        {
            AtualizarIdade();
        }
        private void AtualizarIdade()
        {
            DateTime nascimento = DatePickBirth.Value.Date;
            int idade = DateTime.Today.Year - nascimento.Year;
            if (nascimento > DateTime.Today.AddYears(-idade)) idade--;

            txtIdade.Text = idade.ToString();
        }


    }
}
