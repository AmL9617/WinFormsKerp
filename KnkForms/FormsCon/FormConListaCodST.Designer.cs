namespace KnkForms.FormsCon
{
    partial class FormConListaCodST
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
            this.codListaCST = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.desc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ativo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.codEmp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listVConsulta
            // 
            this.listVConsulta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codListaCST,
            this.tipo,
            this.desc,
            this.ativo,
            this.codEmp});
            // 
            // codListaCST
            // 
            this.codListaCST.Text = "Código Lista CST";
            this.codListaCST.Width = 120;
            // 
            // tipo
            // 
            this.tipo.Text = "Tipo";
            // 
            // desc
            // 
            this.desc.Text = "Descrição";
            this.desc.Width = 100;
            // 
            // ativo
            // 
            this.ativo.Text = "Ativo";
            // 
            // codEmp
            // 
            this.codEmp.Text = "Código Empresa";
            this.codEmp.Width = 100;
            // 
            // FormConListaCodST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FormConListaCodST";
            this.Text = " Form Lista de Códigos ST";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader codListaCST;
        private System.Windows.Forms.ColumnHeader tipo;
        private System.Windows.Forms.ColumnHeader desc;
        private System.Windows.Forms.ColumnHeader ativo;
        private System.Windows.Forms.ColumnHeader codEmp;
    }
}
