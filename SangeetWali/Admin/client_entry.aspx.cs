using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;

public partial class Admin_client_entry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSave_Click(object sender, EventArgs e)
    {

        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString))
        using (SqlCommand cmd = conn.CreateCommand())
        {
            cmd.CommandText = "insert into client values (@a1,@a2,@a3, @a4)";

            cmd.Parameters.AddWithValue("@a1", txtHeading.Text.ToString());
            cmd.Parameters.AddWithValue("@a2", txtPara1.Text.ToString());
            cmd.Parameters.AddWithValue("@a3", DateTime.Now.Date);
            cmd.Parameters.AddWithValue("@a4", DateTime.Now.Date);
            
            conn.Open();
            cmd.ExecuteNonQuery();
            lblmsg.Text = "Client Save Successfully...";
        }
    }
  
}