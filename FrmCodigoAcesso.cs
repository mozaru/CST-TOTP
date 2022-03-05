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
    public partial class FrmCodigoAcesso : Form
    {
        private static FrmCodigoAcesso? _instancia = null;
        private FrmCodigoAcesso()
        {
            InitializeComponent();
        }

        public static bool Executar(AccessCode c)
        {
            if (_instancia == null)
                _instancia = new FrmCodigoAcesso();
            _instancia.AtualizarTela(c);
            bool resp = _instancia.ShowDialog()==DialogResult.OK;
            if (resp)
                _instancia.AtualizarObjeto(c);
            return resp;
        }

        public void AtualizarTela(AccessCode c)
        {
            Text = String.IsNullOrEmpty(c.Name) ? "Novo Código de Acesso" : "Editar Código de Acesso";
            tbxChave.Text = c.Key;
            tbxNome.Text = c.Name;
            tbxIntervalo.Value = c.Interval;
            tbxT0.Value = c.T0;
            tbxTipo.SelectedIndex = tbxTipo.Items.IndexOf(c.Steam ? "Steam" : "Padrão");
            tbxObs.Text = c.Note;
            tbxDigitos.Value = c.Digits;
        }

        public void AtualizarObjeto(AccessCode c)
        {
            c.Key = tbxChave.Text;
            c.Name = tbxNome.Text;
            c.Interval = (long)tbxIntervalo.Value;
            c.T0 = (long)tbxT0.Value;
            c.Steam = tbxTipo.Text == "Steam";
            c.Note = tbxObs.Text;
            c.Digits = (int)tbxDigitos.Value;
        }
    }
}
