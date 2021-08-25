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
public partial class news : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack != true)
        {
            string v = Request.QueryString["News_ID"];
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString))
            using (SqlCommand cmd = conn.CreateCommand())
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                int nID = 0;
                if (!string.IsNullOrEmpty(v))
                    nID = Convert.ToInt32(v);

                cmd.CommandText = "select * from news1 where news_id='" + Request.QueryString["News_ID"] + "'";
                da.SelectCommand = cmd;
                conn.Open();
                da.Fill(dt);

                if (dt.Rows.Count != 0)
                {
                    if (dt.Rows[0]["new_image_path"] != null)
                    {
                        string Ipath = "~/pix/" + dt.Rows[0]["new_image_path"].ToString();
                        Image1.ImageUrl = Ipath;
                        Image1.Visible = true;
                    }

                    LabHad.Text = "News : " + dt.Rows[0]["news_title"].ToString();
                    lblPara1.Text = dt.Rows[0]["news_desc"].ToString();
                }

            }
        }
    }
}