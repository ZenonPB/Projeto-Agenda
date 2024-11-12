﻿    using System;
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
                MySqlConnection? conexao = null;
                try
                {
                    // Entrar e criar a conexao no SQL, inserindo o comando previsto na variavel sql
                    conexao = ConexaoDb.CriarConexao();

                    string sql = "INSERT INTO tbCategorias (categoria) VALUES (@nomeCtg);";

                    conexao.Open();

                    // adicionando os parametros e executando
                    MySqlCommand comando = new MySqlCommand(sql, conexao);

                    comando.Parameters.AddWithValue("@nomeCtg", nomeCtg);

                    // vendo a quantidade afetada e vendo se foi feito com sucesso ou nao
                    int quantidadeAfetada = comando.ExecuteNonQuery();
                    if( quantidadeAfetada > 0)
                    {
                        MessageBox.Show("Categoria adicionada com sucesso!");
                    }

                    conexao.Close();
                    return true;

                }
                catch (Exception erro)
                {
                    // se der erro mostra tlg
                    MessageBox.Show($"Erro ao efetuar o cadastro:{erro.Message}");
                    return false;
                }
                finally
                {
                    conexao?.Close();
                }
            }
       
            public DataTable GetCategorias()
            {
                MySqlConnection? conexao = null;

                try
                {
                    conexao = ConexaoDb.CriarConexao();

                    string sql = @"SELECT id AS 'Código', 
                                categoria AS 'Categoria' 
                                FROM tbCategorias;";

                    conexao.Open();

                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conexao);

                    // criando tabela vazia
                    DataTable tabela = new DataTable();

                    // preenchendo a tabela com os dados automaticamente ooooo coisa boa
                    adapter.Fill(tabela);

                    return tabela;
                }
                catch (Exception erro)
                {

                    // mensagem de erro e retornando uma tabela vazia, crua pra avisar que nao deu bom
                    MessageBox.Show($"Erro ao recuperar categorias: {erro.Message}");
                    return new DataTable();

                }
                finally
                {
                   if( conexao != null)
                    {
                        conexao.Close();
                    }
                }
            }

            public bool RemoveCategoria(int idCategoria)
            {
                try
                {
                    // Entrar e criar a conexao no SQL, inserindo o comando previsto na variavel sql
                    MySqlConnection conexao = ConexaoDb.CriarConexao();

                    string sql = "DELETE FROM tbCategorias WHERE id = @idCategoria;";

                    conexao.Open();

                    // adicionando os parametros e executando
                    MySqlCommand comando = new MySqlCommand(sql, conexao);

                    comando.Parameters.AddWithValue("@idCategoria", idCategoria);
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Categoria excluída com sucesso!");
                    conexao.Close();
                    return true;

                }
                catch (Exception erro)
                {
                    // se der erro mostra tlg
                    MessageBox.Show($"Erro ao excluir a categoria! {erro.Message}");
                    return false;
                }
            }
        }

    }
