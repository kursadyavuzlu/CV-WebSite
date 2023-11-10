using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class AboutMe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {



                DataSet1TableAdapters.Tbl_AboutMeTableAdapter dtAbm = new DataSet1TableAdapters.Tbl_AboutMeTableAdapter();
                TextBox1.Text = dtAbm.ListAboutMe()[0].Name;
                TextBox2.Text = dtAbm.ListAboutMe()[0].Surname;
                TextBox3.Text = dtAbm.ListAboutMe()[0].Address;
                TextBox4.Text = dtAbm.ListAboutMe()[0].Mail;
                TextBox5.Text = dtAbm.ListAboutMe()[0].Phone;
                TextBox6.Text = dtAbm.ListAboutMe()[0].AboutMe;
                TextBox7.Text = dtAbm.ListAboutMe()[0].Photo;

            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            DataSet1TableAdapters.Tbl_AboutMeTableAdapter dtAbm = new DataSet1TableAdapters.Tbl_AboutMeTableAdapter();
            dtAbm.UpdateAboutMe(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text);
            Response.Redirect("Default.aspx");
        }
    }
}