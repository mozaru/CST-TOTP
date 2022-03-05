using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST___CarteiraSenhasTemporais
{
    public partial class FrmSenha : Form
    {
        private static FrmSenha? _Instancia = null;
        private bool _Validar = true;
        public static bool Executar(bool validar=true)
        {
            if (_Instancia == null)
                _Instancia = new FrmSenha();
            _Instancia._Validar = validar;
            _Instancia.tbxSenha.Text = "";
            return _Instancia.ShowDialog() == DialogResult.OK;
        }

        public static string LastSenha()
        {
            if (_Instancia == null)
                _Instancia = new FrmSenha();
            return _Instancia.tbxSenha.Text;
        }

        private FrmSenha()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.None;
            if (!_Validar)
                DialogResult = DialogResult.OK;
            else if (Persistencia.GetInstancia().ValidarSenha(tbxSenha.Text))
                DialogResult = DialogResult.OK;
            else
                MessageBox.Show("Senha não confere!");
        }
    }
}
