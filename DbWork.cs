using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace online
{
    public class DbWork
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
        public SqlDataReader reader;
            
        public SqlDataReader getuserinfo()
        {
            connection.Open();
            string users = $"select * from usertbl";
            return new SqlCommand(users, connection).ExecuteReader();
        }

        public SqlDataReader getcourseinfo()
        {
            connection.Open();
            string course = $"select * from coursetbl";
            return new SqlCommand(course, connection).ExecuteReader();
        }
        public static string genslug(string text)
        {
            text = text.Trim();
            text = text.Replace(" ", "-");
            text = AddRandomNumbers(text);
            return text;
        }
        private static string AddRandomNumbers(string text)
        {
            Random random = new Random();
            int randomNumber = random.Next(10, 99);//Generate a random 4 digit no.
            text += "-" + randomNumber.ToString();
            return text;
        }
        public SqlDataReader orderdetail(string uid)
        {
            connection.Open();
            string query = $"select *from coursetbl join buycoursetbl on coursetbl.slug = buycoursetbl.coslug";
            return new SqlCommand(query, connection).ExecuteReader();
        }
    }
}