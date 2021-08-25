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

public partial class Admin_detail : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myconnectionstring"].ConnectionString);
    SqlCommand cmdd;
    SqlDataReader dr;
    string Sort_Direction = "id Asc";
    string id;
    protected void Page_Load(object sender, EventArgs e)
    {
      id=  Request.QueryString["id"];
        if (!IsPostBack)
        {
            ViewState["SortExpr"] = Sort_Direction;
            DataView dvEmployee = Getdata();
            GridView1.DataSource = dvEmployee;
            GridView1.DataBind();
            bindbooking();
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
        string strSelectCmd = "select * from Booking_Detail where id = '" + id + "'";
        SqlDataAdapter da = new SqlDataAdapter(strSelectCmd, con);
        da.Fill(dsEmployee, "Booking_Detail");
        DataView dvEmp = dsEmployee.Tables["Booking_Detail"].DefaultView;
        dvEmp.Sort = ViewState["SortExpr"].ToString();
        return dvEmp;

    }

    public void bindbooking()
    {
        SqlCommand cmd = new SqlCommand("select Id,Name,LastName as [Last Name],Email, Mobile,Address + ',' + address2 as Address,CONVERT(VARCHAR(20), Date , 103) as Date,convert(varchar, timefrom, 8) as [timefrom],convert(varchar, timeto, 8) as [TimeTo] from booking where id = '" + id + "'", con);
        con.Open();
       SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            lbladress.Text = dr["address"].ToString();
            lblfullname.Text = dr["name"].ToString();
            lbldate.Text = dr["date"].ToString();
            lblmobile.Text = dr["mobile"].ToString();
            lbltimefrom.Text = dr["timefrom"].ToString();
            lbltimeto.Text = dr["timeto"].ToString();
            
        }
    
    }

}
