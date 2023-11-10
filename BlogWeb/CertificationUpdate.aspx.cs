using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class CertificationUpdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["ID"]);
            TxtID.Enabled = false;
            TxtID.Text = id.ToString();

            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.Tbl_CertificationsTableAdapter dt_Skl = new DataSet1TableAdapters.Tbl_CertificationsTableAdapter();
                TxtCertification.Text = dt_Skl.GetCertification(Convert.ToInt16(id))[0].Certification;
            }
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.Tbl_CertificationsTableAdapter dt_Skl = new DataSet1TableAdapters.Tbl_CertificationsTableAdapter();
            dt_Skl.UpdateCertification(TxtCertification.Text, Convert.ToInt16(TxtID.Text));
            Response.Redirect("Certification.aspx");
        }
    }
}