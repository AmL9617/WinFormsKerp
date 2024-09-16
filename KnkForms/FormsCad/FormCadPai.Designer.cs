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
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtIdEmp = new System.Windows.Forms.TextBox();
            this.lblIdEmp = new System.Windows.Forms.Label();
            this.txtDataCad = new System.Windows.Forms.TextBox();
            this.lblDataCad = new System.Windows.Forms.Label();
            this.txtDataAlt = new System.Windows.Forms.TextBox();
            this.lblDataAlteracao = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(32, 42);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(35, 58);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(92, 20);
            this.txtId.TabIndex = 1;
            // 
            // txtIdEmp
            // 
            this.txtIdEmp.Location = new System.Drawing.Point(165, 58);
            this.txtIdEmp.Name = "txtIdEmp";
            this.txtIdEmp.Size = new System.Drawing.Size(92, 20);
            this.txtIdEmp.TabIndex = 3;
            // 
            // lblIdEmp
            // 
            this.lblIdEmp.AutoSize = true;
            this.lblIdEmp.Location = new System.Drawing.Point(162, 42);
            this.lblIdEmp.Name = "lblIdEmp";
            this.lblIdEmp.Size = new System.Drawing.Size(62, 13);
            this.lblIdEmp.TabIndex = 2;
            this.lblIdEmp.Text = "ID Empresa";
            // 
            // txtDataCad
            // 
            this.txtDataCad.Location = new System.Drawing.Point(289, 58);
            this.txtDataCad.Name = "txtDataCad";
            this.txtDataCad.Size = new System.Drawing.Size(92, 20);
            this.txtDataCad.TabIndex = 5;
            // 
            // lblDataCad
            // 
            this.lblDataCad.AutoSize = true;
            this.lblDataCad.Location = new System.Drawing.Point(286, 42);
            this.lblDataCad.Name = "lblDataCad";
            this.lblDataCad.Size = new System.Drawing.Size(90, 13);
            this.lblDataCad.TabIndex = 4;
            this.lblDataCad.Text = "Data de Cadastro";
            // 
            // txtDataAlt
            // 
            this.txtDataAlt.Location = new System.Drawing.Point(412, 58);
            this.txtDataAlt.Name = "txtDataAlt";
            this.txtDataAlt.Size = new System.Drawing.Size(92, 20);
            this.txtDataAlt.TabIndex = 7;
            // 
            // lblDataAlteracao
            // 
            this.lblDataAlteracao.AutoSize = true;
            this.lblDataAlteracao.Location = new System.Drawing.Point(409, 42);
            this.lblDataAlteracao.Name = "lblDataAlteracao";
            this.lblDataAlteracao.Size = new System.Drawing.Size(93, 13);
            this.lblDataAlteracao.TabIndex = 6;
            this.lblDataAlteracao.Text = "Data de Alteração";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(694, 410);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(82, 24);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FormPai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtDataAlt);
            this.Controls.Add(this.lblDataAlteracao);
            this.Controls.Add(this.txtDataCad);
            this.Controls.Add(this.lblDataCad);
            this.Controls.Add(this.txtIdEmp);
            this.Controls.Add(this.lblIdEmp);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Name = "FormPai";
            this.Text = "Form Pai";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txtId;
        public System.Windows.Forms.Label lblId;
        public System.Windows.Forms.TextBox txtIdEmp;
        public System.Windows.Forms.Label lblIdEmp;
        public System.Windows.Forms.TextBox txtDataCad;
        public System.Windows.Forms.Label lblDataCad;
        public System.Windows.Forms.TextBox txtDataAlt;
        public System.Windows.Forms.Label lblDataAlteracao;
        public System.Windows.Forms.Button btnSalvar;
    }
}

