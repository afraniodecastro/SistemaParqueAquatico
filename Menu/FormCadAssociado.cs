using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;//arquivo de conexão com banco de daods

namespace Menu
{
    public partial class FormCadCliente : Form
    {
        public string nome;
        public string dataNascimento;
        public string senha1, senha2;
        public string valor, email, tipoCota, sexo, usuario,telefone;
        string acao = "Inserir";
        int codigoAssociado = 0;

        private MySqlConnection conexao;
        //private string dados_acesso = ("server=localhost;port=3306;User Id=root;database=clube;password=root");
        private string dados_acesso = ("datasource=localhost;username=root;password=root;database=clube");
        private void CBtipoCota_SelectedIndexChanged(object sender, EventArgs e)
        {
           // MessageBox.Show((string)CBtipoCota.SelectedItem);
            if((string)CBtipoCota.SelectedItem == "Familiar")
            {
                TBvalor.Text = "120"; 
            }else if ((string)CBtipoCota.SelectedItem == "Individual")
            {
                TBvalor.Text = "50";
            }
        }

        public FormCadCliente()
        {
            InitializeComponent();
            CBtipoCota.Items.Add("Familiar");
            CBtipoCota.Items.Add("Individual"); 
        }

        private void BTCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TBNome.Text = "";
            TBDataNascimento.Text = "";
            TBsenha1.Text = "";
            TBsenha2.Text = "";
            TBusuario.Text = "";
            TBvalor.Text = "";
            TTBemail.Text = "";
            TBtelefone.Text = "";
            CBtipoCota.Text = "";
            RBfeminino.Checked = false;
            RBmasculino.Checked = false;

            LBnome.ForeColor = Color.Black;
            LBnome.Font = new Font(LBnome.Font, FontStyle.Regular);

            LBtelefone.ForeColor = Color.Black;
            LBtelefone.Font = new Font(LBtelefone.Font, FontStyle.Regular);

            LBdataNascimento.ForeColor = Color.Black;
            LBdataNascimento.Font = new Font(LBdataNascimento.Font, FontStyle.Regular);

            LBsenha1.ForeColor = Color.Black;
            LBsenha1.Font = new Font(LBsenha1.Font, FontStyle.Regular);

            LBsenha2.ForeColor = Color.Black;
            LBsenha2.Font = new Font(LBsenha2.Font, FontStyle.Regular);

            LBusuario.ForeColor = Color.Black;
            LBusuario.Font = new Font(LBusuario.Font, FontStyle.Regular);

            LBvalor.ForeColor = Color.Black;
            LBvalor.Font = new Font(LBvalor.Font, FontStyle.Regular);

            LBemail.ForeColor = Color.Black;
            LBemail.Font = new Font(LBemail.Font, FontStyle.Regular);

            LBsexo.ForeColor = Color.Black;
            LBsexo.Font = new Font(LBsexo.Font, FontStyle.Regular);

            LBtipoCota.ForeColor = Color.Black;
            LBtipoCota.Font = new Font(LBtipoCota.Font, FontStyle.Regular);
        }

