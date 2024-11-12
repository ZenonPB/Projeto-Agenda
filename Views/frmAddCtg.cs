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

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            // definindo o parametro
            string nomeCtg = tbxNomeCtg.Text;

            // instanciando a parada e adicionando no banco de dados tome
            CategoriaController controleCategoria = new CategoriaController();
            controleCategoria.AddCategoria(nomeCtg);

            DataTable tabela = controleCategoria.GetCategorias();
            dataGridView1.DataSource = tabela;

        }

        private void AtualizarTabela()
        {
            CategoriaController controleCategoria = new CategoriaController();
            DataTable tabela = controleCategoria.GetCategorias();
            dataGridView1.DataSource = tabela;
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tbxNomeCtg.Text = "";
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.SelectedCells[0].Value;
            CategoriaController categoriaController = new CategoriaController();
            categoriaController.RemoveCategoria(id);
        }
    }
}