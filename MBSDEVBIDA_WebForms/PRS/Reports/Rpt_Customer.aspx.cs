using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Rpt_Customer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((Session["SalesRep"] != null) || ((Session["SalesRep"] == null) && (Session["Customer"] == null)))
        {
            Response.Redirect("Login.aspx");
        }
    }
}