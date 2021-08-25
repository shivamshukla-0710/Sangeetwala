using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.IO;

public partial class Admin_Super_speciality_TrainingSch : System.Web.UI.Page
{
    Class1 cls = new Class1();
    string subj = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con = cls.getcon();
        SqlCommand cmd = new SqlCommand("select id,subName from subName", con);
        SqlDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            RadioButton cb = new RadioButton();
            cb.Text = dr["subName"].ToString();
            cb.ID = dr["id"].ToString();
            cb.CheckedChanged += new EventHandler(l1_Click);//(l1_Click);// EventHandler(l1_Click);
            cb.GroupName = "1";
            Form.Controls.Add(cb);
            Label separator = new Label();
            separator.Text = "  ";
            Form.Controls.Add(separator);
        }
        con.Close(); 
    }
    protected void Button1_upload_Click(object sender, EventArgs e)
    {
        string tst = subj;
        try
        {
            SqlConnection con = cls.getcon();
            if (ConnectionState.Closed != con.State)
            {
                con.Close();
            }
            string filename = Path.GetFileName(fileuploadimages.PostedFile.FileName);
            string ff = tst + filename;
            fileuploadimages.SaveAs(Server.MapPath("fileName/" + tst + filename));
            con.Open();

            SqlCommand cmd = new SqlCommand("Insert into uploadFiles(fileName,Description) values(@fileName,@Description)", con);

            cmd.Parameters.AddWithValue("@fileName", ff);
            cmd.Parameters.AddWithValue("@Description", TextBox1.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            txtDesc.Text = string.Empty;
            ff = string.Empty;
        }
        catch (Exception ex)
        {
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        SqlConnection con = cls.getcon();
        if (ConnectionState.Closed != con.State)
        {
            con.Close();
        }
        con.Open();
        SqlCommand cmd = new SqlCommand("insert into subName  (subName) values('" + txtDesc.Text + "')", con);
        cmd.ExecuteNonQuery();
        con.Close();
        txtDesc.Text = "";
    }
    void l1_Click(object sender, EventArgs e)
    {
        //Panel1.Visible = true;
        try
        {
            RadioButton lb = (RadioButton)sender;
            //LinkButton lb = new LinkButton();
            //RadioButton lb = new RadioButton();
            int id = Convert.ToInt32(lb.ID);
            SqlConnection cn = cls.getcon();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select subName from subName WHERE id='" + id + "' ", cn);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                //subj = ds.Tables["sub"].ToString();//.Rows.Count;

                subj = ds.Tables[0].Rows[0][0].ToString();
            }
        }
        catch (Exception ex)
        { }
        //cmd.Parameters.Add("@id", id);
        //SqlDataReader dr = cmd.ExecuteReader();
        //while (dr.Read())
        //{
        //    string subjectname=
        //    String url = "audiofile/" + dr["audio"].ToString();
        //    //String videoplayerhtml = "<video controls=\"\" autoplay=\"\" name=\"media\"><source src=\"" + url + "\" type=\"audio/mp3\"></video>";
        //    //String videoplayerhtml = "<audio controls autoplay name=\"xyz\" src=\""+url+"\"></audio>";
        //    //videoplayer.InnerHtml = "";
        //    //videoplayer.InnerHtml = videoplayerhtml;

        //    //String jwplayer_javascript_code = "$(\"document\").ready(function(){jwplayer(\"videoplayer\").load({file: \"" + url + "\", title: \"vivekTitle\", autostart: true});})";
        //    //Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "jwplayerscriptload", jwplayer_javascript_code, true);
        //}


    }
    protected void txtDesc_TextChanged(object sender, EventArgs e)
    {

    }
}