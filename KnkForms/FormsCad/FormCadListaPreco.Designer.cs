﻿namespace KnkForms.Forms
{
    partial class FormCadListaPreco
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
            this.txtNomeLista = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtDescMax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMargemLucro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdGrupo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtNomeLista
            // 
            this.txtNomeLista.Location = new System.Drawing.Point(160, 58);
            this.txtNomeLista.Name = "txtNomeLista";
            this.txtNomeLista.Size = new System.Drawing.Size(100, 20);
            this.txtNomeLista.TabIndex = 52;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(157, 42);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(75, 13);
            this.lbl1.TabIndex = 51;
            this.lbl1.Text = "Nome da Lista";
            // 
            // txtDescMax
            // 
            this.txtDescMax.Location = new System.Drawing.Point(290, 58);
            this.txtDescMax.Name = "txtDescMax";
            this.txtDescMax.Size = new System.Drawing.Size(100, 20);
            this.txtDescMax.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Desconto Máximo";
            // 
            // txtMargemLucro
            // 
            this.txtMargemLucro.Location = new System.Drawing.Point(414, 58);
            this.txtMargemLucro.Name = "txtMargemLucro";
            this.txtMargemLucro.Size = new System.Drawing.Size(100, 20);
            this.txtMargemLucro.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Margem de Lucro";
            // 
            // txtIdMarca
            // 
            this.txtIdMarca.Location = new System.Drawing.Point(537, 58);
            this.txtIdMarca.Name = "txtIdMarca";
            this.txtIdMarca.Size = new System.Drawing.Size(100, 20);
            this.txtIdMarca.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(534, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Id Marca";
            // 
            // txtIdGrupo
            // 
            this.txtIdGrupo.Location = new System.Drawing.Point(660, 58);
            this.txtIdGrupo.Name = "txtIdGrupo";
            this.txtIdGrupo.Size = new System.Drawing.Size(100, 20);
            this.txtIdGrupo.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(657, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Id Grupo";
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Location = new System.Drawing.Point(35, 106);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(56, 17);
            this.chkAtivo.TabIndex = 63;
            this.chkAtivo.Text = "Todas";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // FormCadListaPreco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkAtivo);
            this.Controls.Add(this.txtIdGrupo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIdMarca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMargemLucro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescMax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeLista);
            this.Controls.Add(this.lbl1);
            this.Name = "FormCadListaPreco";
            this.Text = "Form Lista de Preços";
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.lblId, 0);
            this.Controls.SetChildIndex(this.txtId, 0);
            this.Controls.SetChildIndex(this.lblDataCad, 0);
            this.Controls.SetChildIndex(this.txtDataCad, 0);
            this.Controls.SetChildIndex(this.lblDataAlteracao, 0);
            this.Controls.SetChildIndex(this.txtDataAlt, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.lbl1, 0);
            this.Controls.SetChildIndex(this.txtNomeLista, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtDescMax, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtMargemLucro, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtIdMarca, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtIdGrupo, 0);
            this.Controls.SetChildIndex(this.chkAtivo, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeLista;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtDescMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMargemLucro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdGrupo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkAtivo;
    }
}