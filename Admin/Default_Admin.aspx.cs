using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace online.Admin
{
    public partial class Default_Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["aid"] == null)
            {
                aloginBtn.Visible = true;
                Addcourse.Visible = false;
                EditCourse.Visible = false;
                AllCourse.Visible = false;
                Allusers.Visible = false;
            }
            else
            {
                aloginBtn.Visible = false;
                Addcourse.Visible = true;
                EditCourse.Visible = true;
                AllCourse.Visible = true;
                Allusers.Visible = true;
            }
        }



        protected void aloginBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void Addcourse_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddCourse.aspx");
        }

        protected void EditCourse_Click(object sender, EventArgs e)
        {
            Response.Redirect("Edit_Course.aspx");
        }
        protected void AllCourse_Click(object sender, EventArgs e)
        {
            Response.Redirect("All_COurse.aspx");
        }

        protected void Allusers_Click(object sender, EventArgs e)
        {
            Response.Redirect("Allusers.aspx");
        }




    }
}