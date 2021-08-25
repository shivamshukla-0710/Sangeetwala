using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Text.RegularExpressions;

public partial class Admin_youtube : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        fetchdata();

    }
    private void fetchdata()
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from ghar_contact1", con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataList4.DataSource = ds;
                DataList4.DataBind();
            }
            con.Close();
        }

        catch (Exception ex)
        {

        }
    }
}