using Devs2Blu.ProjetosAula.SistemaCadastro.Models.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Forms.Data
{
    public class EnderecoRepository
    {
        public Endereco Save(Endereco endereco)
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();
            try
            {
                endereco.Id = SaveEndereco(endereco, conn);

                return endereco;
            }
            catch (Exception myex)
            {
                MessageBox.Show(myex.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private Int32 SaveEndereco(Endereco endereco, MySqlConnection conn)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_INSERT_ENDERECO, conn);

                cmd.Parameters.Add("@idPessoa", MySqlDbType.VarChar, 50).Value = endereco.Pessoa.Id;
                cmd.Parameters.Add("@CEP", MySqlDbType.VarChar, 50).Value = endereco.CEP;
                cmd.Parameters.Add("@rua", MySqlDbType.VarChar, 50).Value = endereco.Rua;
                cmd.Parameters.Add("@numero", MySqlDbType.VarChar, 50).Value = endereco.Numero;
                cmd.Parameters.Add("@bairro", MySqlDbType.VarChar, 50).Value = endereco.Bairro;
                cmd.Parameters.Add("@cidade", MySqlDbType.VarChar, 50).Value = endereco.Cidade;
                cmd.Parameters.Add("@uf", MySqlDbType.VarChar, 50).Value = endereco.UF;
                cmd.ExecuteNonQuery();
                return (int)cmd.LastInsertedId;
            }
            catch (Exception myex)
            {
                MessageBox.Show(myex.Message, "Erro ao Salvar Endereco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

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

    }
}
