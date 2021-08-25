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

public partial class Admin_testimonial : System.Web.UI.Page
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
        string strSelectCmd = "SELECT * from testimonial";
        SqlDataAdapter da = new SqlDataAdapter(strSelectCmd, con);
        da.Fill(dsEmployee, "testimonial");
        DataView dvEmp = dsEmployee.Tables["testimonial"].DefaultView;
        dvEmp.Sort = ViewState["SortExpr"].ToString();
        return dvEmp;

    }


    public void chkStatus_OnCheckedChanged(object sender, EventArgs e)
    {
        CheckBox chkStatus = (CheckBox)sender;
        GridViewRow row = (GridViewRow)chkStatus.NamingContainer;


        string cid = row.Cells[1].Text;
        bool status = chkStatus.Checked;



        string query = "UPDATE Testimonial SET approve = @Approve WHERE id = @id";


        SqlCommand com = new SqlCommand(query, con);


        com.Parameters.Add("@Approve", SqlDbType.Bit).Value = status;
        com.Parameters.Add("@id", SqlDbType.Int).Value = cid;


        con.Open();
        com.ExecuteNonQuery();
        con.Close();

        Response.Redirect("testimonial.aspx");
    }



    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {

        if (e.CommandName == "Delkey")
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("delete from Testimonial where id = '" + e.CommandArgument.ToString().Trim() + "'", con);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("testimonial.aspx");
        }
    }

}

