using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace Lab11_DB
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-DTRHS3P\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
            conn.Open();
          
            SqlCommand cm;
            string ID = TextBox1.Text;
            string Name = TextBox2.Text;
            string Address = TextBox8.Text;
            string Phone_No = TextBox4.Text;
            string Working_Store = TextBox5.Text;
            string Supervisor = TextBox6.Text;
            string Date = TextBox7.Text;
           
            string query = "Insert into Employee(WorkingStore, Emp_ID, EmpName,Supervisor, EmpAddress, PhoneNo, DateHired ) values('" + Working_Store + "', '" + ID + "','" + Name + "','" + Supervisor + "','" + Address + "','" + Phone_No + "',CONVERT(DATE,'" + Date + "')  ); ";
            cm = new SqlCommand(query, conn);
            cm.ExecuteNonQuery();
            cm.Dispose();
            conn.Close();
        }
    }
}