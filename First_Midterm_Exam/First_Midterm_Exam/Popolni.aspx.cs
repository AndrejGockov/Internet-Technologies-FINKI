using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace First_Midterm_Exam
{
    public partial class Popolni : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                String pr = Request.QueryString["predmet"];

                switch (pr)
                {
                    case "matematika":
                        collegeLogo.ImageUrl = "/Images/fakultet_matematika.png";
                        college.Text = "Математика";
                        subjects.Items.Add("Калкулус");
                        subjects.Items.Add("Анализа");
                        //subjects.Items.Add(new ListItem("Калкулус", ""));
                        //subjects.Items.Add(new ListItem("Анализа", ""));
                        subjects.Items.Add("Веројатност");
                        break;
                    case "fizika":
                        collegeLogo.ImageUrl = "/Images/fakultet_fizika.png";
                        college.Text = "Физика";
                        subjects.Items.Add("Електротехника");
                        subjects.Items.Add("Електрични кола");
                        break;
                    case "informatika":
                        collegeLogo.ImageUrl = "/Images/fakultet_informatika.png";
                        college.Text = "Информатика";
                        subjects.Items.Add("Структурно");
                        subjects.Items.Add("Објектно");
                        subjects.Items.Add("Алгоритми");
                        subjects.Items.Add("ИТ");
                        break;
                }

                subjects.SelectedIndex = 0;
            }
        }

        protected void calculateAvg_Click(object sender, EventArgs e)
        {
            if (subjects.Items.Count != grades.Items.Count)
                return;

            float avrage = 0;
            foreach (ListItem grade in grades.Items)
            {
                avrage += Convert.ToInt32(grade.Text.ToString());
            }

            avrage /= grades.Items.Count;
            Session["avg"] = avrage.ToString();

            Response.Redirect("Prosek.aspx");
        }

        protected void addBtn_Click(object sender, EventArgs e)
        {
            // UNFINISHED
            //&& subjects.Items[subjects.SelectedIndex].Value == ""
            if (subjects.Items.Count > grades.Items.Count)
            {
                grades.Items.Add(grade.Text.ToString());
            }
        }

        protected void subjects_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}