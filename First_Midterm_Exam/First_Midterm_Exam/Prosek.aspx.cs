using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace First_Midterm_Exam
{
    public partial class Prosek : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                string user = (string)Session["name"];
                string mail = (string)Session["email"];
                string avg = (string)Session["avg"];
                lbl.Text = user + "E, Thank you for using our system. Your average is " + avg + ". You will receive information about the entered grades and the calculated average by email, at " + mail;
            }
        }
    }
}