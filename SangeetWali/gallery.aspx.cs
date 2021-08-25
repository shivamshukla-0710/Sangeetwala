using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Data.OleDb;
using System.Net.Mail;
public partial class gallery : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myconnectionstring"].ConnectionString);
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {
        topmost();
    }

    private void topmost()
    {
        SqlCommand sql = new SqlCommand("Bind_Gallery", con);
        con.Open();
        dr = sql.ExecuteReader();
        DataList1.DataSource = dr;
        DataList1.DataBind();
        con.Close();

    }
}