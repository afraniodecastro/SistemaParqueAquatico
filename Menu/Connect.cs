using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public class Connect
    {
        static public void conecta()
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection("server=localhost;port=3306;User Id=root;database=clube;password=root");
                conexao.Open();
                MessageBox.Show("Conectado");
                conexao.Close();
            }
            catch
            {
                MessageBox.Show("Falha de acesso ao BD", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
