using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ACRRENTALCAR
{
    public partial class frmConsultaCliente : Form
    {
        frmCadastroCliente frmCliente;
        public frmConsultaCliente(frmCadastroCliente frmCliente)
        {   
            this.frmCliente = frmCliente;
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultaCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
