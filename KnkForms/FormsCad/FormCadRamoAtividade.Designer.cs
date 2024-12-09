namespace KnkForms.Forms
{
    partial class FormCadRamoAtividade
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
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.txtNomeRamo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCod
            // 
            this.txtCod.Enabled = false;
            // 
            // txtDataCad
            // 
            this.txtDataCad.Enabled = false;
            this.txtDataCad.TabIndex = 8;
            // 
            // txtDataAlt
            // 
            this.txtDataAlt.Enabled = false;
            this.txtDataAlt.TabIndex = 9;
            // 
            // btnSalvar
            // 
            this.btnSalvar.TabIndex = 10;
            // 
            // txtCodUser
            // 
            this.txtCodUser.Enabled = false;
            this.txtCodUser.TabIndex = 7;
            // 
            // btnSair
            // 
            this.btnSair.TabIndex = 11;
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Location = new System.Drawing.Point(726, 26);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(50, 17);
            this.chkAtivo.TabIndex = 4;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            this.chkAtivo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.chkBox);
            // 
            // txtNomeRamo
            // 
            this.txtNomeRamo.Location = new System.Drawing.Point(124, 58);
            this.txtNomeRamo.MaxLength = 30;
            this.txtNomeRamo.Name = "txtNomeRamo";
            this.txtNomeRamo.Size = new System.Drawing.Size(197, 20);
            this.txtNomeRamo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Ramo de Atividade";
            // 
            // FormCadRamoAtividade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkAtivo);
            this.Controls.Add(this.txtNomeRamo);
            this.Controls.Add(this.label1);
            this.Name = "FormCadRamoAtividade";
            this.Text = "Form Ramo de Atividades";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.chkBox);
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
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtNomeRamo, 0);
            this.Controls.SetChildIndex(this.chkAtivo, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.TextBox txtNomeRamo;
        private System.Windows.Forms.Label label1;
    }
}
