using MySqlConnector;
using System.Data;
//using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace harakiri_rpg.Util.ADO
{
    public class ADO
    {
        private readonly string _connectionString;

        // Construtor que inicializa a string de conexão
        public ADO(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Método para executar stored procedures que não retornam dados
        public void ExecuteNonQuery(string storedProcedure, List<MySqlParameter> parameters = null)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                using (var command = new MySqlCommand(storedProcedure, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Adiciona parâmetros, se existirem
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters.ToArray());
                    }

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        // Método para executar stored procedures que retornam dados e retorna um DataTable
        public DataTable ExecuteQuery(string storedProcedure, List<MySqlParameter> parameters = null)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                using (var command = new MySqlCommand(storedProcedure, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Adiciona parâmetros, se existirem
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters.ToArray());
                    }

                    connection.Open();
                    var dataTable = new DataTable();
                    using (var reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                    return dataTable;
                }
            }
        }

        // Método genérico para executar uma stored procedure e mapear o resultado para um objeto (List<T>)
        public List<T> ExecuteQuery<T>(string storedProcedure, List<MySqlParameter> parameters = null) where T : new()
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                using (var command = new MySqlCommand(storedProcedure, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Adiciona parâmetros, se existirem
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters.ToArray());
                    }

                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        var result = new List<T>();
                        var properties = typeof(T).GetProperties().ToList();

                        while (reader.Read())
                        {
                            var obj = new T();
                            foreach (var property in properties)
                            {
                                var columnName = property.Name;
                                if (reader[columnName] != DBNull.Value)
                                {
                                    property.SetValue(obj, reader[columnName]);
                                }
                            }
                            result.Add(obj);
                        }
                        return result;
                    }
                }
            }
        }
    }
}
