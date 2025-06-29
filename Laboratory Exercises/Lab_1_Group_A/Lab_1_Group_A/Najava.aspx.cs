using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_1_Group_A
{
    public partial class Najava : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void najavaBtn_Click(object sender, EventArgs e)
        {
            if(firstName.Text.Length > 0 && lastName.Text.Length > 0 && email.Text.Length > 0)
            {
                Response.Redirect("Glasaj.aspx");
            }
        }
    }
}