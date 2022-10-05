using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Forms.Data
{
    public class ConvenioRepository
    {
        public MySqlDataReader FetchAll()
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_CONVENIO,conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                return dataReader;
            }catch(Exception myex)
            {
                MessageBox.Show(myex.Message,"Erro de MySQL",MessageBoxButtons.OK,MessageBoxIcon.Error);
                throw;
            }
        }
        

        #region SQLs
        private const String SQL_SELECT_CONVENIO = "SELECT * FROM convenio";
        #endregion
    }
}
