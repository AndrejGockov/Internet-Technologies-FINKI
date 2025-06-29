using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_1_Group_A
{
    public partial class Glasaj : System.Web.UI.Page
    {
        String[] professors = { "Prof_1", "Prof_2", "Prof_3" };
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                lbPredmeti.SelectedIndex = 0;
                lbKrediti.SelectedIndex = 0;
                nameLabel.Text = professors[lbPredmeti.SelectedIndex];
                //lbPredmeti.DataBind();
                //lbKrediti.DataBind();
            }
        }

        protected void voteBtn_Click(object sender, EventArgs e)
        {
            if(lbPredmeti.SelectedIndex != -1 && lbKrediti.SelectedIndex != -1)
            {
                Response.Redirect("UspeshnoGlasanje.aspx");
            }
        }

        protected void lbPredmeti_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbKrediti.SelectedIndex = lbPredmeti.SelectedIndex;
            nameLabel.Text = professors[lbPredmeti.SelectedIndex];
        }

        protected void lbKrediti_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbPredmeti.SelectedIndex = lbKrediti.SelectedIndex;
        }
    }
}