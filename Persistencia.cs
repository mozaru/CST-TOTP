using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST___CarteiraSenhasTemporais
{
    public class Persistencia : IEnumerable<AccessCode>
    {
        private static Persistencia? _Instancia = null;
        public static Persistencia GetInstancia()
        {
            if (_Instancia == null)
                _Instancia = new Persistencia();
            return _Instancia;
        }

        private string _Dir="";
        private string _CurrentPassword="";
        private List<AccessCode> _Codes = new List<AccessCode>();

        public bool EhNovo { get { return !System.IO.File.Exists(_Dir); } }
        public bool Logado { get { return !string.IsNullOrEmpty(_CurrentPassword); } }
        public AccessCode this[int index]
        {
            get { return _Codes[index]; }
        }
        public int Count
        {
            get { return _Codes.Count; }
        }

        private Persistencia()
        {
            _Dir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            _Dir = System.IO.Path.Combine(_Dir, "CST-CarteiraSenhasTemporais");
            if (!System.IO.Directory.Exists(_Dir))
                System.IO.Directory.CreateDirectory(_Dir);

            _Dir = System.IO.Path.Combine(_Dir, "dados.dat");
        }

        private void Gravar()
        {
            string txt = Seguranca.Encriptar(_CurrentPassword, ToString());
            System.IO.File.WriteAllText(_Dir + ".sec", txt);
            System.IO.File.WriteAllText(_Dir, txt);
        }

        private void Ler(string senha)
        {
            string txt = System.IO.File.ReadAllText(_Dir);
            txt = Seguranca.Decriptar(senha, txt);
            FromString(txt);
        }

        public void FromString(string txt, bool Importar = false)
        {
            if (!Importar)
                _Codes.Clear();
            foreach(string linha in txt.Split('\n'))
                if (linha!=null && linha.Trim().Length>0)
                {
                    string[] v = linha.Split(';');
                    AccessCode c = new AccessCode();
                    c.Name = v[0];
                    c.Key = v[1];
                    c.Steam = v[2].ToLower().Trim() == "steam";
                    c.T0 = long.Parse(v[3]);
                    c.Interval = long.Parse(v[4]);
                    c.Digits = int.Parse(v[5]);
                    c.Note = v[6].Replace("##NL##", "\n").Replace("##PV##",";");
                    _Codes.Add(c);
                }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var c in _Codes)
                sb.AppendLine(string.Format("{0};{1};{2};{3};{4};{5};{6}", c.Name, c.Key, c.Steam ? "steam" : "", c.T0, c.Interval, c.Digits, c.Note.Replace("\n","##NL##").Replace(";","##PV##")));
            return sb.ToString();
        }

        public bool ValidarSenha(string senha)
        {
            if (!System.IO.File.Exists(_Dir))
                return false;
            try
            {
                Ler(senha);
                _CurrentPassword = senha;
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool TrocarSenha(string senha, string novaSenha)
        {
            if (!System.IO.File.Exists(_Dir))
                return false;
            try
            {
                if (senha != _CurrentPassword)
                    return false;
                _CurrentPassword = novaSenha;
                Gravar();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool CriarSenha(string senha)
        {
            if (System.IO.File.Exists(_Dir))
                return false;
            try
            {
                _CurrentPassword = senha;
                Gravar();
                return true;
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }


        public void Atualizar(string nomeOld, AccessCode c)
        {
            AccessCode a = null;
            foreach (var x in _Codes)
                if (x.Name == nomeOld)
                    a = x;
            if (a!=null)
            {
                if (a != c)
                {
                    a.Name = c.Name;
                    a.Key = c.Key;
                    a.Steam = c.Steam;
                    a.T0 = c.T0;
                    a.Interval = c.Interval;
                    a.Digits = c.Digits;
                    a.Note = c.Note;
                }
                Gravar();
            }
        }
        public void Adicionar(AccessCode c)
        {
            _Codes.Add(c);
            Gravar();
        }

        public void Remover(AccessCode c)
        {
            _Codes.Remove(c);
            Gravar();
        }

        public IEnumerator<AccessCode> GetEnumerator()
        {
            return _Codes.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _Codes.GetEnumerator();
        }

        public void Exportar(string fileName, string senha)
        {
            string txt = Seguranca.Encriptar(senha, ToString());
            System.IO.File.WriteAllText(fileName, txt);
        }

        public bool ValidarArquivo(string fileName, string senha)
        {
            bool valido = true;
            try
            {
                string txt = System.IO.File.ReadAllText(fileName);
                txt = Seguranca.Decriptar(senha, txt);

                foreach (string linha in txt.Split('\n'))
                    if (linha != null && linha.Trim().Length > 0)
                    {
                        string[] v = linha.Split(';');
                        valido = valido && v.Length == 7;
                    }
            }catch(Exception)
            {
                valido = false;
            }
            return valido;
        }

        public void Importar(string fileName, string senha)
        {
            string txt = System.IO.File.ReadAllText(fileName);
            txt = Seguranca.Decriptar(senha, txt);
            FromString(txt, true);
            Gravar();
        }
    }
}

