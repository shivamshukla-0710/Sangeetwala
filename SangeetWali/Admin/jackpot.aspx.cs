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


public partial class Admin_jackpot : System.Web.UI.Page
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
            //DataView dvEmployee = Getdata();
            //GridView1.DataSource = dvEmployee;
            GridView1.DataBind();

            DataSet dss = new DataSet();
            dss = Getdataservice();
            if (dss.Tables["service"].Rows.Count > 0)
            {
                for (int ii = 0; ii < dss.Tables["service"].Rows.Count; ii++)
                {
                    //ddlservices.Items.Add(dss.Tables["service"].Rows[ii][1].ToString());

                  //  ddlservices.Items.Add(new ListItem(dss.Tables["service"].Rows[ii][1].ToString(), dss.Tables["service"].Rows[ii][0].ToString()));
                }
            }

        }
    }
    protected void PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
       // GridView1.PageIndex = e.NewPageIndex;
       //// DataView dvEmployee = Getdata();
       // GridView1.DataSource = dvEmployee;
       // GridView1.DataBind();
    }
    //private DataView Getdata()
    //{
    //    //DataSet dsEmployee = new DataSet();
    //    //string strSelectCmd = "SELECT * from game";
    //    //SqlDataAdapter da = new SqlDataAdapter(strSelectCmd, con);
    //    //da.Fill(dsEmployee, "game");
    //    //DataView dvEmp = dsEmployee.Tables["game"].DefaultView;
    //    //dvEmp.Sort = ViewState["SortExpr"].ToString();
    //    //return dvEmp;

    //}
    private DataSet Getdataservice()
    {
        DataSet dsservice = new DataSet();
        string strSelectCmd = "SELECT * from Services";
        SqlDataAdapter da = new SqlDataAdapter(strSelectCmd, con);
        da.Fill(dsservice, "service");
        DataView dvEmp = dsservice.Tables["service"].DefaultView;

        return dsservice;

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
         con.Close();
       
        string sqlstring = "INSERT INTO game  (Title1,Detail1,serviceid,Title2,Detail2,Title3,Detail3,time) values (@Title1,@detail1,@serviceid,@Title2,@detail2,@Title3,@detail3,@time)";
        using (SqlCommand cmd = new SqlCommand(sqlstring, con))
        {
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("Title1", txtservicename0.Text);
            cmd.Parameters.AddWithValue("detail1", txtservicename.Text);
            cmd.Parameters.AddWithValue("serviceid",ddcategory.SelectedValue);
            cmd.Parameters.AddWithValue("Title2", txtprice.Text);
            cmd.Parameters.AddWithValue("detail2", txtdetail.Text);
            cmd.Parameters.AddWithValue("Title3", txtdetail0.Text);
            cmd.Parameters.AddWithValue("detail3", txtdetail1.Text);
            cmd.Parameters.AddWithValue("time", txttime.Text);
            con.Open();
            cmd.ExecuteNonQuery();
        }
        Response.Redirect("jackpot.aspx");
    
    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Delkey")
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("delete from game where id = '" + e.CommandArgument.ToString().Trim() + "'", con);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("jackpot.aspx");
        }
    }
}