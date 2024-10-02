namespace KnkForms
{
    partial class FormCadPai
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
            this.lblCod = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtDataCad = new System.Windows.Forms.TextBox();
            this.lblDataCad = new System.Windows.Forms.Label();
            this.txtDataAlt = new System.Windows.Forms.TextBox();
            this.lblDataAlteracao = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtCodUser = new System.Windows.Forms.TextBox();
            this.lblCodUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(32, 42);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(40, 13);
            this.lblCod.TabIndex = 0;
            this.lblCod.Text = "Código";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(35, 58);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(63, 20);
            this.txtCod.TabIndex = 1;
            // 
            // txtDataCad
            // 
            this.txtDataCad.Location = new System.Drawing.Point(276, 418);
            this.txtDataCad.Name = "txtDataCad";
            this.txtDataCad.Size = new System.Drawing.Size(87, 20);
            this.txtDataCad.TabIndex = 5;
            // 
            // lblDataCad
            // 
            this.lblDataCad.AutoSize = true;
            this.lblDataCad.Location = new System.Drawing.Point(273, 402);
            this.lblDataCad.Name = "lblDataCad";
            this.lblDataCad.Size = new System.Drawing.Size(90, 13);
            this.lblDataCad.TabIndex = 4;
            this.lblDataCad.Text = "Data de Cadastro";
            // 
            // txtDataAlt
            // 
            this.txtDataAlt.Location = new System.Drawing.Point(399, 418);
            this.txtDataAlt.Name = "txtDataAlt";
            this.txtDataAlt.Size = new System.Drawing.Size(92, 20);
            this.txtDataAlt.TabIndex = 7;
            // 
            // lblDataAlteracao
            // 
            this.lblDataAlteracao.AutoSize = true;
            this.lblDataAlteracao.Location = new System.Drawing.Point(396, 402);
            this.lblDataAlteracao.Name = "lblDataAlteracao";
            this.lblDataAlteracao.Size = new System.Drawing.Size(93, 13);
            this.lblDataAlteracao.TabIndex = 6;
            this.lblDataAlteracao.Text = "Data de Alteração";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(611, 414);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(82, 24);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtCodUser
            // 
            this.txtCodUser.Location = new System.Drawing.Point(164, 418);
            this.txtCodUser.Name = "txtCodUser";
            this.txtCodUser.Size = new System.Drawing.Size(59, 20);
            this.txtCodUser.TabIndex = 11;
            // 
            // lblCodUser
            // 
            this.lblCodUser.AutoSize = true;
            this.lblCodUser.Location = new System.Drawing.Point(161, 402);
            this.lblCodUser.Name = "lblCodUser";
            this.lblCodUser.Size = new System.Drawing.Size(79, 13);
            this.lblCodUser.TabIndex = 10;
            this.lblCodUser.Text = "Código Usuário";
            // 
            // FormCadPai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCodUser);
            this.Controls.Add(this.lblCodUser);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtDataAlt);
            this.Controls.Add(this.lblDataAlteracao);
            this.Controls.Add(this.txtDataCad);
            this.Controls.Add(this.lblDataCad);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.lblCod);
            this.Name = "FormCadPai";
            this.Text = "Form Pai";
            this.Controls.SetChildIndex(this.lblCod, 0);
            this.Controls.SetChildIndex(this.txtCod, 0);
            this.Controls.SetChildIndex(this.lblDataCad, 0);
            this.Controls.SetChildIndex(this.txtDataCad, 0);
            this.Controls.SetChildIndex(this.lblDataAlteracao, 0);
            this.Controls.SetChildIndex(this.txtDataAlt, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.lblCodUser, 0);
            this.Controls.SetChildIndex(this.txtCodUser, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txtCod;
        public System.Windows.Forms.Label lblCod;
        public System.Windows.Forms.TextBox txtDataCad;
        public System.Windows.Forms.Label lblDataCad;
        public System.Windows.Forms.TextBox txtDataAlt;
        public System.Windows.Forms.Label lblDataAlteracao;
        public System.Windows.Forms.Button btnSalvar;
        public System.Windows.Forms.TextBox txtCodUser;
        public System.Windows.Forms.Label lblCodUser;
    }
}

