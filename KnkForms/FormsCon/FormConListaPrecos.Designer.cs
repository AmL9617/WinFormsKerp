namespace KnkForms.FormsCon
{
    partial class FormConListaPrecos
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
            this.codLista = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Lista = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descMax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.margemLucro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.perComissão = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.codEmp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.todas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataCad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataModif = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listVConsulta
            // 
            this.listVConsulta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codLista,
            this.Lista,
            this.descMax,
            this.margemLucro,
            this.perComissão,
            this.todas,
            this.codEmp,
            this.dataCad,
            this.dataModif});
            this.listVConsulta.DoubleClick += new System.EventHandler(this.listV_DoubleClick);
            // 
            // codLista
            // 
            this.codLista.Text = "Código Lista";
            this.codLista.Width = 100;
            // 
            // Lista
            // 
            this.Lista.Text = "Lista de Preços";
            this.Lista.Width = 100;
            // 
            // descMax
            // 
            this.descMax.Text = "Desconto Máximo";
            this.descMax.Width = 100;
            // 
            // margemLucro
            // 
            this.margemLucro.Text = "Margem do Lucro";
            this.margemLucro.Width = 100;
            // 
            // perComissão
            // 
            this.perComissão.Text = "Per. de Comissão";
            this.perComissão.Width = 100;
            // 
            // codEmp
            // 
            this.codEmp.Text = "Código Empresa";
            this.codEmp.Width = 100;
            // 
            // todas
            // 
            this.todas.Text = "Todas";
            // 
            // dataCad
            // 
            this.dataCad.Text = "Data Cadastro";
            this.dataCad.Width = 100;
            // 
            // dataModif
            // 
            this.dataModif.Text = "Data Modificação";
            this.dataModif.Width = 100;
            // 
            // FormConListaPrecos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FormConListaPrecos";
            this.Text = "Form Lista de Preços";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader codLista;
        private System.Windows.Forms.ColumnHeader Lista;
        private System.Windows.Forms.ColumnHeader descMax;
        private System.Windows.Forms.ColumnHeader margemLucro;
        private System.Windows.Forms.ColumnHeader perComissão;
        private System.Windows.Forms.ColumnHeader codEmp;
        private System.Windows.Forms.ColumnHeader todas;
        private System.Windows.Forms.ColumnHeader dataCad;
        private System.Windows.Forms.ColumnHeader dataModif;
    }
}
