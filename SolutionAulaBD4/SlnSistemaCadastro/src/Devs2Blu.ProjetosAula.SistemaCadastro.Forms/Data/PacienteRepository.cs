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
    public class PacienteRepository
    {
        public Paciente Save(Paciente paciente)
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();
            try
            {
                paciente.Pessoa.Id = SavePaciente(paciente,conn);

                return paciente;
            }
            catch (Exception myex)
            {
                MessageBox.Show(myex.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private Int32 SavePaciente(Paciente paciente, MySqlConnection conn)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_INSERT_PACIENTE, conn);
                cmd.Parameters.Add("@pessoa_id", MySqlDbType.Int32, 11).Value = paciente.Pessoa.Id;
                cmd.Parameters.Add("@convenio_id", MySqlDbType.VarChar, 25).Value = paciente.Convenio.Id;
                cmd.Parameters.Add("@numero_prontuario", MySqlDbType.Enum).Value = paciente.NrProntuario;
                cmd.Parameters.Add("@paciente_risco", MySqlDbType.VarChar,5).Value = paciente.PacienteRisco;
                
                cmd.ExecuteNonQuery();
                return (int)cmd.LastInsertedId;
            }
            catch (Exception myex)
            {
                MessageBox.Show(myex.Message, "Erro ao Salvar Paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        public MySqlDataReader FetchAll()
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_PACIENTE, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                return dataReader;
            }
            catch (Exception myex)
            {
                MessageBox.Show(myex.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        #region SQLs

        private const String SQL_INSERT_ENDERECO = @"INSERT INTO `sistemacadastro`.`endereco`
(id_pessoa,
CEP,
rua,
numero,
bairro,
cidade,
uf)
VALUES
(@idPessoa,
@CEP,
@rua,
@numero,
@bairro,
@cidade,
@uf)";
        private const String SQL_INSERT_PACIENTE = @"INSERT INTO paciente
(pessoa_id,
convenio_id,
numero_prontuario,
paciente_risco,
flstatus,
flobito)
VALUES
(@pessoa_id,
@convenio_id,
@numero_prontuario,
@paciente_risco,
'A',
0)";

        private const String SQL_SELECT_PACIENTE = @"SELECT id,
    numero_pronturaio,
    paciente_risco,
    flstatus,
    flobito,
    pessoa_id,
    convenio_id
FROM sistemacadastro.paciente";
        #endregion

    }
}
