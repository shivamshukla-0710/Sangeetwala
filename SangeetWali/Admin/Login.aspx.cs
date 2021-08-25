using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Admin_Login : System.Web.UI.Page
{
    DataSet ds = new DataSet();
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myconnectionstring"].ConnectionString);
    SqlDataReader dr;
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (txtuserid.Text == "")
        {
            Label1.Text = "You must Login with valid username/password";
        }
        else
        {
            string user = txtuserid.Text.Replace("'", "''");
            string pwd = txtpwd.Text.Replace("'", "''");
            cmd = new SqlCommand("select * from admin_login where uid ='" + user + "' and pwd='" + pwd + "'", con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Session["userid"] = dr["uid"].ToString();
                con.Close();
                Response.Redirect("Admin_Dashboard.aspx");
            }
            else
            {
                con.Close();
                Label1.Text = "You must Login with valid username/password";
                txtpwd.Text = "";
                txtuserid.Text = "";
            }

            if (con.State != null)
            {
                con.Close();
            }
        }
    }
}
