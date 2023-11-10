using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class EducationAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.Tbl_EducationTableAdapter dt_Edu = new DataSet1TableAdapters.Tbl_EducationTableAdapter();
            dt_Edu.AddEducation(TxtTitle.Text, TxtSubtitle.Text, TxtExplanation.Text, TxtGradeAvarage.Text, TxtDate.Text);
            Response.Redirect("Education.Aspx");
        }
    }
}