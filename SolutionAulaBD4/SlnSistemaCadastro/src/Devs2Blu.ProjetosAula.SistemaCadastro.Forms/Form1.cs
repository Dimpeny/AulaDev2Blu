using Devs2Blu.ProjetosAula.sistemaCadastro.Models.Enum;
using Devs2Blu.ProjetosAula.sistemaCadastro.Models.Model;
using Devs2Blu.ProjetosAula.SistemaCadastro.Models.Model;
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
        public PessoaRepository PessoaRepository { get; set; }
        public EnderecoRepository EnderecoRepository { get; set; }
        public ConvenioRepository ConvenioRepository { get; set; }
        public PacienteRepository PacienteRepository { get; set; }
        public Random rd;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rd = new Random();
            ConvenioRepository = new ConvenioRepository();
            EnderecoRepository = new EnderecoRepository();
            PacienteRepository = new PacienteRepository();
            PessoaRepository = new PessoaRepository();
            Conn = ConnectionMySQL.GetConnection();

            if (Conn.State == ConnectionState.Open)
            {

                MessageBox.Show("Conexão efetuada com sucesso!", "Conexão MySQL!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Conn.Close();

            }
            PopulaComboBox();
            PopulaGrid();
        }

        #region Metodos
        public void PopulaComboBox()
        {
            var listConvenios = ConvenioRepository.FetchAll();


            cboConvenio.DataSource = new BindingSource(listConvenios, null);
            cboConvenio.DisplayMember = "nome";
            cboConvenio.ValueMember = "id";
        }

        public void PopulaGrid()
        {
            var listaPacientes = PessoaRepository.PreencherGrid();

            dgPessoa.DataSource = new BindingSource(listaPacientes, null);
        }

        private bool ValidaFormCadastro()
        {
            if (tbNome.Text.Equals(""))
                return false;
            if (mskCGCCPF.Text.Equals(""))
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

        private void LimparCampos()
        {
            tbNome.Text = string.Empty;
            tbBairro.Text = string.Empty;
            tbCidade.Text = string.Empty;
            tbNumero.Text = string.Empty;
            tbRua.Text = string.Empty;
            mskCGCCPF.Text = string.Empty;
            mskCep.Text = string.Empty;
            cboConvenio.SelectedIndex = -1;
            cboUf.SelectedIndex = -1;
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
                Pessoa pessoa = preencherPessoa();
                try
                {
                    pessoa = PessoaRepository.Save(pessoa);
                }
                catch (Exception myex)
                {
                    pessoa.Id = 0;
                }


                if (pessoa.Id > 0)
                {
                    Endereco endereco = preencherEndereco(pessoa);
                    EnderecoRepository.Save(endereco);
                }

                if (pessoa.Id > 0)
                {
                    Paciente paciente = new Paciente();
                    Int32.TryParse($"{paciente.Id}{rd.Next(100, 999)}", out int nrProntuario);
                    paciente.NrProntuario = nrProntuario;
                    paciente.PacienteRisco = "";
                    paciente.Convenio.Id = (int)cboConvenio.SelectedValue;
                    paciente.Pessoa = pessoa;

                    var pacienteResult = PacienteRepository.Save(paciente);
                }

                PopulaGrid();

            }
        }

        public Pessoa preencherPessoa()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = tbNome.Text;
            if (rbFisica.Checked)
            {
                pessoa.TipoPessoa = TipoPessoa.PF;
            }
            else
            {
                pessoa.TipoPessoa = TipoPessoa.PJ;
            }

            pessoa.CGCCPF = mskCGCCPF.Text;
            return pessoa;
        }

        public Endereco preencherEndereco(Pessoa pessoa)
        {
            Endereco endereco = new Endereco();
            endereco.CEP = mskCep.Text;
            endereco.Rua = tbRua.Text;
            endereco.Numero = Int32.Parse(tbNumero.Text);
            endereco.Bairro = tbBairro.Text;
            endereco.Cidade = tbCidade.Text;
            endereco.UF = cboUf.SelectedItem.ToString();
            endereco.Pessoa = pessoa;
            return endereco;
        }
        #endregion

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

    }
}
