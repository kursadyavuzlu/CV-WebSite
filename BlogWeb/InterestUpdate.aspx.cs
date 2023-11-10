using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class InterestUpdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["ID"]);
            TxtID.Enabled = false;
            TxtID.Text = id.ToString();

            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.Tbl_InterestsTableAdapter dt_Int = new DataSet1TableAdapters.Tbl_InterestsTableAdapter();
                TxtInterest.Text = dt_Int.GetInterest(Convert.ToInt16(id))[0].Interest;
            }
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.Tbl_InterestsTableAdapter dt_Int = new DataSet1TableAdapters.Tbl_InterestsTableAdapter();
            dt_Int.UpdateInterest(TxtInterest.Text, Convert.ToInt16(TxtID.Text));
            Response.Redirect("Interest.aspx");
        }
    }
}