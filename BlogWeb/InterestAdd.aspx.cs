using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class InterestAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.Tbl_InterestsTableAdapter dt_Int = new DataSet1TableAdapters.Tbl_InterestsTableAdapter();
            dt_Int.AddInterest(TxtInterest.Text);
            Response.Redirect("Interest.Aspx");
        }
    }
}