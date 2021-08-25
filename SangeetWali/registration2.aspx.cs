using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
public partial class registration2 : System.Web.UI.Page
{
     SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ToString());

    SqlCommand cmd;
    SqlDataReader dr;
    int id;
    SqlDataAdapter ad;
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        Panel1.Visible = false;
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Panel1.Visible = true;

                //string path = "~/customer_logo/" + FileUpload1.FileName;
                cn.Open();
                cmd = new SqlCommand("update ghar_contact1 set Staus_app='fees' where emailid='"+TextBox1.Text+"'", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
               // FileUpload1.PostedFile.SaveAs(Server.MapPath(path));
               // clear();
                string Msg = ("Update Data Successfully  Please Pay Ypur Amount from below option!");
                string jv = "<script>alert('" + (Msg) + "');</script>";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alert", jv, false);
            }
          
       


    }




