using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class EducationUpdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["ID"]);
            TxtID.Enabled = false;
            TxtID.Text = id.ToString();

            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.Tbl_EducationTableAdapter dt_Edu = new DataSet1TableAdapters.Tbl_EducationTableAdapter();
                TxtTitle.Text = dt_Edu.List_Education(Convert.ToInt16(id))[0].Title;
                TxtSubtitle.Text = dt_Edu.List_Education(Convert.ToInt16(id))[0].Subtitle;
                TxtExplanation.Text = dt_Edu.List_Education(Convert.ToInt16(id))[0].Explanation;
                TxtGradeAvarage.Text = dt_Edu.List_Education(Convert.ToInt16(id))[0].GradeAvarage;
                TxtDate.Text = dt_Edu.List_Education(Convert.ToInt16(id))[0].Date;
            }
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.Tbl_EducationTableAdapter dt_Edu = new DataSet1TableAdapters.Tbl_EducationTableAdapter();
            dt_Edu.UpdateEducation(TxtTitle.Text, TxtSubtitle.Text, TxtExplanation.Text, TxtGradeAvarage.Text, TxtDate.Text, Convert.ToInt16(TxtID.Text));
            Response.Redirect("Education.aspx");
        }
    }
}