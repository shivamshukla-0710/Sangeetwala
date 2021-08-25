using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
/// <summary>
/// Summary description for myclass
/// </summary>
public class myclass
{

    //  SqlConnection con1 = new SqlConnection(@"Data Source=198.71.226.6; Initial Catalog=SANGEET_KLA; User ID=DBSANGEET; Password=1Dckb^88;");

    SqlConnection con = new SqlConnection(@"Data Source=198.71.226.6; Initial Catalog=SANGEET_KLA; User ID=DBSANGEET; Password=1Dckb^88");
   // SqlConnection con = new SqlConnection(@"Data Source=103.21.58.78;Initial Catalog=rssgdb; User Id=rssguser; Password=pass@786;");

    //------------------------Searching Grid code----------------------------
    public void gridfill(string x, GridView g, Label lblmsg)
    {

        SqlDataAdapter da = new SqlDataAdapter(x, con);
        DataSet ds = new DataSet();

        da.Fill(ds, "avbooks");
        if (ds.Tables["avbooks"].Rows.Count > 0)
            g.DataSource = ds.Tables["avbooks"];
        else
        {
            ds.Dispose();

            g.DataSource = ds.Tables[0];
            lblmsg.Text = "No Records present according to your search";
        }
        // bind data to gridview

        g.DataBind();
    }
    public bool insert(TextBox fname, TextBox lname, TextBox adrs, TextBox mobile, TextBox email, TextBox city, TextBox clg, TextBox course, string tusrid)
    {
        bool res = false;
        try
        {

            SqlCommand comm = new SqlCommand("exec proc_register @a,@b,@c,@d,@e,@f,@g,@h,@i,@j;exec proc_insert_login @a,@b", con);
            comm.Parameters.Add("@a", tusrid);
            comm.Parameters.Add("@b", "ami@12345");
            comm.Parameters.Add("@c", fname.Text);
            comm.Parameters.Add("@d", lname.Text);
            comm.Parameters.Add("@e", adrs.Text);
            comm.Parameters.Add("@f", mobile.Text);
            comm.Parameters.Add("@g", email.Text);
            comm.Parameters.Add("@h", city.Text);
            comm.Parameters.Add("@i", clg.Text);
            comm.Parameters.Add("@j", course.Text);

            con.Open();
            comm.ExecuteNonQuery();

            res = true;
            return res;

        }
        catch (Exception ex)
        {


            return res;

        }
        finally
        {
            con.Close();
            //reset();
        }

    }


    public bool   insertTree(string mode,string side,string sp_id, TextBox userid, string name, string jointype, string joinside, string  lleg, string rleg, int ljoining, int rjoining, string llleg,string rrleg,int lljoining,int rrjoining,int pair)
    {
        bool res = false;
        try
        {

            SqlCommand comm = new SqlCommand("exec proc_manage_Tree @mode,@side,@sp_id, @a,@b,@c,@d,@e,@f,@g,@h,@i,@j,@k,@l,@m", con);
            comm.Parameters.Add("@mode", mode);
            comm.Parameters.Add("@side", side);
            comm.Parameters.Add("@sp_id", sp_id);
            comm.Parameters.Add("@a", userid.Text);
            comm.Parameters.Add("@b", name);
            comm.Parameters.Add("@c", jointype);
            comm.Parameters.Add("@d", joinside);
            comm.Parameters.Add("@e", lleg);
            comm.Parameters.Add("@f", rleg);
            comm.Parameters.Add("@g", ljoining);
            comm.Parameters.Add("@h", rjoining);
            comm.Parameters.Add("@i",llleg );
            comm.Parameters.Add("@j", rrleg);
            comm.Parameters.Add("@k",lljoining);
            comm.Parameters.Add("@l", rrjoining);
            comm.Parameters.Add("@m", pair);


            con.Open();
            comm.ExecuteNonQuery();

            res = true;
            return res;

        }
        catch (Exception ex)
        {


            return res;

        }
        finally
        {
            con.Close();
            //reset();
        }

    }

