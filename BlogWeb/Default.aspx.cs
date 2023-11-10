using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.Tbl_AboutMeTableAdapter dt_Abm = new DataSet1TableAdapters.Tbl_AboutMeTableAdapter();
            Repeater1.DataSource = dt_Abm.ListAboutMe();
            Repeater1.DataBind();

            DataSet1TableAdapters.Tbl_ExperienceTableAdapter dt_Exp = new DataSet1TableAdapters.Tbl_ExperienceTableAdapter();
            Repeater2.DataSource = dt_Exp.ListExperience();
            Repeater2.DataBind();

            DataSet1TableAdapters.Tbl_EducationTableAdapter dt_Edu = new DataSet1TableAdapters.Tbl_EducationTableAdapter();
            Repeater3.DataSource = dt_Edu.ListEducation();
            Repeater3.DataBind();

            DataSet1TableAdapters.Tbl_SkillsTableAdapter dt_Skl = new DataSet1TableAdapters.Tbl_SkillsTableAdapter();
            Repeater4.DataSource = dt_Skl.ListSkills();
            Repeater4.DataBind();

            DataSet1TableAdapters.Tbl_InterestsTableAdapter dt_Int = new DataSet1TableAdapters.Tbl_InterestsTableAdapter();
            Repeater5.DataSource = dt_Int.ListInterests();
            Repeater5.DataBind();

            DataSet1TableAdapters.Tbl_CertificationsTableAdapter dt_Cer = new DataSet1TableAdapters.Tbl_CertificationsTableAdapter();
            Repeater6.DataSource = dt_Cer.ListCertifitications();
            Repeater6.DataBind();

            DataSet1TableAdapters.Tbl_AboutMeTableAdapter dt_Pho = new DataSet1TableAdapters.Tbl_AboutMeTableAdapter();
            Repeater7.DataSource = dt_Pho.ListAboutMe();
            Repeater7.DataBind();
        }
    }
}