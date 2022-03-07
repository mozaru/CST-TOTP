using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST___CarteiraSenhasTemporais
{
    public partial class FrmSobre : Form
    {
        private static FrmSobre? _Instancia = null;
        private FrmSobre()
        {
            InitializeComponent();
        }

        public static void Executar()
        {
            if (_Instancia==null)
                _Instancia = new FrmSobre();
            _Instancia.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://www.paypal.com/donate/?hosted_button_id=SGFDKFJTTU3JS");
            sInfo.UseShellExecute = true;
            Process.Start(sInfo);
        }
    }
}
