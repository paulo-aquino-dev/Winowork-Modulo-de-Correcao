using MySql.Data.MySqlClient;
using System;
using System.Data;


namespace WinoFix
{

    public class Conexao
    {
        public static string MySqlClientString = "server= 172.21.0.88;user id=root;password=winover;database=winover";

        public static void ConexaoBD()
        {

            MySqlConnection conn = new MySqlConnection(MySqlClientString);


            try
            {
                if (conn.State.Equals(ConnectionState.Closed))
                {
                    conn.Open();
                }
            }
            catch (MySqlException erro)
            {
                Console.WriteLine("Não foi possível conectar com o banco de dados : " + erro.Message);
            }
            finally
            {
                conn.Dispose();
            }

        }

    }
}
