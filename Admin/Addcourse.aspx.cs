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
    public partial class Addcourse : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source = DEV; Initial Catalog = Study; Integrated Security = True");
             
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["aid"] == null)
            {
                Response.Redirect("Default_Admin.aspx");
            }
        }

        protected void AdCourseBtn_Click(object sender, EventArgs e)
        {
            CoImage.SaveAs(Server.MapPath("~/admin/image/courseimg" + CoImage.FileName));
                string coname = CoName.Text;
                string codesc = CoDesc.Text;
                string coduration = CoDuration.Text;
                string coprice = CoPrice.Text;
                string coimage =CoImage.FileName;
                 string slugText = CoName.Text;
            string slug = DbWork.genslug(slugText);
            con.Open();
        string query = $"insert into coursetbl(coname, codesc,coduration,coprice,coimage, slug) values('{coname}','{codesc}', '{coduration}', '{coprice}', '{coimage}', '{slug}')";
                new SqlCommand(query, con).ExecuteNonQuery();
        }

        protected void AllCourseBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("All_Course.Aspx");
        }
    }
}