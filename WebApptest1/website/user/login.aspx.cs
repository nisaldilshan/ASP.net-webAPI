using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApptest1.website.user
{
    public partial class login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nisal_Dilshan\Desktop\web api\ASP.net-webAPI\WebApptest1\App_Data\shopping.mdf;Integrated Security=True");
        int tot = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select* from UserRegister where email='"+emailBox.Text+"' and password='"+passwordBox.Text+"'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            tot = Convert.ToInt32(dt.Rows.Count.ToString());

            if (tot>0)
            {
                
                if (Session["checkoutbutton"] == "yes")
                {
                    Session["user"] = emailBox.Text;
                    Response.Redirect("check_order_details.aspx");
                }
                else
                {
                    Session["user"] = emailBox.Text;
                    Response.Redirect("view_cart.aspx");
                }
            }
            else
            {
                Label1.Text = "Invalid Email or Password";
            }

            emailBox.Text = "";
            passwordBox.Text = "";

            con.Close();
        }
    }
}