using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;

public partial class admin_AddNews : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        string strFileName = string.Empty;
        string strFileType = string.Empty;
        if (FileUpload1.HasFile)
        {  
             strFileType = System.IO.Path.GetExtension(FileUpload1.FileName).ToString().ToLower();
            if (strFileType == ".jpg" || strFileType == ".jpeg" || strFileType == ".png")
            {
                strFileName = DateTime.Now.ToString("MM-dd-yyyy_HHmmss");
                EnsureDirectoriesExist();
                String filePath = Server.MapPath(@"~/pix/" + strFileName + strFileType);
                FileUpload1.SaveAs(filePath);
            }
            else
            {
                lblmsg.Text = "Not a Image file";
            }
        }

        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString))
        using (SqlCommand cmd = conn.CreateCommand())
        {
            cmd.CommandText = "insert into news values (@a1,@a2,@a3, @a4, @a5)";
            string path=strFileName + strFileType;
            cmd.Parameters.AddWithValue("@a1", txtHeading.Text.ToString());
            cmd.Parameters.AddWithValue("@a2", txtPara1.Text.ToString());
            cmd.Parameters.AddWithValue("@a3", DateTime.Now.Date);
            cmd.Parameters.AddWithValue("@a4", DateTime.Now.Date);
            cmd.Parameters.AddWithValue("@a5", path);
            conn.Open();
            cmd.ExecuteNonQuery();
            lblmsg.Text = "News Save Successfully...";
        }   
    }

    public void EnsureDirectoriesExist()
    {

        // if the \pix directory doesn't exist - create it. 
        if (!System.IO.Directory.Exists(Server.MapPath(@"~/pix/")))
        {
            System.IO.Directory.CreateDirectory(Server.MapPath(@"~/pix/"));
        }

    }
}