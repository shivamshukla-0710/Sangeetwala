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

public partial class login_Login_employeer : System.Web.UI.Page
{
    DataTable dt;
    SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["myconnectionString"].ToString());
    SqlCommand cmd;
    SqlDataReader dr;
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack != true)
        {
            //   Session.Abandon();
        }
    }
    protected void ImageButton1_Click2(object sender, ImageClickEventArgs e)
    {
        if (TextBox1.Text == "")
        {
            Label1.Text = "You must Login with valid username/password";
        }
        else
        {
            string user = TextBox1.Text.Replace("'", "''");
            string pwd = TextBox2.Text.Replace("'", "''");
            cmd = new SqlCommand("select * from signup where Email ='" + user + "' and createpass='" + pwd + "' and other ='Employer'", cn);
            cn.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Session["userid"] = dr["Email"].ToString();
                cn.Close();
                Response.Redirect("../Employe/default.aspx");
            }
            else
            {
                cn.Close();
                Label1.Text = "You must Login with valid username/password or User type";
                TextBox2.Text = "";
                TextBox1.Text = "";
            }

            if (cn.State != null)
            {
                cn.Close();
            }
        }
    }
}