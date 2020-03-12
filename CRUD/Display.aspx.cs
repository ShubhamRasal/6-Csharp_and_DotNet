using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace CRUD
{
    public partial class Display : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.BindGrid();
            }
        }
        private void BindGrid()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ADMIN\Desktop\CRUD\CRUD\App_Data\Emp.mdf;Integrated Security=True";
            SqlConnection con;
            con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Emp;");
                
             SqlDataAdapter sda = new SqlDataAdapter();
                   
            cmd.Connection = con;
            sda.SelectCommand = cmd;
            DataTable dt = new DataTable();
                        
            try
              {
                   sda.Fill(dt);
                  GridView1.DataSource = dt;
                  GridView1.DataBind();
             }
              catch (Exception e)
              {
                        Console.WriteLine(e);
               }




                        
                    
                
            
        }
    }
}