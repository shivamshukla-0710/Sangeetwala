using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.WebControls;
using System.Web.UI;
using System.Net.Mail;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Class1
{
    SqlConnection con = new SqlConnection(@"Data Source=198.71.226.6; Initial Catalog=SANGEET_KLA; User ID=DBSANGEET; Password=1Dckb^88");

	public Class1()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public void MsgBox(string msg, Page refP)
    {
        Label lbl = new Label();
        lbl.ForeColor = System.Drawing.Color.Red;
        string lb = "window.alert('" + msg + "')";
        ScriptManager.RegisterClientScriptBlock(refP, this.GetType(), "UniqueKey", lb, true);
        refP.Controls.Add(lbl);
    }


    public SqlConnection getcon()
    {

        SqlConnection con = new SqlConnection(@"Data Source=198.71.226.6; Initial Catalog=SANGEET_KLA; User ID=DBSANGEET; Password=1Dckb^88;");
           if (con.State != ConnectionState.Open)
            con.Open();
        return con;
    }

    public bool ins_book(string ddl, string loc, string area, string rs, string des, string fup,string imm1)
    {
        Class1 cls = new Class1();
        SqlConnection con = getcon();
        SqlCommand comm = new SqlCommand("exec pro_ins_prop @pty,@lc,@ara,@im,@r,@ds,@sts", con);
        comm.Parameters.Add("@pty", ddl);
        comm.Parameters.Add("@lc", loc);
        comm.Parameters.Add("@ara", area);
        comm.Parameters.Add("@im", fup);
        comm.Parameters.Add("@r", rs);
        comm.Parameters.Add("@ds", des);
        comm.Parameters.Add("@sts", imm1);
        //con.Open();
        comm.ExecuteNonQuery();
        return true;
    }


    public void gridfill(string x, GridView g, Label lblmsg)
    {
        Class1 cls = new Class1();
        SqlConnection con = getcon();
        SqlDataAdapter da = new SqlDataAdapter(x, con);
        DataSet ds = new DataSet();

        da.Fill(ds, "finder_tb");
        if (ds.Tables["finder_tb"].Rows.Count > 0)
            g.DataSource = ds.Tables["finder_tb"];
        else
        {
            ds.Dispose();
            g.DataSource = ds.Tables[0];
            lblmsg.Text = "No Records present according to your search...";
        }
        // bind data to gridview

        g.DataBind();
    }

//---Contact----------------------
    public bool ins_cntct(string cnam, string cmob, string cmail, string cfile, string ddt,string pst,string exp,string qua,string loc,string wrk)//
    {
        //try
        //{
        Class1 cls = new Class1();
        SqlConnection con = getcon();
        SqlCommand cmd = new SqlCommand("exec proc_cntct @nm,@mob,@ml,@fl,@dt,@po,@ex,@qu,@lc,@wrk", con);//
        cmd.Parameters.Add("@nm", cnam);
        cmd.Parameters.Add("@mob", cmob);
        cmd.Parameters.Add("@ml", cmail);
        cmd.Parameters.Add("@fl", cfile);
        cmd.Parameters.Add("@dt", ddt);
        cmd.Parameters.Add("@po", pst);
        cmd.Parameters.Add("@ex", exp);
        cmd.Parameters.Add("@qu", qua);
        cmd.Parameters.Add("@lc", loc);
        cmd.Parameters.Add("@wrk", wrk);

        //con.Open();
        cmd.ExecuteNonQuery();
        //con.Close();
        return true;
        // }
        //catch (Exception ex)
        //{
        //    return false;
        //}
        //finally
        //{
        //    con.Close();
        //}
    }

//---Admin-mail-----------------
    public bool send_mail_adm(string txtemail)
    {
        string non = txtemail;
        try
        {
            MailAddress toAddress = new MailAddress("astronomer.ravi@gmail.com");
            MailAddress fromAddress = new MailAddress("astronomer.ravi@gmail.com");
            MailMessage MyMail = new MailMessage(fromAddress, toAddress);

            MyMail.Subject = "Confirmation!!!";
            MyMail.Body = "Dear Sir/Ma'am,<br>a new visitor send C.V";

            MyMail.IsBodyHtml = true;


            //Attachment mailAttachment = new Attachment(attachment );
            //MyMail.Attachments.Add(mailAttachment);
            string smtpHost = "smtp.gmail.com";
            System.Net.Mail.SmtpClient mClient = new System.Net.Mail.SmtpClient();
            mClient.Port = 587;
            mClient.EnableSsl = true;
            mClient.UseDefaultCredentials = false;
            mClient.Credentials = new System.Net.NetworkCredential("astronomer.ravi@gmail.com", "9889520605");
            mClient.Host = smtpHost;
            mClient.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
            mClient.Timeout = int.MaxValue;
            mClient.Send(MyMail);
            return true;

        }
        catch (Exception ex)
        {
            return false;
        }
    }

//----Visitor-mail----
    public bool send_mail_vstr(string txtemail)
    {
        try
        {
            MailAddress toAddress = new MailAddress(txtemail);
            MailAddress fromAddress = new MailAddress("astronomer.ravi@gmail.com");
            MailMessage MyMail = new MailMessage(fromAddress, toAddress);

            MyMail.Subject = "Confirmation!!!";
            MyMail.Body = "Dear Applicant,<br>Congratulation! We have received your C.V. We'll contact you very shortly.<br /><br/>ThankYou...  <br/>SAAPSA Buliders<br/>Mo: +91-9621394333";

            MyMail.IsBodyHtml = true;

            //Attachment mailAttachment = new Attachment(attachment );
            //MyMail.Attachments.Add(mailAttachment);
            string smtpHost = "smtp.gmail.com";
            System.Net.Mail.SmtpClient mClient = new System.Net.Mail.SmtpClient();
            mClient.Port = 587;
            mClient.EnableSsl = true;
            mClient.UseDefaultCredentials = false;
            mClient.Credentials = new System.Net.NetworkCredential("astronomer.ravi@gmail.com", "9889520605");
            mClient.Host = smtpHost;
            mClient.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
            mClient.Timeout = int.MaxValue;
            mClient.Send(MyMail);
            return true;

        }
        catch (Exception ex)
        {
            return false;
        }
    }

         public bool ins_registerLogin(string lg_id, string name, string gender, string course, string father, string adrs, string cntct, string email, string joini, string comple, string duration, string issue, string certi)
    
       
    {
        //try
        //{
        SqlCommand cmd = new SqlCommand("exec proc_Register11 @a,@b,@c,@d,@e,@f,@g,@h,@i,@j,@k,@l,@m", con);//
        cmd.Parameters.Add("@a", lg_id);
        cmd.Parameters.Add("@b", name);
        cmd.Parameters.Add("@c", gender);
        cmd.Parameters.Add("@d", course);
        cmd.Parameters.Add("@e", father);
        cmd.Parameters.Add("@f", adrs);
        cmd.Parameters.Add("@g", cntct);
        cmd.Parameters.Add("@h", email);
        cmd.Parameters.Add("@i", joini);
        cmd.Parameters.Add("@j", comple);
        cmd.Parameters.Add("@k", duration);
        cmd.Parameters.Add("@l", issue);
        cmd.Parameters.Add("@m", certi);
        //SqlCommand cmd1 = new SqlCommand("exec proc_userLogin @a,@b,@c,@d", con);
        //cmd1.Parameters.Add("@a", id);
        //cmd1.Parameters.Add("@b", "login@123");
        //cmd1.Parameters.Add("@c", "user");
        ////cmd1.Parameters.Add("@d", "2");
        //cmd1.Parameters.Add("@d", "1");
        con.Open();
        cmd.ExecuteNonQuery();
        //cmd1.ExecuteNonQuery();
        return true;

    
    }

         public bool ins_registerLogin1(string lg_id, string name, string gender, string contact, string father, string adrs)
         {
             //try
             //{
             SqlCommand cmd = new SqlCommand("exec proc_Register11 @a,@b,@c,@d,@e,@f", con);//
             cmd.Parameters.Add("@a", lg_id);
             cmd.Parameters.Add("@b", name);
             cmd.Parameters.Add("@c", gender);
             cmd.Parameters.Add("@d", contact);
             cmd.Parameters.Add("@e", father);
             cmd.Parameters.Add("@f", adrs);
          
             //SqlCommand cmd1 = new SqlCommand("exec proc_userLogin @a,@b,@c,@d", con);
             //cmd1.Parameters.Add("@a", id);
             //cmd1.Parameters.Add("@b", "login@123");
             //cmd1.Parameters.Add("@c", "user");
             ////cmd1.Parameters.Add("@d", "2");
             //cmd1.Parameters.Add("@d", "1");
             con.Open();
             cmd.ExecuteNonQuery();
             //cmd1.ExecuteNonQuery();
             return true;


         }
    }
   

   


   
