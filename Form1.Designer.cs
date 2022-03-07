
namespace CST___CarteiraSenhasTemporais
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnBasic = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnTrocaSenha = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlCtrls = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnSobre = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdmin);
            this.panel1.Controls.Add(this.btnBasic);
            this.panel1.Controls.Add(this.btnExportar);
            this.panel1.Controls.Add(this.btnImportar);
            this.panel1.Controls.Add(this.btnTrocaSenha);
            this.panel1.Controls.Add(this.btnNovo);
            this.panel1.Controls.Add(this.btnSobre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(845, 51);
            this.panel1.TabIndex = 1;
            // 
            // btnAdmin
            // 
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdmin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdmin.Location = new System.Drawing.Point(359, 5);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(118, 41);
            this.btnAdmin.TabIndex = 6;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.Click += new System.EventHandler(this.btnBasic_Click);
            // 
            // btnBasic
            // 
            this.btnBasic.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBasic.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBasic.Location = new System.Drawing.Point(486, 5);
            this.btnBasic.Margin = new System.Windows.Forms.Padding(4);
            this.btnBasic.Name = "btnBasic";
            this.btnBasic.Size = new System.Drawing.Size(118, 41);
            this.btnBasic.TabIndex = 5;
            this.btnBasic.Text = "Voltar";
            this.btnBasic.Click += new System.EventHandler(this.btnBasic_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExportar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExportar.Location = new System.Drawing.Point(241, 5);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(118, 41);
            this.btnExportar.TabIndex = 4;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnImportar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnImportar.Location = new System.Drawing.Point(123, 5);
            this.btnImportar.Margin = new System.Windows.Forms.Padding(4);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(118, 41);
            this.btnImportar.TabIndex = 3;
            this.btnImportar.Text = "Importar";
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnTrocaSenha
            // 
            this.btnTrocaSenha.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTrocaSenha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTrocaSenha.Location = new System.Drawing.Point(604, 5);
            this.btnTrocaSenha.Margin = new System.Windows.Forms.Padding(10);
            this.btnTrocaSenha.Name = "btnTrocaSenha";
            this.btnTrocaSenha.Size = new System.Drawing.Size(118, 41);
            this.btnTrocaSenha.TabIndex = 2;
            this.btnTrocaSenha.Text = "Trocar Senha";
            this.btnTrocaSenha.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNovo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNovo.Location = new System.Drawing.Point(5, 5);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(118, 41);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "Novo";
            this.btnNovo.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlCtrls
            // 
            this.pnlCtrls.AutoScroll = true;
            this.pnlCtrls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCtrls.Location = new System.Drawing.Point(0, 51);
            this.pnlCtrls.Name = "pnlCtrls";
            this.pnlCtrls.Size = new System.Drawing.Size(845, 394);
            this.pnlCtrls.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSobre
            // 
            this.btnSobre.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSobre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSobre.Location = new System.Drawing.Point(722, 5);
            this.btnSobre.Margin = new System.Windows.Forms.Padding(10);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(118, 41);
            this.btnSobre.TabIndex = 7;
            this.btnSobre.Text = "Sobre";
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(845, 445);
            this.Controls.Add(this.pnlCtrls);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CST - Carteira de Senhas Temporais";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlCtrls;
        private System.Windows.Forms.Button btnTrocaSenha;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnBasic;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnSobre;
    }
}