        private void BTSalvar_Click(object sender, EventArgs e)
        {
            if((TBNome.Text == "")
                ||(TBDataNascimento.Text == "")
                ||(TBsenha1.Text == "")
                ||(TBsenha2.Text == "")
                ||(TBusuario.Text == "")
                ||(TBvalor.Text == "")
                ||(TTBemail.Text == "")
                ||((RBmasculino.Checked == false) && (RBfeminino.Checked == false))
                ||(CBtipoCota.SelectedItem == null)
                ||(TBtelefone.Text==""))
            {
                if (TBNome.Text == "")
                {
                    LBnome.ForeColor = Color.Red;
                    LBnome.Font = new Font(LBnome.Font, FontStyle.Bold);
                }
                else
                {
                    LBnome.ForeColor = Color.Black;
                    LBnome.Font = new Font(LBnome.Font, FontStyle.Regular);
                }

                if (TBtelefone.Text == "")
                {
                    LBtelefone.ForeColor = Color.Red;
                    LBtelefone.Font = new Font(LBtelefone.Font, FontStyle.Bold);
                }
                else
                {
                    LBtelefone.ForeColor = Color.Black;
                    LBtelefone.Font = new Font(LBtelefone.Font, FontStyle.Regular);
                }

                if (TBDataNascimento.Text == "")
                {
                    LBdataNascimento.ForeColor = Color.Red;
                    LBdataNascimento.Font = new Font(LBdataNascimento.Font, FontStyle.Bold);
                }
                else
                {
                    LBdataNascimento.ForeColor = Color.Black;
                    LBdataNascimento.Font = new Font(LBdataNascimento.Font, FontStyle.Regular);
                }

                if (TBsenha1.Text == "")
                {
                    LBsenha1.ForeColor = Color.Red;
                    LBsenha1.Font = new Font(LBsenha1.Font, FontStyle.Bold);
                }
                else
                {
                    LBsenha1.ForeColor = Color.Black;
                    LBsenha1.Font = new Font(LBsenha1.Font, FontStyle.Regular);
                }

                if (TBsenha2.Text == "")
                {
                    LBsenha2.ForeColor = Color.Red;
                    LBsenha2.Font = new Font(LBsenha2.Font, FontStyle.Bold);
                }
                else
                {
                    LBsenha2.ForeColor = Color.Black;
                    LBsenha2.Font = new Font(LBsenha2.Font, FontStyle.Regular);
                }

                if (TBusuario.Text == "")
                {
                    LBusuario.ForeColor = Color.Red;
                    LBusuario.Font = new Font(LBusuario.Font, FontStyle.Bold);
                }
                else
                {
                    LBusuario.ForeColor = Color.Black;
                    LBusuario.Font = new Font(LBusuario.Font, FontStyle.Regular);
                }

                if (TBvalor.Text == "")
                {
                    LBvalor.ForeColor = Color.Red;
                    LBvalor.Font = new Font(LBvalor.Font, FontStyle.Bold);
                }
                else
                {
                    LBvalor.ForeColor = Color.Black;
                    LBvalor.Font = new Font(LBvalor.Font, FontStyle.Regular);
                }

                if (TTBemail.Text == "")
                {
                    LBemail.ForeColor = Color.Red;
                    LBemail.Font = new Font(LBemail.Font, FontStyle.Bold);
                }
                else
                {
                    LBemail.ForeColor = Color.Black;
                    LBemail.Font = new Font(LBemail.Font, FontStyle.Regular);
                }

                if ((RBmasculino.Checked == false) && (RBfeminino.Checked == false))
                {
                    LBsexo.ForeColor = Color.Red;
                    LBsexo.Font = new Font(LBsexo.Font, FontStyle.Bold);
                }
                else
                {
                    LBsexo.ForeColor = Color.Black;
                    LBsexo.Font = new Font(LBsexo.Font, FontStyle.Regular);
                }

                if (CBtipoCota.SelectedItem == null)
                {
                    LBtipoCota.ForeColor = Color.Red;
                    LBtipoCota.Font = new Font(LBtipoCota.Font, FontStyle.Bold);
                }
                else
                {
                    LBtipoCota.ForeColor = Color.Black;
                    LBtipoCota.Font = new Font(LBtipoCota.Font, FontStyle.Regular);                    
                }
            }
            else
            {
                if ((TBsenha1.Text != TBsenha2.Text))
                {
                    LBsenha1.ForeColor = Color.Blue;
                    LBsenha2.ForeColor = Color.Blue;
                    LBsenha1.Text = "As senhas não conferem";
                    LBsenha2.Text = "As senhas não conferem";
                    LBsenha1.Font = new Font(LBsenha1.Font, FontStyle.Bold);
                    LBsenha2.Font = new Font(LBsenha2.Font, FontStyle.Bold);
                }
                else
                {
                    LBsenha1.ForeColor = Color.Black;
                    LBsenha2.ForeColor = Color.Black;
                    LBsenha1.Text = "Senha *";
                    LBsenha2.Text = "Repetir senha *";
                    LBsenha1.Font = new Font(LBsenha1.Font, FontStyle.Regular);
                    LBsenha2.Font = new Font(LBsenha2.Font, FontStyle.Regular);

                    nome = TBNome.Text;
                    telefone = TBtelefone.Text;
                    email = TTBemail.Text;
                    valor = TBvalor.Text;
                    dataNascimento = formataData(TBDataNascimento.Text, "US");

                    usuario = TBusuario.Text;
                    senha1 = TBsenha1.Text;
                    tipoCota = "";
                    if ((string)CBtipoCota.SelectedItem == "Familiar")
                    {
                        tipoCota = "F";
                    }
                    else
                    {
                        tipoCota = "I";
                    }

                    if (RBmasculino.Checked)
                    {
                        sexo = "M";
                    }
                    else
                    {
                        sexo = "F";
                    }
                    try
                    {
                        //Criar Conexao com o Mysql
                        conexao = new MySqlConnection(dados_acesso);
                        string sql = "";
                        if (acao == "Inserir")
                        {
                            sql = "INSERT INTO associado (nome,data_nascimento,sexo,email,tipo_cota,valor_cota,telefone,usuario,senha) VALUES('" + nome + "','"
                                                + dataNascimento + "','"
                                                + sexo + "','"
                                                + email + "','"
                                                + tipoCota + "','"
                                                + valor + "','"
                                                + telefone + "','"
                                                + usuario + "','"
                                                + senha1 + "')";
                        }else if (acao == "Alterar")
                        {
                            sql = "UPDATE associado SET     nome = '"+nome+"', " +
                                                            "data_nascimento = '"+dataNascimento+"', " +
                                                            "sexo = '"+sexo+"', " +
                                                            "email = '"+email+"', " +
                                                            "tipo_cota = '"+tipoCota+"', " +
                                                            "valor_cota = '"+valor+"', " +
                                                            "telefone = '"+telefone+"', " +
                                                            "usuario = '"+usuario+"', " +
                                                            "senha = '"+senha1+"'" +
                                   "WHERE (codigo = '"+codigoAssociado+ "');";
                        }
                        MySqlCommand comando = new MySqlCommand(sql,conexao);
                        
                        conexao.Open();
                        comando.ExecuteNonQuery();

                        MessageBox.Show("Sucesso. Associado Cadastrado com sucesso", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // conexao.Close();
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Falha de acesso ao BD" + erro,"ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conexao.Close();
                    }

                    TBNome.Text = "";
                    TBDataNascimento.Text = "";
                    TBsenha1.Text = "";
                    TBsenha2.Text = "";
                    TBusuario.Text = "";
                    TBvalor.Text = "";
                    TTBemail.Text = "";
                    TBtelefone.Text = "";
                    RBmasculino.Checked = false;
                    RBfeminino.Checked = false;
                    CBtipoCota.SelectedItem = null;
                }
                
            }    
        }
        private string formataData(string dataBR, string tipo)
        {
            string tempDia, tempMes, tempAno, dataUSBR="";
            tempDia = dataBR;
            tempMes = dataBR;
            tempAno = dataBR;
            if (tipo == "US")
            {
                tempDia = tempDia.Substring(0, 2);
                tempMes = tempMes.Substring(3, 2);
                tempAno = tempAno.Substring(6, 4);

                dataUSBR = tempAno + "-" + tempMes + "-" + tempDia;
            }
            else
            {
                tempAno = tempAno.Substring(0, 4);
                tempMes = tempMes.Substring(5, 2);
                tempDia = tempDia.Substring(8, 2);
                
                dataUSBR = tempDia + "/" + tempMes + "/" + tempAno;
            }
            return dataUSBR;
        }

        public void AlteraAssociado(string idAssociado)
        {

            try
            {
                conexao = new MySqlConnection(dados_acesso);
                string sql = "SELECT * FROM associado WHERE codigo ="+idAssociado+";";

                conexao.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                MySqlDataReader reader = comando.ExecuteReader();
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
                    
                    TBNome.Text             = reader.GetString(1); //nome
                    TBDataNascimento.Text   = reader.GetString(2);
                    if(reader.GetString(3) == "F")
                    {
                        RBfeminino.Checked = true;
                    }
                    else
                    {
                        RBmasculino.Checked = true;
                    }
                    TTBemail.Text = reader.GetString(4); //email
                    if(reader.GetString(5) == "I")
                    {
                        CBtipoCota.SelectedItem = "Individual";
                    }
                    else
                    {
                        CBtipoCota.SelectedItem = "Familiar";
                    }
                    TBvalor.Text = reader.GetString(6);     //valor cota
                    TBtelefone.Text = reader.GetString(7);  // telefone
                    TBusuario.Text = reader.GetString(8);   // usuario
                    TBsenha1.Text = reader.GetString(9);    //senha 
                    TBsenha2.Text = reader.GetString(9);    //senha
                    acao = "Alterar";
                    codigoAssociado = int.Parse(idAssociado);
                    this.ShowDialog();
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
    }
}
