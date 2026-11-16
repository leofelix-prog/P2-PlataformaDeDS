using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
using SalaDeReunioes.Models;

namespace SalaDeReunioes.Dados
{
    internal class SalaRepositorio
    {
        public void Cadastrar(Sala sala)
        {
            using (NpgsqlConnection conexao = Conexao.GetConexao())
            {
                conexao.Open();

                string sql = "INSERT INTO salas (nome, andar, qtddassentos) VALUES (@nome, @andar, @qtddassentos)";

                using (NpgsqlCommand comando = new NpgsqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@nome", sala.Nome);
                    comando.Parameters.AddWithValue("@andar", sala.Andar);
                    comando.Parameters.AddWithValue("@qtddassentos", sala.QtddAssentos);

                    comando.ExecuteNonQuery();
                }
            }
        }

        public List<Sala> ConsultarTodos()
        {
            List<Sala> salas = new List<Sala>();

            using (NpgsqlConnection conexao = Conexao.GetConexao())
            {
                conexao.Open();

                string sql = "SELECT * FROM salas ORDER BY andar, nome";

                using (NpgsqlCommand comando = new NpgsqlCommand(sql, conexao))
                {
                    using (NpgsqlDataReader leitor = comando.ExecuteReader())
                    {
                        while (leitor.Read())
                        {
                            Sala sala = new Sala();

                            sala.Id = leitor.GetInt32(0);
                            sala.Nome = leitor.GetString(1);
                            sala.Andar = leitor.GetInt32(2);
                            sala.QtddAssentos = leitor.GetInt32(3);

                            salas.Add(sala);
                        }
                    }
                }
            }

            return salas;
        }

        public void Alterar(Sala sala)
        {
            using (NpgsqlConnection conexao = Conexao.GetConexao())
            {
                conexao.Open();

                string sql = "UPDATE salas SET nome = @nome, andar = @andar, qtddassentos = @qtddassentos WHERE id = @id";

                using (NpgsqlCommand comando = new NpgsqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@nome", sala.Nome);
                    comando.Parameters.AddWithValue("@andar", sala.Andar);
                    comando.Parameters.AddWithValue("@qtddassentos", sala.QtddAssentos);
                    comando.Parameters.AddWithValue("@id", sala.Id);

                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Excluir(int id)
        {
            using (NpgsqlConnection conexao = Conexao.GetConexao())
            {
                conexao.Open();

                string sql = "DELETE FROM salas WHERE id = @id";

                using (NpgsqlCommand comando = new NpgsqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@id", id);

                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
