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
public partial class login_login : System.Web.UI.Page
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
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        
    }
    protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
    {
        if (TextBox1.Text == "")
        {
            Label1.Text = "You must Login with valid username/password";
        }
        else
        {
            string user = TextBox1.Text.Replace("'", "''");
            string pwd = TextBox2.Text.Replace("'", "''");
            cmd = new SqlCommand("select * from signup where Email ='" + user + "' and createpass='" + pwd + "' and other ='Berojgar'", cn);
            cn.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Session["userid"] = dr["Email"].ToString();
                cn.Close();
                Response.Redirect("berojgar/Admin_Dashboard.aspx");
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
    protected void ImageButton1_Click2(object sender, ImageClickEventArgs e)
    {
        try
        {
            //if (TextBox1.Text == "")
            //{
            //    Label1.Text = "You must Login with valid username/password";
            //}
            //else
            //{
            //    string user = TextBox1.Text.Replace("'", "''");
            //    string pwd = TextBox2.Text.Replace("'", "''");
            string type = string.Empty;
            cn.Open();
            SqlCommand cmd = new SqlCommand("select Email,createpass,other from signup where Email ='" + TextBox1.Text + "' and createpass ='" + TextBox2.Text + "' and other ='"+DropDownList1.Text+"'", cn);

            //cmd = new SqlCommand

            // cn.Open();    

            // SqlCommand
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            if (ds.Tables[0].Rows.Count >0)
            {
                type = ds.Tables[0].Rows[0]["other"].ToString();
            }

            if (type == "Investor")
            {
                Session["Email"] = ds.Tables[0].Rows[0]["Email"].ToString();

                //cn.Close();
                Response.Redirect("../Emplyer/Admin_Dashboard.aspx");
            }
            else if (type == "Franchise")
            {
                Session["Email"] = ds.Tables[0].Rows[0]["Email"].ToString();
                //cn.Close();
                Response.Redirect("../Emplyer/Admin_Dashboard.aspx");

            }

            else
            {

                cn.Close();
                Label1.Text = "You must Login with valid username/password or User type";
                reset();

            }



        }
        catch(Exception ex)
        {
            
        
        }
    }

    private void reset()
    {
        TextBox1.Text = "";
        TextBox2.Text = "";

    }
}