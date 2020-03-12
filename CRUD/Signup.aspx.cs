using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;


namespace CRUD
{
    public partial class Signup : System.Web.UI.Page
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ADMIN\Desktop\CRUD\CRUD\App_Data\Emp.mdf;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            btn1.Click += new EventHandler(this.btn11_Click);
            btn2.Click += new EventHandler(this.btn12_Click);
        }
        protected void btn11_Click(object sender, EventArgs e)
        {
            SqlConnection con;
            con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Emp(fname,lname,email,mo)values(@fname,@lname,@email,@mo);", con);
            cmd.Parameters.AddWithValue("@fname", txt1.Text);
            cmd.Parameters.AddWithValue("@lname", txt2.Text);
            cmd.Parameters.AddWithValue("@email", email.Text);
            cmd.Parameters.AddWithValue("@mo", mobile.Text);


            if(cmd.ExecuteNonQuery() == 1)
            {
                Label1.Visible = true;
                Label1.Text = "Registered Succussfully";
            }
           

            txt1.Focus();

            con.Close();
        }
        protected void btn12_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            
            email.Text = "";
            mobile.Text = "";
           
            Label1.Visible = true;
            Label1.Text = "";
            // Response.Redirect("");
        }
    }
}