﻿namespace KnkForms.FormsCad
{
    partial class FormCadRamoAtivCliente
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
            this.btnConsulta = new System.Windows.Forms.Button();
            this.txtCodCliForn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrioridade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeCliForn = new System.Windows.Forms.TextBox();
            this.btnRamoAtiv = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeRamo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCod
            // 
            this.txtCod.Enabled = false;
            // 
            // txtDataCad
            // 
            this.txtDataCad.Enabled = false;
            // 
            // txtDataAlt
            // 
            this.txtDataAlt.Enabled = false;
            // 
            // txtCodUser
            // 
            this.txtCodUser.Enabled = false;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(681, 56);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(24, 23);
            this.btnConsulta.TabIndex = 3;
            this.btnConsulta.Text = "⌕";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // txtCodCliForn
            // 
            this.txtCodCliForn.Enabled = false;
            this.txtCodCliForn.Location = new System.Drawing.Point(370, 58);
            this.txtCodCliForn.MaxLength = 100;
            this.txtCodCliForn.Name = "txtCodCliForn";
            this.txtCodCliForn.Size = new System.Drawing.Size(307, 20);
            this.txtCodCliForn.TabIndex = 66;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(367, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 67;
            this.label7.Text = "Cliente/Fornecedor";
            // 
            // txtPrioridade
            // 
            this.txtPrioridade.Location = new System.Drawing.Point(35, 119);
            this.txtPrioridade.MaxLength = 5;
            this.txtPrioridade.Name = "txtPrioridade";
            this.txtPrioridade.Size = new System.Drawing.Size(63, 20);
            this.txtPrioridade.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "Prioridade";
            // 
            // txtNomeCliForn
            // 
            this.txtNomeCliForn.Enabled = false;
            this.txtNomeCliForn.Location = new System.Drawing.Point(370, 58);
            this.txtNomeCliForn.MaxLength = 100;
            this.txtNomeCliForn.Name = "txtNomeCliForn";
            this.txtNomeCliForn.Size = new System.Drawing.Size(307, 20);
            this.txtNomeCliForn.TabIndex = 70;
            // 
            // btnRamoAtiv
            // 
            this.btnRamoAtiv.Location = new System.Drawing.Point(324, 56);
            this.btnRamoAtiv.Name = "btnRamoAtiv";
            this.btnRamoAtiv.Size = new System.Drawing.Size(24, 23);
            this.btnRamoAtiv.TabIndex = 71;
            this.btnRamoAtiv.Text = "⌕";
            this.btnRamoAtiv.UseVisualStyleBackColor = true;
            this.btnRamoAtiv.Click += new System.EventHandler(this.btnRamoAtiv_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "Ramo de Atividades";
            // 
            // txtNomeRamo
            // 
            this.txtNomeRamo.Enabled = false;
            this.txtNomeRamo.Location = new System.Drawing.Point(125, 57);
            this.txtNomeRamo.MaxLength = 30;
            this.txtNomeRamo.Name = "txtNomeRamo";
            this.txtNomeRamo.Size = new System.Drawing.Size(197, 20);
            this.txtNomeRamo.TabIndex = 74;
            // 
            // FormCadRamoAtivCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNomeRamo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRamoAtiv);
            this.Controls.Add(this.txtNomeCliForn);
            this.Controls.Add(this.txtPrioridade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.txtCodCliForn);
            this.Controls.Add(this.label7);
            this.Name = "FormCadRamoAtivCliente";
            this.Text = "Form Ramo de Atividades do Cliente";
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
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtCodCliForn, 0);
            this.Controls.SetChildIndex(this.btnConsulta, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtPrioridade, 0);
            this.Controls.SetChildIndex(this.txtNomeCliForn, 0);
            this.Controls.SetChildIndex(this.btnRamoAtiv, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtNomeRamo, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.TextBox txtCodCliForn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrioridade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeCliForn;
        private System.Windows.Forms.Button btnRamoAtiv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeRamo;
    }
}
