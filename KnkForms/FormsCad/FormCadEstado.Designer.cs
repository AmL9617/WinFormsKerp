namespace KnkForms.Classes
{
    partial class FormCadEstado
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
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblNomeEstado = new System.Windows.Forms.Label();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.txtCodPais = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.txtIcms = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPercIcms = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodWeb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPercRedST = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNomePais = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDataCad
            // 
            this.txtDataCad.TabIndex = 11;
            // 
            // txtDataAlt
            // 
            this.txtDataAlt.TabIndex = 12;
            // 
            // btnSalvar
            // 
            this.btnSalvar.TabIndex = 13;
            // 
            // txtCodUser
            // 
            this.txtCodUser.TabIndex = 10;
            // 
            // btnSair
            // 
            this.btnSair.TabIndex = 14;
            // 
            // txtSigla
            // 
            this.txtSigla.Location = new System.Drawing.Point(397, 59);
            this.txtSigla.MaxLength = 2;
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(42, 20);
            this.txtSigla.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Sigla";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(114, 58);
            this.txtEstado.MaxLength = 50;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(260, 20);
            this.txtEstado.TabIndex = 2;
            // 
            // lblNomeEstado
            // 
            this.lblNomeEstado.AutoSize = true;
            this.lblNomeEstado.Location = new System.Drawing.Point(111, 42);
            this.lblNomeEstado.Name = "lblNomeEstado";
            this.lblNomeEstado.Size = new System.Drawing.Size(40, 13);
            this.lblNomeEstado.TabIndex = 19;
            this.lblNomeEstado.Text = "Estado";
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Location = new System.Drawing.Point(727, 28);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(50, 17);
            this.chkAtivo.TabIndex = 5;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            this.chkAtivo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.chkBox);
            // 
            // txtCodPais
            // 
            this.txtCodPais.Enabled = false;
            this.txtCodPais.Location = new System.Drawing.Point(462, 59);
            this.txtCodPais.MaxLength = 50;
            this.txtCodPais.Name = "txtCodPais";
            this.txtCodPais.Size = new System.Drawing.Size(260, 20);
            this.txtCodPais.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(459, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "País";
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(728, 59);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(21, 20);
            this.btnConsulta.TabIndex = 4;
            this.btnConsulta.Text = "⌕";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // txtIcms
            // 
            this.txtIcms.Location = new System.Drawing.Point(140, 117);
            this.txtIcms.MaxLength = 8;
            this.txtIcms.Name = "txtIcms";
            this.txtIcms.Size = new System.Drawing.Size(62, 20);
            this.txtIcms.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "ICMS";
            // 
            // txtPercIcms
            // 
            this.txtPercIcms.Location = new System.Drawing.Point(36, 117);
            this.txtPercIcms.MaxLength = 8;
            this.txtPercIcms.Name = "txtPercIcms";
            this.txtPercIcms.Size = new System.Drawing.Size(70, 20);
            this.txtPercIcms.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Percentual ICMS";
            // 
            // txtCodWeb
            // 
            this.txtCodWeb.Location = new System.Drawing.Point(344, 117);
            this.txtCodWeb.MaxLength = 100;
            this.txtCodWeb.Name = "txtCodWeb";
            this.txtCodWeb.Size = new System.Drawing.Size(307, 20);
            this.txtCodWeb.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Código Web";
            // 
            // txtPercRedST
            // 
            this.txtPercRedST.Location = new System.Drawing.Point(226, 117);
            this.txtPercRedST.MaxLength = 8;
            this.txtPercRedST.Name = "txtPercRedST";
            this.txtPercRedST.Size = new System.Drawing.Size(70, 20);
            this.txtPercRedST.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Percentual Red. S. T.";
            // 
            // txtNomePais
            // 
            this.txtNomePais.Enabled = false;
            this.txtNomePais.Location = new System.Drawing.Point(462, 59);
            this.txtNomePais.MaxLength = 50;
            this.txtNomePais.Name = "txtNomePais";
            this.txtNomePais.Size = new System.Drawing.Size(260, 20);
            this.txtNomePais.TabIndex = 38;
            // 
            // FormCadEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNomePais);
            this.Controls.Add(this.txtCodWeb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPercRedST);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIcms);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPercIcms);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.txtCodPais);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkAtivo);
            this.Controls.Add(this.txtSigla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblNomeEstado);
            this.Name = "FormCadEstado";
            this.Text = "Form Estado";
            this.Controls.SetChildIndex(this.lblCodUser, 0);
            this.Controls.SetChildIndex(this.txtCodUser, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.lblNomeEstado, 0);
            this.Controls.SetChildIndex(this.txtEstado, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtSigla, 0);
            this.Controls.SetChildIndex(this.chkAtivo, 0);
            this.Controls.SetChildIndex(this.lblCod, 0);
            this.Controls.SetChildIndex(this.txtCod, 0);
            this.Controls.SetChildIndex(this.lblDataCad, 0);
            this.Controls.SetChildIndex(this.txtDataCad, 0);
            this.Controls.SetChildIndex(this.lblDataAlteracao, 0);
            this.Controls.SetChildIndex(this.txtDataAlt, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtCodPais, 0);
            this.Controls.SetChildIndex(this.btnConsulta, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtPercIcms, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtIcms, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtPercRedST, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtCodWeb, 0);
            this.Controls.SetChildIndex(this.txtNomePais, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblNomeEstado;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.TextBox txtCodPais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.TextBox txtIcms;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPercIcms;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodWeb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPercRedST;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNomePais;
    }
}
