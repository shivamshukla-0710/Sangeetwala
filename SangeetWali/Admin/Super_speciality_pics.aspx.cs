using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.SqlClient;
using System.Text;
using System.IO;

public partial class Admin_Super_speciality_pics : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myconnectionstring"].ConnectionString);
    SqlCommand cmdd;
    SqlDataReader dr;
    string Sort_Direction = "Title Asc";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ViewState["SortExpr"] = Sort_Direction;
            DataView dvEmployee = Getdata();
            GridView1.DataSource = dvEmployee;
            GridView1.DataBind();

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
        string strSelectCmd = "SELECT * from gallery1";
        SqlDataAdapter da = new SqlDataAdapter(strSelectCmd, con);
        da.Fill(dsEmployee, "gallery");
        DataView dvEmp = dsEmployee.Tables["gallery"].DefaultView;
        dvEmp.Sort = ViewState["SortExpr"].ToString();
        return dvEmp;

    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Delkey")
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("delete from gallery1 where id = '" + e.CommandArgument.ToString().Trim() + "'", con);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("Super_speciality_pics.aspx");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
         con.Close();
        FileUpload1.SaveAs(Server.MapPath("~/GalleryPic/").ToString() + @"\" + FileUpload1.FileName.ToString());

        string sqlstring = "INSERT INTO gallery1  (Title,Image,categ) values (@Title,@Image,@categ)";
        using (SqlCommand cmd = new SqlCommand(sqlstring, con))
        {
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("Title", TextBox1.Text);
            cmd.Parameters.AddWithValue("Image", "~/GalleryPic/" + FileUpload1.FileName.ToString());
            cmd.Parameters.AddWithValue("categ", DropDownList1.Text);
            
            con.Open();
            cmd.ExecuteNonQuery();
        }
        Response.Redirect("Super_speciality_pics.aspx");
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
