using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_1_Group_B
{
    public partial class Glasaj : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack){
                subjectList.Items.Add(new ListItem("Интернет Технологии", "Prof_1"));
                subjectList.Items.Add(new ListItem("Интернет", "Prof_2"));
                subjectList.Items.Add(new ListItem("Дигитална Електроника", "Prof_3"));

                ectsList.Items.Add("6");
                ectsList.Items.Add("5.5");
                ectsList.Items.Add("5");

                subjectList.SelectedIndex = 0;
                ectsList.SelectedIndex = 0;

                profLabel.Text = subjectList.Items[subjectList.SelectedIndex].Value;
            }
        }

        protected void glasajBtn_Click(object sender, EventArgs e)
        {
            if(subjectList.SelectedIndex != -1 && ectsList.SelectedIndex != -1)
                Response.Redirect("UspeshnoGlasanje.aspx");
        }

        protected void deleteBtn_Click(object sender, EventArgs e)
        {
            if(subjectList.SelectedIndex != -1){
                ectsList.Items.RemoveAt(ectsList.SelectedIndex);
                subjectList.Items.RemoveAt(subjectList.SelectedIndex);
            }
        }

        protected void addBtn_Click(object sender, EventArgs e)
        {
            if (subjectLb.Text.Length == 0 || ectsLb.Text.Length == 0){ 
                return; 
            }

            foreach (var val in subjectList.Items){
                if(val.ToString() == subjectLb.Text){
                    return;
                }
            }

            subjectList.Items.Add(subjectLb.Text);
            ectsList.Items.Add(ectsLb.Text);
        }

        protected void subjectList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ectsList.SelectedIndex = subjectList.SelectedIndex;
            profLabel.Text = subjectList.Items[subjectList.SelectedIndex].Value;
        }

        protected void ectsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            subjectList.SelectedIndex = ectsList.SelectedIndex;
            profLabel.Text = subjectList.Items[subjectList.SelectedIndex].Value;
        }
    }
}