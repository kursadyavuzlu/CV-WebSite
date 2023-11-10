using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace BlogWeb
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-DE76UUJ\SQLEXPRESS;Initial Catalog=Dbo_BlogWeb;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Tbl_Admin WHERE Username=@P1 and Password=@P2", connection);
            command.Parameters.AddWithValue("@P1", TextBox1.Text);
            command.Parameters.AddWithValue("@P2", TextBox2.Text);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                Response.Redirect("AboutMe.Aspx");
            }
            else
            {
                Response.Write("Error at Username or Password!!");
            }
            connection.Close();
        }
    }
}