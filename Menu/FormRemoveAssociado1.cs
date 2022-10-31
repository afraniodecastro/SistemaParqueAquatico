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
        public FormRemoveAssociado1()
        {
            InitializeComponent();
        }

        private void BTCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TBpesquisaAssociado.Clear();    
        }
    }
}