    public string validate(TextBox txt_uname, TextBox txt_pwd)
    {
        string res = "N";
        SqlCommand cmd = new SqlCommand("select utype from login where user_name=@a and password=@b", con);
        cmd.Parameters.Add("@a", txt_uname.Text);
        cmd.Parameters.Add("@b", txt_pwd.Text);
        con.Open();
        //////////////////////////////////
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            res = dr["utype"].ToString();
        }
        /////////////////////////////////////

        con.Close();
        return res;
    }
    public int getstatus(TextBox txt_uname, TextBox txt_pwd)
    {
        int res = 5;
        SqlCommand cmd = new SqlCommand("select status from register where user_name=@a and password=@b", con);
        cmd.Parameters.Add("@a", txt_uname.Text);
        cmd.Parameters.Add("@b", txt_pwd.Text);
        con.Open();
        //////////////////////////////////
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            res = Convert.ToInt16(dr["status"]);
        }
        /////////////////////////////////////

        con.Close();
        return res;
    }
//public bool insert(TextBox uname, TextBox pwd, TextBox fname, TextBox lname, TextBox adrs, TextBox mobile, TextBox email, TextBox city, TextBox clg, TextBox course)
//{
//    bool res = false;
//    try
//    {

//        SqlCommand comm = new SqlCommand("exec proc_register @a,@b,@c,@d,@e,@f,@g,@h,@i,@j;exec proc_insert_login @a,@b", con);
//        comm.Parameters.Add("@a", uname.Text);
//        comm.Parameters.Add("@b", pwd.Text);
//        comm.Parameters.Add("@c", fname.Text);
//        comm.Parameters.Add("@d", lname.Text);
//        comm.Parameters.Add("@e", adrs.Text);
//        comm.Parameters.Add("@f", mobile.Text);
//        comm.Parameters.Add("@g", email.Text);
//        comm.Parameters.Add("@h", city.Text);
//        comm.Parameters.Add("@i", clg.Text);
//        comm.Parameters.Add("@j", course.Text);

//        con.Open();
//        comm.ExecuteNonQuery();

//        res = true;
//        return res;

//    }
//    catch (Exception ex)
//    {


//        return res;

//    }
//    finally
//    {
//        con.Close();
//        //reset();
//    }

