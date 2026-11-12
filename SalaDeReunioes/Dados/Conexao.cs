using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
using Microsoft.Extensions.Configuration;

namespace SalaDeReunioes.Dados
{
    internal class Conexao
    {
        private static readonly IConfiguration configuration = new ConfigurationBuilder().AddUserSecrets<Conexao>().Build();

        private static readonly string connectionString = configuration.GetConnectionString("DefaultConnection")?? throw new InvalidOperationException("A string de conexão não foi configurada.");

        public static NpgsqlConnection GetConexao()
        {
            return new NpgsqlConnection(connectionString);
        }

        public static bool TestarConexao()
        {
            using (NpgsqlConnection conexao = GetConexao())
            {
                conexao.Open();
                return true;
            }
        }
    }
}
