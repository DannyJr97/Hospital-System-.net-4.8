using Hospital97.Conexao;
using Hospital97.Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Hospital97.DAL
{
    internal class PacienteDAL
    {
        public static void Inserir(Paciente paciente)
        {
            using (var conexao = ConexaoBD.ObterConexao())
            {
                string query = @"INSERT INTO pacientes 
                (primeiro_nome, nome_meio, apelido, data_nascimento, sexo, religiao, telefone, email, morada, documento_identidade, alergias, doenca_cronica, nome_parente, telefone_parente, email_parente, foto_base64)
                VALUES 
                (@primeiro_nome, @nome_meio, @apelido, @data_nascimento, @sexo, @religiao, @telefone, @email, @morada, @documento_identidade, @alergias, @doenca_cronica, @nome_parente, @telefone_parente, @email_parente, @foto_base64)";

                using (var cmd = new MySqlCommand(query, conexao))
                {
                    PreencherParametros(cmd, paciente);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Atualizar(Paciente paciente)
        {
            using (var conexao = ConexaoBD.ObterConexao())
            {
                string query = @"UPDATE pacientes SET 
                    primeiro_nome=@primeiro_nome,
                    nome_meio=@nome_meio,
                    apelido=@apelido,
                    data_nascimento=@data_nascimento,
                    sexo=@sexo,
                    religiao=@religiao,
                    telefone=@telefone,
                    email=@email,
                    morada=@morada,
                    documento_identidade=@documento_identidade,
                    alergias=@alergias,
                    doenca_cronica=@doenca_cronica,
                    nome_parente=@nome_parente,
                    telefone_parente=@telefone_parente,
                    email_parente=@email_parente,
                    foto_base64=@foto_base64
                WHERE id=@id";

                using (var cmd = new MySqlCommand(query, conexao))
                {
                    PreencherParametros(cmd, paciente);
                    cmd.Parameters.AddWithValue("@id", paciente.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Excluir(int id)
        {
            using (var conexao = ConexaoBD.ObterConexao())
            {
                string query = "DELETE FROM pacientes WHERE id=@id";
                using (var cmd = new MySqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static Paciente BuscarPorId(int id)
        {
            using (var conexao = ConexaoBD.ObterConexao())
            {
                string query = "SELECT * FROM pacientes WHERE id=@id";
                using (var cmd = new MySqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                            return MapearPaciente(reader);
                        else
                            return null;
                    }
                }
            }
        }

        public static List<Paciente> ListarTodos()
        {
            var lista = new List<Paciente>();
            using (var conexao = ConexaoBD.ObterConexao())
            {
                string query = "SELECT * FROM pacientes ORDER BY primeiro_nome";
                using (var cmd = new MySqlCommand(query, conexao))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        lista.Add(MapearPaciente(reader));
                }
            }
            return lista;
        }

        // 🔧 Métodos auxiliares
        private static void PreencherParametros(MySqlCommand cmd, Paciente p)
        {
            cmd.Parameters.AddWithValue("@primeiro_nome", p.PrimeiroNome);
            cmd.Parameters.AddWithValue("@nome_meio", p.NomeMeio);
            cmd.Parameters.AddWithValue("@apelido", p.Apelido);
            cmd.Parameters.AddWithValue("@data_nascimento", p.DataNascimento);
            cmd.Parameters.AddWithValue("@sexo", p.Sexo);
            cmd.Parameters.AddWithValue("@religiao", p.Religiao);
            cmd.Parameters.AddWithValue("@telefone", p.Telefone);
            cmd.Parameters.AddWithValue("@email", p.Email);
            cmd.Parameters.AddWithValue("@morada", p.Morada);
            cmd.Parameters.AddWithValue("@documento_identidade", p.DocumentoIdentidade);
            cmd.Parameters.AddWithValue("@alergias", p.Alergias);
            cmd.Parameters.AddWithValue("@doenca_cronica", p.DoencaCronica);
            cmd.Parameters.AddWithValue("@nome_parente", p.NomeParente);
            cmd.Parameters.AddWithValue("@telefone_parente", p.TelefoneParente);
            cmd.Parameters.AddWithValue("@email_parente", p.EmailParente);
            cmd.Parameters.AddWithValue("@foto_base64", p.FotoBase64);
        }

        private static Paciente MapearPaciente(MySqlDataReader r)
        {
            return new Paciente
            {
                Id = Convert.ToInt32(r["id"]),
                PrimeiroNome = r["primeiro_nome"].ToString(),
                NomeMeio = r["nome_meio"].ToString(),
                Apelido = r["apelido"].ToString(),
                DataNascimento = Convert.ToDateTime(r["data_nascimento"]),
                Sexo = r["sexo"].ToString(),
                Religiao = r["religiao"].ToString(),
                Telefone = r["telefone"].ToString(),
                Email = r["email"].ToString(),
                Morada = r["morada"].ToString(),
                DocumentoIdentidade = r["documento_identidade"].ToString(),
                Alergias = r["alergias"].ToString(),
                DoencaCronica = r["doenca_cronica"].ToString(),
                NomeParente = r["nome_parente"].ToString(),
                TelefoneParente = r["telefone_parente"].ToString(),
                EmailParente = r["email_parente"].ToString(),
                FotoBase64 = r["foto_base64"].ToString()
            };
        }
    }
}
