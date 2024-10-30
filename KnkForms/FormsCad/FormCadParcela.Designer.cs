namespace KnkForms.Forms
{
    partial class FormCadParcela
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
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDataCad
            // 
            this.txtDataCad.Location = new System.Drawing.Point(184, 330);
            // 
            // lblDataCad
            // 
            this.lblDataCad.Location = new System.Drawing.Point(181, 314);
            // 
            // txtDataAlt
            // 
            this.txtDataAlt.Location = new System.Drawing.Point(307, 330);
            this.txtDataAlt.TabIndex = 6;
            // 
            // lblDataAlteracao
            // 
            this.lblDataAlteracao.Location = new System.Drawing.Point(304, 314);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(519, 326);
            this.btnSalvar.TabIndex = 7;
            // 
            // txtCodUser
            // 
            this.txtCodUser.Location = new System.Drawing.Point(72, 330);
            this.txtCodUser.TabIndex = 4;
            // 
            // lblCodUser
            // 
            this.lblCodUser.Location = new System.Drawing.Point(69, 314);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(614, 326);
            this.btnSair.TabIndex = 8;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(249, 58);
            this.txtValor.MaxLength = 8;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(68, 20);
            this.txtValor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Valor";
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(118, 58);
            this.txtQtd.MaxLength = 8;
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(90, 20);
            this.txtQtd.TabIndex = 2;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(115, 42);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(116, 13);
            this.lbl1.TabIndex = 51;
            this.lbl1.Text = "Quantidade da Parcela";
            // 
            // FormCadParcela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(717, 376);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.lbl1);
            this.Name = "FormCadParcela";
            this.Text = "Form Parcela";
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
            this.Controls.SetChildIndex(this.txtQtd, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtValor, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Label lbl1;
    }
}
