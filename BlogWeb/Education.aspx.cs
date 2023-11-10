using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class Education : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.Tbl_EducationTableAdapter dt_Edu = new DataSet1TableAdapters.Tbl_EducationTableAdapter();
            Repeater1.DataSource = dt_Edu.ListEducation();
            Repeater1.DataBind();
        }
    }
}