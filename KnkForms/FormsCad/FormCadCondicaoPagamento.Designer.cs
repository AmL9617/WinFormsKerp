﻿namespace KnkForms.Forms
{
    partial class FormCadCondicaoPagamento
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
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.txtCondPag = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTaxaJuro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPorParcela = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumParc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.boxOpDisp = new System.Windows.Forms.ComboBox();
            this.boxTipo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtCod
            // 
            this.txtCod.Enabled = false;
            // 
            // txtDataCad
            // 
            this.txtDataCad.Enabled = false;
            this.txtDataCad.TabIndex = 11;
            // 
            // txtDataAlt
            // 
            this.txtDataAlt.Enabled = false;
            this.txtDataAlt.TabIndex = 12;
            // 
            // btnSalvar
            // 
            this.btnSalvar.TabIndex = 13;
            // 
            // txtCodUser
            // 
            this.txtCodUser.Enabled = false;
            this.txtCodUser.TabIndex = 10;
            // 
            // btnSair
            // 
            this.btnSair.TabIndex = 14;
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Location = new System.Drawing.Point(738, 22);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(50, 17);
            this.chkAtivo.TabIndex = 6;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            this.chkAtivo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.chkBox);
            // 
            // txtCondPag
            // 
            this.txtCondPag.Location = new System.Drawing.Point(113, 58);
            this.txtCondPag.MaxLength = 50;
            this.txtCondPag.Name = "txtCondPag";
            this.txtCondPag.Size = new System.Drawing.Size(260, 20);
            this.txtCondPag.TabIndex = 2;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(110, 42);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(124, 13);
            this.lbl1.TabIndex = 51;
            this.lbl1.Text = "Condição de Pagamento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Dia de Pagamento";
            // 
            // txtTaxaJuro
            // 
            this.txtTaxaJuro.Location = new System.Drawing.Point(504, 58);
            this.txtTaxaJuro.MaxLength = 8;
            this.txtTaxaJuro.Name = "txtTaxaJuro";
            this.txtTaxaJuro.Size = new System.Drawing.Size(59, 20);
            this.txtTaxaJuro.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(501, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Taxa dos Juros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Tipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(593, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "Operação Disponível";
            // 
            // txtPorParcela
            // 
            this.txtPorParcela.Location = new System.Drawing.Point(251, 115);
            this.txtPorParcela.MaxLength = 1;
            this.txtPorParcela.Name = "txtPorParcela";
            this.txtPorParcela.Size = new System.Drawing.Size(63, 20);
            this.txtPorParcela.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(248, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 64;
            this.label7.Text = "Porc Parcela";
            // 
            // txtNumParc
            // 
            this.txtNumParc.Location = new System.Drawing.Point(35, 115);
            this.txtNumParc.MaxLength = 2;
            this.txtNumParc.Name = "txtNumParc";
            this.txtNumParc.Size = new System.Drawing.Size(47, 20);
            this.txtNumParc.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "Número de parcelas";
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(142, 115);
            this.txtDia.MaxLength = 10;
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(77, 20);
            this.txtDia.TabIndex = 8;
            // 
            // boxOpDisp
            // 
            this.boxOpDisp.FormattingEnabled = true;
            this.boxOpDisp.Items.AddRange(new object[] {
            "Compras",
            "Vendas",
            "Ambos"});
            this.boxOpDisp.Location = new System.Drawing.Point(596, 58);
            this.boxOpDisp.Name = "boxOpDisp";
            this.boxOpDisp.Size = new System.Drawing.Size(76, 21);
            this.boxOpDisp.TabIndex = 5;
            // 
            // boxTipo
            // 
            this.boxTipo.FormattingEnabled = true;
            this.boxTipo.Items.AddRange(new object[] {
            "Prazo",
            "Mensal"});
            this.boxTipo.Location = new System.Drawing.Point(391, 58);
            this.boxTipo.Name = "boxTipo";
            this.boxTipo.Size = new System.Drawing.Size(86, 21);
            this.boxTipo.TabIndex = 3;
            // 
            // FormCadCondicaoPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boxTipo);
            this.Controls.Add(this.boxOpDisp);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.txtNumParc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPorParcela);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTaxaJuro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkAtivo);
            this.Controls.Add(this.txtCondPag);
            this.Controls.Add(this.lbl1);
            this.Name = "FormCadCondicaoPagamento";
            this.Text = "Form Condição de Pagamento";
            this.Controls.SetChildIndex(this.lblCodUser, 0);
            this.Controls.SetChildIndex(this.txtCodUser, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.lblCod, 0);
            this.Controls.SetChildIndex(this.txtCod, 0);
            this.Controls.SetChildIndex(this.lblDataCad, 0);
            this.Controls.SetChildIndex(this.txtDataCad, 0);
            this.Controls.SetChildIndex(this.lblDataAlteracao, 0);
            this.Controls.SetChildIndex(this.txtDataAlt, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.lbl1, 0);
            this.Controls.SetChildIndex(this.txtCondPag, 0);
            this.Controls.SetChildIndex(this.chkAtivo, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtTaxaJuro, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtPorParcela, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtNumParc, 0);
            this.Controls.SetChildIndex(this.txtDia, 0);
            this.Controls.SetChildIndex(this.boxOpDisp, 0);
            this.Controls.SetChildIndex(this.boxTipo, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.TextBox txtCondPag;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTaxaJuro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPorParcela;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumParc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.ComboBox boxOpDisp;
        private System.Windows.Forms.ComboBox boxTipo;
    }
}
