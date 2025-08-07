using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital97.Modelos
{
    internal class Paciente
    {
        public int Id { get; set; }

        public string PrimeiroNome { get; set; }
        public string NomeMeio { get; set; }
        public string Apelido { get; set; }

        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public string Religiao { get; set; }

        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Morada { get; set; }

        public string DocumentoIdentidade { get; set; }
        public string Alergias { get; set; }
        public string DoencaCronica { get; set; }

        public string NomeParente { get; set; }
        public string TelefoneParente { get; set; }
        public string EmailParente { get; set; }

        public string FotoBase64 { get; set; }
    }
}
