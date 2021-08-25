using System;
using System.Collections.Generic;
using System.Web;
using System.Net.Mail;

/// <summary>

/// </summary>
public class myemail
{
	

    //----------------------Send email code----------------------
    public bool send_mail(string to_adrs,string id,string passwd)
    {
        try{
            MailAddress toAddress = new MailAddress(to_adrs);
            MailAddress fromAddress = new MailAddress("astronomer.ravi@gmail.com");
            MailMessage MyMail = new  MailMessage(fromAddress, toAddress);

            MyMail.Subject = "Confirmation!!!";
            MyMail.Body = "Dear Sir/Ma'am,<br>Congratulations you are successfully registered with RRSG.Kindly note Your Login id:<u>"+id +"</u> and Password:<u>"+passwd +"<u>.<br>Want to login now click link:<a href='http://www.aminabadbook.com/login.aspx'>Login</a>";

            MyMail.IsBodyHtml = true;


            string smtpHost = "smtp.gmail.com";
            System.Net.Mail.SmtpClient mClient = new System.Net.Mail.SmtpClient();
            mClient.Port = 587;
            mClient.EnableSsl = true;
            mClient.UseDefaultCredentials = false;
            mClient.Credentials = new System.Net.NetworkCredential("astronomer.ravi@gmail.com", "786ravi9889520605");
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




    public bool send_ordermail(string to_adrs, string addr, string oid)
    {
        try
        {
            MailAddress toAddress = new MailAddress(to_adrs);
            MailAddress fromAddress = new MailAddress("astronomer.ravi@gmail.com");
            MailMessage MyMail = new MailMessage(fromAddress, toAddress);

            MyMail.Subject = "Confirmation!!!";
            MyMail.Body = "Dear Sir/Ma'am,<br>Thank you for ordering book.Kindly note Your Order number :<u>" + oid + "</u>.As per terms and conditions book will be delivered to <u>" + addr + " ,in coming three working days after reciept of this confirmation mail.";

            MyMail.IsBodyHtml = true;


            string smtpHost = "smtp.gmail.com";
            System.Net.Mail.SmtpClient mClient = new System.Net.Mail.SmtpClient();
            mClient.Port = 587;
            mClient.EnableSsl = true;
            mClient.UseDefaultCredentials = false;
            mClient.Credentials = new System.Net.NetworkCredential("astronomer.ravi@gmail.com", "786ravi9889520605");
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

    public bool send_lettermail(string to_adrs, string Name)
    {
        try
        {
            MailAddress toAddress = new MailAddress(to_adrs);
            MailAddress fromAddress = new MailAddress("astronomer.ravi@gmail.com");
            MailMessage MyMail = new MailMessage(fromAddress, toAddress);

            MyMail.Subject = "Confirmation!!!";
            MyMail.Body = "Dear Sir/Ma'am,<br>Thank you "+Name+"for registering with us.<br>We will be providing you our updates through newsletters.Our Customers means a lot to us.</br>";

            MyMail.IsBodyHtml = true;


            string smtpHost = "smtp.gmail.com";
            System.Net.Mail.SmtpClient mClient = new System.Net.Mail.SmtpClient();
            mClient.Port = 587;
            mClient.EnableSsl = true;
            mClient.UseDefaultCredentials = false;
            mClient.Credentials = new System.Net.NetworkCredential("astronomer.ravi@gmail.com", "786ravi9889520605");
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
}