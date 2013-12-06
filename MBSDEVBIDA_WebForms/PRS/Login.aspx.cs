﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using BUS;
using System.Configuration;
using System.Data.Entity;


public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void LoginButton_Click(object sender, EventArgs e)
    {
        string AuthenticatedUser;
        BUS_Facade newFacade = new BUS_Facade(TextBoxUserName.Text, TextBoxPassword.Text);
        //AuthenticatedUser = newFacade.ProcessAuthenticationRequest();
        AuthenticatedUser = newFacade.TestAuthenticationServer();
        if (TextBoxUserName.Text == AuthenticatedUser)
        {
            Session["New"] = TextBoxUserName.Text;
            if (newFacade.ProcessCheckIfUserIsSalesRep())
            {
                //newFacade.TestAuthenticationServer();

                Response.Redirect("SRP_Portal.aspx");
            }
            else
            {
                Response.Redirect("CUS_Portal.aspx");
            }
        }
        else
        {
            Label1.Visible = true;
            Label1.Text = "Invalid Username or Password";
        }      
    }
}