namespace Devs2Blu.ProjetosAula.Aula6.Jogo21
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
            this.textBoxPlayer1 = new System.Windows.Forms.TextBox();
            this.groupBoxPlayer1 = new System.Windows.Forms.GroupBox();
            this.buttonPlayer1 = new System.Windows.Forms.Button();
            this.groupBoxPlayer2 = new System.Windows.Forms.GroupBox();
            this.buttonPlayer2 = new System.Windows.Forms.Button();
            this.textBoxPlayer2 = new System.Windows.Forms.TextBox();
            this.groupBoxJogo = new System.Windows.Forms.GroupBox();
            this.textBoxConsole = new System.Windows.Forms.TextBox();
            this.buttonNovaPartida = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button1Jogador = new System.Windows.Forms.Button();
            this.buttonMultijogador = new System.Windows.Forms.Button();
            this.groupBoxPlayer1.SuspendLayout();
            this.groupBoxPlayer2.SuspendLayout();
            this.groupBoxJogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPlayer1
            // 
            this.textBoxPlayer1.Location = new System.Drawing.Point(6, 61);
            this.textBoxPlayer1.Name = "textBoxPlayer1";
            this.textBoxPlayer1.Size = new System.Drawing.Size(262, 20);
            this.textBoxPlayer1.TabIndex = 0;
            // 
            // groupBoxPlayer1
            // 
            this.groupBoxPlayer1.Controls.Add(this.buttonPlayer1);
            this.groupBoxPlayer1.Controls.Add(this.textBoxPlayer1);
            this.groupBoxPlayer1.Location = new System.Drawing.Point(12, 341);
            this.groupBoxPlayer1.Name = "groupBoxPlayer1";
            this.groupBoxPlayer1.Size = new System.Drawing.Size(355, 100);
            this.groupBoxPlayer1.TabIndex = 1;
            this.groupBoxPlayer1.TabStop = false;
            this.groupBoxPlayer1.Text = "Player 1";
            // 
            // buttonPlayer1
            // 
            this.buttonPlayer1.Location = new System.Drawing.Point(274, 61);
            this.buttonPlayer1.Name = "buttonPlayer1";
            this.buttonPlayer1.Size = new System.Drawing.Size(75, 23);
            this.buttonPlayer1.TabIndex = 1;
            this.buttonPlayer1.Text = "Ok";
            this.buttonPlayer1.UseVisualStyleBackColor = true;
            // 
            // groupBoxPlayer2
            // 
            this.groupBoxPlayer2.Controls.Add(this.buttonPlayer2);
            this.groupBoxPlayer2.Controls.Add(this.textBoxPlayer2);
            this.groupBoxPlayer2.Location = new System.Drawing.Point(373, 341);
            this.groupBoxPlayer2.Name = "groupBoxPlayer2";
            this.groupBoxPlayer2.Size = new System.Drawing.Size(415, 97);
            this.groupBoxPlayer2.TabIndex = 2;
            this.groupBoxPlayer2.TabStop = false;
            this.groupBoxPlayer2.Text = "Player2";
            // 
            // buttonPlayer2
            // 
            this.buttonPlayer2.Enabled = false;
            this.buttonPlayer2.Location = new System.Drawing.Point(334, 61);
            this.buttonPlayer2.Name = "buttonPlayer2";
            this.buttonPlayer2.Size = new System.Drawing.Size(75, 23);
            this.buttonPlayer2.TabIndex = 1;
            this.buttonPlayer2.Text = "Ok";
            this.buttonPlayer2.UseVisualStyleBackColor = true;
            // 
            // textBoxPlayer2
            // 
            this.textBoxPlayer2.Enabled = false;
            this.textBoxPlayer2.Location = new System.Drawing.Point(6, 61);
            this.textBoxPlayer2.Name = "textBoxPlayer2";
            this.textBoxPlayer2.ReadOnly = true;
            this.textBoxPlayer2.Size = new System.Drawing.Size(322, 20);
            this.textBoxPlayer2.TabIndex = 0;
            // 
            // groupBoxJogo
            // 
            this.groupBoxJogo.Controls.Add(this.textBoxConsole);
            this.groupBoxJogo.Location = new System.Drawing.Point(12, 12);
            this.groupBoxJogo.Name = "groupBoxJogo";
            this.groupBoxJogo.Size = new System.Drawing.Size(776, 275);
            this.groupBoxJogo.TabIndex = 3;
            this.groupBoxJogo.TabStop = false;
            this.groupBoxJogo.Text = "Jogo 21";
            // 
            // textBoxConsole
            // 
            this.textBoxConsole.Location = new System.Drawing.Point(6, 32);
            this.textBoxConsole.Multiline = true;
            this.textBoxConsole.Name = "textBoxConsole";
            this.textBoxConsole.ReadOnly = true;
            this.textBoxConsole.Size = new System.Drawing.Size(764, 237);
            this.textBoxConsole.TabIndex = 0;
            // 
            // buttonNovaPartida
            // 
            this.buttonNovaPartida.Location = new System.Drawing.Point(12, 312);
            this.buttonNovaPartida.Name = "buttonNovaPartida";
            this.buttonNovaPartida.Size = new System.Drawing.Size(77, 23);
            this.buttonNovaPartida.TabIndex = 4;
            this.buttonNovaPartida.Text = "Nova Partida";
            this.buttonNovaPartida.UseVisualStyleBackColor = true;
            this.buttonNovaPartida.Click += new System.EventHandler(this.buttonNovaPartida_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Proxima rodada";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button1Jogador
            // 
            this.button1Jogador.Location = new System.Drawing.Point(197, 312);
            this.button1Jogador.Name = "button1Jogador";
            this.button1Jogador.Size = new System.Drawing.Size(75, 23);
            this.button1Jogador.TabIndex = 6;
            this.button1Jogador.Text = "Um Jogador";
            this.button1Jogador.UseVisualStyleBackColor = true;
            // 
            // buttonMultijogador
            // 
            this.buttonMultijogador.Location = new System.Drawing.Point(278, 312);
            this.buttonMultijogador.Name = "buttonMultijogador";
            this.buttonMultijogador.Size = new System.Drawing.Size(75, 23);
            this.buttonMultijogador.TabIndex = 7;
            this.buttonMultijogador.Text = "Multijogador";
            this.buttonMultijogador.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMultijogador);
            this.Controls.Add(this.button1Jogador);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonNovaPartida);
            this.Controls.Add(this.groupBoxJogo);
            this.Controls.Add(this.groupBoxPlayer2);
            this.Controls.Add(this.groupBoxPlayer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxPlayer1.ResumeLayout(false);
            this.groupBoxPlayer1.PerformLayout();
            this.groupBoxPlayer2.ResumeLayout(false);
            this.groupBoxPlayer2.PerformLayout();
            this.groupBoxJogo.ResumeLayout(false);
            this.groupBoxJogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPlayer1;
        private System.Windows.Forms.GroupBox groupBoxPlayer1;
        private System.Windows.Forms.Button buttonPlayer1;
        private System.Windows.Forms.GroupBox groupBoxPlayer2;
        private System.Windows.Forms.Button buttonPlayer2;
        private System.Windows.Forms.TextBox textBoxPlayer2;
        private System.Windows.Forms.GroupBox groupBoxJogo;
        private System.Windows.Forms.TextBox textBoxConsole;
        private System.Windows.Forms.Button buttonNovaPartida;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button1Jogador;
        private System.Windows.Forms.Button buttonMultijogador;
    }
}

