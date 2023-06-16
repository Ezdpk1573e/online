using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace online
{
    public partial class Registeruser : System.Web.UI.Page
    {
        SqlConnection _con = new SqlConnection("Data Source = DEV; Initial Catalog = Study; Integrated Security = True");
        protected void Page_Load(object sender, EventArgs e)
        {
        }
            protected void RegisterBt_Click(object sender, EventArgs e)
        {
            _con.Open();
            string email = Email.Text;
            string password = Password.Text;
            string name = Name.Text;
            string mobile = Mobile.Text;


            string query = $"Select*from Loginuser where Email='{email}'";
           
            SqlDataReader dr = new SqlCommand(query, _con).ExecuteReader();
            if (dr.Read())
            {
                Response.Write("<script>alert('Email is already registered')</script>");
                _con.Close();
            }
            else
            {
                _con.Close();
                _con.Open();
                string quer = $"insert into Loginuser(Email,Password,Name,Mobile) Values('{email}','{password}','{name}','{mobile}')";
                SqlCommand cmd = new SqlCommand(quer, _con);
              
                    cmd.ExecuteNonQuery();
            }
            _con.Close();
        }
    }
}