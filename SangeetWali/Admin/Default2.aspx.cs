using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Default2 : System.Web.UI.Page
{
    Class1 cls = new Class1();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        SqlConnection con = cls.getcon();
        if(ConnectionState.Closed!=con.State)
        {
            con.Close();
        }
        string filename = Path.GetFileName(fileuploadimages.PostedFile.FileName);

        fileuploadimages.SaveAs(Server.MapPath("Uploadimage/" + filename));

        con.Open();

        SqlCommand cmd = new SqlCommand("Insert into vadm_image(ImageName,Description) values(@ImageName,@Description)", con);

        cmd.Parameters.AddWithValue("@ImageName", filename);
        cmd.Parameters.AddWithValue("@Description", txtDesc.Text);
        cmd.ExecuteNonQuery();

        con.Close();
        txtDesc.Text = string.Empty;

        
    
    }
}