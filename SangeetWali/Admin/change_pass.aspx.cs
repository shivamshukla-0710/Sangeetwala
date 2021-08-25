using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Admin_change_pass : System.Web.UI.Page
{

    ClsGeneral ClsGen = new ClsGeneral();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click1(object sender, EventArgs e)
    {

    }
    protected void ChangePasswordPushButton_Click(object sender, EventArgs e)
    {
        try
        {
            if (!string.IsNullOrEmpty(CurrentPassword.Text) && !string.IsNullOrEmpty(NewPassword.Text) && !string.IsNullOrEmpty(ConfirmNewPassword.Text))
            {
                string CurrPwd = Convert.ToString(ClsGen.ExScaler("select Pwd from Admin_Login where Uid='" + CurrentPassword0.Text + "'"));
                if (CurrentPassword.Text == CurrPwd)
                {
                    if (NewPassword.Text.Equals(ConfirmNewPassword.Text))
                    {
                        ClsGen.ExNonQuery("Update Admin_Login set Pwd='" + NewPassword.Text + "' where Uid='" + CurrentPassword0.Text + "'");
                        CurrentPassword.Text = "";
                        NewPassword.Text = "";
                        ConfirmNewPassword.Text = "";
                        Response.Write("<script>alert('Password Updated!');</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('New And Confirm password dose not match!');</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('Old Password dose not match!');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Please fill all field!');</script>");
            }
        }
        catch (Exception x)
        {
            Response.Write("<script>alert('Error occured, Please contact Administrator!("+x.Message+")');</script>");
            
        }
    
    }
}
