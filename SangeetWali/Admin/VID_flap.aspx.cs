using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using System.Configuration;
public partial class Admin_VID_flap : System.Web.UI.Page
{
    byte[] buffer;//this is the array of bytes which will hold the data (file)
    SqlConnection connection;
    protected void Page_Load(object sender, EventArgs e)
    {
        // HttpPostedFile file = FileUpload1.PostedFile;
        BindGrid();
    }



    private void BindGrid()
    {
        string strConnString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
        using (SqlConnection con = new SqlConnection(strConnString))
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "select ID, Video_Name from Videos1 WHERE catergory ='Flap'";
                cmd.Connection = con;
                con.Open();
                DataList1.DataSource = cmd.ExecuteReader();
                DataList1.DataBind();
                con.Close();
            }
        }
    }
}