using ProjetoAgenda.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgenda.Views
{
    public partial class frmAddCtg : Form
    {
        public frmAddCtg()
        {
            InitializeComponent();
        }

        private void tbxNomeCtg_TextChanged(object sender, EventArgs e)
        {


        }
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            // definindo o parametro
            string nomeCtg = tbxNomeCtg.Text;

            // instanciando a parada e adicionando no banco de dados tome
            CategoriaController addToDb = new CategoriaController();

            bool resultado = addToDb.AddCategoria(nomeCtg);

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tbxNomeCtg.Text = "";
        }

    }
}
