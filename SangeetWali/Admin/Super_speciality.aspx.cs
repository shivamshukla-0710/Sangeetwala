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
using System.Web.Security;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls.WebParts;
using System.Text;


public partial class Admin_Super_speciality : System.Web.UI.Page
{

    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myconnectionstring"].ConnectionString);
    SqlCommand cmdd;
    SqlDataReader dr;
    string Sort_Direction = "id Asc";
    byte[] buffer;//this is the array of bytes which will hold the data (file)
    SqlConnection connection;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpPostedFile file = FileUpload1.PostedFile;
        BindGrid();
        if (!IsPostBack)
        {
            ViewState["SortExpr"] = Sort_Direction;
            DataView dvEmployee = Getdata();
            GridView1.DataSource = dvEmployee;
            //GridView1.DataBind();
            bind_Category();

        }
    }

    private void bind_Category()
    {

         //string com = "Select distinct(category) from category order by category";
         //SqlDataAdapter adpt = new SqlDataAdapter(com, con);
         //DataTable dt = new DataTable();
         //adpt.Fill(dt);
         //ddcategory.DataSource = dt;
         //ddcategory.DataBind();
         //ddcategory.DataTextField = "category";
         //ddcategory.DataValueField = "category";
         //ddcategory.DataBind();
         //ddcategory.Items.Insert(0, "Select");
     
     

    }
    private void BindGrid()
    {
        string strConnString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
        using (SqlConnection con = new SqlConnection(strConnString))
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "select ID, Video_Name from Videos1";
                cmd.Connection = con;
                con.Open();
                DataList1.DataSource = cmd.ExecuteReader();
                DataList1.DataBind();
                con.Close();
            }
        }
    }
    protected void ButtonUpload_Click(object sender, EventArgs e)
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
                SqlCommand cmd = new SqlCommand("INSERT INTO Videos1 (Video, Video_Name, Video_Size,catergory) VALUES (@video, @videoName, @videoSize , @catergory)", connection);
                cmd.Parameters.Add("@video", SqlDbType.VarBinary, buffer.Length).Value = buffer;
                cmd.Parameters.Add("@videoName", SqlDbType.NVarChar).Value = FileUpload1.FileName;
                cmd.Parameters.Add("@videoSize", SqlDbType.BigInt).Value = file.ContentLength;

                cmd.Parameters.Add("@catergory", SqlDbType.NVarChar).Value = DropDownList1.Text;

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
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {

        if (e.CommandName == "Delkey")
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("delete from Videos1 where id = '" + e.CommandArgument.ToString().Trim() + "'", con);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("Super_speciality.aspx");
        }
    }
    protected void PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        DataView dvEmployee = Getdata();
        GridView1.DataSource = dvEmployee;
        GridView1.DataBind();
    }
    private DataView Getdata()
    {
        DataSet dsEmployee = new DataSet();
        string strSelectCmd = "SELECT * from Videos1";
        SqlDataAdapter da = new SqlDataAdapter(strSelectCmd, con);
        da.Fill(dsEmployee, "Videos1");
        DataView dvEmp = dsEmployee.Tables["Videos1"].DefaultView;
        dvEmp.Sort = ViewState["SortExpr"].ToString();
        return dvEmp;

    }

}
