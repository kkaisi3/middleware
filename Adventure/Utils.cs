using Microsoft.Data.SqlClient;
using System.Text.Json;


namespace Adventure
{
    //public class Utils
    //{
       
    //    public const string CONNECTION_STRING = GetConnectionString("DefaultConnection");
    //    public string ConnectionString()
    //    {

    //    }

    //    public static void DropAndCreateDatabase()
    //    {
    //        using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
    //        {
    //            conn.Open();
    //            SqlCommand dropDb = new SqlCommand
    //                (
    //                 "alter database Adventure set single_user with rollback immediate DROP DATABASE IF EXISTS Adventure", conn
    //                );
    //            SqlCommand createDb = new SqlCommand("CREATE DATABASE Adventure", conn);
    //            dropDb.ExecuteNonQuery();
    //            createDb.ExecuteNonQuery();
    //        }
    //    }
    //}
}
