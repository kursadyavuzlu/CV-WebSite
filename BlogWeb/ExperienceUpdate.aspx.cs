using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class ExperienceUpdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["ID"]);
            TxtID.Enabled = false;
            TxtID.Text = id.ToString();

            if(Page.IsPostBack==false)
            { 
                DataSet1TableAdapters.Tbl_ExperienceTableAdapter dt_Exp = new DataSet1TableAdapters.Tbl_ExperienceTableAdapter();
                TxtTitle.Text = dt_Exp.GetDataExperience(Convert.ToInt16(id))[0].Title;
                TxtSubtitle.Text = dt_Exp.GetDataExperience(Convert.ToInt16(id))[0].Subtitle;
                TxtExplanation.Text = dt_Exp.GetDataExperience(Convert.ToInt16(id))[0].Explanation;
                TxtDate.Text = dt_Exp.GetDataExperience(Convert.ToInt16(id))[0].Date;
            }
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.Tbl_ExperienceTableAdapter dt_Exp = new DataSet1TableAdapters.Tbl_ExperienceTableAdapter();
            dt_Exp.UpdateExperience(TxtTitle.Text, TxtSubtitle.Text, TxtExplanation.Text, TxtDate.Text, Convert.ToInt16(TxtID.Text));
            Response.Redirect("Experience.aspx");
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {

        }
    }
}