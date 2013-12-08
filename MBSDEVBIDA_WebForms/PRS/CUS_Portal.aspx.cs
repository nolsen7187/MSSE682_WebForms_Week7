using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CUS_Portal : System.Web.UI.Page
{
    public object test;
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((Session["SalesRep"] != null) || ((Session["SalesRep"] == null) && (Session["Customer"] == null)))
        {
            Response.Redirect("Login.aspx");
        }
    }
}