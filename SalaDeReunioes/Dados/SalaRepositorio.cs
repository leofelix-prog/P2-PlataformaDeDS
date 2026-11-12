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
    }
}
