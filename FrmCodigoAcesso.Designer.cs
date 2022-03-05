
namespace CST___CarteiraSenhasTemporais
{
    partial class FrmCodigoAcesso
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
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxChave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxT0 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxIntervalo = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxTipo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxObs = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxDigitos = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxT0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxIntervalo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxDigitos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 416);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 71);
            this.panel1.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(390, 15);
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
            this.btnOk.Location = new System.Drawing.Point(187, 15);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(125, 40);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // tbxNome
            // 
            this.tbxNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxNome.Location = new System.Drawing.Point(30, 55);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(643, 29);
            this.tbxNome.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nome";
            // 
            // tbxChave
            // 
            this.tbxChave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxChave.Location = new System.Drawing.Point(30, 123);
            this.tbxChave.Name = "tbxChave";
            this.tbxChave.Size = new System.Drawing.Size(643, 29);
            this.tbxChave.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Chave";
            // 
            // tbxT0
            // 
            this.tbxT0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxT0.Location = new System.Drawing.Point(30, 195);
            this.tbxT0.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.tbxT0.Name = "tbxT0";
            this.tbxT0.Size = new System.Drawing.Size(273, 29);
            this.tbxT0.TabIndex = 14;
            this.tbxT0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "T0";
            // 
            // tbxIntervalo
            // 
            this.tbxIntervalo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbxIntervalo.Location = new System.Drawing.Point(329, 195);
            this.tbxIntervalo.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.tbxIntervalo.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tbxIntervalo.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.tbxIntervalo.Name = "tbxIntervalo";
            this.tbxIntervalo.Size = new System.Drawing.Size(91, 29);
            this.tbxIntervalo.TabIndex = 16;
            this.tbxIntervalo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxIntervalo.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Intervalo";
            // 
            // tbxTipo
            // 
            this.tbxTipo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbxTipo.Items.AddRange(new object[] {
            "Padrão",
            "Steam"});
            this.tbxTipo.Location = new System.Drawing.Point(569, 195);
            this.tbxTipo.Name = "tbxTipo";
            this.tbxTipo.Size = new System.Drawing.Size(104, 29);
            this.tbxTipo.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(569, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Tipo";
            // 
            // tbxObs
            // 
            this.tbxObs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxObs.Location = new System.Drawing.Point(30, 268);
            this.tbxObs.Multiline = true;
            this.tbxObs.Name = "tbxObs";
            this.tbxObs.Size = new System.Drawing.Size(643, 121);
            this.tbxObs.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 21);
            this.label6.TabIndex = 19;
            this.label6.Text = "Obs";
            // 
            // tbxDigitos
            // 
            this.tbxDigitos.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbxDigitos.Location = new System.Drawing.Point(448, 195);
            this.tbxDigitos.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.tbxDigitos.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.tbxDigitos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbxDigitos.Name = "tbxDigitos";
            this.tbxDigitos.Size = new System.Drawing.Size(91, 29);
            this.tbxDigitos.TabIndex = 22;
            this.tbxDigitos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxDigitos.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(448, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "Digitos";
            // 
            // FrmCodigoAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 487);
            this.Controls.Add(this.tbxDigitos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbxObs);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxTipo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxIntervalo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxT0);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxChave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCodigoAcesso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmCodigoAcesso";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbxT0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxIntervalo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxDigitos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxChave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown tbxT0;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown tbxIntervalo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tbxTipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxObs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown tbxDigitos;
        private System.Windows.Forms.Label label7;
    }
}