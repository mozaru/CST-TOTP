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
    public partial class FrmCriarSenha : Form
    {
        private static FrmCriarSenha? _Instancia = null;
        private bool _criar = true;
        public static bool Executar(bool Criar=true)
        {
            if (_Instancia == null)
                _Instancia = new FrmCriarSenha();
            _Instancia._criar = Criar;
            _Instancia.tbxNovaSenha.Text = "";
            _Instancia.tbxConfirmacaoNovaSenha.Text = "";
            return _Instancia.ShowDialog() == DialogResult.OK;
        }
        public static string LastSenha()
        {
            if (_Instancia == null)
                _Instancia = new FrmCriarSenha();
            return _Instancia.tbxNovaSenha.Text;
        }

        private FrmCriarSenha()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.None;
            if (string.IsNullOrEmpty(tbxNovaSenha.Text))
                MessageBox.Show("O Campo nova senha deve ser preenchido");
            else if (string.IsNullOrEmpty(tbxConfirmacaoNovaSenha.Text))
                MessageBox.Show("O Campo confirmação de senha deve ser preenchido");
            else if (tbxNovaSenha.Text != tbxConfirmacaoNovaSenha.Text)
                MessageBox.Show("O Campo confirmação de nova senha diferente da nova senha");
            else if (tbxNovaSenha.Text.Trim().Length < 5)
                MessageBox.Show("nova senha muito pequena!");
            if (!_criar)
                DialogResult = DialogResult.OK;
            else if (Persistencia.GetInstancia().CriarSenha(tbxNovaSenha.Text))
            {
                MessageBox.Show("Senha criada com sucesso!");
                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Falha na criacao de senha!");
        }
    }
}
