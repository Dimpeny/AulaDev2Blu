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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConvenioRepository = new ConvenioRepository();
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
        #endregion

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

    }
}
