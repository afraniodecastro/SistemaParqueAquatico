using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Menu
{
    public partial class FLogin : Form
    {

        private MySqlConnection conexao;
        private string dados_acesso = ("datasource=localhost;" +
            "username=root;password=root;database=clube");
        public FLogin()
        {
            InitializeComponent();
        }
        private void BTSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void BTlimpar_Click(object sender, EventArgs e)
        {
            LBErroAutenticacao.Text = "";
            LBusuario.Text = "";
            LBsenha.Text = "";
            TBSenha.Text = "";
            TBUser.Text = "";
        }

        private void BTLogin_Click(object sender, EventArgs e)
        {
            if ((TBSenha.Text == "") || (TBUser.Text == ""))
            {
                if (TBSenha.Text == "")
                {
                    LBsenha.Text = "Informe a senha";
                    LBsenha.ForeColor = Color.Red;
                }
                else
                {
                    LBsenha.Text = "";
                }
                if (TBUser.Text == "")
                {
                    LBusuario.Text = "Informe o usuário";
                    LBusuario.ForeColor = Color.Red;
                }
                else
                {
                    LBusuario.Text = "";
                }
            }
            else
            {
                try
                {
                    conexao = new MySqlConnection(dados_acesso);
                    string sql = "SELECT * FROM associado WHERE usuario = '" + TBUser.Text + 
                        "' and senha = '" + TBSenha.Text + "';";

                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand(sql, conexao);
                    MySqlDataReader reader = comando.ExecuteReader();
                    reader.Read();

                    if (reader.GetString(0) != "")
                    {
                        FormMenu fcc = new FormMenu();
                        fcc.ShowDialog();
                    }
                    else
                    {
                        LBErroAutenticacao.Text = "Usuário ou senha inválidos.";
                        LBErroAutenticacao.ForeColor = Color.Red;
                    }


                }
                catch (MySqlException erro)
                {
                    //MessageBox.Show("Ocorreu: " + erro.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LBErroAutenticacao.Text = "Usuário ou senha inválidos.";
                    LBErroAutenticacao.ForeColor = Color.Red;
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Falha de acesso ao BD" + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conexao.Close();
                }
            }
        }
    }
}
