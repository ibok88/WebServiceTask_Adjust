using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OneToXClient
{
    public partial class ClientUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnGet_Click(object sender, EventArgs e)
        {
            ListOfNumbers.WebServerClient client = new ListOfNumbers.WebServerClient();

            if (!string.IsNullOrWhiteSpace(TextBox1.Text))
            {
                Label1.Text = string.Join(",", client.GetJsonArray(Convert.ToInt32(TextBox1.Text)));

            }
            else
            {
                Label2.Text = "Please input an integer";
            }

            
        }
    }
}