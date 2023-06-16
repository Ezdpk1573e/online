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
    public partial class Loginuser : System.Web.UI.Page
    {
        SqlConnection _con = new SqlConnection("Data Source = DEV; Initial Catalog = Study; Integrated Security = True");

        protected void Page_Load(object sender, EventArgs e)
        {


        }

            protected void LoginBt_Click(object sender, EventArgs e)
        {
            _con.Open();
            string email = Email.Text;
            string password = Password.Text;
            
            string query = $"Select*from Loginuser where Email='{email}'";
            SqlDataReader dr = new SqlCommand(query, _con).ExecuteReader();

            if (dr.Read())
            {

               
                if (password == dr["Password"].ToString())
                {

                    Session["uid"] = dr["id"];

                    Response.Redirect("Default.aspx");
                }

            }
            else
            {
                Response.Write("<script>alert('Email is not Registered')</script>");
            }
        }
      

    }
}

