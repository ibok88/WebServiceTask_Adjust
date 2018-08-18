using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;

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
            var jsonSerilaizer = new JavaScriptSerializer();

            if (!string.IsNullOrWhiteSpace(TextBox1.Text))
            {
                
                var json_array = jsonSerilaizer.Serialize(client.GetJsonArray(Convert.ToInt32(TextBox1.Text)));

                Label1.Text = json_array;

            }
            else
            {
                Label2.Text = "Please input an integer";
            }

            
        }
    }
}