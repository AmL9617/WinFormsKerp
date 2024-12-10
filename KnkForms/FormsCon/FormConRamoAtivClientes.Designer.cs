namespace KnkForms.FormsCon
{
    partial class FormConRamoAtivClientes
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
            this.codRamo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ramo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cliForn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prioridade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.codEmp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listVConsulta
            // 
            this.listVConsulta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codRamo,
            this.ramo,
            this.cliForn,
            this.prioridade,
            this.codEmp});
            // 
            // codRamo
            // 
            this.codRamo.Text = "Código Ramo";
            this.codRamo.Width = 100;
            // 
            // ramo
            // 
            this.ramo.Text = "Ramo de Atividade";
            this.ramo.Width = 120;
            // 
            // cliForn
            // 
            this.cliForn.Text = "Cliente";
            this.cliForn.Width = 100;
            // 
            // prioridade
            // 
            this.prioridade.Text = "Prioridade";
            this.prioridade.Width = 100;
            // 
            // codEmp
            // 
            this.codEmp.Text = "Código Empresa";
            this.codEmp.Width = 100;
            // 
            // FormConRamoAtivClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FormConRamoAtivClientes";
            this.Text = "Form Ramo de Atividades dos Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader codRamo;
        private System.Windows.Forms.ColumnHeader ramo;
        private System.Windows.Forms.ColumnHeader cliForn;
        private System.Windows.Forms.ColumnHeader prioridade;
        private System.Windows.Forms.ColumnHeader codEmp;
    }
}
