﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;

namespace TermProject_Template
{
    public partial class UserLogin : System.Web.UI.Page
    {
        Validation validationOBJ = new Validation();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            int count = validationOBJ.CheckUserExists(email);
            if (count == 1)
            {
                Response.Redirect("CreateAccount.aspx");
            }
            else
            {

            }
            
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserLogin.aspx");
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}