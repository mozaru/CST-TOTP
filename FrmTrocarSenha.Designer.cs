
namespace CST___CarteiraSenhasTemporais
{
    partial class FrmTrocarSenha
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSenha = new System.Windows.Forms.TextBox();
            this.tbxNovaSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxConfirmacaoNovaSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 259);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 71);
            this.panel1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(276, 15);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 40);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(73, 15);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(125, 40);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Entre com a senha de acesso atual";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbxSenha
            // 
            this.tbxSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxSenha.Location = new System.Drawing.Point(99, 53);
            this.tbxSenha.Name = "tbxSenha";
            this.tbxSenha.PasswordChar = '*';
            this.tbxSenha.Size = new System.Drawing.Size(273, 29);
            this.tbxSenha.TabIndex = 2;
            // 
            // tbxNovaSenha
            // 
            this.tbxNovaSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxNovaSenha.Location = new System.Drawing.Point(99, 132);
            this.tbxNovaSenha.Name = "tbxNovaSenha";
            this.tbxNovaSenha.PasswordChar = '*';
            this.tbxNovaSenha.Size = new System.Drawing.Size(273, 29);
            this.tbxNovaSenha.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Entre com a nova senha de acesso";
            // 
            // tbxConfirmacaoNovaSenha
            // 
            this.tbxConfirmacaoNovaSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxConfirmacaoNovaSenha.Location = new System.Drawing.Point(101, 195);
            this.tbxConfirmacaoNovaSenha.Name = "tbxConfirmacaoNovaSenha";
            this.tbxConfirmacaoNovaSenha.PasswordChar = '*';
            this.tbxConfirmacaoNovaSenha.Size = new System.Drawing.Size(273, 29);
            this.tbxConfirmacaoNovaSenha.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirme a nova senha de acesso";
            // 
            // FrmTrocarSenha
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(474, 330);
            this.Controls.Add(this.tbxConfirmacaoNovaSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxNovaSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxSenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmTrocarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Trocar Senha";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSenha;
        private System.Windows.Forms.TextBox tbxNovaSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxConfirmacaoNovaSenha;
        private System.Windows.Forms.Label label3;
    }
}