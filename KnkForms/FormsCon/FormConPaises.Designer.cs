namespace KnkForms.FormsCon
{
    partial class FormConPaises
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
            this.CodPais = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pais = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sigla = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nacional = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.codEmp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataCad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataMod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ddi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ativo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listVConsulta
            // 
            this.listVConsulta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CodPais,
            this.Pais,
            this.Sigla,
            this.ddi,
            this.Nacional,
            this.ativo,
            this.codEmp,
            this.DataCad,
            this.dataMod});
            // 
            // CodPais
            // 
            this.CodPais.Text = "Código País";
            this.CodPais.Width = 120;
            // 
            // Pais
            // 
            this.Pais.Text = "País";
            // 
            // Sigla
            // 
            this.Sigla.Text = "Sigla";
            // 
            // Nacional
            // 
            this.Nacional.Text = "É nacional?";
            this.Nacional.Width = 100;
            // 
            // codEmp
            // 
            this.codEmp.Text = "Código Empresa";
            this.codEmp.Width = 120;
            // 
            // DataCad
            // 
            this.DataCad.Text = "DataCadastro";
            this.DataCad.Width = 100;
            // 
            // dataMod
            // 
            this.dataMod.Text = "Data Modificação";
            this.dataMod.Width = 100;
            // 
            // ddi
            // 
            this.ddi.Text = "DDI";
            // 
            // ativo
            // 
            this.ativo.Text = "Ativo";
            // 
            // FormConPaises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FormConPaises";
            this.Text = "Form Países";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader CodPais;
        private System.Windows.Forms.ColumnHeader Pais;
        private System.Windows.Forms.ColumnHeader Sigla;
        private System.Windows.Forms.ColumnHeader Nacional;
        private System.Windows.Forms.ColumnHeader codEmp;
        private System.Windows.Forms.ColumnHeader DataCad;
        private System.Windows.Forms.ColumnHeader dataMod;
        private System.Windows.Forms.ColumnHeader ddi;
        private System.Windows.Forms.ColumnHeader ativo;
    }
}
