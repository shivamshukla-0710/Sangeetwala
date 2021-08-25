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

public partial class Admin_about : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myconnectionstring"].ConnectionString);

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bind_detail();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Close();        
        string sqlstring = "update about set detail = @detail where id = 1";
        using (SqlCommand cmd = new SqlCommand(sqlstring, con))
        {
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("detail", TextBox1.Text);
            con.Open();
            cmd.ExecuteNonQuery();
        }
        Response.Redirect("about.aspx");
    }

    private void bind_detail()
    {
        con.Close();
        SqlCommand cmd = new SqlCommand("select * from about", con);
        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            TextBox1.Text = dr["detail"].ToString();
           
        }
        con.Close();
    }
}
