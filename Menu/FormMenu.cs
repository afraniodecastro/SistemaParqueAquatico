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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }
        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormCadCliente fcc = new FormCadCliente();
            fcc.ShowDialog();
        }

        private void alterarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Faltera fcc = new Faltera();
            fcc.ShowDialog();
        }

        private void cadastrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormCadEndereco fce = new FormCadEndereco();
            fce.ShowDialog();
        }

        private void excluirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormRemoveAssociado1 fce = new FormRemoveAssociado1();
            fce.ShowDialog();
        }

        private void removerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRemoveEndereco fre = new FormRemoveEndereco();
            fre.ShowDialog();
        }

        private void alterarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormAlteraEndereco altera = new FormAlteraEndereco();
            altera.ShowDialog();
        }
    }
}
