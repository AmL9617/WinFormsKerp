namespace KnkForms.Forms
{
    partial class FormCadFormaPagamento
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
            this.txtNomePagamento = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtOpDisp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNfce = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNomePagamento
            // 
            this.txtNomePagamento.Location = new System.Drawing.Point(35, 120);
            this.txtNomePagamento.Name = "txtNomePagamento";
            this.txtNomePagamento.Size = new System.Drawing.Size(100, 20);
            this.txtNomePagamento.TabIndex = 52;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(32, 104);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(107, 13);
            this.lbl1.TabIndex = 51;
            this.lbl1.Text = "Nome do Pagamento";
            // 
            // txtOpDisp
            // 
            this.txtOpDisp.Location = new System.Drawing.Point(165, 120);
            this.txtOpDisp.Name = "txtOpDisp";
            this.txtOpDisp.Size = new System.Drawing.Size(100, 20);
            this.txtOpDisp.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Operação Disponível";
            // 
            // txtNfce
            // 
            this.txtNfce.Location = new System.Drawing.Point(289, 120);
            this.txtNfce.Name = "txtNfce";
            this.txtNfce.Size = new System.Drawing.Size(100, 20);
            this.txtNfce.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "NFC-E";
            // 
            // FormFormaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNfce);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOpDisp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomePagamento);
            this.Controls.Add(this.lbl1);
            this.Name = "FormFormaPagamento";
            this.Controls.SetChildIndex(this.lblId, 0);
            this.Controls.SetChildIndex(this.txtId, 0);
            this.Controls.SetChildIndex(this.lblIdEmp, 0);
            this.Controls.SetChildIndex(this.txtIdEmp, 0);
            this.Controls.SetChildIndex(this.lblDataCad, 0);
            this.Controls.SetChildIndex(this.txtDataCad, 0);
            this.Controls.SetChildIndex(this.lblDataAlteracao, 0);
            this.Controls.SetChildIndex(this.txtDataAlt, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.lbl1, 0);
            this.Controls.SetChildIndex(this.txtNomePagamento, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtOpDisp, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtNfce, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNomePagamento;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtOpDisp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNfce;
        private System.Windows.Forms.Label label2;
    }
}
