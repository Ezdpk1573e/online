using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace online
{
    public partial class singlecourse : System.Web.UI.Page
    {
        SqlConnection _con = new SqlConnection("Data Source = DEV; Initial Catalog = Study; Integrated Security = True");

        protected void Page_Load(object sender, EventArgs e)
        {
            string slug = Request.QueryString["slug"];
            if (slug != null)
            {
                _con.Open();
                string query = $"select * from coursetbl where slug='{slug}'";
                SqlDataReader dr = new SqlCommand(query, _con).ExecuteReader();
                if (dr.Read())
                {
                    string coname = dr["coname"].ToString();
                    string codesc = dr["codesc"].ToString();
                    string coprice = dr["coprice"].ToString();
                    string coduration = dr["coduration"].ToString();

                    CONAME.InnerText = coname;
                    CODESC.InnerText = codesc;
                    COPRICE.InnerText = coprice;
                    CODURATION.InnerText = coduration;
                    COIMAGE.Src = "/Admin/Image/" + dr["coimage"].ToString();


                }
                else
                {
                    Response.Redirect("Default.aspx");
                }
                _con.Close();

            }




        }
        protected void BuyBtn_Click(object sender, EventArgs e)
        {
            string date1 = DateTime.Now.ToString();
            string uid = Session["uid"].ToString();
            string coslug = Request.QueryString["slug"];


            _con.Open();
            string query = $"insert into buycoursetbl(uid,coslug,orderdate) values('{uid}','{coslug}',getdate())";
            SqlCommand cmd = new SqlCommand(query, _con);
            cmd.ExecuteNonQuery();
            Response.Redirect("Profile.aspx");
            _con.Close();

        }

    }
}