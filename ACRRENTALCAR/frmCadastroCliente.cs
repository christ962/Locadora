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
    public partial class frmCadastroCliente : Form
    {
        
        public frmCadastroCliente()
        {
            
            InitializeComponent();
        }
        private void habilitar()
        {
           
            txtCodigo.Enabled = false;
            txtNome.Enabled = true;
            mskCPF.Enabled = true;
            mskDtNasc.Enabled = true;
        }
        private void desabilitar()
        {
          
            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            mskCPF.Enabled = false;
            mskDtNasc.Enabled = false;
        }
        private void limparControles()
        {
          
            txtCodigo.Enabled = false;
            txtNome.Clear();
            txtCodigo.Clear();
            mskCPF.Clear();
            mskDtNasc.Clear();
            mskCPF.Focus();
        }
        private bool validaDados()
        {
            
            if (string.IsNullOrEmpty(mskCPF.Text))
            {
              
                MessageBox.Show("Preenchimento de campo obrigatório", "ACR Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
                mskCPF.Clear();

               
                mskCPF.Focus();

              
                return false;
            }

           
            DateTime auxData; 
                              
            if (!(DateTime.TryParse(mskDtNasc.Text, out auxData)))
            {
               
                MessageBox.Show("Preenchimento de campo obrigatório", "ACR Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                mskDtNasc.Clear();


                mskDtNasc.Focus();

               
                return false;
            }

            return true;

            if (string.IsNullOrEmpty(txtNome.Text))
            {
           
                MessageBox.Show("Preenchimento de campo obrigatório", "ACR Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Information);

             
                txtNome.Clear();

               
                txtNome.Focus();

             
                return false;
            }

            
            return true;
        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
           
            Form frm = new frmConsultaCliente(this);

           
            frm.MdiParent = this.MdiParent;

          
            frm.Show();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
