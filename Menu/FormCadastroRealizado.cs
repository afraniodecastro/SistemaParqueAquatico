﻿using System;
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
    public partial class FmostraDados : Form
    {
        public string nome;
        public FmostraDados(FormCadCliente fcc)
        {
            InitializeComponent();
        }

        private void BTCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
