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
using System.IO;
using System.Linq;
using System.Net;


public partial class Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myconnectionstring"].ConnectionString);
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        string dt = Request.Form[TextBox4.UniqueID];
        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Selected Date: " + dt + "');", true);

        if (CheckBox1.Checked == true)
        {   //  con.Close();
            if (FileUpload1.HasFile)
            {
                FileUpload1.SaveAs(Server.MapPath("~/Offer_pic/").ToString() + @"\" + FileUpload1.FileName.ToString());
            }
            string sqlstring = "INSERT INTO ghar_contact1(name,gender,contact,addresscoree,emailid,education,teachupto,exper,address_perma,status,areaofteach ,url) values (@name,@gender,@contact,@addresscoree,@emailid,@education,@teachupto,@exper,@address_perma,@status,@areaofteach,@url)";
            using (SqlCommand cmd = new SqlCommand(sqlstring, con))
            {

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("name", TextBox1.Text);
                cmd.Parameters.AddWithValue("gender", TextBox2.Text);
                cmd.Parameters.AddWithValue("teachupto", TextBox3.Text);
                cmd.Parameters.AddWithValue("addresscoree", TextBox4.Text);
                cmd.Parameters.AddWithValue("address_perma", TextBox5.Text);
                cmd.Parameters.AddWithValue("education", TextBox6.Text);
                cmd.Parameters.AddWithValue("contact", TextBox7.Text);
                cmd.Parameters.AddWithValue("emailid", TextBox8.Text);
                cmd.Parameters.AddWithValue("exper", DropDownList2.Text);
                cmd.Parameters.AddWithValue("status", "~/Offer_pic/" + FileUpload1.FileName.ToString());

                cmd.Parameters.AddWithValue("areaofteach", DropDownList1.Text);

                cmd.Parameters.AddWithValue("url", TextBox11.Text);




                con.Open();
                cmd.ExecuteNonQuery();
                sendsms();
                // sendmail1(TextBox1.Text, TextBox8.Text, TextBox7.Text);


            }





            Response.Write("<script type='text/javascript'>");
            Response.Write("alert('Your Registration is Added');");
            Response.Write("document.location.href='registration2.aspx' ");
            Response.Write("</script>");



        }
        else
        {
            Response.Write("<script type='text/javascript'>");
            Response.Write("alert('Please Check Your Terms and Condition');");
            Response.Write("</script>");
        }
    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }
    private void sendsms()
    {

        string pass = TextBox8.Text;
        string msg = "Congratulation, you have successfully registred, User ID=" + TextBox2.Text.Trim() + " Email=" + pass + " ,From Sangeet kala sansthan Team for more Visit at http://sangeetkalasansthan.com";

        SendEnglishSMS(TextBox7.Text, msg);

    }

    public bool SendEnglishSMS(string mobilno, string msgcontent)
    {

        DateTime dt = DateTime.Now;
        string res = string.Empty;

        try
        {

            string a = System.Web.HttpUtility.UrlEncode(msgcontent);
            // res = apicall("http://sms.abacusitsolutions.in/sendsms/send1?userid=manish&pass=Abacus@123&sender=ALINET&mobile=" + mobilno +"&message="+ a +"&route=1");
            //res = apicall(" http://bulksms.morbidosoftware.com/sendSMS?username=BRYUVA&message=" + a + "&sendername=BRYUVA&smstype=TRANS&numbers="+ mobilno +"&apikey=cf032234-eef5-4340-80b0-68c77ed9947f ");
            res = apicall(" http://bulksms.morbidosoftware.com/sendSMS?username=Sangeetkala&message=" + a + "&sendername=SANGKS&smstype=TRANS&numbers=" + mobilno + "&apikey=9491dc20-07f4-486d-bf57-8834b1fccb41 ");

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
    public void sendmail1(string name, string Email, string Contact)
    {
        try
        {
            string s0 = " <h4 style=font-weight: normal>http://sangeetkalasansthan.com/</h4><br/>";
            string s1 = "Dear &nbsp; " + name + ", <br/>Your confermation  credential for Sangeet kala sansthan is below " + "<br/><br/>";

            string s3 = "Your Mobile No is ->&nbsp;&nbsp;&nbsp;" + Contact + "<br/><br/><br/>";
            /// string s4 = "YOur Product Price ->&nbsp;&nbsp;&nbsp;" + product + "<br/><br/><br/>";

            string s5 = "Thanks & Regards" + "<br/>" + " Sangeet kala sansthan Team " + "<br/>" + "..... " + "<br/>" + "Our Contact No :  " + "<br/>";
            //string s5 = "<Font>Account Type ->></Font>" + ddaccounttyp.SelectedItem.Text + "<br/>";
            //string s6 = "<Font>Bank Name ->></Font>" + txtbankname.Text + "<br/>";
            string s30 = s0 + s1 + s3 + s5;

            MailMessage m1 = new MailMessage();

            //  m1.To.Add("info@globalgrouptours.org");
            m1.To.Add(Email);

            m1.From = new MailAddress("Sangeetkalasansthanchinhat@gmail.com");

            m1.Subject = "Confermation credential for Sangeet kala sansthan ";

            m1.Body = s30;

            m1.IsBodyHtml = true;

            SmtpClient sm1 = new SmtpClient();

            sm1.Port = 587;

            sm1.Host = ConfigurationManager.AppSettings["smtp"];

            sm1.Credentials = new System.Net.NetworkCredential(ConfigurationManager.AppSettings["uid"], ConfigurationManager.AppSettings["pwd"]);

            sm1.EnableSsl = true;

            sm1.Send(m1);

            //Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "Alert", "alert('Your query has been sent')", true);
            //           Alert.Show("You are registered successfully ...!!! check your   *** EMAIL ID! *** ");



        }
        catch (Exception ex)
        {
            Session["error"] = ex.Message;
            Response.Redirect("~/frmerror.aspx", false);
        }

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        ImageButton1.Enabled = true;
    }
}
