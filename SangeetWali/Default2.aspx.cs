using System;
using System.Collections;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Data.OleDb;
using System.Net.Mail;

public partial class Default2 : System.Web.UI.Page
{

    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myconnectionstring"].ConnectionString);
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {
//SqlCommand sql = new SqlCommand(" Bind_offer ", con);
        con.Open();
//dr = sql.ExecuteReader();
        //DataList1.DataSource = dr;
        // DataList1.DataBind();

        con.Close();


        if (IsPostBack != true)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["myconnectionstring"].ConnectionString))
            using (SqlCommand cmd = conn.CreateCommand())
            {

                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                cmd.CommandText = "select * from pages where page_id=1";
                da.SelectCommand = cmd;
                conn.Open();
                da.Fill(dt);



                CreateNewLable();
                //createnewpara();

                //topmost();
                // createnewpara1();
                //topmostside();

            }
        }


    }
    private void CreateNewLable()
    {
        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["myconnectionstring"].ConnectionString))
        using (SqlCommand cmd = conn.CreateCommand())
        {

            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            cmd.CommandText = "select news_title,news_id from news1 order by news_id desc";
            da.SelectCommand = cmd;
            conn.Open();
            da.Fill(dt);

            if (dt.Rows.Count != 0)
            {
                string newLable = string.Empty;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (!string.IsNullOrEmpty(dt.Rows[i][0].ToString()))
                        newLable = newLable + MakePageLink(" ** " + dt.Rows[i][0].ToString(), "news.aspx", Convert.ToInt32(dt.Rows[i][1].ToString()));
                }
                LblNews.Text = newLable;
            }

        }
    }
    private void CreateNewLable1()
    {
        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["myconnectionstring"].ConnectionString))
        using (SqlCommand cmd = conn.CreateCommand())
        {

            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            cmd.CommandText = "select news_title,news_id from news1 order by news_id desc";
            da.SelectCommand = cmd;
            conn.Open();
            da.Fill(dt);

            if (dt.Rows.Count != 0)
            {
                string newLable = string.Empty;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (!string.IsNullOrEmpty(dt.Rows[i][0].ToString()))
                        newLable = newLable + MakePageLink(" ** " + dt.Rows[i][0].ToString(), "vishes_link.aspx", Convert.ToInt32(dt.Rows[i][1].ToString()));
                }
                // Label1.Text = newLable;
            }

        }
    }
    static public string MakePageLink(string strCaption, string strPage, int newsID)
    {
        return MakePageLink(strCaption + ".&nbsp&nbsp", strPage, true, newsID);
    }
    static public string MakePageLink(string strCaption, string strPage, bool bPermission, int newsID)
    {


        if (bPermission == false) return "";
        return "<a href=\"" + strPage + "?" + "News_ID" + "=" + newsID + "\" " + ">" + strCaption + "</a>";

    }

}