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
using System.Linq;
using System.Net;
using System.Net.Mail;
public partial class login_sign_up : System.Web.UI.Page
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
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        //if (DropDownList1 = "1")
        //   {
        //       Response.Redirect(("sign_up.aspx?Value=" + DropDownList1.SelectedValue));
        //        // Server.Transfer("sign_up.aspx");
        //    }
        //else if (DropDownList1.SelectedItem = "2")
        //      {
        //          Response.Redirect(("login.aspx?Value=" + DropDownList1.SelectedValue));
        //        // Server.Transfer("login.aspx");
        //       } 

        //if (DropDownList1.SelectedItem.Value == "Berojgar")
        //{
        //    Response.Redirect("login.aspx");
        //}

        //else if (DropDownList1.SelectedItem.Value == "Employer")
        //{

        //    Response.Redirect("sign_up.aspx");
        //}

      
        
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        cn.Close();


        string sqlstring = "INSERT INTO signup  (other,fullname,Email,createpass) values (@other,@fullname,@Email,@createpass)";
        using (SqlCommand cmd = new SqlCommand(sqlstring, cn))
        {
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("other", DropDownList1.Text);
            cmd.Parameters.AddWithValue("fullname", TextBox1.Text);
            cmd.Parameters.AddWithValue("Email", TextBox2.Text);
            cmd.Parameters.AddWithValue("createpass", TextBox3.Text);

            cn.Open();
            cmd.ExecuteNonQuery();

            //sendsms();
           // sendmail1(TextBox1.Text, TextBox2.Text, TextBox3.Text);

            //Response.Write("<script type='text/javascript'>");
            //Response.Write("alert('Your Registartion is Added Check your mails');");
            //Response.Write("document.location.href='apply-for-state-director.aspx';");
            //Response.Write("</script>");
        }
        Response.Redirect("sign_up_thanks.aspx");

    }
    private void sendsms()
    {

        string pass = TextBox3.Text;
        string msg = "Congratulation, you have successfully registred, User ID=" + TextBox2.Text.Trim() + " Password=" + pass + " ,From Job Portal Team for more Visit at http://deutschedigicoin.com";

        SendEnglishSMS(TextBox1.Text, msg);

    }

    public bool SendEnglishSMS(string mobilno, string msgcontent)
    {

        DateTime dt = DateTime.Now;
        string res = string.Empty;

        try
        {

            string a = System.Web.HttpUtility.UrlEncode(msgcontent);
            // res = apicall("http://sms.abacusitsolutions.in/sendsms/send1?userid=manish&pass=Abacus@123&sender=ALINET&mobile=" + mobilno +"&message="+ a +"&route=1");
        res = apicall(" http://bulksms.morbidosoftware.com/sendSMS?username=BRYUVA&message=" + a + "&sendername=BRYUVA&smstype=TRANS&numbers="+ mobilno +"&apikey=cf032234-eef5-4340-80b0-68c77ed9947f ");
            //res = apicall(" http://sms.abacusitsolutions.in/sendsms/send1?userid=safalta&pass=Abacus@123&sender=SMPLAN&mobile=" + mobilno + "&message=" + a + "&route=5");

        }
        catch (Exception ex)
        {
        }


        if (!res.StartsWith("Wrong Username or Password"))
        {
            return true;

        }
        else
        {
            //message not sent successfully................ 
            return false;
        }

    }

    public string apicall(string url)
    {
        HttpWebRequest httpreq = (HttpWebRequest)WebRequest.Create(url);
        try
        {
            HttpWebResponse httpres = (HttpWebResponse)httpreq.GetResponse();
            StreamReader sr = new StreamReader(httpres.GetResponseStream());
            string results = sr.ReadToEnd();
            sr.Close();
            return results;
        }
        catch (Exception ex)
        {
            return "0";
        }

    }

    //public void sendmail1(string name, string Email, string createpass)
    //{
    //    try
    //    {
    //        string s0 = " <h4 style=font-weight: normal>http://youthforhumanrightsindia.org</h4><br/>";
    //        string s1 = "Dear &nbsp; " + name + ", <br/>Your confermation  credential for youthforhumanrightsindia  is below " + "<br/><br/>";

    //        string s3 = "Your Mobile No is ->&nbsp;&nbsp;&nbsp;" + createpass + "<br/><br/><br/>";
    //        /// string s4 = "YOur Product Price ->&nbsp;&nbsp;&nbsp;" + product + "<br/><br/><br/>";

    //        string s5 = "Thanks & Regards" + "<br/>" + " Youthforhumanrightsindia Team " + "<br/>" + "..... " + "<br/>" + "Our Contact No :1800-3000-1133  " + "<br/>";
    //        //string s5 = "<Font>Account Type ->></Font>" + ddaccounttyp.SelectedItem.Text + "<br/>";
    //        //string s6 = "<Font>Bank Name ->></Font>" + txtbankname.Text + "<br/>";
    //        string s30 = s0 + s1 + s3 + s5;

    //        MailMessage m1 = new MailMessage();

    //        //  m1.To.Add("info@globalgrouptours.org");
    //        m1.To.Add(Email);

    //        m1.From = new MailAddress("indiayouthforhumanrights@gmail.com");

    //        m1.Subject = "Confermation credential for youthforhumanrightsindia ";

    //        m1.Body = s30;

    //        m1.IsBodyHtml = true;

    //        SmtpClient sm1 = new SmtpClient();

    //        sm1.Port = 587;

    //        sm1.Host = ConfigurationManager.AppSettings["smtp"];

    //        sm1.Credentials = new System.Net.NetworkCredential(ConfigurationManager.AppSettings["uid"], ConfigurationManager.AppSettings["pwd"]);

    //        sm1.EnableSsl = true;

    //        sm1.Send(m1);

    //        //Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "Alert", "alert('Your query has been sent')", true);
    //        //           Alert.Show("You are registered successfully ...!!! check your   *** EMAIL ID! *** ");



    //    }
    //    catch (Exception ex)
    //    {
    //        Session["error"] = ex.Message;
    //        Response.Redirect("~/frmerror.aspx", false);
    //    }

    //}

}