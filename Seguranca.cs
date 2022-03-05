using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CST___CarteiraSenhasTemporais
{
    public class Seguranca
    {
        private static byte[] HexToBytes(string strhex)
        {
            if (strhex.Length % 2 == 1)
            {
                return new byte[] { };
            }

            byte[] arr = new byte[strhex.Length / 2];

            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = (byte)((GetHexVal(strhex[i * 2]) << 4) |
                                (GetHexVal(strhex[i * 2 + 1])));
            }

            return arr;
        }

        private static int GetHexVal(char hex)
        {
            if (hex < 'A')
            {
                return (byte)(hex - '0');
            }
            else if (hex < 'a')
            {
                return (byte)(hex - 'A') + 10;
            }
            else
            {
                return (byte)(hex - 'a') + 10;
            }
        }

        private static byte[] GenerateIV(int size)
        {
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] iv = new byte[size];
                rng.GetBytes(iv);
                return iv;
            }
        }

        private static string fnEncrypt(string chave, string texto)
        {
            byte[] iv = GenerateIV(16);
            using (var ms = new MemoryStream())
            {
                ms.Write(iv, 0, iv.Length);
                using (var aes = Aes.Create())
                {
                    aes.Mode = CipherMode.ECB;
                    aes.Padding = PaddingMode.Zeros;
                    using (var encryptor = aes.CreateEncryptor(HexToBytes(chave), iv))
                    {
                        using (var aesStream = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                        {
                            using (StreamWriter swEncrypt = new StreamWriter(aesStream))
                            {
                                swEncrypt.Write(texto);
                            }
                        }
                    }
                }
                return Convert.ToBase64String(ms.ToArray());
            }
        }

        private static string fnDecrypt(string chave, string texto)
        {
            byte[] bloco = Convert.FromBase64String(texto);
            byte[] iv = bloco[..16];
            bloco = bloco[16..];
            using (var aes = Aes.Create())
            {
                aes.Mode = CipherMode.ECB;
                aes.Padding = PaddingMode.Zeros;
                using (var decryptor = aes.CreateDecryptor(HexToBytes(chave), iv))
                {
                    using (var ms = new MemoryStream(bloco))
                    using (var aesStream = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    using (var plainStream = new MemoryStream())
                    {
                        aesStream.CopyTo(plainStream);
                        plainStream.Position = 0;
                        return Encoding.UTF8.GetString(plainStream.ToArray()).Trim('\0');
                    }
                }
            }
        }

        public static string sha256(string input, bool isLowercase = false)
        {
            byte[] bytes = Encoding.UTF8.GetBytes((string)input);

            using (var alg = HashAlgorithm.Create("SHA256"))
            {
                if (alg == null)
                    return input;
                var byteHash = alg.ComputeHash(bytes);
                var hash = BitConverter.ToString(byteHash).Replace("-", "");
                return (isLowercase) ? hash.ToLower() : hash;
            }
        }

        public static string Encriptar(string senha, string texto)
        {
            string chave = sha256(senha);
            return fnEncrypt(chave, texto);
        }

        public static string Decriptar(string senha, string texto)
        {
            string chave = sha256(senha);
            return fnDecrypt(chave, texto);
        }
    }
}
