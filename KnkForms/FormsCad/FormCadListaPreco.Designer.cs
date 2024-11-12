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
            this.txtCodSubgrupo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkTodas = new System.Windows.Forms.CheckBox();
            this.btnConsultaMarca = new System.Windows.Forms.Button();
            this.btnConsultaSubgrupo = new System.Windows.Forms.Button();
            this.txtPercCom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomeMarca = new System.Windows.Forms.TextBox();
            this.txtNomeSubgrupo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDataCad
            // 
            this.txtDataCad.TabIndex = 10;
            // 
            // txtDataAlt
            // 
            this.txtDataAlt.TabIndex = 11;
            // 
            // btnSalvar
            // 
            this.btnSalvar.TabIndex = 12;
            // 
            // txtCodUser
            // 
            this.txtCodUser.TabIndex = 9;
            // 
            // btnSair
            // 
            this.btnSair.TabIndex = 13;
            // 
            // txtLista
            // 
            this.txtLista.Location = new System.Drawing.Point(114, 57);
            this.txtLista.MaxLength = 40;
            this.txtLista.Name = "txtLista";
            this.txtLista.Size = new System.Drawing.Size(250, 20);
            this.txtLista.TabIndex = 2;
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
            this.txtDescMax.Location = new System.Drawing.Point(395, 59);
            this.txtDescMax.MaxLength = 8;
            this.txtDescMax.Name = "txtDescMax";
            this.txtDescMax.Size = new System.Drawing.Size(65, 20);
            this.txtDescMax.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(392, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Desconto Máximo";
            // 
            // txtMargemLucro
            // 
            this.txtMargemLucro.Location = new System.Drawing.Point(503, 58);
            this.txtMargemLucro.MaxLength = 8;
            this.txtMargemLucro.Name = "txtMargemLucro";
            this.txtMargemLucro.Size = new System.Drawing.Size(64, 20);
            this.txtMargemLucro.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(500, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Margem de Lucro";
            // 
            // txtCodMarca
            // 
            this.txtCodMarca.Enabled = false;
            this.txtCodMarca.Location = new System.Drawing.Point(38, 119);
            this.txtCodMarca.MaxLength = 30;
            this.txtCodMarca.Name = "txtCodMarca";
            this.txtCodMarca.Size = new System.Drawing.Size(197, 20);
            this.txtCodMarca.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Marca";
            // 
            // txtCodSubgrupo
            // 
            this.txtCodSubgrupo.Enabled = false;
            this.txtCodSubgrupo.Location = new System.Drawing.Point(276, 119);
            this.txtCodSubgrupo.MaxLength = 30;
            this.txtCodSubgrupo.Name = "txtCodSubgrupo";
            this.txtCodSubgrupo.Size = new System.Drawing.Size(197, 20);
            this.txtCodSubgrupo.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 103);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Subgrupo";
            // 
            // chkTodas
            // 
            this.chkTodas.AutoSize = true;
            this.chkTodas.Location = new System.Drawing.Point(732, 21);
            this.chkTodas.Name = "chkTodas";
            this.chkTodas.Size = new System.Drawing.Size(56, 17);
            this.chkTodas.TabIndex = 6;
            this.chkTodas.Text = "Todas";
            this.chkTodas.UseVisualStyleBackColor = true;
            this.chkTodas.KeyUp += new System.Windows.Forms.KeyEventHandler(this.chkBox);
            // 
            // btnConsultaMarca
            // 
            this.btnConsultaMarca.Location = new System.Drawing.Point(241, 119);
            this.btnConsultaMarca.Name = "btnConsultaMarca";
            this.btnConsultaMarca.Size = new System.Drawing.Size(22, 23);
            this.btnConsultaMarca.TabIndex = 7;
            this.btnConsultaMarca.Text = "⌕";
            this.btnConsultaMarca.UseVisualStyleBackColor = true;
            this.btnConsultaMarca.Click += new System.EventHandler(this.btnConsultaMarca_Click);
            // 
            // btnConsultaSubgrupo
            // 
            this.btnConsultaSubgrupo.Location = new System.Drawing.Point(479, 117);
            this.btnConsultaSubgrupo.Name = "btnConsultaSubgrupo";
            this.btnConsultaSubgrupo.Size = new System.Drawing.Size(21, 23);
            this.btnConsultaSubgrupo.TabIndex = 8;
            this.btnConsultaSubgrupo.Text = "⌕";
            this.btnConsultaSubgrupo.UseVisualStyleBackColor = true;
            this.btnConsultaSubgrupo.Click += new System.EventHandler(this.btnConsultaGrupo_Click);
            // 
            // txtPercCom
            // 
            this.txtPercCom.Location = new System.Drawing.Point(611, 59);
            this.txtPercCom.MaxLength = 8;
            this.txtPercCom.Name = "txtPercCom";
            this.txtPercCom.Size = new System.Drawing.Size(64, 20);
            this.txtPercCom.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(608, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "Perc. Comissão";
            // 
            // txtNomeMarca
            // 
            this.txtNomeMarca.Enabled = false;
            this.txtNomeMarca.Location = new System.Drawing.Point(38, 119);
            this.txtNomeMarca.MaxLength = 30;
            this.txtNomeMarca.Name = "txtNomeMarca";
            this.txtNomeMarca.Size = new System.Drawing.Size(197, 20);
            this.txtNomeMarca.TabIndex = 63;
            // 
            // txtNomeSubgrupo
            // 
            this.txtNomeSubgrupo.Enabled = false;
            this.txtNomeSubgrupo.Location = new System.Drawing.Point(276, 119);
            this.txtNomeSubgrupo.MaxLength = 30;
            this.txtNomeSubgrupo.Name = "txtNomeSubgrupo";
            this.txtNomeSubgrupo.Size = new System.Drawing.Size(197, 20);
            this.txtNomeSubgrupo.TabIndex = 64;
            // 
            // FormCadListaPreco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNomeSubgrupo);
            this.Controls.Add(this.txtNomeMarca);
            this.Controls.Add(this.txtPercCom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnConsultaSubgrupo);
            this.Controls.Add(this.btnConsultaMarca);
            this.Controls.Add(this.chkTodas);
            this.Controls.Add(this.txtCodSubgrupo);
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
            this.Controls.SetChildIndex(this.txtCodSubgrupo, 0);
            this.Controls.SetChildIndex(this.chkTodas, 0);
            this.Controls.SetChildIndex(this.btnConsultaMarca, 0);
            this.Controls.SetChildIndex(this.btnConsultaSubgrupo, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtPercCom, 0);
            this.Controls.SetChildIndex(this.txtNomeMarca, 0);
            this.Controls.SetChildIndex(this.txtNomeSubgrupo, 0);
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
        private System.Windows.Forms.TextBox txtCodSubgrupo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkTodas;
        private System.Windows.Forms.Button btnConsultaMarca;
        private System.Windows.Forms.Button btnConsultaSubgrupo;
        private System.Windows.Forms.TextBox txtPercCom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomeMarca;
        private System.Windows.Forms.TextBox txtNomeSubgrupo;
    }
}
