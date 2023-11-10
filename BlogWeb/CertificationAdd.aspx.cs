using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class CertificationAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.Tbl_CertificationsTableAdapter dt_Cer = new DataSet1TableAdapters.Tbl_CertificationsTableAdapter();
            dt_Cer.AddCertification(TxtCertification.Text);
            Response.Redirect("Certification.aspx");
        }
    }
}