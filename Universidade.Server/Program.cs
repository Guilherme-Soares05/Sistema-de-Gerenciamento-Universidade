using System;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace MeuProjeto
{
  class Program
  {
    static void Main(string[] args)
    {
      // Carrega as configura��es do arquivo appsettings.json
      IConfiguration configuration = new ConfigurationBuilder()
          .AddJsonFile("appsettings.json")
          .Build();

      // Obt�m a string de conex�o do arquivo de configura��o
      string connectionString = configuration.GetConnectionString("MySqlConnection");

      // Tenta estabelecer uma conex�o com o banco de dados MySQL
      using (var connection = new MySqlConnection(connectionString))
      {
        try
        {
          connection.Open();
          Console.WriteLine("Conex�o com o banco de dados MySQL estabelecida com sucesso!");
        }
        catch (Exception ex)
        {
          Console.WriteLine($"Erro ao tentar conectar ao banco de dados: {ex.Message}");
        }
      }
    }
  }
}
