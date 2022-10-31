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
    public partial class FLogin : Form
    {
        string senha = "123456";
        string usuario = "afranio";
        public FLogin()
        {
            InitializeComponent();
        }
        private void BTLogin_Click(object sender, EventArgs e)
        {
            if ((TBSenha.Text == "") || (TBUser.Text == "")){ 
                if (TBSenha.Text == "") {
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
            }else{
                if ((TBSenha.Text == senha) && (TBUser.Text == usuario))
                {
                    FormMenu fcc = new FormMenu();
                    FLogin fl = new FLogin();
                    fl.Close();
                    fcc.ShowDialog();               
                }
                else
                {
                    LBErroAutenticacao.Text = "Usuário ou senha inválidos.";
                    LBErroAutenticacao.ForeColor = Color.Red;
                }
            }
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
    }
}
