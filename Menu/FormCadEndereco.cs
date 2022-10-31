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
    public partial class FormCadEndereco : Form
    {
        public FormCadEndereco()
        {
            InitializeComponent();
        }

        private void BTCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
