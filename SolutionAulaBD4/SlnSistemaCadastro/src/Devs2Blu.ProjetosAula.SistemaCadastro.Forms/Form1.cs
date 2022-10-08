using Devs2Blu.ProjetosAula.sistemaCadastro.Models.Model;
using Devs2Blu.ProjetosAula.SistemaCadastro.Forms.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Forms
{
    public partial class Form1 : Form
    {
        public MySqlConnection Conn { get; set; }
        public ConvenioRepository ConvenioRepository { get; set; }
        public PacienteRepository PacienteRepository { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConvenioRepository = new ConvenioRepository();
            PacienteRepository = new PacienteRepository();
            Conn = ConnectionMySQL.GetConnection();

            if (Conn.State == ConnectionState.Open)
            {

                MessageBox.Show("Conexão efetuada com sucesso!", "Conexão MySQL!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Conn.Close();

            }
            PopulaComboBox();
        }

        #region Metodos
        public void PopulaComboBox()
        {
            var listConvenios = ConvenioRepository.FetchAll();


            cboConvenio.DataSource = new BindingSource(listConvenios, null);
            cboConvenio.DisplayMember = "nome";
            cboConvenio.ValueMember = "id";
        }

        private bool ValidaFormCadastro()
        {
            if (tbNome.Text.Equals(""))
                return false;
            if (tbCGCCPF.Text.Equals(""))
                return false;
            /*if (cboConvenio.SelectedIndex == -1)
                return false;
            if (mskCep.Text.Equals(""))
                return false;
            if (cbUf.SelectedIndex == -1)
                return false;
            if (tbRua.Text.Equals(""))
                return false;
            if (tbCidade.Text.Equals(""))
                return false;
            if (tbBairro.Text.Equals(""))
                return false;
            if (tbNumero.Text.Equals(""))
                return false;*/

            return true;
        } 

        #endregion

        #region Events
        private void rbFisica_CheckedChanged(object sender, EventArgs e)
        {

            lblCGCCPF.Text = "CPF:";
            lblCGCCPF.Visible = true;

        }

        private void rbJuridica_CheckedChanged(object sender, EventArgs e)
        {

            lblCGCCPF.Text = "CNPJ:";
            lblCGCCPF.Visible = true;

        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaFormCadastro())
            {
                Paciente paciente = new Paciente();
                paciente.Pessoa.Nome = tbNome.Text;
                paciente.Pessoa.CGCCPF = tbCGCCPF.Text;
                var pacienteResult = PacienteRepository.Save(paciente);
                if(pacienteResult.Pessoa.Id > 0)
                {
                    MessageBox.Show("Pessoa salva com sucesso", "Adicionar pessoa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }
        #endregion

    }
}
