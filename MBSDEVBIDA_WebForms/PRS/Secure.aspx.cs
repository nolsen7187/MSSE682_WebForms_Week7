using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Secure : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((Session["Customer"] != null) || (Session["SalesRep"] != null))
        {
            if (Session["Customer"] != null)
            {
                SalesRepLabel.Visible = false;
                CustomerLabel.Text += Session["Customer"].ToString();
            }
            else
            {
                CustomerLabel.Visible = false;
                SalesRepLabel.Text += Session["SalesRep"].ToString();
            }
        }
        else
        {
            Response.Redirect("Login.aspx");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["Customer"] = null;
        Session["SalesRep"] = null;
        Response.Redirect("Default.aspx");
    }
}