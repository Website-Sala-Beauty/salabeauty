using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_MasterPage : System.Web.UI.MasterPage
{
    dbcsdlDataContext db = new dbcsdlDataContext();
    public string adminName, count;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["UserNail"] != null)
        {
            adminName = Request.Cookies["UserNail"].Value;
            //loadMenu();
        }
        else
        {
            Response.Redirect("/app-login");
        }
    }

    protected void rpModule_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {

    }

    protected void rpModule_Init(object sender, EventArgs e)
    {

    }


    protected void btnLogout_ServerClick(object sender, EventArgs e)
    {

    }
}
