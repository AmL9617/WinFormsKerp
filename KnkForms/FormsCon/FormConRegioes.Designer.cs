namespace KnkForms.Classes
{
    partial class FormConRegioes
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
            this.codRegiao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.regiao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ativo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.codigoUsuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.codEmpresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataCadastro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataModificacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listVConsulta
            // 
            this.listVConsulta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codRegiao,
            this.regiao,
            this.descricao,
            this.ativo,
            this.codigoUsuario,
            this.codEmpresa,
            this.dataCadastro,
            this.dataModificacao});
            // 
            // codRegiao
            // 
            this.codRegiao.Text = "Código Região";
            this.codRegiao.Width = 100;
            // 
            // regiao
            // 
            this.regiao.Text = "Região";
            this.regiao.Width = 80;
            // 
            // descricao
            // 
            this.descricao.Text = "Descrição";
            this.descricao.Width = 150;
            // 
            // ativo
            // 
            this.ativo.Text = "Ativo";
            // 
            // codigoUsuario
            // 
            this.codigoUsuario.Text = "Código Usuário";
            this.codigoUsuario.Width = 100;
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
            // FormConRegioes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FormConRegioes";
            this.Text = "Form Regiões";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader codRegiao;
        private System.Windows.Forms.ColumnHeader regiao;
        private System.Windows.Forms.ColumnHeader descricao;
        private System.Windows.Forms.ColumnHeader ativo;
        private System.Windows.Forms.ColumnHeader codigoUsuario;
        private System.Windows.Forms.ColumnHeader codEmpresa;
        private System.Windows.Forms.ColumnHeader dataCadastro;
        private System.Windows.Forms.ColumnHeader dataModificacao;
    }
}
