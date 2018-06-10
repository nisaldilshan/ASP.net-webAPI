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
    public partial class user : System.Web.UI.MasterPage
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nisal_Dilshan\Desktop\web api\ASP.net-webAPI\WebApptest1\App_Data\shopping.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            highlight_calender();
        }

        protected void Calendar_SelectionChanged(object sender, EventArgs e)
        {
            

            //lblday.Text = Calendar1.TodaysDate.ToShortDateString();
            string date = Calendar.SelectedDate.ToShortDateString();

            //System.Diagnostics.Debug.Write(date);
            dateLabel.Text = date;

            highlight_calender();

        }

        protected void highlight_calender()
        {
            Calendar.SelectedDayStyle.BackColor = System.Drawing.Color.Red;

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Category";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                DateTime datetime;
                datetime = Convert.ToDateTime(dr["product_category"].ToString());
                Calendar.SelectedDates.Add(datetime);
            }

            con.Close();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("display_item.aspx?category="+ dateLabel.Text);
        }
    }
}