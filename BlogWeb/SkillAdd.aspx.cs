using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class SkillAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.Tbl_SkillsTableAdapter dt_Skl = new DataSet1TableAdapters.Tbl_SkillsTableAdapter();
            dt_Skl.AddSkill(TxtSkill.Text);
            Response.Redirect("Skill.aspx");
        }
    }
}