using System.Data.SqlClient;
namespace DBConnection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn =  new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=dotNet;Integrated Security=True;");
            SqlCommand cmd = new SqlCommand("Select * from Employee",conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                Console.WriteLine(reader[0] + "\t" + reader[1] + "\t" + reader[2] + "\t" + reader[3] + "\t" + reader[4]);
            }

        }
    }
}
