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
    public partial class FrmTrocarSenha : Form
    {
        private static FrmTrocarSenha? _Instancia=null;
        public static bool Executar()
        {
            if (_Instancia == null)
                _Instancia = new FrmTrocarSenha();
            _Instancia.tbxSenha.Text = "";
            _Instancia.tbxNovaSenha.Text = "";
            _Instancia.tbxConfirmacaoNovaSenha.Text = "";
            return _Instancia.ShowDialog() == DialogResult.OK;
        }
        private FrmTrocarSenha()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.None;
            if (string.IsNullOrEmpty(tbxSenha.Text))
                MessageBox.Show("O Campo senha deve ser preenchido");
            else if (string.IsNullOrEmpty(tbxNovaSenha.Text))
                MessageBox.Show("O Campo nova senha deve ser preenchido");
            else if (string.IsNullOrEmpty(tbxConfirmacaoNovaSenha.Text))
                MessageBox.Show("O Campo confirmação de senha deve ser preenchido");
            else if (tbxNovaSenha.Text!=tbxConfirmacaoNovaSenha.Text)
                MessageBox.Show("O Campo confirmação de nova senha diferente da nova senha");
            else if (tbxNovaSenha.Text.Trim().Length<5)
                MessageBox.Show("nova senha muito pequena!");
            if (Persistencia.GetInstancia().TrocarSenha(tbxSenha.Text, tbxNovaSenha.Text))
            {
                MessageBox.Show("Senha trocada com sucesso!");
                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Falha na troca de senha!");
        }
    }
}
