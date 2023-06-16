using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace online
{
    public partial class User : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["uid"] == null)
            {
                LoginBtn.Visible = true;
                RegisterBtn.Visible = true;
                ProfileBtn.Visible = false;
                LogoutBtn.Visible = false;
            }
            else
            {
                LoginBtn.Visible =false;
                RegisterBtn.Visible = false;
                ProfileBtn.Visible = true;
                LogoutBtn.Visible = true;
            }

        }
        protected void LoginBtn_Click(object sender, EventArgs e)
        {

            Response.Redirect("Loginuser.aspx");
        }

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {

            Response.Redirect("Registeruser.aspx");
        }
        protected void ProfileBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Profile.aspx");

        }
        protected void LogoutBtn_Click(object sender, EventArgs e)
        {

            Session.RemoveAll();
            Session.Abandon();
            Response.Redirect("~/Loginuser.aspx");
        }
    }
}