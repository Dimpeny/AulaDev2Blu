namespace Devs2Blu.ProjetosAula.SistemaCadastro.Forms
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cboConvenio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpFormCadastro = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mskCGCCPF = new System.Windows.Forms.MaskedTextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.gpEnderecoCadastro = new System.Windows.Forms.GroupBox();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.mskCep = new System.Windows.Forms.MaskedTextBox();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.tbRua = new System.Windows.Forms.TextBox();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.cboUf = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCGCCPF = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gpTipoPessoa = new System.Windows.Forms.GroupBox();
            this.rbJuridica = new System.Windows.Forms.RadioButton();
            this.rbFisica = new System.Windows.Forms.RadioButton();
            this.groupBoxBtns = new System.Windows.Forms.GroupBox();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dgPessoa = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.gpFormCadastro.SuspendLayout();
            this.gpEnderecoCadastro.SuspendLayout();
            this.gpTipoPessoa.SuspendLayout();
            this.groupBoxBtns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPessoa)).BeginInit();
            this.SuspendLayout();
            // 
            // cboConvenio
            // 
            this.cboConvenio.FormattingEnabled = true;
            this.cboConvenio.Location = new System.Drawing.Point(310, 56);
            this.cboConvenio.Name = "cboConvenio";
            this.cboConvenio.Size = new System.Drawing.Size(152, 21);
            this.cboConvenio.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Convênio:";
            // 
            // gpFormCadastro
            // 
            this.gpFormCadastro.BackColor = System.Drawing.SystemColors.Control;
            this.gpFormCadastro.Controls.Add(this.label9);
            this.gpFormCadastro.Controls.Add(this.textBox1);
            this.gpFormCadastro.Controls.Add(this.mskCGCCPF);
            this.gpFormCadastro.Controls.Add(this.btnLimpar);
            this.gpFormCadastro.Controls.Add(this.tbNome);
            this.gpFormCadastro.Controls.Add(this.gpEnderecoCadastro);
            this.gpFormCadastro.Controls.Add(this.lblCGCCPF);
            this.gpFormCadastro.Controls.Add(this.label2);
            this.gpFormCadastro.Controls.Add(this.gpTipoPessoa);
            this.gpFormCadastro.Controls.Add(this.label1);
            this.gpFormCadastro.Controls.Add(this.cboConvenio);
            this.gpFormCadastro.Location = new System.Drawing.Point(12, 12);
            this.gpFormCadastro.Name = "gpFormCadastro";
            this.gpFormCadastro.Size = new System.Drawing.Size(1123, 323);
            this.gpFormCadastro.TabIndex = 2;
            this.gpFormCadastro.TabStop = false;
            this.gpFormCadastro.Text = "Formulario de Cadastro";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(222, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Paciente Risco:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(310, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 20);
            this.textBox1.TabIndex = 8;
            // 
            // mskCGCCPF
            // 
            this.mskCGCCPF.Location = new System.Drawing.Point(59, 56);
            this.mskCGCCPF.Mask = "000.000.000-00";
            this.mskCGCCPF.Name = "mskCGCCPF";
            this.mskCGCCPF.Size = new System.Drawing.Size(157, 20);
            this.mskCGCCPF.TabIndex = 7;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLimpar.Location = new System.Drawing.Point(19, 284);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(59, 19);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(403, 20);
            this.tbNome.TabIndex = 4;
            // 
            // gpEnderecoCadastro
            // 
            this.gpEnderecoCadastro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gpEnderecoCadastro.Controls.Add(this.tbNumero);
            this.gpEnderecoCadastro.Controls.Add(this.mskCep);
            this.gpEnderecoCadastro.Controls.Add(this.tbBairro);
            this.gpEnderecoCadastro.Controls.Add(this.tbRua);
            this.gpEnderecoCadastro.Controls.Add(this.tbCidade);
            this.gpEnderecoCadastro.Controls.Add(this.cboUf);
            this.gpEnderecoCadastro.Controls.Add(this.label8);
            this.gpEnderecoCadastro.Controls.Add(this.label7);
            this.gpEnderecoCadastro.Controls.Add(this.label6);
            this.gpEnderecoCadastro.Controls.Add(this.label5);
            this.gpEnderecoCadastro.Controls.Add(this.label4);
            this.gpEnderecoCadastro.Controls.Add(this.label3);
            this.gpEnderecoCadastro.Location = new System.Drawing.Point(16, 152);
            this.gpEnderecoCadastro.Name = "gpEnderecoCadastro";
            this.gpEnderecoCadastro.Size = new System.Drawing.Size(419, 125);
            this.gpEnderecoCadastro.TabIndex = 3;
            this.gpEnderecoCadastro.TabStop = false;
            this.gpEnderecoCadastro.Text = "Endereço/Contato";
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(61, 79);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(100, 20);
            this.tbNumero.TabIndex = 12;
            // 
            // mskCep
            // 
            this.mskCep.Location = new System.Drawing.Point(43, 13);
            this.mskCep.Mask = "00.000-00";
            this.mskCep.Name = "mskCep";
            this.mskCep.Size = new System.Drawing.Size(77, 20);
            this.mskCep.TabIndex = 11;
            // 
            // tbBairro
            // 
            this.tbBairro.Location = new System.Drawing.Point(237, 51);
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(170, 20);
            this.tbBairro.TabIndex = 10;
            // 
            // tbRua
            // 
            this.tbRua.Location = new System.Drawing.Point(43, 48);
            this.tbRua.Name = "tbRua";
            this.tbRua.Size = new System.Drawing.Size(145, 20);
            this.tbRua.TabIndex = 9;
            // 
            // tbCidade
            // 
            this.tbCidade.Location = new System.Drawing.Point(237, 17);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(176, 20);
            this.tbCidade.TabIndex = 8;
            // 
            // cboUf
            // 
            this.cboUf.FormattingEnabled = true;
            this.cboUf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cboUf.Location = new System.Drawing.Point(156, 12);
            this.cboUf.Name = "cboUf";
            this.cboUf.Size = new System.Drawing.Size(32, 21);
            this.cboUf.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(126, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "UF:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(194, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Cidade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(194, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Bairro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Número:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Rua:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "CEP:";
            // 
            // lblCGCCPF
            // 
            this.lblCGCCPF.AutoSize = true;
            this.lblCGCCPF.Location = new System.Drawing.Point(24, 59);
            this.lblCGCCPF.Name = "lblCGCCPF";
            this.lblCGCCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCGCCPF.TabIndex = 3;
            this.lblCGCCPF.Text = "CPF:";
            this.lblCGCCPF.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // gpTipoPessoa
            // 
            this.gpTipoPessoa.Controls.Add(this.rbJuridica);
            this.gpTipoPessoa.Controls.Add(this.rbFisica);
            this.gpTipoPessoa.Location = new System.Drawing.Point(19, 90);
            this.gpTipoPessoa.Name = "gpTipoPessoa";
            this.gpTipoPessoa.Size = new System.Drawing.Size(197, 56);
            this.gpTipoPessoa.TabIndex = 0;
            this.gpTipoPessoa.TabStop = false;
            this.gpTipoPessoa.Text = "Tipo de Pessoa";
            // 
            // rbJuridica
            // 
            this.rbJuridica.AutoSize = true;
            this.rbJuridica.Location = new System.Drawing.Point(118, 20);
            this.rbJuridica.Name = "rbJuridica";
            this.rbJuridica.Size = new System.Drawing.Size(61, 17);
            this.rbJuridica.TabIndex = 1;
            this.rbJuridica.Text = "Juridica";
            this.rbJuridica.UseVisualStyleBackColor = true;
            this.rbJuridica.CheckedChanged += new System.EventHandler(this.rbJuridica_CheckedChanged);
            // 
            // rbFisica
            // 
            this.rbFisica.AutoSize = true;
            this.rbFisica.Checked = true;
            this.rbFisica.Location = new System.Drawing.Point(23, 22);
            this.rbFisica.Name = "rbFisica";
            this.rbFisica.Size = new System.Drawing.Size(52, 17);
            this.rbFisica.TabIndex = 0;
            this.rbFisica.TabStop = true;
            this.rbFisica.Text = "Fisica";
            this.rbFisica.UseVisualStyleBackColor = true;
            this.rbFisica.CheckedChanged += new System.EventHandler(this.rbFisica_CheckedChanged);
            // 
            // groupBoxBtns
            // 
            this.groupBoxBtns.Controls.Add(this.btnEditar);
            this.groupBoxBtns.Controls.Add(this.btnInfo);
            this.groupBoxBtns.Controls.Add(this.btnCancelar);
            this.groupBoxBtns.Controls.Add(this.btnSalvar);
            this.groupBoxBtns.Location = new System.Drawing.Point(12, 569);
            this.groupBoxBtns.Name = "groupBoxBtns";
            this.groupBoxBtns.Size = new System.Drawing.Size(1123, 74);
            this.groupBoxBtns.TabIndex = 3;
            this.groupBoxBtns.TabStop = false;
            this.groupBoxBtns.Text = "Opções";
            // 
            // btnInfo
            // 
            this.btnInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInfo.BackgroundImage")));
            this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Location = new System.Drawing.Point(1042, 19);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(50, 50);
            this.btnInfo.TabIndex = 2;
            this.btnInfo.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(77, 19);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(50, 50);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvar.BackgroundImage")));
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(6, 19);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(50, 50);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dgPessoa
            // 
            this.dgPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPessoa.Location = new System.Drawing.Point(12, 341);
            this.dgPessoa.Name = "dgPessoa";
            this.dgPessoa.Size = new System.Drawing.Size(1123, 222);
            this.dgPessoa.TabIndex = 4;
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(137, 18);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(50, 50);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1147, 655);
            this.Controls.Add(this.dgPessoa);
            this.Controls.Add(this.groupBoxBtns);
            this.Controls.Add(this.gpFormCadastro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpFormCadastro.ResumeLayout(false);
            this.gpFormCadastro.PerformLayout();
            this.gpEnderecoCadastro.ResumeLayout(false);
            this.gpEnderecoCadastro.PerformLayout();
            this.gpTipoPessoa.ResumeLayout(false);
            this.gpTipoPessoa.PerformLayout();
            this.groupBoxBtns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPessoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboConvenio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpFormCadastro;
        private System.Windows.Forms.Label lblCGCCPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gpTipoPessoa;
        private System.Windows.Forms.RadioButton rbJuridica;
        private System.Windows.Forms.RadioButton rbFisica;
        private System.Windows.Forms.GroupBox gpEnderecoCadastro;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.ComboBox cboUf;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.TextBox tbBairro;
        private System.Windows.Forms.TextBox tbRua;
        private System.Windows.Forms.MaskedTextBox mskCep;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox groupBoxBtns;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dgPessoa;
        private System.Windows.Forms.MaskedTextBox mskCGCCPF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnEditar;
    }
}

