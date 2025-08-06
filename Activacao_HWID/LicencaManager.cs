using System;
using System.Security.Cryptography;
using System.Text;
using System.IO;
using System.Globalization;
using DotNetEnv;

namespace Hospital97.Activacao
{
    internal static class LicencaManager
    {
        private static readonly string chaveSecreta = "ChaveInternaDoSistema97"; // Protege a assinatura

        public static bool LicencaValida()
        {
            string caminhoLic = @"licenca.lic";

            if (!File.Exists(caminhoLic)) return false;

            string conteudo = File.ReadAllText(caminhoLic).Trim();
            return ValidarChave(conteudo);
        }

        public static string GerarChave(string hwid, string tipoPeriodo)
        {
            DateTime agora = DateTime.Now;
            DateTime expiracao;

            switch (tipoPeriodo)
            {
                case "1 minuto": expiracao = agora.AddMinutes(1); break;
                case "5 minutos": expiracao = agora.AddMinutes(5); break;
                case "1 dia": expiracao = agora.AddDays(1); break;
                case "15 dias": expiracao = agora.AddDays(15); break;
                case "30 dias": expiracao = agora.AddDays(30); break;
                case "90 dias": expiracao = agora.AddDays(90); break;
                case "180 dias": expiracao = agora.AddDays(180); break;
                case "1 ano": expiracao = agora.AddYears(1); break;
                default: expiracao = agora.AddDays(30); break; // fallback
            }

            string chaveBase = $"H97|{hwid}|{tipoPeriodo}|{expiracao:yyyy-MM-dd HH:mm:ss}";
            string assinatura = GerarAssinatura(chaveBase);

            return $"{chaveBase}|{assinatura}";
        }

        public static bool ValidarChave(string chaveRecebida)
        {
            try
            {
                var partes = chaveRecebida.Split('|');
                if (partes.Length != 5 || partes[0] != "H97") return false;

                string hwidAtual = HardwareUtils.GetHardwareID();
                string hwidNaChave = partes[1];
                string expiracaoStr = partes[3];
                string assinatura = partes[4];

                if (hwidAtual != hwidNaChave) return false;

                string chaveBase = string.Join("|", partes[0], partes[1], partes[2], partes[3]);
                string assinaturaEsperada = GerarAssinatura(chaveBase);
                if (assinaturaEsperada != assinatura) return false;

                DateTime expiracao = DateTime.ParseExact(expiracaoStr, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                return expiracao >= DateTime.Now;
            }
            catch
            {
                return false;
            }
        }

        public static bool HorarioManipulado()
        {
            string caminhoControle = @"controle_hora.dat";

            try
            {
                DateTime agora = DateTime.Now;

                if (File.Exists(caminhoControle))
                {
                    string criptografado = File.ReadAllText(caminhoControle).Trim();
                    DateTime ultimoRegistro = DateTime.ParseExact(Descriptografar(criptografado), "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

                    if (agora < ultimoRegistro)
                        return true; // Hora foi retrocedida
                }

                string criptografar = Criptografar(agora.ToString("yyyy-MM-dd HH:mm:ss"));
                File.WriteAllText(caminhoControle, criptografar);
            }
            catch { return false; }

            return false;
        }

        private static string Criptografar(string texto)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(chaveSecreta.Substring(0, 16));
                aes.IV = Encoding.UTF8.GetBytes(chaveSecreta.Substring(0, 16));
                using (var encryptor = aes.CreateEncryptor())
                {
                    byte[] dados = Encoding.UTF8.GetBytes(texto);
                    byte[] cifrado = encryptor.TransformFinalBlock(dados, 0, dados.Length);
                    return Convert.ToBase64String(cifrado);
                }
            }
        }

        private static string Descriptografar(string cifrado)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(chaveSecreta.Substring(0, 16));
                aes.IV = Encoding.UTF8.GetBytes(chaveSecreta.Substring(0, 16));
                using (var decryptor = aes.CreateDecryptor())
                {
                    byte[] dados = Convert.FromBase64String(cifrado);
                    byte[] decifrado = decryptor.TransformFinalBlock(dados, 0, dados.Length);
                    return Encoding.UTF8.GetString(decifrado);
                }
            }
        }


        private static string GerarAssinatura(string texto)
        {
            using (var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(chaveSecreta)))
            {
                byte[] hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(texto));
                return BitConverter.ToString(hash).Replace("-", "").Substring(0, 16);
            }
        }

        public static int DiasRestantes()
        {
            string caminhoLic = @"licenca.lic";
            if (!File.Exists(caminhoLic)) return 0;

            string conteudo = File.ReadAllText(caminhoLic).Trim();
            var partes = conteudo.Split('|');

            if (partes.Length != 5 || partes[0] != "H97") return 0;

            DateTime expiracao;
            if (!DateTime.TryParseExact(partes[3], "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out expiracao))
                return 0;

            int dias = (expiracao - DateTime.Now).Days;
            return dias > 0 ? dias : 0;
        }

        public static bool SenhaAdminValida(string senhaDigitada)
        {
            //Os dados do admin devem ser inseridos no .env, isso na raiz do projecto

            //Garante que as variaveis do .env sao carregadas
            Env.Load();

            //Le a senha/dados do env
            string senhaEsperada = Env.GetString("ADMIN_PASSWORD");

            return senhaDigitada.Trim() == senhaEsperada;
        }

        public static string GerarHashSHA256(string texto)
        {
            using (var sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(texto.Trim()));
                return BitConverter.ToString(bytes).Replace("-", "").ToUpper();
            }
        }
    }
}
