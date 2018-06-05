using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApptest1.website.admin
{
    public partial class add_product : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nisal_Dilshan\Desktop\web api\ASP.net-webAPI\WebApptest1\App_Data\shopping.mdf;Integrated Security=True");
        string a, b;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void b1_Click(object sender, EventArgs e)
        {
            a = Class1.GetRandomPassword(10).ToString();
            f1.SaveAs(Request.PhysicalApplicationPath + "/website/images/" + a + f1.FileName.ToString());
            b = "/website/images/" + a + f1.FileName.ToString();

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into product values('"+t1.Text+"','"+t2.Text+"',"+t3.Text+","+t4.Text+",'"+b.ToString()+"')";
            cmd.ExecuteNonQuery();
            con.Close();
            
        }
    }
}
