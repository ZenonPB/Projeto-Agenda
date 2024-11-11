using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ProjetoAgenda.Data;

namespace ProjetoAgenda.Controllers
{
    internal class CategoriaController
    {
        public bool AddCategoria(string nomeCtg)
        {
            try
            {
                // Entrar e criar a conexao no SQL, inserindo o comando previsto na variavel sql
                MySqlConnection conexao = ConexaoDb.CriarConexao();

                string sql = "INSERT INTO tbCategorias (categoria) VALUES (@nomeCtg);";

                conexao.Open();

                // adicionando os parametros e executando
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@nomeCtg", nomeCtg);

                // vendo a quantidade afetada e vendo se foi feito com sucesso ou nao
                int quantidadeAfetada = comando.ExecuteNonQuery();

                conexao.Close();
                return true;

            }
            catch (Exception erro)
            {
                // se der erro mostra tlg
                MessageBox.Show($"Erro ao efetuar o cadastro:{erro.Message}");
                return false;
            }
        }
       
        public DataTable GetCategorias()
        {
            MySqlConnection conexao = null;

            try
            {
                conexao = ConexaoDb.CriarConexao();

                string sql = @"SELECT id AS 'Código', 
                            categoria AS 'Categoria' 
                            FROM tbCategorias;";

                conexao.Open();

                MySqlDataAdapter adapter = new MySqlDataAdapter();
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao recuperar categorias: {erro.Message}")
            }
        }
    }
}
