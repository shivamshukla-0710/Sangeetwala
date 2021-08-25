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

public partial class Admin_video : System.Web.UI.Page
{
    byte[] buffer;//this is the array of bytes which will hold the data (file)
    SqlConnection connection;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpPostedFile file = FileUpload1.PostedFile;
        BindGrid();
    }

    private void BindGrid()
    {
       string strConnString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
        using (SqlConnection con = new SqlConnection(strConnString))
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "select ID, Video_Name from Videos";
                cmd.Connection = con;
                con.Open();
                DataList1.DataSource = cmd.ExecuteReader();
                DataList1.DataBind();
                con.Close();
            }  }
}protected void  ButtonUpload_Click(object sender, EventArgs e)
{
    if (FileUpload1.HasFile && FileUpload1.PostedFile != null && FileUpload1.PostedFile.FileName != "")
    {
        HttpPostedFile file = FileUpload1.PostedFile;//retrieve the HttpPostedFile object
        buffer = new byte[file.ContentLength];
        int bytesReaded = file.InputStream.Read(buffer, 0, FileUpload1.PostedFile.ContentLength);
        //the HttpPostedFile has InputStream porperty (using System.IO;)
        //which can read the stream to the buffer object,
        //the first parameter is the array of bytes to store in,
        //the second parameter is the zero index (of specific byte) where to start storing in the buffer,
        //the third parameter is the number of bytes you want to read (do u care about this?)
        if (bytesReaded > 0)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
                connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand
                    ("INSERT INTO Videos (Video, Video_Name, Video_Size) VALUES (@video, @videoName, @videoSize)", connection);
                cmd.Parameters.Add("@video", SqlDbType.VarBinary, buffer.Length).Value = buffer;
                cmd.Parameters.Add("@videoName", SqlDbType.NVarChar).Value = FileUpload1.FileName;
                cmd.Parameters.Add("@videoSize", SqlDbType.BigInt).Value = file.ContentLength;
                using (connection)
                {
                    connection.Open();
                    int i = cmd.ExecuteNonQuery();
                    Label1.Text = "uploaded, " + i.ToString() + " rows affected";
                }
            }
            catch (Exception ex)
            {
                Label1.Text = ex.Message.ToString();
            }
        }

    }
    else
    {
        Label1.Text = "Choose a valid video file";
    }
}
}
