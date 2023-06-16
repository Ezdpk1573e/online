using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace online.Admin
{
    public partial class Login : System.Web.UI.Page
    {


        SqlConnection _con = new SqlConnection("Data Source = DEV; Initial Catalog = Study; Integrated Security = True");
        protected void Page_Load(object sender, EventArgs e)
        {
            _con.Open();
            string Email = aEmail.Text;
            string password = Password.Text;
            string query = $"Select*from admintbl where email='{Email}'";
            SqlDataReader dr= new SqlCommand(query, _con).ExecuteReader();

            if (dr.Read())
            {

                Session["aid"] = dr["aid"];
                if (password == dr["password"].ToString())
                {

                    Session["aid"] = dr["aid"];

                    Response.Redirect("default_Admin.aspx");
                }
               
            }
            else
            {
                Response.Write("<script>alert('Email is not Registered')</script>");
            }
        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default_Admin.aspx");
        }

        }
    }