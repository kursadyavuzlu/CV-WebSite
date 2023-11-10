using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class InterestDelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["ID"]);

            DataSet1TableAdapters.Tbl_InterestsTableAdapter dt_Int = new DataSet1TableAdapters.Tbl_InterestsTableAdapter();
            dt_Int.DeleteInterest(Convert.ToInt16(id));
            Response.Redirect("Interest.aspx");
        }
    }
}