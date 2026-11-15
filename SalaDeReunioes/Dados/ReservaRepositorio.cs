using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
using SalaDeReunioes.Models;

namespace SalaDeReunioes.Dados
{
    internal class ReservaRepositorio
    {
        public void Cadastrar(Reserva reserva)
        {
            using (NpgsqlConnection conexao = Conexao.GetConexao())
            {
                conexao.Open();

                string sql = "INSERT INTO reservas (sala_id, inicio, fim) VALUES (@sala_id, @inicio, @fim)";

                using (NpgsqlCommand comando = new NpgsqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@sala_id", reserva.SalaId);
                    comando.Parameters.AddWithValue("@inicio", reserva.Inicio);
                    comando.Parameters.AddWithValue("@fim", reserva.Fim);

                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Alterar(Reserva reserva)
        {
            using (NpgsqlConnection conexao = Conexao.GetConexao())
            {
                conexao.Open();

                string sql = "UPDATE reservas SET sala_id = @sala_id, inicio = @inicio, fim = @fim WHERE id = @id";

                using (NpgsqlCommand comando = new NpgsqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@sala_id", reserva.SalaId);
                    comando.Parameters.AddWithValue("@inicio", reserva.Inicio);
                    comando.Parameters.AddWithValue("@fim", reserva.Fim);
                    comando.Parameters.AddWithValue("@id", reserva.Id);

                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Excluir(int id)
        {
            using (NpgsqlConnection conexao = Conexao.GetConexao())
            {
                conexao.Open();

                string sql = "DELETE FROM reservas WHERE id = @id";

                using (NpgsqlCommand comando = new NpgsqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@id", id);

                    comando.ExecuteNonQuery();
                }
            }
        }

        public List<Reserva> ConsultarTodos()
        {
            List<Reserva> reservas = new List<Reserva>();

            using (NpgsqlConnection conexao = Conexao.GetConexao())
            {
                conexao.Open();

                string sql = "SELECT reservas.id, reservas.sala_id, salas.nome, salas.andar, reservas.inicio, reservas.fim FROM reservas INNER JOIN salas ON reservas.sala_id = salas.id ORDER BY reservas.inicio";

                using (NpgsqlCommand comando = new NpgsqlCommand(sql, conexao))
                {
                    using (NpgsqlDataReader leitor = comando.ExecuteReader())
                    {
                        while (leitor.Read())
                        {
                            Reserva reserva = new Reserva();

                            reserva.Id = leitor.GetInt32(0);
                            reserva.SalaId = leitor.GetInt32(1);
                            reserva.NomeSala = leitor.GetString(2);
                            reserva.AndarSala = leitor.GetInt32(3);
                            reserva.Inicio = leitor.GetDateTime(4);
                            reserva.Fim = leitor.GetDateTime(5);

                            reservas.Add(reserva);
                        }
                    }
                }
            }

            return reservas;
        }


    }
}
