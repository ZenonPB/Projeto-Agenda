using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ProjetoAgenda.Data;

namespace ProjetoAgenda.Controllers
{
    internal class AddToDb
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

                if (quantidadeAfetada > 0)
                {
                    // deu certo iupii
                    MessageBox.Show("Categoria cadastrada com sucesso!");
                    return true;
                }
                else
                {
                    // nao deu aaah:(
                    MessageBox.Show("Ocorreu um erro! Tente novamente");
                    return false;
                }

            }
            catch (Exception erro)
            {
                // se der erro mostra tlg
                MessageBox.Show($"Erro ao efetuar o cadastro:{erro.Message}");
                return false;
            }
        }
       
    }
}
