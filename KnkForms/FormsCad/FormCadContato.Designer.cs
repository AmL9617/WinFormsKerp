namespace KnkForms.FormsCad
{
    partial class FormCadContato
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtContato = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFornCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConsultaCid = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDataCad
            // 
            this.txtDataCad.Location = new System.Drawing.Point(137, 418);
            this.txtDataCad.TabIndex = 6;
            // 
            // lblDataCad
            // 
            this.lblDataCad.Location = new System.Drawing.Point(134, 402);
            // 
            // txtDataAlt
            // 
            this.txtDataAlt.Location = new System.Drawing.Point(260, 418);
            // 
            // lblDataAlteracao
            // 
            this.lblDataAlteracao.Location = new System.Drawing.Point(257, 402);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(472, 414);
            // 
            // txtCodUser
            // 
            this.txtCodUser.Location = new System.Drawing.Point(25, 418);
            this.txtCodUser.TabIndex = 5;
            // 
            // lblCodUser
            // 
            this.lblCodUser.Location = new System.Drawing.Point(22, 402);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(567, 414);
            // 
            // txtContato
            // 
            this.txtContato.Location = new System.Drawing.Point(35, 172);
            this.txtContato.MaxLength = 200;
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(614, 20);
            this.txtContato.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Contato";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(35, 117);
            this.txtTipo.MaxLength = 50;
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(260, 20);
            this.txtTipo.TabIndex = 2;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(32, 101);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(83, 13);
            this.lbl1.TabIndex = 53;
            this.lbl1.Text = "Tipo de Contato";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(35, 233);
            this.txtObservacao.MaxLength = 500;
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(614, 95);
            this.txtObservacao.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Observação";
            // 
            // txtFornCliente
            // 
            this.txtFornCliente.Location = new System.Drawing.Point(122, 58);
            this.txtFornCliente.MaxLength = 100;
            this.txtFornCliente.Name = "txtFornCliente";
            this.txtFornCliente.Size = new System.Drawing.Size(307, 20);
            this.txtFornCliente.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Fornecedor/Cliente";
            // 
            // btnConsultaCid
            // 
            this.btnConsultaCid.Location = new System.Drawing.Point(435, 58);
            this.btnConsultaCid.Name = "btnConsultaCid";
            this.btnConsultaCid.Size = new System.Drawing.Size(24, 23);
            this.btnConsultaCid.TabIndex = 557;
            this.btnConsultaCid.Text = "⌕";
            this.btnConsultaCid.UseVisualStyleBackColor = true;
            this.btnConsultaCid.Click += new System.EventHandler(this.btnConsultaCid_Click);
            // 
            // FormCadContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(670, 450);
            this.Controls.Add(this.btnConsultaCid);
            this.Controls.Add(this.txtFornCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtContato);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.lbl1);
            this.Name = "FormCadContato";
            this.Text = "Form Contato";
            this.Controls.SetChildIndex(this.lblCod, 0);
            this.Controls.SetChildIndex(this.txtCod, 0);
            this.Controls.SetChildIndex(this.lblDataCad, 0);
            this.Controls.SetChildIndex(this.txtDataCad, 0);
            this.Controls.SetChildIndex(this.lblDataAlteracao, 0);
            this.Controls.SetChildIndex(this.txtDataAlt, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.lblCodUser, 0);
            this.Controls.SetChildIndex(this.txtCodUser, 0);
            this.Controls.SetChildIndex(this.lbl1, 0);
            this.Controls.SetChildIndex(this.txtTipo, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtContato, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtObservacao, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtFornCliente, 0);
            this.Controls.SetChildIndex(this.btnConsultaCid, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFornCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConsultaCid;
    }
}
