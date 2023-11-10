using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class Interest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.Tbl_InterestsTableAdapter dt_Int = new DataSet1TableAdapters.Tbl_InterestsTableAdapter();
            Repeater1.DataSource = dt_Int.ListInterests();
            Repeater1.DataBind();
        }
    }
}