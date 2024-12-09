namespace KnkForms.FormsCon
{
    partial class FormConRamoAtividades
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
            this.codRamo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ativo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.codEmp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataCad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataAlt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listVConsulta
            // 
            this.listVConsulta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codRamo,
            this.nome,
            this.ativo,
            this.codEmp,
            this.dataCad,
            this.dataAlt});
            // 
            // codRamo
            // 
            this.codRamo.Text = "Código";
            // 
            // nome
            // 
            this.nome.Text = "Ramo de Atividade";
            this.nome.Width = 120;
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
            // dataCad
            // 
            this.dataCad.Text = "Data de Cadastro";
            this.dataCad.Width = 100;
            // 
            // dataAlt
            // 
            this.dataAlt.Text = "Data de Alteração";
            this.dataAlt.Width = 100;
            // 
            // FormConRamoAtividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FormConRamoAtividades";
            this.Text = "Form Ramo de Atividades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader codRamo;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader ativo;
        private System.Windows.Forms.ColumnHeader codEmp;
        private System.Windows.Forms.ColumnHeader dataCad;
        private System.Windows.Forms.ColumnHeader dataAlt;
    }
}
