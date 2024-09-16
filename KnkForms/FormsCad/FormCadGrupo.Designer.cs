namespace KnkForms.Forms
{
    partial class FormCadGrupo
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
            this.txtNomeGrupo = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Location = new System.Drawing.Point(165, 119);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(50, 17);
            this.chkAtivo.TabIndex = 53;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // txtNomeGrupo
            // 
            this.txtNomeGrupo.Location = new System.Drawing.Point(35, 119);
            this.txtNomeGrupo.Name = "txtNomeGrupo";
            this.txtNomeGrupo.Size = new System.Drawing.Size(100, 20);
            this.txtNomeGrupo.TabIndex = 52;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(32, 103);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(82, 13);
            this.lbl1.TabIndex = 51;
            this.lbl1.Text = "Nome do Grupo";
            // 
            // FormGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkAtivo);
            this.Controls.Add(this.txtNomeGrupo);
            this.Controls.Add(this.lbl1);
            this.Name = "FormGrupo";
            this.Text = "Form Grupo";
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
            this.Controls.SetChildIndex(this.txtNomeGrupo, 0);
            this.Controls.SetChildIndex(this.chkAtivo, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.TextBox txtNomeGrupo;
        private System.Windows.Forms.Label lbl1;
    }
}
