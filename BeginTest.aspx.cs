using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace QuizSystem
{
    public partial class BeginTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            string email = txtemail.Text;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM userlogin WHERE Email = @Email";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Email", email);
                con.Open();
                int count = (int)cmd.ExecuteScalar();
                con.Close();

                if (count > 0)
                {
                    
                    Session["Email"] = email;
                    Response.Redirect("QuestionsPage.aspx");
                }
                else
                {
                    lblerrormsg.Text = "Invalid email !!";
                }
            }
           
        }
    }
}