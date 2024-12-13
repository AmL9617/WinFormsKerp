namespace KnkForms.FormsCad
{
    partial class FormCadListaCodST
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
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtCod
            // 
            this.txtCod.MaxLength = 3;
            // 
            // txtDataCad
            // 
            this.txtDataCad.Enabled = false;
            this.txtDataCad.Location = new System.Drawing.Point(139, 418);
            this.txtDataCad.TabIndex = 6;
            // 
            // lblDataCad
            // 
            this.lblDataCad.Location = new System.Drawing.Point(136, 402);
            // 
            // txtDataAlt
            // 
            this.txtDataAlt.Enabled = false;
            this.txtDataAlt.Location = new System.Drawing.Point(262, 418);
            // 
            // lblDataAlteracao
            // 
            this.lblDataAlteracao.Location = new System.Drawing.Point(259, 402);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(474, 414);
            // 
            // txtCodUser
            // 
            this.txtCodUser.Enabled = false;
            this.txtCodUser.Location = new System.Drawing.Point(39, 418);
            this.txtCodUser.TabIndex = 5;
            // 
            // lblCodUser
            // 
            this.lblCodUser.Location = new System.Drawing.Point(36, 402);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(569, 414);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(35, 108);
            this.txtDescricao.MaxLength = 150;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(584, 90);
            this.txtDescricao.TabIndex = 4;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(110, 58);
            this.txtTipo.MaxLength = 1;
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(37, 20);
            this.txtTipo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 148;
            this.label2.Text = "Descrição";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(107, 41);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(28, 13);
            this.lbl1.TabIndex = 147;
            this.lbl1.Text = "Tipo";
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Location = new System.Drawing.Point(596, 26);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(50, 17);
            this.chkAtivo.TabIndex = 3;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            this.chkAtivo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.chkBox);
            // 
            // FormCadListaCodST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(658, 450);
            this.Controls.Add(this.chkAtivo);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl1);
            this.Name = "FormCadListaCodST";
            this.Text = "Form Lista Código ST";
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
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtTipo, 0);
            this.Controls.SetChildIndex(this.txtDescricao, 0);
            this.Controls.SetChildIndex(this.chkAtivo, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.CheckBox chkAtivo;
    }
}
