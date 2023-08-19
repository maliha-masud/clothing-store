using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Lab11_DB
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-DTRHS3P\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
            conn.Open();

            SqlCommand cm;
            string ID = TextBox2.Text;
            string Num = TextBox4.Text;


            string query = "Insert into Customer2 values('" + ID + "', '" + Num + "'); ";
            cm = new SqlCommand(query, conn);
            cm.ExecuteNonQuery();
            cm.Dispose();
            conn.Close();
        }
    }
}