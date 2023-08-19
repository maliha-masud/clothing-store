using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace Lab11_DB
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           // SqlConnection conn = new SqlConnection("Data Source=DESKTOP-DTRHS3P\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
            //conn.Open();

            //SqlCommand cm;
            string ID = TextBox2.Text;
           // cm = new SqlCommand(query, conn);
          //  cm.ExecuteNonQuery();
            //cm.Dispose();
            //conn.Close();


            string constr ="Data Source=DESKTOP-DTRHS3P\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT E_ID, Amount, PaymentDate FROM Payment WHERE Payment_ID = " +ID))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        TextBox3.Text = sdr["E_ID"].ToString();
                        TextBox4.Text = sdr["Amount"].ToString();
                        TextBox5.Text = sdr["PaymentDate"].ToString();
                    }
                    con.Close();
                }
            }



        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}