namespace KnkForms.Forms
{
    partial class FormCadListaPreco
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
            this.txtLista = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtDescMax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMargemLucro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodGrupo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkTodas = new System.Windows.Forms.CheckBox();
            this.btnConsultaMarca = new System.Windows.Forms.Button();
            this.btnConsultaGrupo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLista
            // 
            this.txtLista.Location = new System.Drawing.Point(114, 57);
            this.txtLista.MaxLength = 30;
            this.txtLista.Name = "txtLista";
            this.txtLista.Size = new System.Drawing.Size(126, 20);
            this.txtLista.TabIndex = 52;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(111, 41);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(75, 13);
            this.lbl1.TabIndex = 51;
            this.lbl1.Text = "Lista de Preço";
            // 
            // txtDescMax
            // 
            this.txtDescMax.Location = new System.Drawing.Point(263, 58);
            this.txtDescMax.Name = "txtDescMax";
            this.txtDescMax.Size = new System.Drawing.Size(65, 20);
            this.txtDescMax.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Desconto Máximo";
            // 
            // txtMargemLucro
            // 
            this.txtMargemLucro.Location = new System.Drawing.Point(365, 58);
            this.txtMargemLucro.Name = "txtMargemLucro";
            this.txtMargemLucro.Size = new System.Drawing.Size(64, 20);
            this.txtMargemLucro.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Margem de Lucro";
            // 
            // txtCodMarca
            // 
            this.txtCodMarca.Location = new System.Drawing.Point(464, 58);
            this.txtCodMarca.Name = "txtCodMarca";
            this.txtCodMarca.Size = new System.Drawing.Size(55, 20);
            this.txtCodMarca.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(461, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Código Marca";
            // 
            // txtCodGrupo
            // 
            this.txtCodGrupo.Location = new System.Drawing.Point(35, 123);
            this.txtCodGrupo.Name = "txtCodGrupo";
            this.txtCodGrupo.Size = new System.Drawing.Size(63, 20);
            this.txtCodGrupo.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Código Grupo";
            // 
            // chkTodas
            // 
            this.chkTodas.AutoSize = true;
            this.chkTodas.Location = new System.Drawing.Point(732, 21);
            this.chkTodas.Name = "chkTodas";
            this.chkTodas.Size = new System.Drawing.Size(56, 17);
            this.chkTodas.TabIndex = 63;
            this.chkTodas.Text = "Todas";
            this.chkTodas.UseVisualStyleBackColor = true;
            // 
            // btnConsultaMarca
            // 
            this.btnConsultaMarca.Location = new System.Drawing.Point(540, 56);
            this.btnConsultaMarca.Name = "btnConsultaMarca";
            this.btnConsultaMarca.Size = new System.Drawing.Size(98, 23);
            this.btnConsultaMarca.TabIndex = 64;
            this.btnConsultaMarca.Text = "Consulta Marca";
            this.btnConsultaMarca.UseVisualStyleBackColor = true;
            this.btnConsultaMarca.Click += new System.EventHandler(this.btnConsultaMarca_Click);
            // 
            // btnConsultaGrupo
            // 
            this.btnConsultaGrupo.Location = new System.Drawing.Point(114, 123);
            this.btnConsultaGrupo.Name = "btnConsultaGrupo";
            this.btnConsultaGrupo.Size = new System.Drawing.Size(103, 23);
            this.btnConsultaGrupo.TabIndex = 65;
            this.btnConsultaGrupo.Text = "Consulta Grupo";
            this.btnConsultaGrupo.UseVisualStyleBackColor = true;
            this.btnConsultaGrupo.Click += new System.EventHandler(this.btnConsultaGrupo_Click);
            // 
            // FormCadListaPreco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConsultaGrupo);
            this.Controls.Add(this.btnConsultaMarca);
            this.Controls.Add(this.chkTodas);
            this.Controls.Add(this.txtCodGrupo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCodMarca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMargemLucro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescMax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLista);
            this.Controls.Add(this.lbl1);
            this.Name = "FormCadListaPreco";
            this.Text = "Form Lista de Preços";
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
            this.Controls.SetChildIndex(this.txtLista, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtDescMax, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtMargemLucro, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtCodMarca, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtCodGrupo, 0);
            this.Controls.SetChildIndex(this.chkTodas, 0);
            this.Controls.SetChildIndex(this.btnConsultaMarca, 0);
            this.Controls.SetChildIndex(this.btnConsultaGrupo, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLista;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtDescMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMargemLucro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodGrupo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkTodas;
        private System.Windows.Forms.Button btnConsultaMarca;
        private System.Windows.Forms.Button btnConsultaGrupo;
    }
}
