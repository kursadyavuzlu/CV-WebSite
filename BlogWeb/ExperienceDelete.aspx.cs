using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class ExperienceDelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["ID"]);

            DataSet1TableAdapters.Tbl_ExperienceTableAdapter dt_Exp = new DataSet1TableAdapters.Tbl_ExperienceTableAdapter();
            dt_Exp.DeleteExperience(Convert.ToInt16(id));
            Response.Redirect("Experience.aspx");
        }
    }
}