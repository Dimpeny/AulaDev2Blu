using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.Aula6.Jogo21
{
    public partial class Form1 : Form
    {
        int numeroAleatorio,numeroJogadorUm,numeroJogadorDois,pontuacaoJogadorUm, pontuacaoJogadorDois;
        bool partidaEmAndamento, partidaMultijogador;
        bool primeiraPartida = true;
        string mensagemPontuacao;
        const string MensagemRegras = "";
        
        /*
        7=10
        14=20
        21=30
        1-6=1
        8-13=5
        15-20=6
         */

        private void buttonNovaPartida_Click(object sender, EventArgs e)
        {
            if (partidaEmAndamento)
            {
                textBoxConsole.Text += "\n Não é possivel iniciar uma partida enquanto outra partida está acontecendo!";
            }
            else
            {
                textBoxConsole.Text = "Bem-vindo(a) ao jogo do 21!";
                partidaEmAndamento = true;
                textBoxConsole.Text += "\n";
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

    }
}
