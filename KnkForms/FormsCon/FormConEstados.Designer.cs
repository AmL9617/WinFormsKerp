﻿namespace KnkForms.Classes
{
    partial class FormConEstados
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
            this.codEstado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pais = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.estado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sigla = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.percICMS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.icms = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.percRedST = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.codWeb = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataCadastro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataModificacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.codEmp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listVConsulta
            // 
            this.listVConsulta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codEstado,
            this.estado,
            this.pais,
            this.sigla,
            this.percICMS,
            this.icms,
            this.percRedST,
            this.codWeb,
            this.codEmp,
            this.dataCadastro,
            this.dataModificacao});
            this.listVConsulta.DoubleClick += new System.EventHandler(this.listV_DoubleClick);
            // 
            // codEstado
            // 
            this.codEstado.Text = "Código Estado";
            this.codEstado.Width = 100;
            // 
            // pais
            // 
            this.pais.Text = "País";
            this.pais.Width = 100;
            // 
            // estado
            // 
            this.estado.Text = "Estado";
            this.estado.Width = 100;
            // 
            // sigla
            // 
            this.sigla.Text = "Sigla";
            this.sigla.Width = 50;
            // 
            // percICMS
            // 
            this.percICMS.Text = "Percentual ICMS";
            this.percICMS.Width = 100;
            // 
            // icms
            // 
            this.icms.Text = "ICMS";
            // 
            // percRedST
            // 
            this.percRedST.Text = "Perc. Redução S.T.";
            this.percRedST.Width = 100;
            // 
            // codWeb
            // 
            this.codWeb.Text = "Código Web";
            this.codWeb.Width = 80;
            // 
            // dataCadastro
            // 
            this.dataCadastro.Text = "Data de Cadastro";
            this.dataCadastro.Width = 100;
            // 
            // dataModificacao
            // 
            this.dataModificacao.Text = "Data de Modificacao";
            this.dataModificacao.Width = 100;
            // 
            // codEmp
            // 
            this.codEmp.Text = "Código Empresa";
            this.codEmp.Width = 100;
            // 
            // FormConEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FormConEstados";
            this.Text = "Form Estados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader codEstado;
        private System.Windows.Forms.ColumnHeader pais;
        private System.Windows.Forms.ColumnHeader estado;
        private System.Windows.Forms.ColumnHeader sigla;
        private System.Windows.Forms.ColumnHeader percICMS;
        private System.Windows.Forms.ColumnHeader icms;
        private System.Windows.Forms.ColumnHeader percRedST;
        private System.Windows.Forms.ColumnHeader codWeb;
        private System.Windows.Forms.ColumnHeader codEmp;
        private System.Windows.Forms.ColumnHeader dataCadastro;
        private System.Windows.Forms.ColumnHeader dataModificacao;
    }
}
