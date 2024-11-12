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
    public partial class frmExcludeCtg : Form
    {
        public frmExcludeCtg()
        {
            InitializeComponent();
        }

        private void btnExclude_Click(object sender, EventArgs e)
        {
            int idCategoria = Convert.ToInt32(tbxExclude.Text);

            CategoriaController categoriaController = new CategoriaController();
            bool resultado = categoriaController.RemoveCategoria(idCategoria);
            if(resultado == true)
            {
                this.Close();
            }

        }
    }
}
