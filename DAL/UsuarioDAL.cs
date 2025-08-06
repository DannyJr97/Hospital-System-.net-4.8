using Hospital97.Conexao;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital97.DAL
{
    internal class UsuarioDAL
    {
        public static bool ValidarLogin(string usuario, string senha)
        {
            using (var conexao = ConexaoBD.ObterConexao())
            {
                string query = "SELECT COUNT(*) FROM usuarios WHERE nome=@usuario AND senha=@senha";
                using (var cmd = new MySqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@senha", senha);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }
    }
}
