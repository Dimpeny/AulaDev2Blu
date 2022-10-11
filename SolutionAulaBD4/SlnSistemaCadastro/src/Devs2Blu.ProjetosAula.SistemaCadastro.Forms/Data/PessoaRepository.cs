using Devs2Blu.ProjetosAula.sistemaCadastro.Models.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Forms.Data
{
    public class PessoaRepository
    {
        public Pessoa Save(Pessoa pessoa)
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();
            try
            {
                pessoa.Id = SavePessoa(pessoa, conn);

                return pessoa;
            }
            catch (Exception myex)
            {
                MessageBox.Show(myex.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private Int32 SavePessoa(Pessoa pessoa, MySqlConnection conn)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_INSERT_PESSOA, conn);
                cmd.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = pessoa.Nome;
                cmd.Parameters.Add("@cgccpf", MySqlDbType.VarChar, 25).Value = pessoa.CGCCPF;
                cmd.Parameters.Add("@tipopessoa", MySqlDbType.Enum).Value = pessoa.TipoPessoa;
                cmd.ExecuteNonQuery();
                return (int)cmd.LastInsertedId;
            }
            catch (Exception myex)
            {
                MessageBox.Show(myex.Message, "Erro ao Salvar Pessoa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public MySqlDataReader PreencherGrid()
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_GRID, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                return dataReader;
            }
            catch (Exception myex)
            {
                MessageBox.Show(myex.Message, "Erro ao buscar pessoas cadastradas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        #region SQLs

        private const String SQL_INSERT_PESSOA = @"INSERT INTO pessoa
(nome,
cgccpf,
tipopessoa,
flstatus)
VALUES
(@nome,
@cgccpf,
@tipopessoa,
'A')";
        private const String SQL_SELECT_GRID = @"SELECT `pessoa`.`id` as 'Id',
    `pessoa`.`nome` as 'Nome',
    `pessoa`.`tipopessoa` as 'Tipo',
    `pessoa`.`cgccpf` as 'CPF/CNPJ',
    `pessoa`.`flstatus`as 'Status pessoa',
    `paciente`.`numero_prontuario` as 'Prontuario',
    `paciente`.`paciente_risco` as 'Risco',
    `paciente`.`flstatus` as 'Status Paciente',
    `paciente`.`flobito` as 'Óbito',
    `endereco`.`CEP` as 'CEP',
    `endereco`.`rua` as 'Rua',
    `endereco`.`numero` as 'Numero',
    `endereco`.`bairro` as 'Bairro',
    `endereco`.`cidade` as 'Cidade',
    `endereco`.`UF` as 'UF',
    `convenio`.`nome` as 'Convênio'
FROM `sistemacadastro`.`pessoa`
LEFT JOIN `paciente`
ON `pessoa`.`id` = `paciente`.`pessoa_id`
LEFT JOIN `endereco`
ON `pessoa`.`id` =`endereco`.`id_pessoa`
LEFT JOIN `convenio`
ON `paciente`.`convenio_id` = `convenio`.`id`
WHERE `pessoa`.`flstatus` != 'E';";
        #endregion
    }
}
