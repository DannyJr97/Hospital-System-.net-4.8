using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using DotNetEnv;

namespace Hospital97.Conexao
{
    internal class ConexaoBD
    {

        private static string _connectionString;

        //Os dados do admin devem ser inseridos no .env, isso na raiz do projecto
        static ConexaoBD()
        {
            Env.Load();
            _connectionString = $"Server={Env.GetString("DB_HOST")};" +
                                $"Database={Env.GetString("DB_NAME")};" +
                                $"User={Env.GetString("DB_USER")};" +
                                $"Password={Env.GetString("DB_PASSWORD")};";
        }

        public static MySqlConnection ObterConexao()
        {
            var conexao = new MySqlConnection(_connectionString);
            conexao.Open();
            return conexao;
        }
    
    }
}
