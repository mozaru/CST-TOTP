using System;
using System.Linq;
using System.Text;

namespace Criptografia
{
    public class TOTP
    {
        //https://www.paypal.com/donate/?hosted_button_id=SGFDKFJTTU3JS
        /*<form action = "https://www.paypal.com/donate" method="post" target="_top">
<input type = "hidden" name="hosted_button_id" value="SGFDKFJTTU3JS" />
<input type = "image" src="https://www.paypalobjects.com/pt_BR/BR/i/btn/btn_donateCC_LG.gif" border="0" name="submit" title="PayPal - The safer, easier way to pay online!" alt="Faça doações com o botão do PayPal" />
<img alt = "" border="0" src="https://www.paypal.com/pt_BR/i/scr/pixel.gif" width="1" height="1" />
</form>*/



        private static byte[] Base32Encode(string source)
        {
            string allowedCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ234567";
            var bits = source.ToUpper().ToCharArray().Select(c =>
                Convert.ToString(allowedCharacters.IndexOf(c), 2).PadLeft(5, '0')).Aggregate((a, b) => a + b);
            return Enumerable.Range(0, bits.Length / 8).Select(i => Convert.ToByte(bits.Substring(i * 8, 8), 2)).ToArray();
        }
        private static byte[] LongToByte(long tempo)
        {
            byte[] v = BitConverter.GetBytes(tempo);
            if (BitConverter.IsLittleEndian) Array.Reverse(v);
            return v;
        }
        private static string SteamEncoder(long Codigo)
        {
            string baseCaracteres = "23456789BCDFGHJKMNPQRTVWXY";
            string Result = "";
            for (int i = 0; i < 5; i++)
            {
                Result += baseCaracteres[(int)(Codigo % baseCaracteres.Length)];
                Codigo = Codigo / baseCaracteres.Length;
            }
            return Result;
        }
        private static string Encoder(int Digitos, long codigo)
        {
            string r = codigo.ToString();
            if (r.Length > Digitos)
                r = r.Substring(r.Length - Digitos);
            else
                while (r.Length < Digitos)
                    r = "0" + r;
            return r;
        }
        public static string GerarChaveAleatoriaBase32(string separador = " ")
        {
            Random r = new Random((int)DateTime.Now.Ticks);
            string allowedCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ234567";
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 16; i++)
            {
                if (i != 0 && i % 4 == 0)
                    sb.Append(separador);
                sb.Append(allowedCharacters[r.Next(allowedCharacters.Length)]);
            }
            return sb.ToString();
        }

        public string KeyHEX
        {
            get { return _KeyHEX; }
            set { _Key = Base32Encode(value.Trim().Replace(" ", "").ToUpper()); _KeyHEX = value; }
        }
        private byte[] _Key;
        private string _KeyHEX = "";

        public long T0 { get; set; } = 0;
        public long Interval { get; set; } = 30;
        public int Digits { get; set; } = 6;
        public bool Steam { get; set; } = false;

        public TOTP()
        {
            _KeyHEX = GerarChaveAleatoriaBase32();
            _Key = Base32Encode(_KeyHEX.Trim().Replace(" ", "").ToUpper());
        }

        public long ObterTempoCorrent()
        {
            long delta = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;

            return (delta - T0) / Interval;
        }

        public long TempoRestante()
        {
            long delta = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
            return Interval - (delta - T0) % Interval;
        }

        public string ComputarTOTP()
        {
            return ComputarTOTP(ObterTempoCorrent());
        }

        public string ComputarTOTP(long Tempo)
        {
            System.Security.Cryptography.HMACSHA1 alg = new System.Security.Cryptography.HMACSHA1();
            alg.Key = _Key;
            byte[] tempo = LongToByte(Tempo);
            byte[] hash = alg.ComputeHash(tempo);
            //hash = new byte[] { 0x1f, 0x86 , 0x98 , 0x69 , 0x0e , 0x02 , 0xca , 0x16 , 0x61 , 0x85 , 0x50 , 0xef , 0x7f , 0x19 , 0xda , 0x8e , 0x94 , 0x5b , 0x55 , 0x5a };
            int offset = hash[hash.Length - 1] & 0xf;
            long otp = ((hash[offset + 0] & 0x7f) << 24) |
                       ((hash[offset + 1] & 0xff) << 16) |
                       ((hash[offset + 2] & 0xff) << 8) |
                        (hash[offset + 3] & 0xff);
            //otp = otp % 1000000;
            return Steam ? SteamEncoder(otp) : Encoder(Digits, otp);
        }

        public bool ValidarCodigo(string codigo)
        {
            codigo = codigo.Trim().ToUpper();
            long t = ObterTempoCorrent();
            return codigo == ComputarTOTP(t) || codigo == ComputarTOTP(t - 1) || codigo == ComputarTOTP(t - 2);
        }
    }
}