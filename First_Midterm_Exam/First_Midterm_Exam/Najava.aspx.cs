using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace First_Midterm_Exam
{
    public partial class Najava : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void mathBtn_Click(object sender, EventArgs e)
        {
            Session["name"] = nameBox.Text.ToString();
            Session["email"] = emailBox.Text.ToString();
            Session["pwd"] = passwordBox.Text.ToString();
            Response.Redirect("Popolni.aspx?predmet=matematika");
        }

        protected void physicsBtn_Click(object sender, EventArgs e)
        {
            Session["name"] = nameBox.Text.ToString();
            Session["email"] = emailBox.Text.ToString();
            Session["pwd"] = passwordBox.Text.ToString();
            Response.Redirect("Popolni.aspx?predmet=fizika");
        }

        protected void informaticsBtn_Click(object sender, EventArgs e)
        {
            Session["name"] = nameBox.Text.ToString();
            Session["email"] = emailBox.Text.ToString();
            Session["pwd"] = passwordBox.Text.ToString();
            Response.Redirect("Popolni.aspx?predmet=informatika");
        }
    }
}