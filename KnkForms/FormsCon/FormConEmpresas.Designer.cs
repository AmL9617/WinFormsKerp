namespace KnkForms.Classes
{
    partial class FormConEmpresas
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
            this.codEmp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.razaoSocial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nomeFantasia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cnpj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.codCidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listVConsulta
            // 
            this.listVConsulta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codEmp,
            this.razaoSocial,
            this.nomeFantasia,
            this.cnpj,
            this.codCidade});
            // 
            // codEmp
            // 
            this.codEmp.Text = "Código Empresa";
            this.codEmp.Width = 100;
            // 
            // razaoSocial
            // 
            this.razaoSocial.Text = "Razão Social";
            this.razaoSocial.Width = 100;
            // 
            // nomeFantasia
            // 
            this.nomeFantasia.Text = "Nome Fantasia";
            this.nomeFantasia.Width = 100;
            // 
            // cnpj
            // 
            this.cnpj.Text = "Cnpj";
            // 
            // codCidade
            // 
            this.codCidade.Text = "Código Cidade";
            this.codCidade.Width = 100;
            // 
            // FormConEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FormConEmpresas";
            this.Text = "Form Empresas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader codEmp;
        private System.Windows.Forms.ColumnHeader razaoSocial;
        private System.Windows.Forms.ColumnHeader nomeFantasia;
        private System.Windows.Forms.ColumnHeader cnpj;
        private System.Windows.Forms.ColumnHeader codCidade;
    }
}
