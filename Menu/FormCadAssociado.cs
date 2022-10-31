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
    public partial class FormCadCliente : Form
    {
        public string nome;
        public string dataNascimento;
        public string senha1, senha2;
        public string valor, email, tipoCota, sexo, usuario,telefone;

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
                    nome = TBNome.Text;
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
                    telefone = TBtelefone.Text;
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
                    dataNascimento = TBDataNascimento.Text;
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
                    senha1 = TBsenha1.Text;
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
                    senha2 = TBsenha2.Text;
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
                    usuario = TBusuario.Text;
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
                    valor = TBvalor.Text;
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
                    email = TTBemail.Text;
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
                    if (RBmasculino.Checked)
                    {
                        sexo = "Masculino";
                    }
                    else
                    {
                        sexo = "Feminino";
                    }
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
                    tipoCota = "";
                    if (CBtipoCota.SelectedItem == "Familiar"){
                        tipoCota = "Familiar";
                    }
                    else
                    {
                        tipoCota = "Individual";
                    }
                    
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

                    FmostraDados fmd = new FmostraDados(this);
                    fmd.ShowDialog();
                }
                
            }        
            

        }
    }
}
