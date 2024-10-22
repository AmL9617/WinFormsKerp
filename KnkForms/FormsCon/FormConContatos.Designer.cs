namespace KnkForms.FormsCon
{
    partial class FormConContatos
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
            this.codContato = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.codFornCli = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contato = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.observacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.codEmp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listVConsulta
            // 
            this.listVConsulta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codContato,
            this.codFornCli,
            this.tipo,
            this.contato,
            this.observacao,
            this.codEmp});
            // 
            // codContato
            // 
            this.codContato.Text = "Código Contato";
            this.codContato.Width = 100;
            // 
            // codFornCli
            // 
            this.codFornCli.Text = "Código Fornecedor/Cliente";
            this.codFornCli.Width = 100;
            // 
            // tipo
            // 
            this.tipo.Text = "Tipo";
            // 
            // contato
            // 
            this.contato.Text = "Contato";
            this.contato.Width = 150;
            // 
            // observacao
            // 
            this.observacao.Text = "Observacao";
            this.observacao.Width = 150;
            // 
            // codEmp
            // 
            this.codEmp.Text = "Código Empresa";
            this.codEmp.Width = 100;
            // 
            // FormConContatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FormConContatos";
            this.Text = "Form Contatos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader codContato;
        private System.Windows.Forms.ColumnHeader codFornCli;
        private System.Windows.Forms.ColumnHeader tipo;
        private System.Windows.Forms.ColumnHeader contato;
        private System.Windows.Forms.ColumnHeader observacao;
        private System.Windows.Forms.ColumnHeader codEmp;
    }
}
