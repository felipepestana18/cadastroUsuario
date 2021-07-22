
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroUsuario.Data
{
    public class Data : IDisposable
    {
        protected SqlConnection connectionDB;

        public Data()
        {
            try
            {
                // Se tiver usando o SQL normal É SÓ TIRAR \SQLEXPRESS              
                string strConexao = @"Data Source = localhost\SQLEXPRESS;
                                      initial Catalog = Usuario;
                                      integrated Security = true;
                                      MultipleActiveResultSets=True;";

                connectionDB = new SqlConnection(strConexao);

                connectionDB.Open();
            }
            catch (SqlException er)
            {
                Console.WriteLine("Erro do Banco " + er);
            }
        }
        public void Dispose()
        {
            connectionDB.Close();
        }
    }
}