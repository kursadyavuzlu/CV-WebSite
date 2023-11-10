using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class Skill : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.Tbl_SkillsTableAdapter dt_Skl = new DataSet1TableAdapters.Tbl_SkillsTableAdapter();
            Repeater1.DataSource = dt_Skl.ListSkills();
            Repeater1.DataBind();
        }
    }
}