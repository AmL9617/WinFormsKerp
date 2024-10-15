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
            this.txtFormaPagamento = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtOpDisp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNfce = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDataCad
            // 
            this.txtDataCad.TabIndex = 6;
            // 
            // txtCodUser
            // 
            this.txtCodUser.TabIndex = 5;
            // 
            // txtFormaPagamento
            // 
            this.txtFormaPagamento.Location = new System.Drawing.Point(114, 58);
            this.txtFormaPagamento.MaxLength = 30;
            this.txtFormaPagamento.Name = "txtFormaPagamento";
            this.txtFormaPagamento.Size = new System.Drawing.Size(197, 20);
            this.txtFormaPagamento.TabIndex = 2;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(111, 42);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(108, 13);
            this.lbl1.TabIndex = 51;
            this.lbl1.Text = "Forma de Pagamento";
            // 
            // txtOpDisp
            // 
            this.txtOpDisp.Location = new System.Drawing.Point(326, 58);
            this.txtOpDisp.MaxLength = 30;
            this.txtOpDisp.Name = "txtOpDisp";
            this.txtOpDisp.Size = new System.Drawing.Size(197, 20);
            this.txtOpDisp.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Operação Disponível";
            // 
            // txtNfce
            // 
            this.txtNfce.Location = new System.Drawing.Point(540, 58);
            this.txtNfce.MaxLength = 9;
            this.txtNfce.Name = "txtNfce";
            this.txtNfce.Size = new System.Drawing.Size(113, 20);
            this.txtNfce.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(537, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "NFC-E";
            // 
            // FormCadFormaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNfce);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOpDisp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFormaPagamento);
            this.Controls.Add(this.lbl1);
            this.Name = "FormCadFormaPagamento";
            this.Text = "Form Forma de Pagamento";
            this.Controls.SetChildIndex(this.lblCodUser, 0);
            this.Controls.SetChildIndex(this.txtCodUser, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.lblCod, 0);
            this.Controls.SetChildIndex(this.txtCod, 0);
            this.Controls.SetChildIndex(this.lblDataCad, 0);
            this.Controls.SetChildIndex(this.txtDataCad, 0);
            this.Controls.SetChildIndex(this.lblDataAlteracao, 0);
            this.Controls.SetChildIndex(this.txtDataAlt, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.lbl1, 0);
            this.Controls.SetChildIndex(this.txtFormaPagamento, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtOpDisp, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtNfce, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFormaPagamento;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtOpDisp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNfce;
        private System.Windows.Forms.Label label2;
    }
}
