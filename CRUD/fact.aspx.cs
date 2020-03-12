using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUD
{
    public partial class fact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btn1.Click += new EventHandler(this.on_Click);
        }
        protected void on_Click(object sender, EventArgs e)
        {
            int i, fact = 1, number;
            bool isIntString = no1.Text.All(char.IsDigit);
            if (isIntString)
            {
                number = int.Parse(no1.Text);
                for (i = 1; i <= number; i++)
                {
                    fact = fact * i;
                }
                no1.Focus();
                label.Visible = true;
                label.Text = fact.ToString();
            }
            else
            {
                label.Visible = true;
                label.Text = "Wrong Input";
            }
        }
    }
}