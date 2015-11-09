using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.Class
{
    public class DBContext
    {
        SQLiteConnection conexion = new SQLiteConnection("Data Source= C:\\Users\andre\\Documents\\GitHubVisualStudio\\WebApplication\\DataBase.sqlite; Version=3; New=True;Compress=True;");

        public void Consultar()
        {
            conexion.Open();
        }

        public bool Save(Customer customer)
        {
            conexion.Open();

            string insert = "INSERT INTO customer VALUES(@id, @document, @name, @date)";

            SqlCommand cmd = new SqlCommand(insert);

            cmd.Parameters.AddWithValue("@id", customer.id);
            cmd.Parameters.AddWithValue("@document", customer.document);
            cmd.Parameters.AddWithValue("@name", customer.name);
            cmd.Parameters.AddWithValue("@date", customer.date);

            return cmd.ExecuteNonQuery() > 0;
        }
    }
}