//}
    public bool ins_book(TextBox isbn_txt, TextBox auth_txt, TextBox bknm_txt, TextBox edn_txt, TextBox publ_txt, TextBox prc_txt, FileUpload b_path, TextBox qty_txt)
    {
        bool res = false;
        try
        {

            SqlCommand comm = new SqlCommand("exec pro_ins_phrbk @a,@c,@d,@e,@f,@g,@h,@i", con);

            comm.Parameters.Add("@a", isbn_txt.Text); 
           
            comm.Parameters.Add("@c", auth_txt.Text);
            comm.Parameters.Add("@d", bknm_txt.Text);
            comm.Parameters.Add("@e", edn_txt.Text);
            comm.Parameters.Add("@f", publ_txt.Text);
            comm.Parameters.Add("@h", b_path.FileName);
            comm.Parameters.Add("@g", prc_txt.Text);
            comm.Parameters.Add("@i", qty_txt.Text);

            con.Open();
            comm.ExecuteNonQuery();

            res = true;
            return res;

        }
        catch (Exception ex)
        {


            return res;

        }
        finally
        {
            con.Close();

        }

    }
    public bool ins_bpharma(TextBox sem, TextBox sub, TextBox ppr_cd)
    {
        bool res = false;
        try
        {

            SqlCommand comm = new SqlCommand("exec pro_ins_bpharma @a,@b,@c", con);
            comm.Parameters.Add("@a", sem.Text);
            comm.Parameters.Add("@b", sub.Text);
            comm.Parameters.Add("@c", ppr_cd.Text);
            con.Open();
            comm.ExecuteNonQuery();

            res = true;
            return res;

        }
        catch (Exception ex)
        {


            return res;

        }
        finally
        {
            con.Close();

        }

    }


    public bool ins_barch(TextBox sem, TextBox sub, TextBox ppr_cd)
    {
        bool res = false;
        try
        {

            SqlCommand comm = new SqlCommand("exec pro_barch @a,@b,@c", con);
            comm.Parameters.Add("@a", sem.Text);
            comm.Parameters.Add("@b", sub.Text);
            comm.Parameters.Add("@c", ppr_cd.Text);
            con.Open();
            comm.ExecuteNonQuery();

            res = true;
            return res;

        }
        catch (Exception ex)
        {


            return res;

        }
        finally
        {
            con.Close();

        }

    }

    public bool ins_btechme(TextBox sem, TextBox sub, TextBox ppr_cd)
    {
        bool res = false;
        try
        {

            SqlCommand comm = new SqlCommand("exec pro_btechme @a,@b,@c", con);
            comm.Parameters.Add("@a", sem.Text);
            comm.Parameters.Add("@b", sub.Text);
            comm.Parameters.Add("@c", ppr_cd.Text);
            con.Open();
            comm.ExecuteNonQuery();

            res = true;
            return res;

        }
        catch (Exception ex)
        {


            return res;

        }
        finally
        {
            con.Close();

        }

    }

    public bool ins_btechec(TextBox sem, TextBox sub, TextBox ppr_cd)
    {
        bool res = false;
        try
        {

            SqlCommand comm = new SqlCommand("exec pro_btechec @a,@b,@c", con);
            comm.Parameters.Add("@a", sem.Text);
            comm.Parameters.Add("@b", sub.Text);
            comm.Parameters.Add("@c", ppr_cd.Text);
            con.Open();
            comm.ExecuteNonQuery();

            res = true;
            return res;

        }
        catch (Exception ex)
        {


            return res;

        }
        finally
        {
            con.Close();

        }

    }
    public bool ins_btechee(TextBox sem, TextBox sub, TextBox ppr_cd)
    {
        bool res = false;
        try
        {

            SqlCommand comm = new SqlCommand("exec pro_btechee @a,@b,@c", con);
            comm.Parameters.Add("@a", sem.Text);
            comm.Parameters.Add("@b", sub.Text);
            comm.Parameters.Add("@c", ppr_cd.Text);
            con.Open();
            comm.ExecuteNonQuery();

            res = true;
            return res;

        }
        catch (Exception ex)
        {


            return res;

        }
        finally
        {
            con.Close();

        }

    }
    public bool ins_btechit(TextBox sem, TextBox sub, TextBox ppr_cd)
    {
        bool res = false;
        try
        {

            SqlCommand comm = new SqlCommand("exec pro_btechit @a,@b,@c", con);
            comm.Parameters.Add("@a", sem.Text);
            comm.Parameters.Add("@b", sub.Text);
            comm.Parameters.Add("@c", ppr_cd.Text);
            con.Open();
            comm.ExecuteNonQuery();

            res = true;
            return res;

        }
        catch (Exception ex)
        {


            return res;

        }
        finally
        {
            con.Close();

        }

    }

    public bool ins_btechcs(TextBox sem, TextBox sub, TextBox ppr_cd)
    {
        bool res = false;
        try
        {

            SqlCommand comm = new SqlCommand("exec pro_btechcs @a,@b,@c", con);
            comm.Parameters.Add("@a", sem.Text);
            comm.Parameters.Add("@b", sub.Text);
            comm.Parameters.Add("@c", ppr_cd.Text);
            con.Open();
            comm.ExecuteNonQuery();

            res = true;
            return res;

        }
        catch (Exception ex)
        {


            return res;

        }
        finally
        {
            con.Close();

        }

    }

    public bool ins_mba(TextBox sem, TextBox sub, TextBox ppr_cd)
    {
        bool res = false;
        try
        {

            SqlCommand comm = new SqlCommand("exec pro_ins_mba @a,@b,@c", con);
            comm.Parameters.Add("@a", sem.Text);
            comm.Parameters.Add("@b", sub.Text);
            comm.Parameters.Add("@c", ppr_cd.Text);
            con.Open();
            comm.ExecuteNonQuery();

            res = true;
            return res;

        }
        catch (Exception ex)
        {


            return res;

        }
        finally
        {
            con.Close();

        }

    }
    public bool ins_mca(TextBox sem, TextBox sub, TextBox ppr_cd)
    {
        bool res = false;
        try
        {

            SqlCommand comm = new SqlCommand("exec pro_ins_mca @a,@b,@c", con);
            comm.Parameters.Add("@a", sem.Text);
            comm.Parameters.Add("@b", sub.Text);
            comm.Parameters.Add("@c", ppr_cd.Text);
            con.Open();
            comm.ExecuteNonQuery();

            res = true;
            return res;

        }
        catch (Exception ex)
        {


            return res;

        }
        finally
        {
            con.Close();

        }

    }
    public bool insert_dtls(TextBox uname, TextBox pwd, TextBox fname, TextBox lname, TextBox adrs, TextBox mobile, TextBox email, TextBox city)
    {
        bool res = false;
        try
        {

            SqlCommand comm = new SqlCommand("exec pro_ins_adreg @a,@b,@c,@d,@e,@f,@g,@h;exec pro_ins_adlogin @a,@b ", con);
            comm.Parameters.Add("@a", uname.Text);
            comm.Parameters.Add("@b", pwd.Text);
            comm.Parameters.Add("@c", fname.Text);
            comm.Parameters.Add("@d", lname.Text);
            comm.Parameters.Add("@e", adrs.Text);
            comm.Parameters.Add("@f", mobile.Text);
            comm.Parameters.Add("@g", email.Text);
            comm.Parameters.Add("@h", city.Text);


            con.Open();
            comm.ExecuteNonQuery();

            res = true;
            return res;

        }
        catch (Exception ex)
        {
            return res;

        }
        finally
        {
            con.Close();
            //reset();
        }
    }
    public bool seladmin(String sessid, Label fname, Label lname, Label mob, Label email, Label add, Label city)
    {

        bool res = false;
        try
        {
            con.Open();
            SqlDataAdapter dap1 = new SqlDataAdapter("select fname,lname,mobile,email_id,address,city from register where user_name='" + sessid + "'", con);

            DataSet dset = new DataSet();
            dap1.Fill(dset);
            fname.Text = dset.Tables[0].Rows[0][0].ToString();
            lname.Text = dset.Tables[0].Rows[0][1].ToString();
            mob.Text = dset.Tables[0].Rows[0][2].ToString();
            email.Text = dset.Tables[0].Rows[0][3].ToString();
            add.Text = dset.Tables[0].Rows[0][4].ToString();
            city.Text = dset.Tables[0].Rows[0][5].ToString();
            res = true;
            return res;

        }
        catch (Exception ex)
        {
            return res;

        }
        finally
        {
            con.Close();
        }
   }
    public bool selusr(String sessid, Label fname, Label lname, Label mob, Label email, Label add, Label city,Label course,Label college)
    {

        bool res = false;
        try
        {
            con.Open();
            SqlDataAdapter dap1 = new SqlDataAdapter("select fname,lname,mobile,email_id,address,city,course,college from register where user_name='" + sessid + "'", con);

            DataSet dset = new DataSet();
            dap1.Fill(dset);
            fname.Text = dset.Tables[0].Rows[0][0].ToString();
            lname.Text = dset.Tables[0].Rows[0][1].ToString();
            mob.Text = dset.Tables[0].Rows[0][2].ToString();
            email.Text = dset.Tables[0].Rows[0][3].ToString();
            add.Text = dset.Tables[0].Rows[0][4].ToString();
            city.Text = dset.Tables[0].Rows[0][5].ToString();
            course.Text = dset.Tables[0].Rows[0][6].ToString();
            college.Text = dset.Tables[0].Rows[0][7].ToString();
            res = true;
            return res;

        }
        catch (Exception ex)
        {
            return res;

        }
        finally
        {
            con.Close();
        }
    }
    public bool updadmin(String sessid, TextBox fname, TextBox lname, TextBox num_tbx, TextBox email, TextBox add, TextBox city)
    {

        bool res = false;
        try
        {
            con.Open();
            SqlCommand comm = new SqlCommand("exec proc_upd_reg  @a,@b,@c,@d,@e,@f,@g", con);
            comm.Parameters.Add("@a", fname.Text);
            comm.Parameters.Add("@b", lname.Text);
            comm.Parameters.Add("@c", num_tbx.Text);
            comm.Parameters.Add("@d", email.Text);
            comm.Parameters.Add("@e", add.Text);
            comm.Parameters.Add("@f", city.Text);
            comm.Parameters.Add("@g", sessid);
            comm.ExecuteNonQuery();
            res = true;
            return res;

        }
        catch (Exception ex)
        {
            return res;

        }
        finally
        {
            con.Close();
        }
    }
    public bool updusr(String sessid, TextBox fname, TextBox lname, TextBox num_tbx, TextBox email, TextBox add, TextBox city,TextBox college,TextBox course)
    {

        bool res = false;
        try
        {
            con.Open();
            SqlCommand comm = new SqlCommand("exec pro_upregr  @a,@b,@c,@d,@e,@f,@g,@h,@i", con);
            comm.Parameters.Add("@a", fname.Text);
            comm.Parameters.Add("@b", lname.Text);
            comm.Parameters.Add("@c", num_tbx.Text);
            comm.Parameters.Add("@d", email.Text);
            comm.Parameters.Add("@e", add.Text);
            comm.Parameters.Add("@f", city.Text);
            comm.Parameters.Add("@g", sessid);
            comm.Parameters.Add("@h", college.Text);
            comm.Parameters.Add("@i", course.Text);
            comm.ExecuteNonQuery();
            res = true;
            return res;

        }
        catch (Exception ex)
        {
            return res;

        }
        finally
        {
            con.Close();
        }
    }
    public string confirmpass(String sessid)
    {

        string res = "";
        try
        {
            con.Open();
            SqlCommand comm = new SqlCommand("exec pro_confpass @b", con);
          
            comm.Parameters.Add("@b", sessid);
            comm.ExecuteNonQuery();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.Read())
            {
                res = dr["password"].ToString();
            }
            /////////////////////////////////////

            return res;

        }
        catch (Exception ex)
        {
            return res;

        }
        finally
        {
            con.Close();
        }

    }
    public bool updatepass(String sessid, TextBox npwd)
    {

        bool res = false;
        try
        {
            con.Open();
            SqlCommand comm = new SqlCommand("exec pro_ad_chngepass @a,@b;exec pro_log_chngepass @a,@b", con);
            comm.Parameters.Add("@a", npwd.Text);
            comm.Parameters.Add("@b", sessid);
            comm.ExecuteNonQuery();
            res = true;
            return res;

        }
        catch (Exception ex)
        {
            return res;

        }
        finally
        {
            con.Close();
        }
    }
    public bool exist(TextBox txt_uname)
    {
        bool res = false;
        SqlCommand cmd = new SqlCommand("select * from login where user_name=@a", con);
        cmd.Parameters.Add("@a", txt_uname.Text);
        con.Open();
       
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            res = true;
        }
       

        con.Close();
        return res;
    }
    public string avail(TextBox txt_isbn)
    {
        String res = "N";
        SqlCommand cmd = new SqlCommand("exec pro_availphbook @a", con);
        cmd.Parameters.Add("@a", txt_isbn.Text);
        con.Open();
        
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            res = dr["avail"].ToString();
        }
      

        con.Close();
        return res;
    }
    public int price(TextBox txt_isbn)
    {
        int res = 0;
        SqlCommand cmd = new SqlCommand("exec pro_selprice @a", con);
        cmd.Parameters.Add("@a", txt_isbn.Text);
        con.Open();

        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            res = Convert.ToInt16(dr["price"]);
        }


        con.Close();
        return res;
    }
    public bool addtocart(String oid,TextBox txt_fname , TextBox txt_lname, TextBox txt_addr, TextBox txt_pnum, TextBox txt_eid,TextBox txt_isbn,TextBox txt_qty,Int64 price)
    {
        bool res = false;
        try
        {

            SqlCommand comm = new SqlCommand("exec pro_userorder @oid,@a,@b,@c,@d,@e;exec pro_addcart @f,@g,@h,@i", con);
            comm.Parameters.Add("@oid", oid); 
            comm.Parameters.Add("@a", txt_fname.Text);
            comm.Parameters.Add("@b", txt_lname.Text);
            comm.Parameters.Add("@c", txt_addr.Text);
            comm.Parameters.Add("@d", txt_pnum.Text);
            comm.Parameters.Add("@e", txt_eid.Text);
            comm.Parameters.Add("@f", oid);
            comm.Parameters.Add("@g", txt_isbn.Text);
            comm.Parameters.Add("@h", txt_qty.Text);
            comm.Parameters.Add("@i", price);
           
            con.Open();
            comm.ExecuteNonQuery();

            res = true;
            return res;

        }
        catch (Exception ex)
        {


            return res;

        }
        finally
        {
            con.Close();
            //reset();
        }

    }
    public bool mycart(String oid, TextBox txt_isbn, TextBox txt_qty, Int64 price)
    {
        bool res = false;
        try
        {

            SqlCommand comm = new SqlCommand("exec pro_addcart @f,@g,@h,@i", con);
            
            comm.Parameters.Add("@f", oid);
            comm.Parameters.Add("@g", txt_isbn.Text);
            comm.Parameters.Add("@h", txt_qty.Text);
            comm.Parameters.Add("@i", price);

            con.Open();
            comm.ExecuteNonQuery();

            res = true;
            return res;

        }
        catch (Exception ex)
        {


            return res;

        }
        finally
        {
            con.Close();
            //reset();
        }

    }
    public bool viewcart(string ordid, GridView gview_cart, Label lbl_msg)
    {
        bool res = false;
        try
        {
            SqlCommand comm = new SqlCommand("exec pro_cart @a", con);
            comm.Parameters.Add("@a", ordid);
            con.Open();
            comm.ExecuteNonQuery();

            
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(comm);
            da.Fill(ds, "cart");
            if (ds.Tables["cart"].Rows.Count > 0)
            {
                gview_cart.DataSource = ds.Tables["cart"];
                lbl_msg.Visible = true;
                lbl_msg.Text = "YOU ADDED FOLLOWING BOOKS IN YOUR CART...";
            }
            else
            {
                ds.Dispose();
                gview_cart.DataSource = ds.Tables[0];
                lbl_msg.Visible = true;
                lbl_msg.Text = "NO BOOKS ARE YET ADDED TO YOUR CART...";
            }
            gview_cart.DataBind();
            res = true;
            return res;


        }
        catch (Exception ex)
        {
            return res;
        }
        finally
        {
            con.Close();
            //reset();
        }
    }
    public bool booksearch(GridView gridview1, Label lbl_PaperCode)
    {
        bool res = false;
        try
        {
            SqlCommand comm = new SqlCommand("exec pro_booksearch @a", con);
            comm.Parameters.Add("@a", lbl_PaperCode.Text);
            con.Open();
            comm.ExecuteNonQuery();


            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(comm);
            da.Fill(ds, "bs");
            if (ds.Tables["bs"].Rows.Count > 0)
            {
                gridview1.DataSource = ds.Tables["bs"];


            }
            else
            {
                ds.Dispose();
                gridview1.DataSource = ds.Tables[0];

            }
            gridview1.DataBind();
            res = true;
            return res;


        }
        catch (Exception ex)
        {
            return res;
        }
        finally
        {
            con.Close();
            //reset();
        }
    }
    public string getimg(TextBox txt_isbn)
    {
        string res = "N";
        SqlCommand cmd = new SqlCommand("select book_path from pharmabook where book_isbn=@a ", con);
        cmd.Parameters.Add("@a", txt_isbn.Text);

        con.Open();

        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            res = "~/bookimg/" + dr["book_path"].ToString();
        }


        con.Close();
        return res;
    }
    public bool delcart(String s1, String s2, String s3)
    {
        bool res = false;
        SqlCommand cmd = new SqlCommand("exec pro_delcart @a,@b,@c", con);
        cmd.Parameters.Add("@a", s1);
        cmd.Parameters.Add("@b", s2);
        cmd.Parameters.Add("@c", s3);

        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();


        con.Close();
        return res;
    }
    public bool setstatus(String s1, String s2, String s3)
    {
        bool res = false;
        SqlCommand cmd = new SqlCommand("exec pro_setstatus @a,@b,@c", con);
        cmd.Parameters.Add("@a", s1);
        cmd.Parameters.Add("@b", s2);
        cmd.Parameters.Add("@c", s3);

        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            res = true;
        }
        con.Close();
        return res;


    }
    public bool upstatus(String s1, String s2, String s3)
    {
        bool res = false;
        SqlCommand cmd = new SqlCommand("exec pro_upstatus @a,@b,@c", con);
        cmd.Parameters.Add("@a", s1);
        cmd.Parameters.Add("@b", s2);
        cmd.Parameters.Add("@c", s3);

        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            res = true;
        }
        con.Close();
        return res;


    }
    public bool finalstatus(String s1)
    {
        bool res = false;
        SqlCommand cmd = new SqlCommand("exec pro_finalstatus @a", con);
        cmd.Parameters.Add("@a", s1);

        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            res = true;
        }
        con.Close();
        return res;


    }
    public bool ord(String s1)
    {
        bool res = false;
        SqlCommand cmd = new SqlCommand("exec pro_stock @a", con);
        cmd.Parameters.Add("@a", s1);

        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            res = true;
        }
        con.Close();
        return res;


    }
    public bool upavail(TextBox txt_book, TextBox txt_isbn)
    {
        bool res = false;
        SqlCommand cmd = new SqlCommand("exec pro_upstock @a,@b", con);
        int i = Convert.ToInt16((txt_book.Text));
        cmd.Parameters.Add("@a", i);
        cmd.Parameters.Add("@b", txt_isbn.Text);
        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            res = true;
        }
        con.Close();
        return res;


    }

    public bool upbs(TextBox txt_isbn,TextBox txt_book)
    {
        bool res = false;
        SqlCommand cmd = new SqlCommand("exec pro_upstock @a,@b", con);
        
        cmd.Parameters.Add("@a", txt_isbn.Text);
        cmd.Parameters.Add("@b", txt_book.Text);
        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            res = true;
        }
        con.Close();
        return res;


    }
    public string getemail(String s)
    {
        string res = "N";
        SqlCommand cmd = new SqlCommand("select email from userorder where Ord_id=@a ", con);
        cmd.Parameters.Add("@a", s);

        con.Open();

        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            res = dr["email"].ToString();
        }


        con.Close();
        return res;
    }

    public bool getregemail(TextBox s)
    {
        bool res = false;
        SqlCommand cmd1 = new SqlCommand("select * from register where email_id=@a ", con);
        cmd1.Parameters.Add("@a", s.Text);
        con.Open();
        SqlDataReader dr = cmd1.ExecuteReader();
        if (dr.Read())
        {
            res = true;
        }


        con.Close();
        return res;
    }


   
    public string getadd(String s)
    {
        string res = "N";
        SqlCommand cmd = new SqlCommand("select addr from userorder where Ord_id=@a ", con);
        cmd.Parameters.Add("@a", s);
        con.Open();

        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            res = dr["addr"].ToString();
        }


        con.Close();
        return res;
    }
    public string getamt(String s)
    {
        string res = "N";
        SqlCommand cmd = new SqlCommand("exec pro_amt @a", con);
        cmd.Parameters.Add("@a", s);

        con.Open();

        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            res = dr["amt"].ToString();
        }


        con.Close();
        return res;
    }

    public bool getisbn(TextBox tb)
    {

        bool res = false;
        try
        {
            con.Open();
            SqlCommand comm = new SqlCommand("exec pro_geteisbn @b", con);

            comm.Parameters.Add("@b", tb.Text);
            comm.ExecuteNonQuery();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.Read())
            {
                res = true;
            }

            return res;

        }
        catch (Exception ex)
        {
            return res;

        }
        finally
        {
            con.Close();
        }


    }




    public DataTable getcommission(string agent)
    {
        DataTable dtsponser = new DataTable();
        dtsponser.Clear();
        dtsponser.Columns.Add("SponserID");
        dtsponser.Columns.Add("FromSponser");
        DataRow dr;

        try
        {
            con.Open();
           
        start:
            SqlDataAdapter dap1 = new SqlDataAdapter("select sponser_id from User_Detail where userid='" + agent + "'", con);
            
            DataTable dtagent = new DataTable();
            string newsponser = string.Empty;
            dtagent.Clear();
            dap1.Fill(dtagent);

            if (dtagent.Rows.Count > 0)
            {
                newsponser = dtagent.Rows[0]["sponser_id"].ToString();
                if (newsponser == "00000")
                {
                    goto end;
                }
               
                SqlDataAdapter dap3 = new SqlDataAdapter("select lleg,rleg,llleg,rrleg from User_Detail where userid='" + newsponser + "'", con);
                DataTable dtLegs = new DataTable();
                dtLegs.Clear();
                dap3.Fill(dtLegs);
                if (dtLegs.Rows.Count > 0)
                {
                    string lleg = string.Empty;
                    string llleg = string.Empty;
                    string rleg = string.Empty;
                    string rrleg = string.Empty;
                    lleg = dtLegs.Rows[0]["lleg"].ToString();
                    rleg = dtLegs.Rows[0]["rleg"].ToString();
                    llleg = dtLegs.Rows[0]["llleg"].ToString();
                    rrleg = dtLegs.Rows[0]["rrleg"].ToString();
                 
                    if (lleg != "" && rleg != "" && llleg != "" && rrleg != "")
                    {
                        dr = dtsponser.NewRow();
                        dr["SponserID"] = newsponser;
                        dr["FromSponser"] = agent;
                        dtsponser.Rows.Add(dr);
                    }
                    else
                    {

                    }
                    agent = newsponser;
                    goto start;
                   
                    
                }
                else
                {
                    goto end;
                }


            }
            else
            {
                goto end;
            }
        end:
            {
               
        }


       

            }        
        catch (Exception ex)
        {
           // return res;

        }
        finally
        {
            con.Close();
        }
        return dtsponser;
    }



    public bool insertCommission(string agent_id, double amount, string from_agent_id)
    {
        bool res = false;
        try
        {

            SqlCommand comm = new SqlCommand("exec proc_insert_Commission @agent_id,@Amount,@from_agent_id", con);
            comm.Parameters.Add("@agent_id", agent_id);
            comm.Parameters.Add("@Amount", amount);
            comm.Parameters.Add("@from_agent_id", from_agent_id);
            con.Open();
            comm.ExecuteNonQuery();

            res = true;
            return res;

        }
        catch (Exception ex)
        {


            return res;

        }
        finally
        {
            con.Close();
            //reset();
        }

    }



    public DataTable  SearchCommission(string date1,string date2, string status)
    {

        DataTable dtcommission = new DataTable();
        dtcommission.Clear();
        try
        {
            con.Open();
            if (status == "Pending")
            {
                SqlDataAdapter dap1 = new SqlDataAdapter("select c_id, agent_id as 'AgentCode',Amount, CONVERT(nvarchar(12),commission_date,103) as 'CommissionDate' from tbl_commission where (CONVERT(nvarchar(12),commission_date,103) between '" + date1 + "' and '" + date2 + "') and status='" + status + "'", con);
                dap1.Fill(dtcommission);
                return dtcommission;
            }
            else
            {
                SqlDataAdapter dap1 = new SqlDataAdapter("select c_id, agent_id as 'AgentCode',Amount, CONVERT(nvarchar(12),PaidDate,103) as 'CommissionDate' from tbl_commission where (CONVERT(nvarchar(12),PaidDate,103) between '" + date1 + "' and '" + date2 + "') and status='" + status + "'", con);
                dap1.Fill(dtcommission);
                return dtcommission;
            }
            

                     

        }
        catch (Exception ex)
        {

            return dtcommission;
        }
        finally
        {
            con.Close();
        }
    }

    public DataTable SearchPaidCommission(string agent_id,string date1, string date2, string status)
    {

        DataTable dtcommission = new DataTable();
        dtcommission.Clear();
        try
        {
            con.Open();

            SqlDataAdapter dap1 = new SqlDataAdapter("select c_id, agent_id as 'AgentCode',Amount, CONVERT(nvarchar(12),PaidDate,103) as 'CommissionDate' from tbl_commission where (CONVERT(nvarchar(12),PaidDate,103) between '" + date1 + "' and '" + date2 + "') and (status='" + status + "') and agent_id='" + agent_id + "'", con);
                dap1.Fill(dtcommission);
                return dtcommission;
        }
        catch (Exception ex)
        {

            return dtcommission;
        }
        finally
        {
            con.Close();
        }
    }
    public bool upadteCommission(int c_id)
    {
        bool res = false;
        try
        {

            SqlCommand comm = new SqlCommand("exec proc_Update_Commission @c_id", con);
            comm.Parameters.Add("@c_id", c_id);
            con.Open();
            comm.ExecuteNonQuery();
            res = true;
            return res;

        }
        catch (Exception ex)
        {


            return res;

        }
        finally
        {
            con.Close();
            //reset();
        }

    }

}