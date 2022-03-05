using Criptografia;
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
    public partial class Form1 : Form
    {
        private TOTP totp = new TOTP();
        enum modeType { basic, admin };

        private modeType mode = modeType.basic;

        Color c1 = Color.FromArgb(100, Color.White);
        Color c2 = Color.FromArgb(10, Color.Black);

        public Form1()
        {
            InitializeComponent();
            btnTrocaSenha.Visible = btnBasic.Visible = btnExportar.Visible = btnImportar.Visible = btnNovo.Visible = mode == modeType.admin;
            btnAdmin.Visible = mode == modeType.basic;
        }

        public void AtualizarTela()
        {
            foreach(var ctrl in pnlCtrls.Controls)
            {
                if (ctrl is Panel && ((Panel)ctrl).Tag!=null)
                {
                    dynamic ctr = (dynamic)((Panel)ctrl).Tag;
                    AccessCode c = ctr.ControleAcesso;
                    ctr.lblCodigo.Text = string.Format("{0}", CalcularCodigo(c));
                    ctr.lblTempo.Text = string.Format("{0:00}s", TempoRestante(c));
                }
            }
        }


        private void AddPanel(AccessCode c)
        {
            Panel pnl = new Panel();
            pnl.Dock = DockStyle.Top;
            pnl.Height = 40;
            pnl.Padding = new Padding(10,0,10,0);

            Label lblTempo = new Label();
            lblTempo.Text = string.Format("{0:00}s", TempoRestante(c));
            lblTempo.Parent = pnl;
            lblTempo.Location = new Point(0, 0);
            lblTempo.AutoSize = false;
            lblTempo.Width = 60;
            lblTempo.TextAlign = ContentAlignment.MiddleCenter;
            lblTempo.Dock = DockStyle.Right;
            lblTempo.Tag = c;
            lblTempo.BackColor = Color.Transparent;


            Label lblCodigo = new Label();
            lblCodigo.Text = string.Format("{0}", CalcularCodigo(c));
            lblCodigo.Parent = pnl;
            lblCodigo.Location = new Point(0, 0);
            lblCodigo.AutoSize = false;
            lblCodigo.Width = 160;
            lblCodigo.TextAlign = ContentAlignment.MiddleCenter;
            lblCodigo.Dock = DockStyle.Right;
            lblCodigo.Tag = c;
            lblCodigo.BackColor = Color.Transparent;

            Button btnCopyCode = new Button();
            btnCopyCode.Text = "C";
            btnCopyCode.SetBounds(0, pnl.Width-25, pnl.Height, pnl.Height);
            btnCopyCode.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            btnCopyCode.Parent = pnl;
            btnCopyCode.Tag = c;
            btnCopyCode.Dock = DockStyle.Right;
            btnCopyCode.Click += BtnCopyCode_Click;

            if (mode == modeType.admin)
            {
                Button btnCopyKey = new Button();
                btnCopyKey.Text = "K";
                btnCopyKey.Tag = c;
                btnCopyKey.SetBounds(0, pnl.Width - 2 * 25, pnl.Height, pnl.Height);
                btnCopyKey.Anchor = AnchorStyles.Right | AnchorStyles.Top;
                btnCopyKey.Dock = DockStyle.Right;
                btnCopyKey.Parent = pnl;
                btnCopyKey.Click += BtnCopyKey_Click;

                Button btnEdit = new Button();
                btnEdit.Text = "E";
                btnEdit.Tag = c;
                btnEdit.SetBounds(0, pnl.Width - 2 * 25, pnl.Height, pnl.Height);
                btnEdit.Anchor = AnchorStyles.Right | AnchorStyles.Top;
                btnEdit.Dock = DockStyle.Right;
                btnEdit.Parent = pnl;
                btnEdit.Click += BtnEdit_Click;

                Button btnDel = new Button();
                btnDel.Text = "D";
                btnDel.Tag = c;
                btnDel.SetBounds(0, pnl.Width - 2 * 25, pnl.Height, pnl.Height);
                btnDel.Anchor = AnchorStyles.Right | AnchorStyles.Top;
                btnDel.Dock = DockStyle.Right;
                btnDel.Parent = pnl;
                btnDel.Click += BtnDel_Click;
            }

            Label lblnome = new Label();
            lblnome.Text = c.Name;
            lblnome.Parent = pnl;
            lblnome.Location = new Point(0, 0);
            lblnome.AutoSize = false;
            lblnome.Dock = DockStyle.Fill;
            lblnome.TextAlign = ContentAlignment.MiddleLeft;
            lblnome.BackColor = Color.Transparent;

            pnl.Parent = pnlCtrls;
            //pnl.BorderStyle = BorderStyle.FixedSingle;
            pnl.BackColor = pnlCtrls.Controls.Count % 2 == 0 ? c1 : c2;// Color.FloralWhite: Color.Lavender;
            pnl.BringToFront();
            pnl.Tag = new
            {
                ControleAcesso=c,
                lblCodigo = lblCodigo,
                lblNome = lblnome,
                lblTempo = lblTempo,
                btnCopyCode = btnCopyCode,
            };

        }

        private string CalcularCodigo(AccessCode c)
        {
            totp.KeyHEX = c.Key;
            totp.T0 = c.T0;
            totp.Steam = c.Steam;
            totp.Interval = c.Interval;
            totp.Digits = c.Digits;
            return totp.ComputarTOTP();
        }
        private long TempoRestante(AccessCode c)
        {
            totp.KeyHEX = c.Key;
            totp.T0 = c.T0;
            totp.Steam = c.Steam;
            totp.Interval = c.Interval;
            totp.Digits = c.Digits;
            return totp.TempoRestante();
        }

        private void BtnCopyCode_Click(object? sender, EventArgs e)
        {
            if (sender != null && sender is Button && ((Button)sender).Tag != null && ((Button)sender).Tag is AccessCode)
            {
                AccessCode c = ((AccessCode)((Button)sender).Tag);
                Clipboard.SetText(CalcularCodigo(c));
            }
        }
        private void BtnDel_Click(object? sender, EventArgs e)
        {
            if (sender != null && sender is Button && ((Button)sender).Tag != null && ((Button)sender).Tag is AccessCode)
            {
                AccessCode c = ((AccessCode)((Button)sender).Tag);
                if (MessageBox.Show("Tem certeza que deseja remove "+c.Name,"Remover",MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    Persistencia.GetInstancia().Remover(c);
                    Reload();
                }
            }
        }
        private void BtnCopyKey_Click(object? sender, EventArgs e)
        {
            if (sender != null && sender is Button && ((Button)sender).Tag != null && ((Button)sender).Tag is AccessCode)
                Clipboard.SetText(((AccessCode)((Button)sender).Tag).Key);
        }

        private void BtnEdit_Click(object? sender, EventArgs e)
        {
            if (sender != null && sender is Button && ((Button)sender).Tag != null && ((Button)sender).Tag is AccessCode)
                if (FrmCodigoAcesso.Executar((AccessCode)((Button)sender).Tag))
                    Reload();
        }

        public void CriarEntradas()
        {
            //Controls.Clear();
            foreach(AccessCode c in Persistencia.GetInstancia())
                AddPanel(c);
        }

        public void Reload()
        {
            /*List<Panel> list = new List<Panel>();
            foreach (var ctr in Controls)
                if (ctr is Panel && ((Panel)ctr).Tag != null)
                    list.Add((Panel)ctr);
            foreach (var ctrl in list)
                ctrl.Dispose();*/
            pnlCtrls.SuspendLayout();
            pnlCtrls.Controls.Clear();
            CriarEntradas();
            pnlCtrls.ResumeLayout();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Persistencia.GetInstancia().EhNovo)
            {
                if (!FrmCriarSenha.Executar())
                    Close();
            }
            else
            {
                if (!FrmSenha.Executar())
                    Close();
            }
            CriarEntradas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccessCode c = new AccessCode();
            if (FrmCodigoAcesso.Executar(c))
            {
                Persistencia.GetInstancia().Adicionar(c);
                AddPanel(c);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AtualizarTela();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmTrocarSenha.Executar();
        }

        private void btnBasic_Click(object sender, EventArgs e)
        {
            if (sender == btnBasic)
                mode = modeType.basic;
            else if (sender == btnAdmin)
            {
                if (FrmSenha.Executar())
                    mode = modeType.admin;
            }
            Reload();
            btnTrocaSenha.Visible = btnBasic.Visible = btnExportar.Visible = btnImportar.Visible = btnNovo.Visible = mode == modeType.admin;
            btnAdmin.Visible = mode == modeType.basic;
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            if (sender == btnImportar)
            {
                openFileDialog1.Filter = "Arquivo Seguro cst (*.cst)|*.cst|Todos os Arquivos(*.*)|*.*";
                if (openFileDialog1.ShowDialog() == DialogResult.OK && FrmSenha.Executar(false))
                    if (Persistencia.GetInstancia().ValidarArquivo(openFileDialog1.FileName, FrmSenha.LastSenha()))
                    {
                        Persistencia.GetInstancia().Importar(openFileDialog1.FileName, FrmSenha.LastSenha());
                        Reload();
                    }
                    else
                        MessageBox.Show("Não foi possivel importar o arquivo selecionado", "Arquivo Invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (sender == btnExportar)
            {
                saveFileDialog1.Filter = "Arquivo Seguro cst (*.cst)|*.cst|Todos os Arquivos(*.*)|*.*";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK && FrmCriarSenha.Executar(false))
                    Persistencia.GetInstancia().Exportar(saveFileDialog1.FileName, FrmCriarSenha.LastSenha());
            }
        }
    }
}
