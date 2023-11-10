using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class SkillUpdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["ID"]);
            TxtID.Enabled = false;
            TxtID.Text = id.ToString();

            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.Tbl_SkillsTableAdapter dt_Skl = new DataSet1TableAdapters.Tbl_SkillsTableAdapter();
                TxtSkill.Text = dt_Skl.ListSkill(Convert.ToInt16(id))[0].Skill;
            }
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.Tbl_SkillsTableAdapter dt_Skl = new DataSet1TableAdapters.Tbl_SkillsTableAdapter();
            dt_Skl.UpdateSkill(TxtSkill.Text, Convert.ToInt16(TxtID.Text));
            Response.Redirect("Skill.aspx");
        }
    }
}