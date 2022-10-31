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
    public partial class Faltera : Form
    {
        public Faltera()
        {
            InitializeComponent();
        }

        private void BTCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
