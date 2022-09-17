using System;
using System.Collections.Generic;
using Devs2Blu.ProjetosAula.Classes;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.AulaOop1Int
{
    public partial class Form1 : Form
    {
        public List<Recepcionista> RecepcionistasList { get; set; }
        public List<Diretor> DiretorsList { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RecepcionistasList = new List<Recepcionista>();
            DiretorsList = new List<Diretor>();
        }

        #region Metodos
        private void salvarRecepcionista(Recepcionista recepcionista) 
        {
            RecepcionistasList.Add(recepcionista);
        }
        private void salvarDiretor(Diretor diretor)
        {
            DiretorsList.Add(diretor);
        }
        #endregion

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (radioButtonRecepcionista.Checked)
            {
                Recepcionista recepcionista = new Recepcionista();
                recepcionista.Nome = tbNome.Text;
                recepcionista.Sobrenome = tbSobrenome.Text;
                this.BackColor = Color.Red;
                salvarRecepcionista(recepcionista);
            }else if (radioButtonDiretor.Checked)
            {
                Diretor diretor = new Diretor();
                diretor.Nome = tbNome.Text;
                diretor.Sobrenome = tbSobrenome.Text;
                this.BackColor = Color.Blue;
                salvarDiretor(diretor);
            }
        }
    }
}
