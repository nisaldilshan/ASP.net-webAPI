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
    public partial class payment_success : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nisal_Dilshan\Desktop\web api\ASP.net-webAPI\WebApptest1\App_Data\shopping.mdf;Integrated Security=True");
        string order = "";
        //string order_id;
        string s;
        string t;
        string[] a = new string[5];
        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
            order = Request.QueryString["order"].ToString();

            if (order == Session["order_no"].ToString())
            {
                //getting user details and store in order_details table

                SqlCommand cmd = con.CreateCommand(); 
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from UserRegister where email='"+ Session["user"].ToString() +"'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);


                //getting items from cookies
                if (Request.Cookies["aa"] != null)
                {
                    s = Convert.ToString(Request.Cookies["aa"].Value);
                    string[] strArr = s.Split('|');
                    for (int i = 0; i < strArr.Length; i++)
                    {
                        t = Convert.ToString(strArr[i].ToString());
                        string[] strArr1 = t.Split(',');
                        for (int j = 0; j < strArr1.Length; j++)
                        {
                            a[j] = strArr1[j].ToString();
                        }

                    }
                }
                //end of getting items from cookies


                foreach (DataRow dr in dt.Rows)
                {
                    SqlCommand cmd1 = con.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "insert into order_details values('abcd','"+a[0].ToString()+"','time','"+ a[3].ToString() + "','"+ a[2].ToString() + "','"+ a[4].ToString() + "','"+ dr["name"].ToString() + "','"+ Session["user"].ToString() + "','"+ dr["phone"].ToString() + "')";
                    cmd1.ExecuteNonQuery();
                }

                //end

                
            }

            else
            {
                Response.Redirect("login.aspx");
            }

            con.Close();

            Session["user"] = "";
            Response.Cookies["aa"].Expires = DateTime.Now.AddDays(-1);
            Response.Cookies["aa"].Expires = DateTime.Now.AddDays(-1);

            Response.Redirect("display_item.aspx");
        }
    }
}