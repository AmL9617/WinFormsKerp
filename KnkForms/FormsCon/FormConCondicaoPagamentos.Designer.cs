namespace KnkForms.Classes
{
    partial class FormConCondicaoPagamentos
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
            this.codCondPag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.condPag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.taxaJuros = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numParcelas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.operacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ativo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.porParcela = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataCadastro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataModificacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.codEmpresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listVConsulta
            // 
            this.listVConsulta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codCondPag,
            this.condPag,
            this.taxaJuros,
            this.numParcelas,
            this.tipo,
            this.dia,
            this.operacao,
            this.Ativo,
            this.porParcela,
            this.codEmpresa,
            this.dataCadastro,
            this.dataModificacao});
            // 
            // codCondPag
            // 
            this.codCondPag.Text = "Código Cond. Pag.";
            this.codCondPag.Width = 110;
            // 
            // condPag
            // 
            this.condPag.Text = "Condição de Pagamento";
            this.condPag.Width = 150;
            // 
            // taxaJuros
            // 
            this.taxaJuros.Text = "Taxa de Juros";
            this.taxaJuros.Width = 100;
            // 
            // numParcelas
            // 
            this.numParcelas.Text = "Número de Parcelas";
            this.numParcelas.Width = 120;
            // 
            // tipo
            // 
            this.tipo.Text = "Tipo";
            // 
            // dia
            // 
            this.dia.Text = "Dia";
            // 
            // operacao
            // 
            this.operacao.Text = "Operação Disp.";
            this.operacao.Width = 120;
            // 
            // Ativo
            // 
            this.Ativo.Text = "Ativo";
            // 
            // porParcela
            // 
            this.porParcela.Text = "Código Parcela";
            this.porParcela.Width = 100;
            // 
            // dataCadastro
            // 
            this.dataCadastro.Text = "Data de Cadastro";
            this.dataCadastro.Width = 100;
            // 
            // dataModificacao
            // 
            this.dataModificacao.Text = "Data de Modificação";
            this.dataModificacao.Width = 100;
            // 
            // codEmpresa
            // 
            this.codEmpresa.Text = "Código Empresa";
            this.codEmpresa.Width = 100;
            // 
            // FormConCondicaoPagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FormConCondicaoPagamentos";
            this.Text = "Form Condição de Pagamentos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader codCondPag;
        private System.Windows.Forms.ColumnHeader condPag;
        private System.Windows.Forms.ColumnHeader taxaJuros;
        private System.Windows.Forms.ColumnHeader numParcelas;
        private System.Windows.Forms.ColumnHeader tipo;
        private System.Windows.Forms.ColumnHeader dia;
        private System.Windows.Forms.ColumnHeader operacao;
        private System.Windows.Forms.ColumnHeader Ativo;
        private System.Windows.Forms.ColumnHeader porParcela;
        private System.Windows.Forms.ColumnHeader dataCadastro;
        private System.Windows.Forms.ColumnHeader dataModificacao;
        private System.Windows.Forms.ColumnHeader codEmpresa;
    }
}
