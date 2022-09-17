namespace Devs2Blu.ProjetosAula.AulaOop1Int
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
            this.groupBoxCadastro = new System.Windows.Forms.GroupBox();
            this.groupBoxStatus = new System.Windows.Forms.GroupBox();
            this.groupBoxControles = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonRecepcionista = new System.Windows.Forms.RadioButton();
            this.radioButtonDiretor = new System.Windows.Forms.RadioButton();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.tbNascimento = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbSobrenome = new System.Windows.Forms.TextBox();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.groupBoxCadastro.SuspendLayout();
            this.groupBoxControles.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCadastro
            // 
            this.groupBoxCadastro.Controls.Add(this.tbEndereco);
            this.groupBoxCadastro.Controls.Add(this.tbSobrenome);
            this.groupBoxCadastro.Controls.Add(this.tbNome);
            this.groupBoxCadastro.Controls.Add(this.tbNascimento);
            this.groupBoxCadastro.Controls.Add(this.groupBox1);
            this.groupBoxCadastro.Controls.Add(this.label3);
            this.groupBoxCadastro.Controls.Add(this.label2);
            this.groupBoxCadastro.Controls.Add(this.label1);
            this.groupBoxCadastro.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCadastro.Name = "groupBoxCadastro";
            this.groupBoxCadastro.Size = new System.Drawing.Size(570, 426);
            this.groupBoxCadastro.TabIndex = 0;
            this.groupBoxCadastro.TabStop = false;
            this.groupBoxCadastro.Text = "Cadastro de Funcionários";
            // 
            // groupBoxStatus
            // 
            this.groupBoxStatus.Location = new System.Drawing.Point(588, 12);
            this.groupBoxStatus.Name = "groupBoxStatus";
            this.groupBoxStatus.Size = new System.Drawing.Size(200, 206);
            this.groupBoxStatus.TabIndex = 1;
            this.groupBoxStatus.TabStop = false;
            this.groupBoxStatus.Text = "Status";
            // 
            // groupBoxControles
            // 
            this.groupBoxControles.Controls.Add(this.buttonLimpar);
            this.groupBoxControles.Controls.Add(this.buttonSalvar);
            this.groupBoxControles.Location = new System.Drawing.Point(588, 224);
            this.groupBoxControles.Name = "groupBoxControles";
            this.groupBoxControles.Size = new System.Drawing.Size(200, 214);
            this.groupBoxControles.TabIndex = 2;
            this.groupBoxControles.TabStop = false;
            this.groupBoxControles.Text = "Controles";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nascimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Endereco:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonDiretor);
            this.groupBox1.Controls.Add(this.radioButtonRecepcionista);
            this.groupBox1.Location = new System.Drawing.Point(29, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo Funcionário";
            // 
            // radioButtonRecepcionista
            // 
            this.radioButtonRecepcionista.AutoSize = true;
            this.radioButtonRecepcionista.Location = new System.Drawing.Point(82, 47);
            this.radioButtonRecepcionista.Name = "radioButtonRecepcionista";
            this.radioButtonRecepcionista.Size = new System.Drawing.Size(93, 17);
            this.radioButtonRecepcionista.TabIndex = 0;
            this.radioButtonRecepcionista.TabStop = true;
            this.radioButtonRecepcionista.Text = "Recepcionista";
            this.radioButtonRecepcionista.UseVisualStyleBackColor = true;
            // 
            // radioButtonDiretor
            // 
            this.radioButtonDiretor.AutoSize = true;
            this.radioButtonDiretor.Location = new System.Drawing.Point(327, 47);
            this.radioButtonDiretor.Name = "radioButtonDiretor";
            this.radioButtonDiretor.Size = new System.Drawing.Size(56, 17);
            this.radioButtonDiretor.TabIndex = 1;
            this.radioButtonDiretor.TabStop = true;
            this.radioButtonDiretor.Text = "Diretor";
            this.radioButtonDiretor.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(6, 53);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(188, 39);
            this.buttonSalvar.TabIndex = 0;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // tbNascimento
            // 
            this.tbNascimento.Location = new System.Drawing.Point(102, 81);
            this.tbNascimento.Name = "tbNascimento";
            this.tbNascimento.Size = new System.Drawing.Size(100, 20);
            this.tbNascimento.TabIndex = 4;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(102, 50);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(100, 20);
            this.tbNome.TabIndex = 5;
            // 
            // tbSobrenome
            // 
            this.tbSobrenome.Location = new System.Drawing.Point(208, 50);
            this.tbSobrenome.Name = "tbSobrenome";
            this.tbSobrenome.Size = new System.Drawing.Size(100, 20);
            this.tbSobrenome.TabIndex = 6;
            // 
            // tbEndereco
            // 
            this.tbEndereco.Location = new System.Drawing.Point(102, 112);
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(100, 20);
            this.tbEndereco.TabIndex = 7;
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(6, 135);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(188, 40);
            this.buttonLimpar.TabIndex = 1;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxControles);
            this.Controls.Add(this.groupBoxStatus);
            this.Controls.Add(this.groupBoxCadastro);
            this.Name = "Form1";
            this.Text = "Sistema de cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxCadastro.ResumeLayout(false);
            this.groupBoxCadastro.PerformLayout();
            this.groupBoxControles.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCadastro;
        private System.Windows.Forms.GroupBox groupBoxStatus;
        private System.Windows.Forms.GroupBox groupBoxControles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonDiretor;
        private System.Windows.Forms.RadioButton radioButtonRecepcionista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.TextBox tbSobrenome;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbNascimento;
        private System.Windows.Forms.Button buttonLimpar;
    }
}

