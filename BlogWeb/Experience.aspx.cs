using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class Experience : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.Tbl_ExperienceTableAdapter dt_Exp = new DataSet1TableAdapters.Tbl_ExperienceTableAdapter();
            Repeater1.DataSource = dt_Exp.ListExperience();
            Repeater1.DataBind();
        }
    }
}