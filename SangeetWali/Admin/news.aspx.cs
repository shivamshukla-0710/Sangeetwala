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

public partial class Admin_news : System.Web.UI.Page
{
    static int id;
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myconnectionstring"].ConnectionString);
    //SqlConnection con = new SqlConnection();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            TextBox4.Text = DateTime.Now.ToShortDateString();
            //TextBox2.Text = System.DateTime.Now.ToString("dd-MM-yyyy"); //ok
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myconnectionstring"].ConnectionString);
    
            SqlCommand cmd = new SqlCommand("Insert into post_t (post,dt) values(@cnt,@dtm)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@cnt", TextBox3.Text);
            cmd.Parameters.AddWithValue("@dtm", Convert.ToDateTime(TextBox4.Text));

            cmd.ExecuteNonQuery();

            TextBox3.Text = "";

        
       
    }

   
    protected void TextBox4_TextChanged(object sender, EventArgs e)
    {

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}