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

public partial class Admin_addservices : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myconnectionstring"].ConnectionString);
    SqlCommand cmdd;
    SqlDataReader dr;
    string Sort_Direction = "id Asc";
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            ViewState["SortExpr"] = Sort_Direction;
            DataView dvEmployee = Getdata();
            GridView1.DataSource = dvEmployee;
            GridView1.DataBind();
            bind_Category();

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
        string strSelectCmd = "SELECT * from services";
        SqlDataAdapter da = new SqlDataAdapter(strSelectCmd, con);
        da.Fill(dsEmployee, "services");
        DataView dvEmp = dsEmployee.Tables["services"].DefaultView;
        dvEmp.Sort = ViewState["SortExpr"].ToString();
        return dvEmp;

    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {

        if (e.CommandName == "Delkey")
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("delete from services where id = '" + e.CommandArgument.ToString().Trim() + "'", con);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("addservices.aspx");
        }
    }
     public void bind_Category()
     {
         string com = "Select distinct(category) from category order by category";
         SqlDataAdapter adpt = new SqlDataAdapter(com, con);
         DataTable dt = new DataTable();
         adpt.Fill(dt);
         ddcategory.DataSource = dt;
         ddcategory.DataBind();
         ddcategory.DataTextField = "category";
         ddcategory.DataValueField = "category";
         ddcategory.DataBind();
         ddcategory.Items.Insert(0, "Select");
     
     }

    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Close();
        string sqlstring = "INSERT INTO services  (Servicename,Time,Price,detail,category) values (@Servicename,@Time,@Price,@detail,@category)";
        using (SqlCommand cmd = new SqlCommand(sqlstring, con))
        {
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("Servicename", txtservicename.Text);
            cmd.Parameters.AddWithValue("Time", txttime.Text);
            cmd.Parameters.AddWithValue("Price", txtprice.Text);
            cmd.Parameters.AddWithValue("detail", txtdetail.Text);
            cmd.Parameters.AddWithValue("category", ddcategory.Text);
            con.Open();
            cmd.ExecuteNonQuery();
        }
        Response.Redirect("addservices.aspx");
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}

