using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class SkillDelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["ID"]);

            DataSet1TableAdapters.Tbl_SkillsTableAdapter dt_Skl = new DataSet1TableAdapters.Tbl_SkillsTableAdapter();
            dt_Skl.DeleteSkill(Convert.ToInt16(id));
            Response.Redirect("Skill.aspx");
        }
    }
}