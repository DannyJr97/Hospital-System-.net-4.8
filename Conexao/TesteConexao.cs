using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Hospital97.Conexao
{
    internal class TesteConexao
    {

        public static bool TestarConexao(out string mensagem)
        {
            try
            {
                using (var conexao = ConexaoBD.ObterConexao())
                {
                    mensagem = "✅ Conexão bem-sucedida!";
                    return true;
                }
            }
            catch (Exception ex)
            {
                mensagem = "❌ Erro na conexão:\n" + ex.Message;
                return false;
            }
        }

    }
}
