namespace KnkForms.Forms
{
    partial class FormCadPais
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
            this.lblNomePais = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.boxNacional = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDataCad
            // 
            this.txtDataCad.TabIndex = 8;
            // 
            // txtDataAlt
            // 
            this.txtDataAlt.TabIndex = 9;
            // 
            // btnSalvar
            // 
            this.btnSalvar.TabIndex = 10;
            // 
            // txtCodUser
            // 
            this.txtCodUser.TabIndex = 7;
            // 
            // btnSair
            // 
            this.btnSair.TabIndex = 11;
            // 
            // lblNomePais
            // 
            this.lblNomePais.AutoSize = true;
            this.lblNomePais.Location = new System.Drawing.Point(112, 42);
            this.lblNomePais.Name = "lblNomePais";
            this.lblNomePais.Size = new System.Drawing.Size(29, 13);
            this.lblNomePais.TabIndex = 9;
            this.lblNomePais.Text = "País";
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(115, 58);
            this.txtPais.MaxLength = 50;
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(260, 20);
            this.txtPais.TabIndex = 2;
            // 
            // txtSigla
            // 
            this.txtSigla.Location = new System.Drawing.Point(394, 57);
            this.txtSigla.MaxLength = 2;
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(42, 20);
            this.txtSigla.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Sigla";
            // 
            // txtDdi
            // 
            this.txtDdi.Location = new System.Drawing.Point(458, 57);
            this.txtDdi.MaxLength = 3;
            this.txtDdi.Name = "txtDdi";
            this.txtDdi.Size = new System.Drawing.Size(35, 20);
            this.txtDdi.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "DDI";
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Location = new System.Drawing.Point(727, 28);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(50, 17);
            this.chkAtivo.TabIndex = 6;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            this.chkAtivo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.chkBox);
            // 
            // boxNacional
            // 
            this.boxNacional.FormattingEnabled = true;
            this.boxNacional.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.boxNacional.Location = new System.Drawing.Point(517, 57);
            this.boxNacional.Name = "boxNacional";
            this.boxNacional.Size = new System.Drawing.Size(80, 21);
            this.boxNacional.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(515, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "O país é nacional?";
            // 
            // FormCadPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.boxNacional);
            this.Controls.Add(this.chkAtivo);
            this.Controls.Add(this.txtDdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSigla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.lblNomePais);
            this.Name = "FormCadPais";
            this.Text = "Form Pais";
            this.Controls.SetChildIndex(this.lblNomePais, 0);
            this.Controls.SetChildIndex(this.txtPais, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtSigla, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtDdi, 0);
            this.Controls.SetChildIndex(this.chkAtivo, 0);
            this.Controls.SetChildIndex(this.lblCodUser, 0);
            this.Controls.SetChildIndex(this.txtCodUser, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.lblCod, 0);
            this.Controls.SetChildIndex(this.txtCod, 0);
            this.Controls.SetChildIndex(this.lblDataCad, 0);
            this.Controls.SetChildIndex(this.txtDataCad, 0);
            this.Controls.SetChildIndex(this.lblDataAlteracao, 0);
            this.Controls.SetChildIndex(this.txtDataAlt, 0);
            this.Controls.SetChildIndex(this.boxNacional, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomePais;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.ComboBox boxNacional;
        private System.Windows.Forms.Label label4;
    }
}
