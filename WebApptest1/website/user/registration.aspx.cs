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
    public partial class registration : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nisal_Dilshan\Desktop\web api\ASP.net-webAPI\WebApptest1\App_Data\shopping.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into UserRegister values('"+nameBox.Text+"','"+emailBox.Text+ "','"+passwordBox.Text + "','"+pinBox.Text + "','"+phoneBox.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            nameBox.Text = "";
            emailBox.Text = "";
            passwordBox.Text = "";
            pinBox.Text = "";
            phoneBox.Text = "";

            Label1.Text = "Registration Successful";

        }
    }
}