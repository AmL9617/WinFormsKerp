namespace KnkForms.FormsCon
{
    partial class FormConCidades
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
            this.codCidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.codEstado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ddd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ativo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.codEmpresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataCadastro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataModificacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listVConsulta
            // 
            this.listVConsulta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codCidade,
            this.codEstado,
            this.cidade,
            this.ddd,
            this.ativo,
            this.codEmpresa,
            this.dataCadastro,
            this.dataModificacao});
            // 
            // codCidade
            // 
            this.codCidade.Text = "Código Cidade";
            this.codCidade.Width = 100;
            // 
            // codEstado
            // 
            this.codEstado.Text = "Código Estado";
            this.codEstado.Width = 100;
            // 
            // cidade
            // 
            this.cidade.Text = "Cidade";
            this.cidade.Width = 150;
            // 
            // ddd
            // 
            this.ddd.Text = "DDD";
            // 
            // ativo
            // 
            this.ativo.Text = "Ativo";
            // 
            // codEmpresa
            // 
            this.codEmpresa.Text = "Código Empresa";
            this.codEmpresa.Width = 100;
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
            // FormConCidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FormConCidades";
            this.Text = "Form Cidades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader codCidade;
        private System.Windows.Forms.ColumnHeader codEstado;
        private System.Windows.Forms.ColumnHeader cidade;
        private System.Windows.Forms.ColumnHeader ddd;
        private System.Windows.Forms.ColumnHeader ativo;
        private System.Windows.Forms.ColumnHeader codEmpresa;
        private System.Windows.Forms.ColumnHeader dataCadastro;
        private System.Windows.Forms.ColumnHeader dataModificacao;
    }
}
