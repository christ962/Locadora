﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACRRENTALCAR
{
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Form frm = new frmCadastroCliente();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
