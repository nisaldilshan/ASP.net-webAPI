using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace WebApptest1.website.user
{
    public partial class product_desc : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nisal_Dilshan\Desktop\web api\ASP.net-webAPI\WebApptest1\App_Data\shopping.mdf;Integrated Security=True");
        int id;
        string new_seating_str;
        string product_name, product_description, product_price, product_qty, product_images;



        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] == null)
            {
                Response.Redirect("display_item.aspx");
            }
            else
            {
                id = Convert.ToInt32(Request.QueryString["id"].ToString());
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from product where id=" + id + "";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                d1.DataSource = dt;
                d1.DataBind();
                con.Close();


                seating();
                
            }
            
        }

        protected void seating()
        {
            con.Open();
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from seats where product_id=" + id + "";
            cmd1.ExecuteNonQuery();

            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);

            foreach (DataRow dr in dt1.Rows)
            {
                string abc = dr["array"].ToString();
                new_seating_str = abc;
                string[] s = abc.Split(',');
                

                for (int j = 0; j < s.Length; j++)
                {
                    System.Diagnostics.Debug.Write(s[j].ToString());
                    setcolor(s[j].ToString());
                }

                
            }

            con.Close();

            Session[id.ToString()] = id.ToString();
        }

        protected void setcolor(string str)
        {
            switch (str)
            {
                case "01":
                    Label1.BackColor = Color.Red;
                    Label1.ForeColor = Color.White;
                    break;
                case "02":
                    Label2.BackColor = Color.Red;
                    Label2.ForeColor = Color.White;
                    break;
                case "03":
                    Label3.BackColor = Color.Red;
                    Label3.ForeColor = Color.White;
                    break;
                case "04":
                    Label4.BackColor = Color.Red;
                    Label4.ForeColor = Color.White;
                    break;
                case "05":
                    Label5.BackColor = Color.Red;
                    Label5.ForeColor = Color.White;
                    break;
                case "06":
                    Label6.BackColor = Color.Red;
                    Label6.ForeColor = Color.White;
                    break;
                case "07":
                    Label7.BackColor = Color.Red;
                    Label7.ForeColor = Color.White;
                    break;
                case "08":
                    Label8.BackColor = Color.Red;
                    Label8.ForeColor = Color.White;
                    break;
                case "09":
                    Label9.BackColor = Color.Red;
                    Label9.ForeColor = Color.White;
                    break;
                case "10":
                    Label10.BackColor = Color.Red;
                    Label10.ForeColor = Color.White;
                    break;
                case "11":
                    Label11.BackColor = Color.Red;
                    Label11.ForeColor = Color.White;
                    break;
                case "12":
                    Label12.BackColor = Color.Red;
                    Label12.ForeColor = Color.White;
                    break;
                case "13":
                    Label13.BackColor = Color.Red;
                    Label13.ForeColor = Color.White;
                    break;
                case "14":
                    Label14.BackColor = Color.Red;
                    Label14.ForeColor = Color.White;
                    break;
                case "15":
                    Label15.BackColor = Color.Red;
                    Label15.ForeColor = Color.White;
                    break;
                case "16":
                    Label16.BackColor = Color.Red;
                    Label16.ForeColor = Color.White;
                    break;
                default:
                    break;
            }
        }

        protected void B1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from product where id=" + id + "";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            

            foreach (DataRow dr in dt.Rows)
            {
                product_name = dr["product_name"].ToString();
                product_description = dr["product_desc"].ToString();
                product_price = dr["product_price"].ToString();
                product_qty = dr["product_qty"].ToString();
                product_images = dr["product_images"].ToString();
            }

            con.Close();

            if (Convert.ToInt32(t1.Text)> Convert.ToInt32(product_qty))
            {
                l1.Text = "Quantity Exceeded";
            }
            else
            {
                l1.Text = "";
                if (Request.Cookies["aa"] == null)
                {
                    Response.Cookies["aa"].Value = product_name.ToString() + "," + product_description.ToString() + "," + product_price.ToString() + "," + product_qty.ToString() + "," + product_images.ToString();
                    Response.Cookies["aa"].Expires = DateTime.Now.AddDays(1);
                }
                else
                {
                    Response.Cookies["aa"].Value = Request.Cookies["aa"].Value + "|" + product_name.ToString() + "," + product_description.ToString() + "," + product_price.ToString() + "," + product_qty.ToString() + "," + product_images.ToString();
                    Response.Cookies["aa"].Expires = DateTime.Now.AddDays(1);
                }
            }

            setcolor(t1.Text);

            new_seating_str = new_seating_str + "," + t1.Text;
            System.Diagnostics.Debug.WriteLine(new_seating_str);
            Session[id.ToString()] = Session[id.ToString()] + "|" + new_seating_str;
            System.Diagnostics.Debug.WriteLine(Session[id.ToString()]);
        }
    }
}