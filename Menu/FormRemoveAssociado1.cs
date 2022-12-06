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

namespace Menu
{
    public partial class FormRemoveAssociado1 : Form
    {
        private MySqlConnection conexao;
        private string dados_acesso = ("datasource=localhost;username=root;password=root;database=clube");
        public FormRemoveAssociado1()
        {
            InitializeComponent();
            LVdados.View = View.Details;
            LVdados.LabelEdit = true;
            LVdados.AllowColumnReorder = true;
            LVdados.FullRowSelect = true;
            LVdados.GridLines = true;
            LVdados.Clear();

           BTRemover.Enabled = false;

            LVdados.Columns.Add("Codigo", 30, HorizontalAlignment.Center);
            LVdados.Columns.Add("NOME", 150, HorizontalAlignment.Center);
            LVdados.Columns.Add("Data Nascimento", 100, HorizontalAlignment.Center);
            LVdados.Columns.Add("SEXO", 60, HorizontalAlignment.Center);
            LVdados.Columns.Add("EMAIL", 130, HorizontalAlignment.Center);
            LVdados.Columns.Add("TIPO COTA", 60, HorizontalAlignment.Center);
            LVdados.Columns.Add("Valor Cota", 60, HorizontalAlignment.Center);
            LVdados.Columns.Add("Telefone", 60, HorizontalAlignment.Center);
            LVdados.Columns.Add("Usuario", 60, HorizontalAlignment.Center);
            LVdados.Columns.Add("Senha", 60, HorizontalAlignment.Center);    
            CarregarDados();
        }

        private void BTCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TBbuscar.Clear();    
        }

        private void CarregarDados()
        {
            try
            {
                conexao = new MySqlConnection(dados_acesso);
                string sql = "SELECT * FROM associado;";

                conexao.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                MySqlDataReader reader = comando.ExecuteReader();
                LVdados.Items.Clear();

                while (reader.Read())
                {
                    string[] linha =
                    {
                        reader.GetString(0), //codigo
                        reader.GetString(1), //nome
                        reader.GetString(2), //data nascimento
                        reader.GetString(3), //sexo
                        reader.GetString(4), //email
                        reader.GetString(5), //tipo cota
                        reader.GetString(6), //valor cota
                        reader.GetString(7), // telefone
                        reader.GetString(8), // usuario
                        reader.GetString(9) //senha 
                    };
                    var linha_listView = new ListViewItem(linha);
                    LVdados.Items.Add(linha_listView);
                }
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Ocorreu: " + erro.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void LVdados_SelectedIndexChanged(object sender, EventArgs e)
        {
            BTRemover.Enabled = true;
        }

        private void BTRemover_Click(object sender, EventArgs e)
        {
            removeAssociado();
        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            removeAssociado();
        }

        private void removeAssociado()
        {
            DialogResult conf = MessageBox.Show("Deseja mesmo remover esse registro? ",
                            "Deseja remover?",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);
            if (conf == DialogResult.Yes)
            {
                ListView.SelectedListViewItemCollection itens_selecionados = LVdados.SelectedItems;
                foreach (ListViewItem item in itens_selecionados)
                {
                    try
                    {
                        conexao = new MySqlConnection(dados_acesso);
                        string sql = "DELETE FROM associado WHERE (`codigo` = '" + item.SubItems[0].Text + "');";

                        conexao.Open();
                        MySqlCommand comando = new MySqlCommand(sql, conexao);
                        MySqlDataReader reader = comando.ExecuteReader();
                        CarregarDados();
                    }
                    catch (MySqlException erro)
                    {
                        MessageBox.Show("Ocorreu: " + erro.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Registro Removido com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BTbuscar_Click(object sender, EventArgs e)
        {
            string criterioBusca = "'%" + TBbuscar.Text + "%'";
            try
            {
                conexao = new MySqlConnection(dados_acesso);
                string sql = "SELECT * FROM associado WHERE nome LIKE " + criterioBusca + " or email LIKE " + criterioBusca + ";";

                conexao.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                MySqlDataReader reader = comando.ExecuteReader();
                LVdados.Items.Clear();

                while (reader.Read())
                {
                    string[] linha =
                    {
                        reader.GetString(0), //codigo
                        reader.GetString(1), //nome
                        reader.GetString(2), //data nascimento
                        reader.GetString(3), //sexo
                        reader.GetString(4), //email
                        reader.GetString(5), //tipo cota
                        reader.GetString(6), //valor cota
                        reader.GetString(7), // telefone
                        reader.GetString(8), // usuario
                        reader.GetString(9) //senha 
                    };
                    var linha_listView = new ListViewItem(linha);
                    LVdados.Items.Add(linha_listView);
                }
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
