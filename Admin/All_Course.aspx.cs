using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace online.Admin
{
    public partial class All_Course : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["aid"]==null)
            {
                Response.Redirect("Default_Admin.aspx");
            }
        }
    }
}