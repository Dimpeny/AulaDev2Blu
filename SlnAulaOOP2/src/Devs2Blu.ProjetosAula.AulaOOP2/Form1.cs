using Devs2Blu.ProjetosAula.OOP2Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.AulaOOP2
{
    public partial class Form1 : Form
    {
        static List<Contato> ListaContatos;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListaContatos = new List<Contato>();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (!ValidaForm()) return;

            Contato contatoNovo = new Contato();

            contatoNovo.Nome = tbNome.Text;
            contatoNovo.TelCel = tbTelefone.Text;
            contatoNovo.Email = tbEmail.Text;
            contatoNovo.Cep = tbCep.Text;
            contatoNovo.Rua = tbRua.Text;
            contatoNovo.Numero = Int32.Parse(tbNumero.Text);
            contatoNovo.Bairro = tbBairro.Text;
            contatoNovo.Cidade = tbCidade.Text;
            contatoNovo.Estado = tbEstado.Text;

            ListaContatos.Add(contatoNovo);
            tbTextoGrande.Text += " "+contatoNovo.Nome;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparFormulario();
        }

        #region metodos

        private void limparFormulario()
        {
            tbNome.Clear();
            tbTelefone.Clear();
            tbEmail.Clear();
            tbCep.Clear();
            tbRua.Clear();
            tbNumero.Clear();
            tbBairro.Clear();
            tbCidade.Clear();
            tbEstado.Clear();
        }

        private bool ValidaForm()
        {
            if( tbNome.Text == String.Empty) return false;
            if( tbTelefone.Text == String.Empty) return false;
            if( tbEmail.Text == String.Empty) return false;
            if( tbCep.Text == String.Empty) return false;
            if( tbRua.Text == String.Empty) return false;
            if( tbNumero.Text == String.Empty) return false;
            if( tbBairro.Text == String.Empty) return false;
            if( tbCidade.Text== String.Empty ) return false;
            if( tbEstado.Text == String.Empty) return false;

            return true;

            
        }

        #endregion
    }
}
