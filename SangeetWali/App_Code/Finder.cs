using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Net.Security;

/// <summary>
/// Summary description for Finder
/// </summary>
public class Finder
{

    public Finder()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn1"].ToString());
    DataSet ds, ds1;

    SqlCommand cmd, cmd1;
    SqlDataAdapter adp, adp1;
    SqlDataReader dr;
    int less_Rchild = 0;
    int less_Lchild = 0;
    int cry_Rchild = 0;
    int cry_Lchild = 0;
    public string countLeftChild(string parent)
    {

        string count = "0";

        if (conn.State == ConnectionState.Open)
        {

            cmd = new SqlCommand("select ParentChild_id from tbl_UserHierarchy where MemberId='" + parent + "'", conn);
            dr = cmd.ExecuteReader();
            dr.Read();
            string prt_chld = dr["ParentChild_id"].ToString();
            dr.Close();
            cmd = new SqlCommand("select LChildId from tbl_UserHierarchy where MemberId='" + parent + "'", conn);
            dr = cmd.ExecuteReader();
            dr.Read();
            string left = prt_chld + "." + dr["LChildId"].ToString() + ".%";
            dr.Close();
            cmd = new SqlCommand("select count (UserID) from tbl_UserHierarchy where ParentChild_id like '" + left + "'and clr='Green'", conn);

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (dr[0].ToString() != "0")
                {
                    count = dr[0].ToString();

                    //lbltotllftmem.Text = l.ToString();
                }
                else
                {
                    count = "0";
                    //lbltotllftmem.Text = l.ToString();
                }
            }

            dr.Close();

        }
        else
        {
            conn.Open();
            cmd = new SqlCommand("select ParentChild_id from tbl_UserHierarchy where MemberId='" + parent + "'", conn);
            dr = cmd.ExecuteReader();
            dr.Read();
            string prt_chld = dr["ParentChild_id"].ToString();
            dr.Close();
            cmd = new SqlCommand("select LChildId from tbl_UserHierarchy where MemberId='" + parent + "'", conn);
            dr = cmd.ExecuteReader();
            dr.Read();
            string left1 = prt_chld + "." + dr["LChildId"].ToString() + ".%";
            dr.Close();
            cmd = new SqlCommand("select count (UserID) from tbl_UserHierarchy where ParentChild_id like '" + left1 + "'and clr='Green'", conn);

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (dr[0].ToString() != "0")
                {
                    count = dr[0].ToString();

                    //lbltotllftmem.Text = l.ToString();
                }
                else
                {
                    count = "0";
                    //lbltotllftmem.Text = l.ToString();
                }
            }

            dr.Close();


        }
        return count;


    }

    public string countRightChild(string parent11)
    {

        string count1 = "0";
        if (conn.State == ConnectionState.Open)
        {
            cmd = new SqlCommand("select ParentChild_id from tbl_UserHierarchy where MemberId='" + parent11 + "'", conn);
            dr = cmd.ExecuteReader();
            dr.Read();
            string prt_chld = dr["ParentChild_id"].ToString();
            dr.Close();
            cmd = new SqlCommand("select RChildId from tbl_UserHierarchy where MemberId='" + parent11 + "'", conn);
            dr = cmd.ExecuteReader();
            dr.Read();
            string Right = prt_chld + "." + dr["RChildId"].ToString() + ".%";
            dr.Close();
            cmd = new SqlCommand("select count (UserID) from tbl_UserHierarchy where ParentChild_id like '" + Right + "'and clr='Green'", conn);

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (dr[0].ToString() != "0")
                {
                    count1 = dr[0].ToString();

                    //lbltotllftmem.Text = l.ToString();
                }
                else
                {
                    count1 = "0";
                    //lbltotllftmem.Text = l.ToString();
                }
            }

            dr.Close();

        }
        else
        {
            conn.Open();
            cmd = new SqlCommand("select ParentChild_id from tbl_UserHierarchy where MemberId='" + parent11 + "'", conn);
            dr = cmd.ExecuteReader();
            dr.Read();
            string prt_chld = dr["ParentChild_id"].ToString();
            dr.Close();
            cmd = new SqlCommand("select RChildId from tbl_UserHierarchy where MemberId='" + parent11 + "'", conn);
            dr = cmd.ExecuteReader();
            dr.Read();
            string Right1 = prt_chld + "." + dr["RChildId"].ToString() + ".%";
            dr.Close();
            cmd = new SqlCommand("select count (UserID) from tbl_UserHierarchy where ParentChild_id like '" + Right1 + "'and clr='Green'", conn);

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (dr[0].ToString() != "0")
                {
                    count1 = dr[0].ToString();

                    //lbltotllftmem.Text = l.ToString();
                }
                else
                {
                    count1 = "0";
                    //lbltotllftmem.Text = l.ToString();
                }
            }

            dr.Close();


        }
      
        return count1;
    }
    public int countPair(string user)
    {
        string lc = countLeftChild(user);
        string rc = countRightChild(user);
        int lcc = int.Parse(lc);
        int rcc = int.Parse(rc);
        int cp = 0;
        if (lcc > rcc)
        {
            cp = rcc;
        }
        else if (rcc > lcc)
        {
            cp = lcc;
        }
        else if(lcc==rcc)
        {
            cp = rcc;
        }
       // int cp = (lcc + rcc) / 2;
        return cp;

    }
    public string FindParent(string user)
    {

        string parent = "";

        if (conn.State == ConnectionState.Open)
        {
            cmd = new SqlCommand("select UserID from tbl_UserHierarchy where MemberId='" + user + "'", conn);
            ds = new DataSet();
            ds.Clear();
            adp = new SqlDataAdapter(cmd);
            adp.Fill(ds, "ch1");
            if (ds.Tables["ch1"].Rows.Count > 0)
            {
                parent = ds.Tables["ch1"].Rows[0]["UserID"].ToString();
            }
            else
            {
                parent = "No Id Found";
            }
            conn.Close();
            return parent;
        }
        else
        {
            conn.Open();
            cmd = new SqlCommand("select UserID from tbl_UserHierarchy where MemberId='" + user + "'", conn);
            ds = new DataSet();
            ds.Clear();
            adp = new SqlDataAdapter(cmd);
            adp.Fill(ds, "ch1");
            if (ds.Tables["ch1"].Rows.Count > 0)
            {
                parent = ds.Tables["ch1"].Rows[0]["UserID"].ToString();
            }
            else
            {
                parent = "No Id Found";
            }
            conn.Close();
            return parent;

        }

    }


    public void FillRefferel(string id)
    {
        int cpp = countDirectChild(id); //countDirectPair(id);
        string dd = "";
        conn.Open();
        if (cpp > 0)
        {


            if (conn.State == ConnectionState.Open)
            {
                if (cpp > 0 && cpp < 2)
                {
                    cmd = new SqlCommand("select Refferel_Income from tbl_Refferel where Member_id='" + id + "'", conn);
                    ds = new DataSet();
                    ds.Clear();
                    adp = new SqlDataAdapter(cmd);
                    adp.Fill(ds, "ch1");
                    if (ds.Tables["ch1"].Rows.Count == 0)
                    {
                        decimal amt = 2500;
                        //string pc = FindParent(id);
                        decimal td = 2500 * 10 / 100;
                            decimal st=2500*5/100;
                            decimal na = amt - td - st;
                        cmd = new SqlCommand("insert into tbl_Refferel (Member_id,Total_child,Refferel_Income,Income_Date,Status)values('" + id + "','1','" + amt + "','" + System.DateTime.Today.ToShortDateString() + "','Unpaid')", conn);
                        cmd.ExecuteNonQuery();
                        cmd = new SqlCommand("insert into tbl_Accountdetails(Member_Id,Date,Income_Type,Credit_Amount,Debit_Amount,Prize,Status,Remark,TDS,Service_Tax,Net_Amount)values('" + id + "','" + System.DateTime.Today.ToShortDateString() + "','Direct','2500','0','Null','Unpaid','Null','"+td+"','"+st+"','"+na+"')", conn);
                        cmd.ExecuteNonQuery();

                    }
                    else
                    {
                        dd = "Already Get Refferel Income";
                    }
                }
                else if (cpp >= 2)
                {
                    cmd = new SqlCommand("select Refferel_Income from tbl_Refferel where Member_id='" + id + "'", conn);
                    ds = new DataSet();
                    ds.Clear();
                    adp = new SqlDataAdapter(cmd);
                    adp.Fill(ds, "ch1");
                    if (ds.Tables["ch1"].Rows.Count == 0)
                    {
                        decimal amt = 5000;
                        decimal td = 5000 * 10 / 100;
                        decimal st = 5000 * 5 / 100;
                        decimal na = amt - td - st;
                        //string pc = FindParent(id);
                        cmd = new SqlCommand("insert into tbl_Refferel (Member_id,Total_child,Refferel_Income,Income_Date,Status)values('" + id + "','2','" + amt + "','" + System.DateTime.Today.ToShortDateString() + "','Unpaid')", conn);
                        cmd.ExecuteNonQuery();
                        cmd = new SqlCommand("insert into tbl_Accountdetails(Member_Id,Date,Income_Type,Credit_Amount,Debit_Amount,Prize,Status,Remark,TDS,Service_Tax,Net_Amount)values('" + id + "','" + System.DateTime.Today.ToShortDateString() + "','Direct','5000','0','Null','Unpaid','Null','" + td + "','" + st + "','" + na + "')", conn);
                        cmd.ExecuteNonQuery();

                    }
                    else if (ds.Tables["ch1"].Rows.Count > 0 && ds.Tables["ch1"].Rows.Count<=1)
                    {
                        decimal amt1 = 2500;
                        decimal td = 2500 * 10 / 100;
                        decimal st = 2500 * 5 / 100;
                        decimal na = amt1 - td - st;
                        //string pc = FindParent(id);
                        cmd = new SqlCommand("insert into tbl_Refferel (Member_id,Total_child,Refferel_Income,Income_Date,Status)values('" + id + "','1','" + amt1 + "','" + System.DateTime.Today.ToShortDateString() + "','Unpaid')", conn);
                        cmd.ExecuteNonQuery();
                        cmd = new SqlCommand("insert into tbl_Accountdetails(Member_Id,Date,Income_Type,Credit_Amount,Debit_Amount,Prize,Status,Remark,TDS,Service_Tax,Net_Amount)values('" + id + "','" + System.DateTime.Today.ToShortDateString() + "','Direct','2500','0','Null','Unpaid','Null','" + td + "','" + st + "','" + na + "')", conn);
                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    dd = "Already Get Refferel Income";
                }

            }
            else
            {
                conn.Open();
                if (cpp > 0 && cpp < 2)
                {
                    cmd = new SqlCommand("select Refferel_Income from tbl_Refferel where Member_id='" + id + "'", conn);
                    ds = new DataSet();
                    ds.Clear();
                    adp = new SqlDataAdapter(cmd);
                    adp.Fill(ds, "ch1");
                    if (ds.Tables["ch1"].Rows.Count == 0)
                    {
                        decimal amt = 2500;
                        //string pc = FindParent(id);
                        decimal td = 2500 * 10 / 100;
                        decimal st = 2500 * 5 / 100;
                        decimal na = amt - td - st;
                        cmd = new SqlCommand("insert into tbl_Refferel (Member_id,Total_child,Refferel_Income,Income_Date,Status)values('" + id + "','1','" + amt + "','" + System.DateTime.Today.ToShortDateString() + "','Unpaid')", conn);
                        cmd.ExecuteNonQuery();
                        cmd = new SqlCommand("insert into tbl_Accountdetails(Member_Id,Date,Income_Type,Credit_Amount,Debit_Amount,Prize,Status,Remark,TDS,Service_Tax,Net_Amount)values('" + id + "','" + System.DateTime.Today.ToShortDateString() + "','Direct','2500','0','Null','Unpaid','Null','" + td + "','" + st + "','" + na + "')", conn);
                        cmd.ExecuteNonQuery();

                    }
                    else
                    {
                        dd = "Already Get Refferel Income";
                    }
                }
                else if (cpp >= 2)
                {
                    cmd = new SqlCommand("select Refferel_Income from tbl_Refferel where Member_id='" + id + "'", conn);
                    ds = new DataSet();
                    ds.Clear();
                    adp = new SqlDataAdapter(cmd);
                    adp.Fill(ds, "ch1");
                    if (ds.Tables["ch1"].Rows.Count == 0)
                    {
                        decimal amt = 5000;
                        //string pc = FindParent(id);
                        decimal td = 5000 * 10 / 100;
                        decimal st = 5000 * 5 / 100;
                        decimal na = amt - td - st;
                        cmd = new SqlCommand("insert into tbl_Refferel (Member_id,Total_child,Refferel_Income,Income_Date,Status)values('" + id + "','1','" + amt + "','" + System.DateTime.Today.ToShortDateString() + "','Unpaid')", conn);
                        cmd.ExecuteNonQuery();
                        cmd = new SqlCommand("insert into tbl_Accountdetails(Member_Id,Date,Income_Type,Credit_Amount,Debit_Amount,Prize,Status,Remark,TDS,Service_Tax,Net_Amount)values('" + id + "','" + System.DateTime.Today.ToShortDateString() + "','Direct','5000','0','Null','Unpaid','Null','" + td + "','" + st + "','" + na + "')", conn);
                        cmd.ExecuteNonQuery();

                    }
                    else if (ds.Tables["ch1"].Rows.Count > 0 && ds.Tables["ch1"].Rows.Count <= 1)
                    {
                        decimal amt = 2500;
                        //string pc = FindParent(id);
                        decimal td = 2500 * 10 / 100;
                        decimal st = 2500 * 5 / 100;
                        decimal na = amt - td - st;
                        cmd = new SqlCommand("insert into tbl_Refferel (Member_id,Total_child,Refferel_Income,Income_Date,Status)values('" + id + "','1','" + amt + "','" + System.DateTime.Today.ToShortDateString() + "','Unpaid')", conn);
                        cmd.ExecuteNonQuery();
                        cmd = new SqlCommand("insert into tbl_Accountdetails(Member_Id,Date,Income_Type,Credit_Amount,Debit_Amount,Prize,Status,Remark,TDS,Service_Tax,Net_Amount)values('" + id + "','" + System.DateTime.Today.ToShortDateString() + "','Direct','2500','0','Null','Unpaid','Null','" + td + "','" + st + "','" + na + "')", conn);
                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    dd = "Already Get Refferel Income";
                }
                conn.Close();

            }
        }
    }


    public void FillSpilOver(string member)
    {
        string sp = "";
        decimal amt = 0;
        string tc = "";
        int dccc = 0;
        int kk = 0;
        string dgf = "";
        sp = FindParent(member);


        if (conn.State == ConnectionState.Open)
        {
            cmd = new SqlCommand("select MemberId from tbl_UserHierarchy where ParentID=" + sp + " and (MemberId <>'')and (clr ='Green')", conn);
            ds = new DataSet();
            ds.Clear();
            adp = new SqlDataAdapter(cmd);
            adp.Fill(ds, "ch1");
            int dfg = ds.Tables["ch1"].Rows.Count;
         
            if (dfg > 2)
            {
                dccc = Convert.ToInt32(ds.Tables["ch1"].Rows.Count.ToString());
               
                cmd1 = new SqlCommand("select sum(Total_child) from tbl_spilover where Member_id='" + member + "'", conn);
                ds1 = new DataSet();
                ds1.Clear();
                adp1 = new SqlDataAdapter(cmd1);
                adp1.Fill(ds1, "ch11");
                dgf = ds1.Tables["ch11"].Rows[0][0].ToString();
                if (dgf == "")
                {

                    kk = dccc - 2;
                    amt = kk * 2500;
                    decimal td1 = amt * 10 / 100;
                    decimal st1 = amt * 5 / 100;
                    decimal na1 = amt - td1 - st1;

                    cmd1 = new SqlCommand("insert into tbl_spilover(Member_id,Total_child,Total_Income,Income_Date,Status)values('" + member + "','" + kk + "','" + amt + "','" + System.DateTime.Today.ToShortDateString() + "','Unpaid')", conn);
                    cmd1.ExecuteNonQuery();
                    cmd1 = new SqlCommand("insert into tbl_Accountdetails(Member_Id,Date,Income_Type,Credit_Amount,Debit_Amount,Prize,Status,Remark,TDS,Service_Tax,Net_Amount)values('" + member + "','" + System.DateTime.Today.ToShortDateString() + "','Direct','" + amt + "','0','Null','Unpaid','Null','" + td1 + "','" + st1 + "','" + na1 + "')", conn);
                    cmd1.ExecuteNonQuery();

                }
                else
                {

                    dccc = Convert.ToInt32(ds.Tables["ch1"].Rows.Count.ToString());
                    int lk = dccc - 2;
                    tc = ds1.Tables["ch11"].Rows[0][0].ToString();
                    if (lk == Convert.ToInt32(tc))
                    {
                        string bh = "do Nothing";
                    }
                    else
                    {
                        kk = lk - Convert.ToInt32(tc);
                        amt = 2500 * kk;
                        decimal td1 = amt * 10 / 100;
                        decimal st1 = amt * 5 / 100;
                        decimal na1 = amt - td1 - st1;

                        cmd1 = new SqlCommand("insert into tbl_spilover(Member_id,Total_child,Total_Income,Income_Date,Status)values('" + member + "','" + kk + "','" + amt + "','" + System.DateTime.Today.ToShortDateString() + "','Unpaid')", conn);
                        cmd1.ExecuteNonQuery();
                        cmd1 = new SqlCommand("insert into tbl_Accountdetails(Member_Id,Date,Income_Type,Credit_Amount,Debit_Amount,Prize,Status,Remark,TDS,Service_Tax,Net_Amount)values('" + member + "','" + System.DateTime.Today.ToShortDateString() + "','Direct','" + amt + "','0','Null','Unpaid','Null','" + td1 + "','" + st1 + "','" + na1 + "')", conn);
                        cmd1.ExecuteNonQuery();
                    }
                }

            }
            else
            {
                string dd = "No SpillOver Income Income";
            }
            conn.Close();
        }
        else
        {
            conn.Open();
            cmd = new SqlCommand("select MemberId from tbl_UserHierarchy where ParentID=" + sp + " and (MemberId <>'')and (clr ='Green')", conn);
            ds = new DataSet();
            ds.Clear();
            adp = new SqlDataAdapter(cmd);
            adp.Fill(ds, "ch1");
            int gh = ds.Tables["ch1"].Rows.Count;
      
            if (gh > 2)
            {
                dccc = Convert.ToInt32(ds.Tables["ch1"].Rows.Count.ToString());
           
                cmd1 = new SqlCommand("select sum(Total_child) from tbl_spilover where Member_id='" + member + "'", conn);
                ds1 = new DataSet();
                ds1.Clear();
                adp1 = new SqlDataAdapter(cmd1);
                adp1.Fill(ds1, "ch11");
                dgf = ds1.Tables["ch11"].Rows[0][0].ToString();
                if (dgf == "")
                {
                    kk = dccc - 2;
                    amt = kk * 2500;

                    decimal td1 = amt * 10 / 100;
                    decimal st1 = amt * 5 / 100;
                    decimal na1 = amt - td1 - st1;

                    cmd1 = new SqlCommand("insert into tbl_spilover(Member_id,Total_child,Total_Income,Income_Date,Status)values('" + member + "','" + kk + "','" + amt + "','" + System.DateTime.Today.ToShortDateString() + "','Unpaid')", conn);
                    cmd1.ExecuteNonQuery();
                    cmd1 = new SqlCommand("insert into tbl_Accountdetails(Member_Id,Date,Income_Type,Credit_Amount,Debit_Amount,Prize,Status,Remark,TDS,Service_Tax,Net_Amount)values('" + member + "','" + System.DateTime.Today.ToShortDateString() + "','Direct','" + amt + "','0','Null','Unpaid','Null','" + td1 + "','" + st1 + "','" + na1 + "')", conn);
                    cmd1.ExecuteNonQuery();
                }
                else
                {

                    dccc = Convert.ToInt32(ds.Tables["ch1"].Rows.Count.ToString());
                    int lk = dccc - 2;
                    tc = ds1.Tables["ch11"].Rows[0][0].ToString();
                    if (lk == Convert.ToInt32(tc))
                    {
                        string bh = "do Nothing";
                    }
                    else
                    {
                        kk = lk - Convert.ToInt32(tc);
                        amt = 2500 * kk;
                        decimal td1 = amt * 10 / 100;
                        decimal st1 = amt * 5 / 100;
                        decimal na1 = amt - td1 - st1;

                        cmd1 = new SqlCommand("insert into tbl_spilover(Member_id,Total_child,Total_Income,Income_Date,Status)values('" + member + "','" + kk + "','" + amt + "','" + System.DateTime.Today.ToShortDateString() + "','Unpaid')", conn);
                        cmd1.ExecuteNonQuery();
                        cmd1 = new SqlCommand("insert into tbl_Accountdetails(Member_Id,Date,Income_Type,Credit_Amount,Debit_Amount,Prize,Status,Remark,TDS,Service_Tax,Net_Amount)values('" + member + "','" + System.DateTime.Today.ToShortDateString() + "','Direct','" + amt + "','0','Null','Unpaid','Null','" + td1 + "','" + st1 + "','" + na1 + "')", conn);
                        cmd1.ExecuteNonQuery();
                    }
                }

            }
            else
            {
                string dd = "No SpillOver Income Income";
            }
            conn.Close();
        }

    }

    public void CreateBlackPin(string Member)
    {
        try
        {
            string count1 = "";
            string a2 = "";
            string uid = "";
            string pcid = "";
            if (conn.State == ConnectionState.Open)
            {
                cmd = new SqlCommand("select * from tbl_UserHierarchy where MemberId='" + Member + "'", conn);
                ds = new DataSet();
                ds.Clear();
                adp = new SqlDataAdapter(cmd);
                adp.Fill(ds, "ch1");
                if (ds.Tables["ch1"].Rows.Count > 0)
                {

                    uid = ds.Tables["ch1"].Rows[0]["UserID"].ToString();
                    pcid = ds.Tables["ch1"].Rows[0]["Parentchild_id"].ToString();
                    string sts = "Right";
                    for (int i = 0; i < 2; i++)
                    {
                    vijay:
                        Random rnd1 = new Random();
                        a2 = rnd1.Next(10000000, 99999999).ToString();
                        cmd = new SqlCommand("select Pin_Number from tbl_BlackPin where Pin_number='" + a2 + "'", conn);
                        ds = new DataSet();
                        ds.Clear();
                        adp = new SqlDataAdapter(cmd);
                        adp.Fill(ds, "vj");
                        if (ds.Tables["vj"].Rows.Count == 0)
                        {
                        vj:
                            string pass = RandomNumberGenerator(8);
                            cmd = new SqlCommand("select Password from tbl_BlackPin where Password='" + pass + "'", conn);
                            ds = new DataSet();
                            ds.Clear();
                            adp = new SqlDataAdapter(cmd);
                            adp.Fill(ds, "vj");
                            if (ds.Tables["vj"].Rows.Count == 0)
                            {

                                if (sts == "Right")
                                {
                                    cmd = new SqlCommand("insert into tbl_BlackPin(Pin_number,Password,Associated_Member,Status,Creation_Date)values('" + a2 + "','" + pass + "','" + Member + "','Right','" + System.DateTime.Today.ToShortDateString() + "')", conn);
                                    cmd.ExecuteNonQuery();
                                    cmd = new SqlCommand("select * from tbl_BlackPin where Pin_number='" + a2 + "'", conn);
                                    ds = new DataSet();
                                    ds.Clear();
                                    adp = new SqlDataAdapter(cmd);
                                    adp.Fill(ds, "vj");
                                    if (ds.Tables["vj"].Rows.Count > 0)
                                    {
                                        string uid1 = ds.Tables["vj"].Rows[0]["id"].ToString();
                                        string pd = pcid + "." + uid1;

                                        cmd = new SqlCommand("insert into tbl_UserHierarchy(UserID,ParentID,MemberId,Parentchild_id,logn_sts,clr)values(" + uid1 + "," + uid + ",'" + a2 + "','" + pd + "','Active','Black')", conn);
                                        cmd.ExecuteNonQuery();

                                        cmd = new SqlCommand("update tbl_UserHierarchy set RChildId=" + uid1 + " where UserID='" + uid + "'", conn);
                                        cmd.ExecuteNonQuery();

                                    }



                                    sts = "Left";
                                }
                                else
                                {
                                    cmd = new SqlCommand("insert into tbl_BlackPin(Pin_number,Password,Associated_Member,Status,Creation_Date)values('" + a2 + "','" + pass + "','" + Member + "','Left','" + System.DateTime.Today.ToShortDateString() + "')", conn);
                                    cmd.ExecuteNonQuery();

                                    cmd = new SqlCommand("select * from tbl_BlackPin where Pin_number='" + a2 + "'", conn);
                                    ds = new DataSet();
                                    ds.Clear();
                                    adp = new SqlDataAdapter(cmd);
                                    adp.Fill(ds, "vj");
                                    if (ds.Tables["vj"].Rows.Count > 0)
                                    {
                                        string uid1 = ds.Tables["vj"].Rows[0]["id"].ToString();
                                        string pd = pcid + "." + uid1;

                                        cmd = new SqlCommand("insert into tbl_UserHierarchy(UserID,ParentID,MemberId,Parentchild_id,logn_sts,clr)values(" + uid1 + "," + uid + ",'" + a2 + "','" + pd + "','Active','Black')", conn);
                                        cmd.ExecuteNonQuery();

                                        cmd = new SqlCommand("update tbl_UserHierarchy set LChildId=" + uid1 + " where UserID='" + uid + "'", conn);
                                        cmd.ExecuteNonQuery();

                                    }
                                    sts = "Right";
                                }
                            }

                            else
                            {
                                goto vj;
                            }

                        }
                        else
                        {
                            goto vijay;
                        }
                    }
                }
                else
                {
                    string dd = "Member Already Exists";
                }
                conn.Close();
            }

            else
            {
                conn.Open();
                cmd = new SqlCommand("select * from tbl_UserHierarchy where MemberId='" + Member + "'", conn);
                ds = new DataSet();
                ds.Clear();
                adp = new SqlDataAdapter(cmd);
                adp.Fill(ds, "ch1");
                if (ds.Tables["ch1"].Rows.Count > 0)
                {

                    uid = ds.Tables["ch1"].Rows[0]["UserID"].ToString();
                    pcid = ds.Tables["ch1"].Rows[0]["Parentchild_id"].ToString();

                    string sts = "Right";
                    for (int i = 0; i < 2; i++)
                    {
                    vijay:
                        Random rnd1 = new Random();
                        a2 = rnd1.Next(10000000, 99999999).ToString();
                        cmd = new SqlCommand("select Pin_Number from tbl_BlackPin where Pin_number='" + a2 + "'", conn);
                        ds = new DataSet();
                        ds.Clear();
                        adp = new SqlDataAdapter(cmd);
                        adp.Fill(ds, "vj");
                        if (ds.Tables["vj"].Rows.Count == 0)
                        {
                        vj:
                            string pass = RandomNumberGenerator(8);
                            cmd = new SqlCommand("select Password from tbl_BlackPin where Password='" + pass + "'", conn);
                            ds = new DataSet();
                            ds.Clear();
                            adp = new SqlDataAdapter(cmd);
                            adp.Fill(ds, "vj");
                            if (ds.Tables["vj"].Rows.Count == 0)
                            {
                                if (sts == "Right")
                                {
                                    cmd = new SqlCommand("insert into tbl_BlackPin(Pin_number,Password,Associated_Member,Status,Creation_Date)values('" + a2 + "','" + pass + "','" + Member + "','Right','" + System.DateTime.Today.ToShortDateString() + "')", conn);
                                    cmd.ExecuteNonQuery();
                                    cmd = new SqlCommand("select * from tbl_BlackPin where Pin_number='" + a2 + "'", conn);
                                    ds = new DataSet();
                                    ds.Clear();
                                    adp = new SqlDataAdapter(cmd);
                                    adp.Fill(ds, "vj");
                                    if (ds.Tables["vj"].Rows.Count > 0)
                                    {
                                        string uid1 = ds.Tables["vj"].Rows[0]["id"].ToString();
                                        string pd = pcid + "." + uid1;

                                        cmd = new SqlCommand("insert into tbl_UserHierarchy (UserID,ParentID,MemberId,Parentchild_id,logn_sts,clr)values(" + uid1 + "," + uid + ",'" + a2 + "','" + pd + "','Active','Black')", conn);
                                        cmd.ExecuteNonQuery();

                                        cmd = new SqlCommand("update tbl_UserHierarchy set RChildId=" + uid1 + " where UserID='" + uid + "'", conn);
                                        cmd.ExecuteNonQuery();

                                    }



                                    sts = "Left";
                                }
                                else
                                {
                                    cmd = new SqlCommand("insert into tbl_BlackPin(Pin_number,Password,Associated_Member,Status,Creation_Date)values('" + a2 + "','" + pass + "','" + Member + "','Left','" + System.DateTime.Today.ToShortDateString() + "')", conn);
                                    cmd.ExecuteNonQuery();

                                    cmd = new SqlCommand("select * from tbl_BlackPin where Pin_number='" + a2 + "'", conn);
                                    ds = new DataSet();
                                    ds.Clear();
                                    adp = new SqlDataAdapter(cmd);
                                    adp.Fill(ds, "vj");
                                    if (ds.Tables["vj"].Rows.Count > 0)
                                    {
                                        string uid1 = ds.Tables["vj"].Rows[0]["id"].ToString();
                                        string pd = pcid + "." + uid1;

                                        cmd = new SqlCommand("insert into tbl_UserHierarchy(UserID,ParentID,MemberId,Parentchild_id,logn_sts,clr)values(" + uid1 + "," + uid + ",'" + a2 + "','" + pd + "','Active','Black')", conn);
                                        cmd.ExecuteNonQuery();

                                        cmd = new SqlCommand("update tbl_UserHierarchy set LChildId=" + uid1 + " where UserID='" + uid + "'", conn);
                                        cmd.ExecuteNonQuery();

                                    }
                                    sts = "Right";
                                }
                            }

                            else
                            {
                                goto vj;
                            }

                        }
                        else
                        {
                            goto vijay;
                        }
                    }
                }
                else
                {
                    string dd = "No Member Found";
                }
                conn.Close();
            }
        }
        catch (Exception ex)
        {
            string rt = ex.Message;
        }
    }

    private static string RandomNumberGenerator(int length)
    {
        System.Security.Cryptography.RandomNumberGenerator rng = System.Security.Cryptography.RandomNumberGenerator.Create();

        char[] chars = new char[length];

        //based on your requirment you can take only alphabets or number 
        string validChars = "abcdefghijklmnopqrstuvwxyzABCEDFGHIJKLMNOPQRSTUVWXYZ1234567890";

        for (int i = 0; i < length; i++)
        {
            byte[] bytes = new byte[1];
            rng.GetBytes(bytes);

            Random rnd = new Random(bytes[0]);

            chars[i] = validChars[rnd.Next(0, 61)];
        }

        return (new string(chars));
    }

    public string FindColor(string Pin)
    {

        string color = "";
        if (conn.State == ConnectionState.Open)
        {
            cmd = new SqlCommand("select pin_color from var_code where code=@pin and sts='Inactive'", conn);
            cmd.Parameters.Add(new SqlParameter("@pin", SqlDbType.NVarChar));
            cmd.Parameters["@pin"].Value = Pin;
            ds = new DataSet();
            ds.Clear();
            adp = new SqlDataAdapter(cmd);
            adp.Fill(ds, "ch1");
            if (ds.Tables["ch1"].Rows.Count > 0)
            {
                color = ds.Tables["ch1"].Rows[0]["pin_color"].ToString();

            }
            else
            {
                color = "No Color";
            }

        }
        else
        {
            conn.Open();
            cmd = new SqlCommand("select pin_color from var_code where code=@pin and sts='Inactive'", conn);
            cmd.Parameters.Add(new SqlParameter("@pin", SqlDbType.NVarChar));
            cmd.Parameters["@pin"].Value = Pin;
            ds = new DataSet();
            ds.Clear();
            adp = new SqlDataAdapter(cmd);
            adp.Fill(ds, "ch1");
            if (ds.Tables["ch1"].Rows.Count > 0)
            {
                color = ds.Tables["ch1"].Rows[0]["pin_color"].ToString();

            }
            else
            {
                color = "No Color";
            }
            conn.Close();
        }
        return color;
    }


    public bool FindSponser(string sponser)
    {

        string color = "";
        if (conn.State == ConnectionState.Open)
        {
            cmd = new SqlCommand("select usr_id from cust_data where usr_id=@spn", conn);
            cmd.Parameters.Add(new SqlParameter("@spn", SqlDbType.NVarChar));
            cmd.Parameters["@spn"].Value = sponser;
            ds = new DataSet();
            ds.Clear();
            adp = new SqlDataAdapter(cmd);
            adp.Fill(ds, "ch1");
            if (ds.Tables["ch1"].Rows.Count > 0)
            {
                return true;

            }
            else
            {
                return false;
            }

        }
        else
        {
            conn.Open();

            cmd = new SqlCommand("select usr_id from cust_data where usr_id=@spn", conn);
            cmd.Parameters.Add(new SqlParameter("@spn", SqlDbType.NVarChar));
            cmd.Parameters["@spn"].Value = sponser;
            ds = new DataSet();
            ds.Clear();
            adp = new SqlDataAdapter(cmd);
            adp.Fill(ds, "ch1");
            if (ds.Tables["ch1"].Rows.Count > 0)
            {
                return true;

            }
            else
            {
                return false;
            }

            conn.Close();
        }
    }

    public int GetNewParentIdforLeft(int ParentID, SqlConnection con)
    {
        cmd = new SqlCommand("select UserID,LChildID from tbl_UserHierarchy where UserID=" + ParentID + "", con);

        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        adp.Fill(dt);
        if (dt != null && dt.Rows.Count > 0 && dt.Rows[0]["LChildID"] != DBNull.Value)
        {
            return GetNewParentIdforLeft(Convert.ToInt32(dt.Rows[0]["LChildID"]), con);
        }
        else
        {
            return Convert.ToInt32(dt.Rows[0]["UserID"]);
        }
    }

    public int GetNewParentIdforRight(int ParentID, SqlConnection con)
    {
        cmd = new SqlCommand("select UserID,RChildID from tbl_UserHierarchy where UserID=" + ParentID + "", con);

        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        adp.Fill(dt);
        if (dt != null && dt.Rows.Count > 0 && dt.Rows[0]["RChildID"] != DBNull.Value)
        {
            return GetNewParentIdforRight(Convert.ToInt32(dt.Rows[0]["RChildID"]), con);
        }
        else
        {
            return Convert.ToInt32(dt.Rows[0]["UserID"]);
        }
    }

    public string[] countpairing(int left, int Right)
    {
        //cn.Open();
        //SqlTransaction trans = cn.BeginTransaction();
        //int NewParentID = GetNewParentId(Convert.ToInt32(idd), cn, trans);

        //int NewParentID2 = GetNewParentId2(Convert.ToInt32(idd), cn, trans);
        //trans.Commit();
        string[] result = new string[2];
        int p;
        int j;
        int pair = 0;
        if (conn.State == ConnectionState.Open)
        {

            if (left == Right)
            {
                p = left + Right;
                pair = p / 2;
                j = pair * 2500;
                //lblpair.Text = pair.ToString();
                //lblamount.Text = j.ToString();
                result[0] = pair.ToString();
                result[1] = j.ToString();
            }
            else
            {
                if (Right > left)
                {
                    j = left * 2500;
                    result[0] = left.ToString();
                    result[1] = j.ToString();
                }
                else if (left > Right)
                {
                    j = Right * 2500;
                    result[0] = Right.ToString();
                    result[1] = j.ToString();
                }
            }
        }
        else
        {
            conn.Open();
            if (left == Right)
            {
                p = left + Right;
                pair = p / 2;
                j = pair * 2500;
                //lblpair.Text = pair.ToString();
                //lblamount.Text = j.ToString();
                result[0] = pair.ToString();
                result[1] = j.ToString();
            }
            else
            {
                if (Right > left)
                {
                    j = left * 2500;
                    result[0] = left.ToString();
                    result[1] = j.ToString();
                }
                else if (left > Right)
                {
                    j = Right * 2500;
                    result[0] = Right.ToString();
                    result[1] = j.ToString();
                }
            }
            conn.Close();

        }
        //lblleft.Text = left.ToString();
        //lblrgt.Text = Right.ToString();
        return result;

    }

    public void fillReward(string Member, int left, int right)
    {

        string[] showpair = new string[2];
        showpair = countpairing(left, right);
        int pp = Convert.ToInt32(showpair[0].ToString());
        if (conn.State == ConnectionState.Open)
        {
            if (pp >= 10)
            {
                cmd = new SqlCommand("select top 1 (Reward),Month(date),count from rewards_count where Reward='10 Pair' and Member_id='" + Member + "' order by date desc", conn);
                ds.Clear();
                adp = new SqlDataAdapter(cmd);
                adp.Fill(ds, "rj1");
                if (ds.Tables["rj1"].Rows.Count > 0)
                {
                    string m1 = ds.Tables["rj1"].Rows[0][1].ToString();

                    string m2 = System.DateTime.Now.Month.ToString();

                    string count = ds.Tables["rj1"].Rows[0]["count"].ToString();
                    if (count == "12")
                    {
                        string dfg = "All Income Gives";
                    }
                    else
                    {
                        if (m1 != m2)
                        {
                            
                            string newcount = (Convert.ToInt32(count) + 1).ToString();
                            decimal amt2 = 1000;
                            decimal td2 = amt2 * 10 / 100;
                            decimal st2 = amt2 * 5 / 100;
                            decimal na2 = amt2 - td2 - st2;
                            cmd = new SqlCommand("insert into rewards_count(Member_id,Reward,Date,Pairs,count,Reward_Amount,Status)values('" + Member + "','10 Pair','" + System.DateTime.Now.ToShortDateString() + "','" + pp + "','" + newcount + "','1000','Unpaid')", conn);
                            cmd.ExecuteNonQuery();
                            cmd = new SqlCommand("insert into tbl_Accountdetails(Member_Id,Date,Income_Type,Credit_Amount,Debit_Amount,Prize,Status,Remark,TDS,Service_Tax,Net_Amount)values('" + Member + "','" + System.DateTime.Today.ToShortDateString() + "','Reward','" + amt2 + "','0','Null','Unpaid','Null','" + td2 + "','" + st2 + "','" + na2 + "')", conn);
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            string resl = "No Income Generate";
                        }
                    }
                }
                else
                {
                    decimal amt2 = 1000;
                    decimal td2 = amt2 * 10 / 100;
                    decimal st2 = amt2 * 5 / 100;
                    decimal na2 = amt2 - td2 - st2;
                    cmd = new SqlCommand("insert into rewards_count(Member_id,Reward,Date,Pairs,count,Reward_Amount,Status)values('" + Member + "','10 Pair','" + System.DateTime.Now.ToShortDateString() + "','" + pp + "','1','1000','Unpaid')", conn);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("insert into tbl_Accountdetails(Member_Id,Date,Income_Type,Credit_Amount,Debit_Amount,Prize,Status,Remark,TDS,Service_Tax,Net_Amount)values('" + Member + "','" + System.DateTime.Today.ToShortDateString() + "','Reward','" + amt2 + "','0','Null','Unpaid','Null','" + td2 + "','" + st2 + "','" + na2 + "')", conn);
                    cmd.ExecuteNonQuery();
                }
            }
            if (pp >= 40)
            {
                cmd = new SqlCommand("select top 1 (Reward),Month(date),count from rewards_count where Reward='30 Pair' and Member_id='" + Member + "'order by date desc", conn);
                ds.Clear();
                adp = new SqlDataAdapter(cmd);
                adp.Fill(ds, "rj1");
                if (ds.Tables["rj1"].Rows.Count > 0)
                {
                    string m1 = ds.Tables["rj1"].Rows[0][1].ToString();

                    string m2 = System.DateTime.Now.Month.ToString();

                    string count = ds.Tables["rj1"].Rows[0]["count"].ToString();
                    if (count == "12")
                    {
                        string dfg = "All Income Gives";
                    }
                    else
                    {
                        if (m1 != m2)
                        {
                            string newcount = (Convert.ToInt32(count) + 1).ToString();
                            decimal amt2 = 3000;
                            decimal td2 = amt2 * 10 / 100;
                            decimal st2 = amt2 * 5 / 100;
                            decimal na2 = amt2 - td2 - st2;
                            cmd = new SqlCommand("insert into rewards_count(Member_id,Reward,Date,Pairs,count,Reward_Amount,Status)values('" + Member + "','30 Pair','" + System.DateTime.Now.ToShortDateString() + "','" + pp + "','" + newcount + "','3000','Unpaid')", conn);
                            cmd.ExecuteNonQuery();
                            cmd = new SqlCommand("insert into tbl_Accountdetails(Member_Id,Date,Income_Type,Credit_Amount,Debit_Amount,Prize,Status,Remark,TDS,Service_Tax,Net_Amount)values('" + Member + "','" + System.DateTime.Today.ToShortDateString() + "','Reward','" + amt2 + "','0','Null','Unpaid','Null','" + td2 + "','" + st2 + "','" + na2 + "')", conn);
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            string resl = "No Income Generate";
                        }
                    }
                }
                else
                {
                    decimal amt2 = 3000;
                    decimal td2 = amt2 * 10 / 100;
                    decimal st2 = amt2 * 5 / 100;
                    decimal na2 = amt2 - td2 - st2;
                    cmd = new SqlCommand("insert into rewards_count(Member_id,Reward,Date,Pairs,count,Reward_Amount,Status)values('" + Member + "','30 Pair','" + System.DateTime.Now.ToShortDateString() + "','" + pp + "','1','3000','Unpaid')", conn);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("insert into tbl_Accountdetails(Member_Id,Date,Income_Type,Credit_Amount,Debit_Amount,Prize,Status,Remark,TDS,Service_Tax,Net_Amount)values('" + Member + "','" + System.DateTime.Today.ToShortDateString() + "','Reward','" + amt2 + "','0','Null','Unpaid','Null','" + td2 + "','" + st2 + "','" + na2 + "')", conn);
                    cmd.ExecuteNonQuery();

                }
            }
            else
            {
                string gh = "No Rewards Generated";
            }
        }
        else
        {
            conn.Open();
            if (pp >= 10)
            {
                cmd = new SqlCommand("select top 1 (Reward),Month(date),count from rewards_count where Reward='10 Pair' and Member_id='" + Member + "' order by date desc", conn);
                ds.Clear();
                adp = new SqlDataAdapter(cmd);
                adp.Fill(ds, "rj1");
                if (ds.Tables["rj1"].Rows.Count > 0)
                {
                    string m1 = ds.Tables["rj1"].Rows[0][1].ToString();

                    string m2 = System.DateTime.Now.Month.ToString();

                    string count = ds.Tables["rj1"].Rows[0]["count"].ToString();
                    if (count == "12")
                    {
                        string dfg = "All Income Gives";
                    }
                    else
                    {
                        if (m1 != m2)
                        {
                            string newcount = (Convert.ToInt32(count) + 1).ToString();
                            decimal amt2 = 1000;
                            decimal td2 = amt2 * 10 / 100;
                            decimal st2 = amt2 * 5 / 100;
                            decimal na2 = amt2 - td2 - st2;
                            cmd = new SqlCommand("insert into rewards_count(Member_id,Reward,Date,Pairs,count,Reward_Amount,Status)values('" + Member + "','10 Pair','" + System.DateTime.Now.ToShortDateString() + "','" + pp + "','" + newcount + "','1000','Unpaid')", conn);
                            cmd.ExecuteNonQuery();
                            cmd = new SqlCommand("insert into tbl_Accountdetails(Member_Id,Date,Income_Type,Credit_Amount,Debit_Amount,Prize,Status,Remark,TDS,Service_Tax,Net_Amount)values('" + Member + "','" + System.DateTime.Today.ToShortDateString() + "','Reward','" + amt2 + "','0','Null','Unpaid','Null','" + td2 + "','" + st2 + "','" + na2 + "')", conn);
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            string resl = "No Income Generate";
                        }
                    }
                }
                else
                {
                    decimal amt2 = 1000;
                    decimal td2 = amt2 * 10 / 100;
                    decimal st2 = amt2 * 5 / 100;
                    decimal na2 = amt2 - td2 - st2;
                    cmd = new SqlCommand("insert into rewards_count(Member_id,Reward,Date,Pairs,count,Reward_Amount,Status)values('" + Member + "','10 Pair','" + System.DateTime.Now.ToShortDateString() + "','" + pp + "','1','1000','Unpaid')", conn);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("insert into tbl_Accountdetails(Member_Id,Date,Income_Type,Credit_Amount,Debit_Amount,Prize,Status,Remark,TDS,Service_Tax,Net_Amount)values('" + Member + "','" + System.DateTime.Today.ToShortDateString() + "','Reward','" + amt2 + "','0','Null','Unpaid','Null','" + td2 + "','" + st2 + "','" + na2 + "')", conn);
                    cmd.ExecuteNonQuery();
                }
            }
            if (pp >= 40)
            {
                cmd = new SqlCommand("select top 1 (Reward),Month(date),count from rewards_count where Reward='30 Pair' and Member_id='" + Member + "' order by date desc", conn);
                ds.Clear();
                adp = new SqlDataAdapter(cmd);
                adp.Fill(ds, "rj1");
                if (ds.Tables["rj1"].Rows.Count > 0)
                {
                    string m1 = ds.Tables["rj1"].Rows[0][1].ToString();

                    string m2 = System.DateTime.Now.Month.ToString();

                    string count = ds.Tables["rj1"].Rows[0]["count"].ToString();
                    if (count == "12")
                    {
                        string dfg = "All Income Gives";
                    }
                    else
                    {
                        if (m1 != m2)
                        {
                            string newcount = (Convert.ToInt32(count) + 1).ToString();
                            decimal amt2 = 3000;
                            decimal td2 = amt2 * 10 / 100;
                            decimal st2 = amt2 * 5 / 100;
                            decimal na2 = amt2 - td2 - st2;
                            cmd = new SqlCommand("insert into rewards_count(Member_id,Reward,Date,Pairs,count,Reward_Amount,Status)values('" + Member + "','30 Pair','" + System.DateTime.Now.ToShortDateString() + "','" + pp + "','" + newcount + "','3000','Unpaid')", conn);
                            cmd.ExecuteNonQuery();
                            cmd = new SqlCommand("insert into tbl_Accountdetails(Member_Id,Date,Income_Type,Credit_Amount,Debit_Amount,Prize,Status,Remark,TDS,Service_Tax,Net_Amount)values('" + Member + "','" + System.DateTime.Today.ToShortDateString() + "','Reward','" + amt2 + "','0','Null','Unpaid','Null','" + td2 + "','" + st2 + "','" + na2 + "')", conn);
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            string resl = "No Income Generate";
                        }
                    }
                }
                else
                {
                    decimal amt2 = 3000;
                    decimal td2 = amt2 * 10 / 100;
                    decimal st2 = amt2 * 5 / 100;
                    decimal na2 = amt2 - td2 - st2;
                    cmd = new SqlCommand("insert into rewards_count(Member_id,Reward,Date,Pairs,count,Reward_Amount,Status)values('" + Member + "','30 Pair','" + System.DateTime.Now.ToShortDateString() + "','" + pp + "','1','3000','Unpaid')", conn);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("insert into tbl_Accountdetails(Member_Id,Date,Income_Type,Credit_Amount,Debit_Amount,Prize,Status,Remark,TDS,Service_Tax,Net_Amount)values('" + Member + "','" + System.DateTime.Today.ToShortDateString() + "','Reward','" + amt2 + "','0','Null','Unpaid','Null','" + td2 + "','" + st2 + "','" + na2 + "')", conn);
                    cmd.ExecuteNonQuery();

                }
            }
            else
            {
                string gh = "No Rewards Generated";
            }
            conn.Close();
        }

    }




    public void fillPrize(string Member, int left, int right)
    {

        string[] showpair = new string[2];
        showpair = countpairing(left, right);
        int pp = Convert.ToInt32(showpair[0].ToString());
        if (conn.State == ConnectionState.Open)
        {
            if (pp >= 4)
            {
                cmd = new SqlCommand("select top 1 (Prize),Month(Prize_date),count from tbl_prize where Prize='4 Pair' and Member_id='" + Member + "' order by Prize_date desc  ", conn);
                ds = new DataSet();
                ds.Clear();
                adp = new SqlDataAdapter(cmd);
                adp.Fill(ds, "rj1");
                if (ds.Tables["rj1"].Rows.Count == 0)
                {
                    decimal amt3 = 3000;
                    decimal td3 = amt3 * 10 / 100;
                    decimal st3 = amt3 * 5 / 100;
                    decimal na3 = amt3 - td3 - st3;
                    cmd = new SqlCommand("insert into tbl_prize(Member_id,Prize,Prize_date,Pair,count,Prize_Money,Status)values('" + Member + "','4 Pair','" + System.DateTime.Now.ToShortDateString() + "','" + pp + "','1','3000','Unpaid')", conn);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("insert into tbl_Accountdetails(Member_Id,Date,Income_Type,Credit_Amount,Debit_Amount,Prize,Status,Remark,TDS,Service_Tax,Net_Amount)values('" + Member + "','" + System.DateTime.Today.ToShortDateString() + "','Prize','" + amt3 + "','0','Null','Unpaid','Null','" + td3 + "','" + st3 + "','" + na3 + "')", conn);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    string dd = "No Money Generated";
                }
            }
            if (pp >= 20)
            {
                cmd = new SqlCommand("select top 1 (Prize),Month(Prize_date),count from tbl_prize where Prize='16 Pair' and Member_id='" + Member + "' order by Prize_date desc ", conn);
                ds = new DataSet();
                adp = new SqlDataAdapter(cmd);
                adp.Fill(ds, "rj1");
                if (ds.Tables["rj1"].Rows.Count == 0)
                {
                    decimal amt3 = 21000;
                    decimal td3 = amt3 * 10 / 100;
                    decimal st3 = amt3 * 5 / 100;
                    decimal na3 = amt3 - td3 - st3;
                    cmd = new SqlCommand("insert into tbl_prize(Member_id,Prize,Prize_date,Pair,count,Prize_Money,Status)values('" + Member + "','16 Pair','" + System.DateTime.Now.ToShortDateString() + "','" + pp + "','1','21000','Unpaid')", conn);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("insert into tbl_Accountdetails(Member_Id,Date,Income_Type,Credit_Amount,Debit_Amount,Prize,Status,Remark,TDS,Service_Tax,Net_Amount)values('" + Member + "','" + System.DateTime.Today.ToShortDateString() + "','Prize','" + amt3 + "','0','Null','Unpaid','Null','" + td3 + "','" + st3 + "','" + na3 + "')", conn);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    string dd = "No Money Generated";
                }


            }
            if (pp >= 60)
            {
                cmd = new SqlCommand("select top 1 (Prize),Month(Prize_date),count from tbl_prize where Prize='60 Pair' and Member_id='" + Member + "' order by Prize_date desc", conn);
                ds = new DataSet();
                adp = new SqlDataAdapter(cmd);
                adp.Fill(ds, "rj1");
                if (ds.Tables["rj1"].Rows.Count == 0)
                {
                    decimal amt3 = 0;
                    decimal td3 = 0;
                    decimal st3 = 0;
                    decimal na3 = 0;
                    cmd = new SqlCommand("insert into tbl_prize(Member_id,Prize,Prize_date,Pair,count,Prize_Money,Status)values('" + Member + "','60 Pair','" + System.DateTime.Now.ToShortDateString() + "','" + pp + "','1','Bike','Unpaid')", conn);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("insert into tbl_Accountdetails(Member_Id,Date,Income_Type,Credit_Amount,Debit_Amount,Prize,Status,Remark,TDS,Service_Tax,Net_Amount)values('" + Member + "','" + System.DateTime.Today.ToShortDateString() + "','Prize','" + amt3 + "','0','Bike','Unpaid','Null','" + td3 + "','" + st3 + "','" + na3 + "')", conn);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    string dd = "No Money Generated";
                }


            }
            if (pp >= 160)
            {
                cmd = new SqlCommand("select top 1 (Prize),Month(Prize_date),count from tbl_prize where Prize='100 Pair' and Member_id='" + Member + "'order by Prize_date desc", conn);
                ds = new DataSet();
                adp = new SqlDataAdapter(cmd);
                adp.Fill(ds, "rj1");
                if (ds.Tables["rj1"].Rows.Count == 0)
                {
                    decimal amt3 = 0;
                    decimal td3 = 0;
                    decimal st3 = 0;
                    decimal na3 = 0;
                    cmd = new SqlCommand("insert into tbl_prize(Member_id,Prize,Prize_date,Pair,count,Prize_Money,Status)values('" + Member + "','100 Pair','" + System.DateTime.Now.ToShortDateString() + "','" + pp + "','1','Alto Car','Unpaid')", conn);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("insert into tbl_Accountdetails(Member_Id,Date,Income_Type,Credit_Amount,Debit_Amount,Prize,Status,Remark,TDS,Service_Tax,Net_Amount)values('" + Member + "','" + System.DateTime.Today.ToShortDateString() + "','Prize','" + amt3 + "','0','Alto Car','Unpaid','Null','" + td3 + "','" + st3 + "','" + na3 + "')", conn);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    string dd = "No Money Generated";
                }


            }
            if (pp >= 310)
            {
                cmd = new SqlCommand("select top 1 (Prize),Month(Prize_date),count from tbl_prize where Prize='150 Pair' and Member_id='" + Member + "' order by Prize_date desc", conn);
                ds = new DataSet();
                adp = new SqlDataAdapter(cmd);
                adp.Fill(ds, "rj1");
                if (ds.Tables["rj1"].Rows.Count == 0)
                {
                    decimal amt3 = 0;
                    decimal td3 = 0;
                    decimal st3 = 0;
                    decimal na3 = 0;
                    cmd = new SqlCommand("insert into tbl_prize(Member_id,Prize,Prize_date,Pair,count,Prize_Money,Status)values('" + Member + "','150 Pair','" + System.DateTime.Now.ToShortDateString() + "','" + pp + "','1','Figo','Unpaid')", conn);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("insert into tbl_Accountdetails(Member_Id,Date,Income_Type,Credit_Amount,Debit_Amount,Prize,Status,Remark,TDS,Service_Tax,Net_Amount)values('" + Member + "','" + System.DateTime.Today.ToShortDateString() + "','Prize','" + amt3 + "','0','Figo Car','Unpaid','Null','" + td3 + "','" + st3 + "','" + na3 + "')", conn);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    string dd = "No Money Generated";
                }


            }
            if (pp >= 610)
            {
                cmd = new SqlCommand("select top 1 (Prize),Month(Prize_date),count from tbl_prize where Prize='300 Pair' and Member_id='" + Member + "' order by Prize_date desc", conn);
                ds = new DataSet();
                adp = new SqlDataAdapter(cmd);
                adp.Fill(ds, "rj1");
                if (ds.Tables["rj1"].Rows.Count == 0)
                {
                    decimal amt3 = 0;
                    decimal td3 = 0;
                    decimal st3 = 0;
                    decimal na3 = 0;
                    cmd = new SqlCommand("insert into tbl_prize(Member_id,Prize,Prize_date,Pair,count,Prize_Money,Status)values('" + Member + "','300 Pair','" + System.DateTime.Now.ToShortDateString() + "','" + pp + "','1','Safari','Unpaid')", conn);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("insert into tbl_Accountdetails(Member_Id,Date,Income_Type,Credit_Amount,Debit_Amount,Prize,Status,Remark,TDS,Service_Tax,Net_Amount)values('" + Member + "','" + System.DateTime.Today.ToShortDateString() + "','Prize','" + amt3 + "','0','Safari Car','Unpaid','Null','" + td3 + "','" + st3 + "','" + na3 + "')", conn);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    string dd = "No Money Generated";
                }


            }
        }
        else
        {
            conn.Open();
            if (pp >= 4)
            {
                cmd = new SqlCommand("select top 1 (Prize),Month(Prize_date),count from tbl_prize where Prize='4 Pair' and Member_id='" + Member + "' order by Prize_date desc  ", conn);
                ds = new DataSet();
                ds.Clear();
                adp = new SqlDataAdapter(cmd);
                adp.Fill(ds, "rj1");
                if (ds.Tables["rj1"].Rows.Count == 0)
                {
                    decimal amt3 = 3000;
                    decimal td3 = amt3 * 10 / 100;
                    decimal st3 = amt3 * 5 / 100;
                    decimal na3 = amt3 - td3 - st3;
                    cmd = new SqlCommand("insert into tbl_prize(Member_id,Prize,Prize_date,Pair,count,Prize_Money,Status)values('" + Member + "','4 Pair','" + System.DateTime.Now.ToShortDateString() + "','" + pp + "','1','3000','Unpaid')", conn);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("insert into tbl_Accountdetails(Member_Id,Date,Income_Type,Credit_Amount,Debit_Amount,Prize,Status,Remark,TDS,Service_Tax,Net_Amount)values('" + Member + "','" + System.DateTime.Today.ToShortDateString() + "','Prize','" + amt3 + "','0','Null','Unpaid','Null','" + td3 + "','" + st3 + "','" + na3 + "')", conn);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    string dd = "No Money Generated";
                }
            }
            if (pp >= 20)
            {
                cmd = new SqlCommand("select top 1 (Prize),Month(Prize_date),count from tbl_prize where Prize='16 Pair' and Member_id='" + Member + "' order by Prize_date desc ", conn);
                ds = new DataSet();
                adp = new SqlDataAdapter(cmd);
                adp.Fill(ds, "rj1");
                if (ds.Tables["rj1"].Rows.Count == 0)
                {
                    decimal amt3 = 21000;
                    decimal td3 = amt3 * 10 / 100;
                    decimal st3 = amt3 * 5 / 100;
                    decimal na3 = amt3 - td3 - st3;
                    cmd = new SqlCommand("insert into tbl_prize(Member_id,Prize,Prize_date,Pair,count,Prize_Money,Status)values('" + Member + "','16 Pair','" + System.DateTime.Now.ToShortDateString() + "','" + pp + "','1','21000','Unpaid')", conn);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("insert into tbl_Accountdetails(Member_Id,Date,Income_Type,Credit_Amount,Debit_Amount,Prize,Status,Remark,TDS,Service_Tax,Net_Amount)values('" + Member + "','" + System.DateTime.Today.ToShortDateString() + "','Prize','" + amt3 + "','0','Null','Unpaid','Null','" + td3 + "','" + st3 + "','" + na3 + "')", conn);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    string dd = "No Money Generated";
                }


            }
            if (pp >= 60)
            {
                cmd = new SqlCommand("select top 1 (Prize),Month(Prize_date),count from tbl_prize where Prize='60 Pair' and Member_id='" + Member + "' order by Prize_date desc", conn);
                ds = new DataSet();
                adp = new SqlDataAdapter(cmd);
                adp.Fill(ds, "rj1");
                if (ds.Tables["rj1"].Rows.Count == 0)
                {
                    decimal amt3 = 0;
                    decimal td3 = 0;
                    decimal st3 = 0;
                    decimal na3 = 0;
                    cmd = new SqlCommand("insert into tbl_prize(Member_id,Prize,Prize_date,Pair,count,Prize_Money,Status)values('" + Member + "','60 Pair','" + System.DateTime.Now.ToShortDateString() + "','" + pp + "','1','Bike','Unpaid')", conn);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("insert into tbl_Accountdetails(Member_Id,Date,Income_Type,Credit_Amount,Debit_Amount,Prize,Status,Remark,TDS,Service_Tax,Net_Amount)values('" + Member + "','" + System.DateTime.Today.ToShortDateString() + "','Prize','" + amt3 + "','0','Bike','Unpaid','Null','" + td3 + "','" + st3 + "','" + na3 + "')", conn);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    string dd = "No Money Generated";
                }


            }
            if (pp >= 160)
            {
                cmd = new SqlCommand("select top 1 (Prize),Month(Prize_date),count from tbl_prize where Prize='100 Pair' and Member_id='" + Member + "'order by Prize_date desc", conn);
                ds = new DataSet();
                adp = new SqlDataAdapter(cmd);
                adp.Fill(ds, "rj1");
                if (ds.Tables["rj1"].Rows.Count == 0)
                {
                    decimal amt3 = 0;
                    decimal td3 = 0;
                    decimal st3 = 0;
                    decimal na3 = 0;
                    cmd = new SqlCommand("insert into tbl_prize(Member_id,Prize,Prize_date,Pair,count,Prize_Money,Status)values('" + Member + "','100 Pair','" + System.DateTime.Now.ToShortDateString() + "','" + pp + "','1','Alto Car','Unpaid')", conn);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("insert into tbl_Accountdetails(Member_Id,Date,Income_Type,Credit_Amount,Debit_Amount,Prize,Status,Remark,TDS,Service_Tax,Net_Amount)values('" + Member + "','" + System.DateTime.Today.ToShortDateString() + "','Prize','" + amt3 + "','0','Alto Car','Unpaid','Null','" + td3 + "','" + st3 + "','" + na3 + "')", conn);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    string dd = "No Money Generated";
                }


            }
            if (pp >= 310)
            {
                cmd = new SqlCommand("select top 1 (Prize),Month(Prize_date),count from tbl_prize where Prize='150 Pair' and Member_id='" + Member + "' order by Prize_date desc", conn);
                ds = new DataSet();
                adp = new SqlDataAdapter(cmd);
                adp.Fill(ds, "rj1");
                if (ds.Tables["rj1"].Rows.Count == 0)
                {
                    decimal amt3 = 0;
                    decimal td3 = 0;
                    decimal st3 = 0;
                    decimal na3 = 0;
                    cmd = new SqlCommand("insert into tbl_prize(Member_id,Prize,Prize_date,Pair,count,Prize_Money,Status)values('" + Member + "','150 Pair','" + System.DateTime.Now.ToShortDateString() + "','" + pp + "','1','Figo','Unpaid')", conn);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("insert into tbl_Accountdetails(Member_Id,Date,Income_Type,Credit_Amount,Debit_Amount,Prize,Status,Remark,TDS,Service_Tax,Net_Amount)values('" + Member + "','" + System.DateTime.Today.ToShortDateString() + "','Prize','" + amt3 + "','0','Figo Car','Unpaid','Null','" + td3 + "','" + st3 + "','" + na3 + "')", conn);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    string dd = "No Money Generated";
                }


            }
            if (pp >= 610)
            {
                cmd = new SqlCommand("select top 1 (Prize),Month(Prize_date),count from tbl_prize where Prize='300 Pair' and Member_id='" + Member + "' order by Prize_date desc", conn);
                ds = new DataSet();
                adp = new SqlDataAdapter(cmd);
                adp.Fill(ds, "rj1");
                if (ds.Tables["rj1"].Rows.Count == 0)
                {
                    decimal amt3 = 0;
                    decimal td3 = 0;
                    decimal st3 = 0;
                    decimal na3 = 0;
                    cmd = new SqlCommand("insert into tbl_prize(Member_id,Prize,Prize_date,Pair,count,Prize_Money,Status)values('" + Member + "','300 Pair','" + System.DateTime.Now.ToShortDateString() + "','" + pp + "','1','Safari','Unpaid')", conn);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("insert into tbl_Accountdetails(Member_Id,Date,Income_Type,Credit_Amount,Debit_Amount,Prize,Status,Remark,TDS,Service_Tax,Net_Amount)values('" + Member + "','" + System.DateTime.Today.ToShortDateString() + "','Prize','" + amt3 + "','0','Safari Car','Unpaid','Null','" + td3 + "','" + st3 + "','" + na3 + "')", conn);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    string dd = "No Money Generated";
                }

            }
            conn.Close();
        }



    }
    public int countDirectPair(string sps)
    {
        string id = FindParent(sps);
        int dcc = 0;
        int dpp = 0;
        if (conn.State == ConnectionState.Open)
        {
            cmd = new SqlCommand("select MemberId from tbl_UserHierarchy where ParentID=" + id + " and (MemberId <>'')and (clr ='Green') ", conn);
            ds = new DataSet();
            ds.Clear();
            adp = new SqlDataAdapter(cmd);
            adp.Fill(ds, "ch1");
            if (ds.Tables["ch1"].Rows.Count > 1)
            {
                dcc = Convert.ToInt32(ds.Tables["ch1"].Rows.Count.ToString());
                dpp = dcc / 2;


            }
            else
            {
                dpp = 0; ;
            }

            conn.Close();


        }
        else
        {
            conn.Open();
            cmd = new SqlCommand("select MemberId from tbl_UserHierarchy where ParentID=" + id + " and (MemberId <>'')and (clr ='Green')", conn);
            ds = new DataSet();
            ds.Clear();
            adp = new SqlDataAdapter(cmd);
            adp.Fill(ds, "ch1");
            if (ds.Tables["ch1"].Rows.Count > 1)
            {
                dcc = Convert.ToInt32(ds.Tables["ch1"].Rows.Count.ToString());
                dpp = dcc / 2;
            }
            else
            {
                dpp = 0;
            }

            conn.Close();



        }
   
        return dpp;
    }

    public string paidLeftChild(string mem)
    {
        string lc = countLeftChild(mem);
        int newLeft = Convert.ToInt32(lc) + cry_Lchild - less_Lchild;
        string res1 = Convert.ToString(newLeft);
        return res1;
    }

    public string paidRightChild(string mem1)
    {
        string rc = countRightChild(mem1);
        int newRight = Convert.ToInt32(rc) + cry_Rchild - less_Rchild;
        string res2 = Convert.ToString(newRight);
        return res2;

    }


    public void cry_frwd_childrens(string memb)
    {

        if (conn.State == ConnectionState.Open)
        {
            cmd = new SqlCommand("select * from cry_frwd where member_id='" + memb + "'", conn);
            ds = new DataSet();
            ds.Clear();
            adp = new SqlDataAdapter(cmd);
            adp.Fill(ds, "ov");
            if (ds.Tables["ov"].Rows.Count > 0)
            {
                cmd = new SqlCommand("select * from cry_frwd where member_id='" + memb + "' ", conn);
                dr = cmd.ExecuteReader();
                dr.Read();
                less_Lchild = Convert.ToInt32(dr["less_Lchild"].ToString());
                less_Rchild = Convert.ToInt32(dr["less_Rchild"].ToString());
                cry_Lchild = Convert.ToInt32(dr["cry_frwd_Lchild"].ToString());
                cry_Rchild = Convert.ToInt32(dr["cry_frwd_Rchild"].ToString());
                dr.Close();
            }
            else
            {
                less_Rchild = 0;
                less_Lchild = 0;
                cry_Rchild = 0;
                cry_Lchild = 0;
            }
        }
        else
        {
            conn.Open();
            cmd = new SqlCommand("select * from cry_frwd where member_id='" + memb + "'", conn);
            ds = new DataSet();
            ds.Clear();
            adp = new SqlDataAdapter(cmd);
            adp.Fill(ds, "ov");
            if (ds.Tables["ov"].Rows.Count > 0)
            {
                cmd = new SqlCommand("select * from cry_frwd where member_id='" + memb + "' ", conn);
                dr = cmd.ExecuteReader();
                dr.Read();
                less_Lchild = Convert.ToInt32(dr["less_Lchild"].ToString());
                less_Rchild = Convert.ToInt32(dr["less_Rchild"].ToString());
                cry_Lchild = Convert.ToInt32(dr["cry_frwd_Lchild"].ToString());
                cry_Rchild = Convert.ToInt32(dr["cry_frwd_Rchild"].ToString());
                dr.Close();
            }
            else
            {
                less_Rchild = 0;
                less_Lchild = 0;
                cry_Rchild = 0;
                cry_Lchild = 0;
            }
            conn.Close();
        }

    }
    public void fillBonanza(string mem)
    {
        string id = FindParent(mem);
        int ct = 0;
        int dpp1 = 0;
        string rty = "";
        if (conn.State == ConnectionState.Open)
        {
            cmd = new SqlCommand("select MemberId from tbl_UserHierarchy where ParentID=" + id + " and (MemberId <>'')and (clr ='Green')", conn);
            ds = new DataSet();
            ds.Clear();
            adp = new SqlDataAdapter(cmd);
            adp.Fill(ds, "ch1");
            int fg = ds.Tables["ch1"].Rows.Count;
        
            if (fg > 0)
            {
                ct = fg;//ds.Tables["ch1"].Rows.Count;
                if (ct >=1)
                {
                    cmd = new SqlCommand("select top 1 (Bonanza) from tbl_Bonanza where Bonanza='Dinner Set'and Member_id='"+mem+"'", conn);
                    ds = new DataSet();
                    adp = new SqlDataAdapter(cmd);
                    adp.Fill(ds, "rj1");
                    if (ds.Tables["rj1"].Rows.Count == 0)
                    {
                        decimal amt4 = 0;
                        decimal td4 = 0;
                        decimal st4 = 0;
                        decimal na4 = 0;
                        cmd = new SqlCommand("insert into tbl_Bonanza(Member_id,Direct_Child,Bonanza,Bonanza_Date,Status)values('" + mem + "'," + ct + ",'Dinner Set','" + System.DateTime.Now.ToShortDateString() + "','Unpaid')", conn);
                        cmd.ExecuteNonQuery();
                        cmd = new SqlCommand("insert into tbl_Accountdetails(Member_Id,Date,Income_Type,Credit_Amount,Debit_Amount,Prize,Status,Remark,TDS,Service_Tax,Net_Amount)values('" + mem + "','" + System.DateTime.Today.ToShortDateString() + "','Bonanza','0','0','Dinner Set','Unpaid','Null','" + td4 + "','" + st4 + "','" + na4 + "')", conn);
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        rty = "No Income";
                    }
                }
                    if (ct >= 3)
                    {
                        cmd = new SqlCommand("select top 1 (Bonanza) from tbl_Bonanza where Bonanza='Microwave Oven'  and Member_id='" + mem + "'", conn);
                        ds = new DataSet();
                        adp = new SqlDataAdapter(cmd);
                        adp.Fill(ds, "rj1");
                        if (ds.Tables["rj1"].Rows.Count == 0)
                        {
                            decimal amt4 = 0;
                            decimal td4 = 0;
                            decimal st4 = 0;
                            decimal na4 = 0;
                            cmd = new SqlCommand("insert into tbl_Bonanza(Member_id,Direct_Child,Bonanza,Bonanza_Date,Status)values('" + mem + "'," + ct + ",'Microwave Oven','" + System.DateTime.Now.ToShortDateString() + "','Unpaid')", conn);
                            cmd.ExecuteNonQuery();
                            cmd = new SqlCommand("insert into tbl_Accountdetails(Member_Id,Date,Income_Type,Credit_Amount,Debit_Amount,Prize,Status,Remark,TDS,Service_Tax,Net_Amount)values('" + mem + "','" + System.DateTime.Today.ToShortDateString() + "','Bonanza','0','0','Microwave Oven','Unpaid','Null','" + td4 + "','" + st4 + "','" + na4 + "')", conn);
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            rty = "No Income";
                        }


                    }
                    if (ct >= 5)
                    {
                        cmd = new SqlCommand("select top 1 (Bonanza) from tbl_Bonanza where Bonanza='Washing Machine'and Member_id='" + mem + "'", conn);
                        ds = new DataSet();
                        adp = new SqlDataAdapter(cmd);
                        adp.Fill(ds, "rj1");
                        if (ds.Tables["rj1"].Rows.Count == 0)
                        {
                            decimal amt4 = 0;
                            decimal td4 = 0;
                            decimal st4 = 0;
                            decimal na4 = 0;
                            cmd = new SqlCommand("insert into tbl_Bonanza(Member_id,Direct_Child,Bonanza,Bonanza_Date,Status)values('" + mem + "'," + ct + ",'Washing Machine','" + System.DateTime.Now.ToShortDateString() + "','Unpaid')", conn);
                            cmd.ExecuteNonQuery();
                            cmd = new SqlCommand("insert into tbl_Accountdetails(Member_Id,Date,Income_Type,Credit_Amount,Debit_Amount,Prize,Status,Remark,TDS,Service_Tax,Net_Amount)values('" + mem + "','" + System.DateTime.Today.ToShortDateString() + "','Bonanza','0','0','Washin Machine','Unpaid','Null','" + td4 + "','" + st4 + "','" + na4 + "')", conn);
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            rty = "No Income";
                        }
                    }
                    if (ct >= 8)
                    {
                        cmd = new SqlCommand("select top 1 (Bonanza) from tbl_Bonanza where Bonanza='Fridge' and Member_id='" + mem + "'", conn);
                        ds = new DataSet();
                        adp = new SqlDataAdapter(cmd);
                        adp.Fill(ds, "rj1");
                        if (ds.Tables["rj1"].Rows.Count == 0)
                        {
                            decimal amt4 = 0;
                            decimal td4 = 0;
                            decimal st4 = 0;
                            decimal na4 = 0;
                            cmd = new SqlCommand("insert into tbl_Bonanza(Member_id,Direct_Child,Bonanza,Bonanza_Date,Status)values('" + mem + "'," + ct + ",'Fridge','" + System.DateTime.Now.ToShortDateString() + "','Unpaid')", conn);
                            cmd.ExecuteNonQuery();
                            cmd = new SqlCommand("insert into tbl_Accountdetails(Member_Id,Date,Income_Type,Credit_Amount,Debit_Amount,Prize,Status,Remark,TDS,Service_Tax,Net_Amount)values('" + mem + "','" + System.DateTime.Today.ToShortDateString() + "','Bonanza','0','0','Fridge','Unpaid','Null','" + td4 + "','" + st4 + "','" + na4 + "')", conn);
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            rty = "No Income";
                        }
                    }
                    if (ct >= 10)
                    {
                        cmd = new SqlCommand("select top 1 (Bonanza) from tbl_Bonanza where Bonanza='26 inch LCD TV' and Member_id='"+mem+"'", conn);
                        ds = new DataSet();
                        adp = new SqlDataAdapter(cmd);
                        adp.Fill(ds, "rj1");
                        if (ds.Tables["rj1"].Rows.Count == 0)
                        {
                            decimal amt4 = 0;
                            decimal td4 = 0;
                            decimal st4 = 0;
                            decimal na4 = 0;
                            cmd = new SqlCommand("insert into tbl_Bonanza(Member_id,Direct_Child,Bonanza,Bonanza_Date,Status)values('" + mem + "'," + ct + ",'26 inch LCD TV','" + System.DateTime.Now.ToShortDateString() + "','Unpaid')", conn);
                            cmd.ExecuteNonQuery();
                            cmd = new SqlCommand("insert into tbl_Accountdetails(Member_Id,Date,Income_Type,Credit_Amount,Debit_Amount,Prize,Status,Remark,TDS,Service_Tax,Net_Amount)values('" + mem + "','" + System.DateTime.Today.ToShortDateString() + "','Bonanza','0','0','26 inch LCD TV','Unpaid','Null','" + td4 + "','" + st4 + "','" + na4 + "')", conn);
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            rty = "No Income";
                        }
                    }
                    if (ct >= 15)
                    {
                        cmd = new SqlCommand("select top 1 (Bonanza) from tbl_Bonanza where Bonanza='32 inch LCD TV' and Member_id='" + mem + "'", conn);
                        ds = new DataSet();
                        adp = new SqlDataAdapter(cmd);
                        adp.Fill(ds, "rj1");
                        if (ds.Tables["rj1"].Rows.Count == 0)
                        {
                            decimal amt4 = 0;
                            decimal td4 = 0;
                            decimal st4 = 0;
                            decimal na4 = 0;
                            cmd = new SqlCommand("insert into tbl_Bonanza(Member_id,Direct_Child,Bonanza,Bonanza_Date,Status)values('" + mem + "'," + ct + ",'32 inch LCD TV','" + System.DateTime.Now.ToShortDateString() + "','Unpaid')", conn);
                            cmd.ExecuteNonQuery();
                            cmd = new SqlCommand("insert into tbl_Accountdetails(Member_Id,Date,Income_Type,Credit_Amount,Debit_Amount,Prize,Status,Remark,TDS,Service_Tax,Net_Amount)values('" + mem + "','" + System.DateTime.Today.ToShortDateString() + "','Bonanza','0','0','32 inch LCD TV','Unpaid','Null','" + td4 + "','" + st4 + "','" + na4 + "')", conn);
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            rty = "No Income";
                        }
                    }
                }
                    else
                    {
                        rty = "No Income";
                    }


           


        }
        else
        {
            conn.Open();
            cmd = new SqlCommand("select MemberId from tbl_UserHierarchy where ParentID=" + id + " and (MemberId <>'')and (clr ='Green')", conn);
            ds = new DataSet();
            ds.Clear();
            adp = new SqlDataAdapter(cmd);
            adp.Fill(ds, "ch1");
            int kj = ds.Tables["ch1"].Rows.Count;
           
            if (kj> 0)
            {
                ct = ds.Tables["ch1"].Rows.Count;
                if (ct >=1)
                {
                    cmd = new SqlCommand("select top 1 (Bonanza) from tbl_Bonanza where Bonanza='Dinner Set' and Member_id='" + mem + "'", conn);
                    ds = new DataSet();
                    adp = new SqlDataAdapter(cmd);
                    adp.Fill(ds, "rj1");
                    if (ds.Tables["rj1"].Rows.Count == 0)
                    {
                        decimal amt4 = 0;
                        decimal td4 = 0;
                        decimal st4 = 0;
                        decimal na4 = 0;
                        cmd = new SqlCommand("insert into tbl_Bonanza(Member_id,Direct_Child,Bonanza,Bonanza_Date,Status)values('" + mem + "'," + ct + ",'Dinner Set','" + System.DateTime.Now.ToShortDateString() + "','Unpaid')", conn);
                        cmd.ExecuteNonQuery();
                        cmd = new SqlCommand("insert into tbl_Accountdetails(Member_Id,Date,Income_Type,Credit_Amount,Debit_Amount,Prize,Status,Remark,TDS,Service_Tax,Net_Amount)values('" + mem + "','" + System.DateTime.Today.ToShortDateString() + "','Bonanza','0','0','Dinner Set','Unpaid','Null','" + td4 + "','" + st4 + "','" + na4 + "')", conn);
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        rty = "No Income";
                    }
                }
                    if (ct >= 3)
                    {
                        cmd = new SqlCommand("select top 1 (Bonanza) from tbl_Bonanza where Bonanza='Microwave Oven' and Member_id='" + mem + "'", conn);
                        ds = new DataSet();
                        adp = new SqlDataAdapter(cmd);
                        adp.Fill(ds, "rj1");
                        if (ds.Tables["rj1"].Rows.Count == 0)
                        {
                            decimal amt4 = 0;
                            decimal td4 = 0;
                            decimal st4 = 0;
                            decimal na4 = 0;
                            cmd = new SqlCommand("insert into tbl_Bonanza(Member_id,Direct_Child,Bonanza,Bonanza_Date,Status)values('" + mem + "'," + ct + ",'Microwave Oven','" + System.DateTime.Now.ToShortDateString() + "','Unpaid')", conn);
                            cmd.ExecuteNonQuery();
                            cmd = new SqlCommand("insert into tbl_Accountdetails(Member_Id,Date,Income_Type,Credit_Amount,Debit_Amount,Prize,Status,Remark,TDS,Service_Tax,Net_Amount)values('" + mem + "','" + System.DateTime.Today.ToShortDateString() + "','Bonanza','0','0','Microwave Oven','Unpaid','Null','" + td4 + "','" + st4 + "','" + na4 + "')", conn);
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            rty = "No Income";
                        }


                    }
                    if (ct >= 5)
                    {
                        cmd = new SqlCommand("select top 1 (Bonanza) from tbl_Bonanza where Bonanza='Washing Machine' and Member_id='" + mem + "'", conn);
                        ds = new DataSet();
                        adp = new SqlDataAdapter(cmd);
                        adp.Fill(ds, "rj1");
                        if (ds.Tables["rj1"].Rows.Count == 0)
                        {
                            decimal amt4 = 0;
                            decimal td4 = 0;
                            decimal st4 = 0;
                            decimal na4 = 0;
                            cmd = new SqlCommand("insert into tbl_Bonanza(Member_id,Direct_Child,Bonanza,Bonanza_Date,Status)values('" + mem + "'," + ct + ",'Washing Machine','" + System.DateTime.Now.ToShortDateString() + "','Unpaid')", conn);
                            cmd.ExecuteNonQuery();
                            cmd = new SqlCommand("insert into tbl_Accountdetails(Member_Id,Date,Income_Type,Credit_Amount,Debit_Amount,Prize,Status,Remark,TDS,Service_Tax,Net_Amount)values('" + mem + "','" + System.DateTime.Today.ToShortDateString() + "','Bonanza','0','0','Washing Machine','Unpaid','Null','" + td4 + "','" + st4 + "','" + na4 + "')", conn);
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            rty = "No Income";
                        }
                    }
                    if (ct >= 8)
                    {
                        cmd = new SqlCommand("select top 1 (Bonanza) from tbl_Bonanza where Bonanza='Fridge'and Member_id='" + mem + "'", conn);
                        ds = new DataSet();
                        adp = new SqlDataAdapter(cmd);
                        adp.Fill(ds, "rj1");
                        if (ds.Tables["rj1"].Rows.Count == 0)
                        {
                            decimal amt4 = 0;
                            decimal td4 = 0;
                            decimal st4 = 0;
                            decimal na4 = 0;
                            cmd = new SqlCommand("insert into tbl_Bonanza(Member_id,Direct_Child,Bonanza,Bonanza_Date,Status)values('" + mem + "'," + ct + ",'Fridge','" + System.DateTime.Now.ToShortDateString() + "','Unpaid')", conn);
                            cmd.ExecuteNonQuery();
                            cmd = new SqlCommand("insert into tbl_Accountdetails(Member_Id,Date,Income_Type,Credit_Amount,Debit_Amount,Prize,Status,Remark,TDS,Service_Tax,Net_Amount)values('" + mem + "','" + System.DateTime.Today.ToShortDateString() + "','Bonanza','0','0','Fridge','Unpaid','Null','" + td4 + "','" + st4 + "','" + na4 + "')", conn);
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            rty = "No Income";
                        }
                    }
                    if (ct >= 10)
                    {
                        cmd = new SqlCommand("select top 1 (Bonanza) from tbl_Bonanza where Bonanza='26 inch LCD TV'and Member_id='" + mem + "'", conn);
                        ds = new DataSet();
                        adp = new SqlDataAdapter(cmd);
                        adp.Fill(ds, "rj1");
                        if (ds.Tables["rj1"].Rows.Count == 0)
                        {
                            decimal amt4 = 0;
                            decimal td4 = 0;
                            decimal st4 = 0;
                            decimal na4 = 0;
                            cmd = new SqlCommand("insert into tbl_Bonanza(Member_id,Direct_Child,Bonanza,Bonanza_Date,Status)values('" + mem + "'," + ct + ",'26 inch LCD TV','" + System.DateTime.Now.ToShortDateString() + "','Unpaid')", conn);
                            cmd.ExecuteNonQuery();
                            cmd = new SqlCommand("insert into tbl_Accountdetails(Member_Id,Date,Income_Type,Credit_Amount,Debit_Amount,Prize,Status,Remark,TDS,Service_Tax,Net_Amount)values('" + mem + "','" + System.DateTime.Today.ToShortDateString() + "','Bonanza','0','0','26 inch LCD TV','Unpaid','Null','" + td4 + "','" + st4 + "','" + na4 + "')", conn);
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            rty = "No Income";
                        }
                    }
                    if (ct >= 15)
                    {
                        cmd = new SqlCommand("select top 1 (Bonanza) from tbl_Bonanza where Bonanza='32 inch LCD TV'and Member_id='" + mem + "'", conn);
                        ds = new DataSet();
                        adp = new SqlDataAdapter(cmd);
                        adp.Fill(ds, "rj1");
                        if (ds.Tables["rj1"].Rows.Count == 0)
                        {
                            decimal amt4 = 0;
                            decimal td4 = 0;
                            decimal st4 = 0;
                            decimal na4 = 0;
                            cmd = new SqlCommand("insert into tbl_Bonanza(Member_id,Direct_Child,Bonanza,Bonanza_Date,Status)values('" + mem + "'," + ct + ",'32 inch LCD TV','" + System.DateTime.Now.ToShortDateString() + "','Unpaid')", conn);
                            cmd.ExecuteNonQuery();
                            cmd = new SqlCommand("insert into tbl_Accountdetails(Member_Id,Date,Income_Type,Credit_Amount,Debit_Amount,Prize,Status,Remark,TDS,Service_Tax,Net_Amount)values('" + mem + "','" + System.DateTime.Today.ToShortDateString() + "','Bonanza','0','0','32 inch LCD TV','Unpaid','Null','" + td4 + "','" + st4 + "','" + na4 + "')", conn);
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            rty = "No Income";
                        }
                    }
            }
                    else
                    {
                        rty = "No Income";
                    }

                    conn.Close();
        }

        
    }

    public string countpreviousPair(string memb)
    {
        string p1 = "";
        string p2 = "";
        string p3 = "";
        

        if (conn.State == ConnectionState.Open)
        {
            cmd = new SqlCommand("select * from tbl_Binarydetails where Member_Id='" + memb + "'", conn);
            ds.Clear();
            adp = new SqlDataAdapter(cmd);
            adp.Fill(ds, "rjjj");
            if (ds.Tables["rjjj"].Rows.Count > 0)
            {
                string p4 = "";
                int k = 0;
                for (int i = 0; i < ds.Tables["rjjj"].Rows.Count; i++)
                {
                    p4 = ds.Tables["rjjj"].Rows[i]["Pair"].ToString();
                    k = k + Convert.ToInt32(p4);
                }
                p1 = k.ToString();

            }
            else
            {
                string l11=countLeftChild(memb);
                string r11=countRightChild(memb);
                int lf = Convert.ToInt32(l11);
                int rf = Convert.ToInt32(r11);
                int olp = 0;
                int lp1 = 0;
                int lp2 = 0;
                if (lf > rf)
                {
                    olp = lf - rf;
                    lf = lf - olp;
                    lp1 = lf;
                    lp2 = rf;

                }
                else if (rf > lf)
                {
                    olp = rf - lf;
                    rf = rf - olp;
                    lp1 = lf;
                    lp2 = rf;
                }
                else
                {
                    lp1 = lf;
                    lp2 = rf;
                }

                int tc11=Convert.ToInt32(lp1)+Convert.ToInt32(lp2);
                int p11=tc11/2;
                decimal amt1=Convert.ToDecimal(p11)*2500;
                decimal tdd=amt1*10/100;
                decimal stt=amt1*5/100;
                decimal naa=amt1-tdd-stt;

                cmd1 = new SqlCommand("insert into tbl_Binarydetails(Member_Id,Left_Child,Right_Child,Pair,Paid_Pair,TotalAmount,TDS,ServiceTax,Net_Amount,Date)values('" + memb + "','" + l11 + "','" + r11 + "','" + p11 + "','"+p11+"','" + amt1 + "','" + tdd + "','" + stt + "','" + naa + "','" + System.DateTime.Now.ToShortDateString() + "')", conn);
                cmd1.ExecuteNonQuery();
                cmd1 = new SqlCommand("insert into tbl_Accountdetails(Member_Id,Date,Income_Type,Credit_Amount,Debit_Amount,Prize,Status,Remark,TDS,Service_Tax,Net_Amount)values('" + memb + "','" + System.DateTime.Today.ToShortDateString() + "','Binary','" + amt1 + "','0','Null','Unpaid','Null','" + tdd + "','" + stt + "','" + naa + "')", conn);
                cmd1.ExecuteNonQuery();
                p1 = p11.ToString();
            }
            conn.Close();

        }
        else
        {
            conn.Open();
           
            cmd = new SqlCommand("select * from tbl_Binarydetails where Member_Id='" + memb + "'", conn);
            ds.Clear();
            adp = new SqlDataAdapter(cmd);
            adp.Fill(ds, "rjjj");
            if (ds.Tables["rjjj"].Rows.Count > 0)
            {
                string p4 = "";
                int k = 0;
                for (int i = 0; i < ds.Tables["rjjj"].Rows.Count; i++)
                {
                    p4 = ds.Tables["rjjj"].Rows[i]["Pair"].ToString();
                    k = k + Convert.ToInt32(p4);
                }
                p1 = k.ToString();

            }
            else
            {
                string l11 = countLeftChild(memb);
                string r11 = countRightChild(memb);
               
                int lf = Convert.ToInt32(l11);
                int rf = Convert.ToInt32(r11);
                int olp = 0;
                int lp1 = 0;
                int lp2 = 0;
                if (lf > rf)
                {
                    olp = lf - rf;
                    lf = lf - olp;
                    lp1 = lf;
                    lp2 = rf;

                }
                else if (rf > lf)
                {
                    olp = rf - lf;
                    rf = rf - olp;
                    lp1 = lf;
                    lp2 = rf;
                }
                else
                {
                    lp1 = lf;
                    lp2 = rf;
                }

                int tc11 = Convert.ToInt32(lp1) + Convert.ToInt32(lp2);
                int p11 = tc11 / 2;
                decimal amt1 = Convert.ToDecimal(p11) * 2500;
                decimal tdd = amt1 * 10 / 100;
                decimal stt = amt1 * 5 / 100;
                decimal naa = amt1 - tdd - stt;
                cmd1 = new SqlCommand("insert into tbl_Binarydetails(Member_Id,Left_Child,Right_Child,Pair,Paid_Pair,TotalAmount,TDS,ServiceTax,Net_Amount,Date)values('" + memb + "','" + l11 + "','" + r11 + "','"+p11+"','" + p11 + "','" + amt1 + "','" + tdd + "','" + stt + "','" + naa + "','" + System.DateTime.Now.ToShortDateString() + "')", conn);
                cmd1.ExecuteNonQuery();
                cmd1 = new SqlCommand("insert into tbl_Accountdetails(Member_Id,Date,Income_Type,Credit_Amount,Debit_Amount,Prize,Status,Remark,TDS,Service_Tax,Net_Amount)values('" + memb + "','" + System.DateTime.Today.ToShortDateString() + "','Binary','" + amt1 + "','0','Null','Unpaid','Null','" + tdd + "','" + stt + "','" + naa + "')", conn);
                cmd1.ExecuteNonQuery();
                p1 = p11.ToString();
            }
            conn.Close();
        }
        return p1;
    }

    public void fillBinary(string memb, string left, string right)
    {
        if (conn.State == ConnectionState.Open)
        {
            //int tc12 = Convert.ToInt32(left) + Convert.ToInt32(right);
          //  int p12 = tc12 / 2;
            string pp = countpreviousPair(memb);
            string cp = Convert.ToString(countPair(memb));
            if (pp != cp)
            {
                int uu = Convert.ToInt32(cp) -Convert.ToInt32(pp);
                decimal amt11 = Convert.ToDecimal(uu) * 2500;
                decimal tdd1 = amt11 * 10 / 100;
                decimal stt1 = amt11 * 5 / 100;
                decimal naa1 = amt11 - tdd1 - stt1;
                cmd1 = new SqlCommand("insert into tbl_Binarydetails(Member_Id,Left_Child,Right_Child,Pair,Paid_Pair,TotalAmount,TDS,ServiceTax,Net_Amount,Date)values('" + memb + "','" + left + "','" + right + "','"+cp+"','" + uu + "','" + amt11 + "','" + tdd1 + "','" + stt1 + "','" + naa1 + "','" + System.DateTime.Now.ToShortDateString() + "')", conn);
                cmd1.ExecuteNonQuery();
                cmd1 = new SqlCommand("insert into tbl_Accountdetails(Member_Id,Date,Income_Type,Credit_Amount,Debit_Amount,Prize,Status,Remark,TDS,Service_Tax,Net_Amount)values('" + memb + "','" + System.DateTime.Today.ToShortDateString() + "','Binary','" + amt11 + "','0','Null','Unpaid','Null','" + tdd1 + "','" + stt1 + "','" + naa1 + "')", conn);
                cmd1.ExecuteNonQuery();
            }
            else
            {
                string bgh = "NO Binary Income";
            }
        }
        else
        {
            conn.Open();
           // int tc12 = Convert.ToInt32(left) + Convert.ToInt32(right);
            //int p12 = tc12 / 2;
            string pp = countpreviousPair(memb);
            string cp = Convert.ToString(countPair(memb));
            if (cp!=pp)
            {
                int uu = Convert.ToInt32(cp) - Convert.ToInt32(pp);
                decimal amt11 = Convert.ToDecimal(uu) * 2500;
                decimal tdd1 = amt11 * 10 / 100;
                decimal stt1 = amt11 * 5 / 100;
                decimal naa1 = amt11 - tdd1 - stt1;
                cmd1 = new SqlCommand("insert into tbl_Binarydetails(Member_Id,Left_Child,Right_Child,Pair,Paid_Pair,TotalAmount,TDS,ServiceTax,Net_Amount,Date)values('" + memb + "','" + left + "','" + right + "','" + uu + "','"+cp+"','" + amt11 + "','" + tdd1 + "','" + stt1 + "','" + naa1 + "','" + System.DateTime.Now.ToShortDateString() + "')", conn);
                cmd1.ExecuteNonQuery();
                cmd1 = new SqlCommand("insert into tbl_Accountdetails(Member_Id,Date,Income_Type,Credit_Amount,Debit_Amount,Prize,Status,Remark,TDS,Service_Tax,Net_Amount)values('" + memb + "','" + System.DateTime.Today.ToShortDateString() + "','Binary','" + amt11 + "','0','Null','Unpaid','Null','" + tdd1 + "','" + stt1 + "','" + naa1 + "')", conn);
                cmd1.ExecuteNonQuery();
            }
            else
            {
                string bgh = "NO Binary Income";
            }
            conn.Close();
        }

    }


    public int countDirectChild(string memb)
    {
        string id5 = FindParent(memb);
        int dcc5 = 0;
        int dpp5 = 0;
        if (conn.State == ConnectionState.Open)
        {
            cmd = new SqlCommand("select MemberId from tbl_UserHierarchy where ParentID=" + id5 + " and (MemberId <>'')and (clr ='Green') ", conn);
            ds = new DataSet();
            ds.Clear();
            adp = new SqlDataAdapter(cmd);
            adp.Fill(ds, "ch11");
            if (ds.Tables["ch11"].Rows.Count > 0)
            {
                dpp5 = Convert.ToInt32(ds.Tables["ch11"].Rows.Count.ToString());
                //dpp = dcc / 2;


            }
            else
            {
                dpp5 = 0; ;
            }

            conn.Close();


        }
        else
        {
            conn.Open();
            cmd = new SqlCommand("select MemberId from tbl_UserHierarchy where ParentID=" + id5 + " and (MemberId <>'')and (clr ='Green')", conn);
            ds = new DataSet();
            ds.Clear();
            adp = new SqlDataAdapter(cmd);
            adp.Fill(ds, "ch1");
            if (ds.Tables["ch1"].Rows.Count > 0)
            {
                dpp5 = Convert.ToInt32(ds.Tables["ch1"].Rows.Count.ToString());
                //dpp = dcc / 2;
            }
            else
            {
                dpp5 = 0;
            }

            conn.Close();



        }

        return dpp5;
    
    }

    public void fill_masterdetails(string mem)
    {
        if (conn.State == ConnectionState.Open)
        {
            conn.Close();
        
        }
        string sid = "";
        string userid = "";
        string uname = "";
        string bank = "";
        string ac_num = "";
        string ac_holder = "";
        string result = "";

      
        cmd = new SqlCommand("select * from cust_data where usr_id='" + mem + "'", conn);
        ds = new DataSet();
        ds.Clear();
        adp = new SqlDataAdapter(cmd);
        adp.Fill(ds, "md");
        if (ds.Tables["md"].Rows.Count > 0)
        {
            sid=ds.Tables["md"].Rows[0]["sp_id"].ToString();
            userid = ds.Tables["md"].Rows[0]["usr_id"].ToString();
            uname = ds.Tables["md"].Rows[0]["f_name"].ToString() + ds.Tables["md"].Rows[0]["ml_name"].ToString() + ds.Tables["md"].Rows[0]["l_name"].ToString(); 
            bank = ds.Tables["md"].Rows[0]["bank_name"].ToString();
            ac_num = ds.Tables["md"].Rows[0]["account_no"].ToString();
            ac_holder = ds.Tables["md"].Rows[0]["account_name"].ToString();

            string cb = fetch_binary(mem);
            string cr = fetch_Refferel(mem);
            string cso = fetch_Spilover(mem);

            string pb = fetch_Prevbinary(mem);
            string pr = fetch_prevRefferel(mem);
            string pso = fetch_prevSpilover(mem);

            decimal tb=Convert.ToDecimal(cb);
            decimal td = Convert.ToDecimal(cr) + Convert.ToDecimal(cso);
            decimal tbd=tb+td;
            decimal tctds=tbd*10/100;
            decimal tcad= tbd*5/100;
            decimal tcnet=tbd-tctds-tcad;

            decimal tpb = Convert.ToDecimal(pb);
            decimal tpd = Convert.ToDecimal(pr) + Convert.ToDecimal(pso);

            decimal tpbd=tpb+tpd;
            decimal tptds=tpbd*10/100;
            decimal tpad= tpbd*5/100;
            decimal tpnet=tpbd-tptds-tpad;

                    decimal up3= Convert.ToDecimal(totalBDUnPaidcurrent(mem));
                    decimal pa3 = Convert.ToDecimal(totalBDPaidcurrent(mem));
                    decimal ac3 = up3 - pa3;


                      decimal up4= Convert.ToDecimal(totalBDUnPaidprevious(mem));
                    decimal pa4 = Convert.ToDecimal(totalBDPaidPrevious(mem));
                    decimal ac4 = up4 - pa4;

                    //Label1.Text = ac3.ToString();
                  //Label2.Text = totalPending(id);

                    //Label3.Text = totalBDPaid(id);

            decimal tot_ded = 0;

            if (tpb <= 200000)
            {

              string month=System.DateTime.Today.Month.ToString();
                string m1="";
                string y1="";

                if(month=="1")
                {

                    m1=(System.DateTime.Now.Month-1).ToString();
                    y1=(System.DateTime.Now.Year-1).ToString();

                   // cmd = new SqlCommand("select * from  tbl_master_deatails where Member_id='" + mem + "' and  Month = DATENAME(mm, DATEADD(m, - 1, GETDATE())) and Year=DATENAME(yyyy, DATEADD(yy, - 1, GETDATE()))", conn);
                    cmd = new SqlCommand("select * from  tbl_master_deatails where Member_id='" + mem + "' and Month ='" + m1 + "' and Year='" + y1 + "'", conn);
 
                }

                else
                {
                    m1=(System.DateTime.Now.Month-1).ToString();
                    y1=(System.DateTime.Now.Year).ToString();
                   // cmd = new SqlCommand("select * from  tbl_master_deatails where Member_id='" + mem + "' and Month = DATENAME(mm, DATEADD(m, - 1, GETDATE())) and Year=Year(GETDATE())", conn);
                    cmd = new SqlCommand("select * from  tbl_master_deatails where Member_id='" + mem + "' and Month ='"+m1+"' and Year='"+y1+"'", conn);
                }

                ds.Clear();
                adp = new SqlDataAdapter(cmd);
                adp.Fill(ds, "md1");
                if (ds.Tables["md1"].Rows.Count > 0)
                {
                    conn.Open();
                    cmd = new SqlCommand("update  tbl_master_deatails set Total_binary='" + tpb + "',Total_direct='" + tpd + "',TDS='" + tptds + "',Service='" + tpad + "',total_paid='" + pa4 + "',total_unpaid='" + up4 + "',Net_amount='" + tpnet + "'where Member_id='"+mem+"' and Month='"+m1+"' and Year='"+y1+"'", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                }
                else
                {
                    conn.Open();
                    cmd = new SqlCommand("insert into  tbl_master_deatails(sp_id,Member_id,Member_name,Bank_Name,Acct_number,Acct_holder,Total_binary,total_direct,total_deduction,TDS,Service,Net_amount,Month,Year,total_paid,Total_unpaid,remark)values('" + sid + "','" + userid + "','" + uname + "','" + bank + "','" + ac_num + "','" + ac_holder + "','" + tpb + "','" + tpd + "','" + tot_ded + "','" + tptds + "','" + tpad + "','" + tpnet + "','" + m1 + "','" + y1 + "','" + pa4 + "','" + up4 + "','Null')", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                
              }


            else
            { 

                tot_ded=tpb-200000;
                tpb=tpb-tot_ded;
                tpbd=tpd+tpb;
                tptds=tpbd*10/100;
                tpad=tpbd*5/100;
                tpnet=tpbd-tptds-tpad;

                
                 string month=System.DateTime.Today.Month.ToString();
                string m1="";
                string y1="";

                if(month=="1")
                {

                    m1=(System.DateTime.Now.Month-1).ToString();
                    y1=(System.DateTime.Now.Year-1).ToString();

                    //cmd = new SqlCommand("select * from  tbl_master_deatails where Member_id='" + mem + "' and Month = DATENAME(mm, DATEADD(m, - 1, GETDATE())) and Year=DATENAME(yyyy, DATEADD(yy, - 1, GETDATE()))", conn);
                    cmd = new SqlCommand("select * from  tbl_master_deatails where Member_id='" + mem + "' and Month ='" + m1 + "' and Year='" + y1 + "'", conn);
                }

                else
                {
                    m1=(System.DateTime.Now.Month-1).ToString();
                    y1=(System.DateTime.Now.Year).ToString();
                    //cmd = new SqlCommand("select * from  tbl_master_deatails where Member_id='" + mem + "'and  Month = DATENAME(mm, DATEADD(m, - 1, GETDATE())) and Year=Year(GETDATE())", conn);
                    cmd = new SqlCommand("select * from  tbl_master_deatails where Member_id='" + mem + "' and Month ='" + m1 + "' and Year='" + y1 + "'", conn);
                }

                ds.Clear();
                adp = new SqlDataAdapter(cmd);
                adp.Fill(ds, "md1");
                if (ds.Tables["md1"].Rows.Count > 0)
                {
                    conn.Open();
                    cmd = new SqlCommand("update  tbl_master_deatails set Total_binary='" + tpb + "',Total_direct='" + tpd + "',TDS='" + tptds + "',Service='" + tpad + "',total_paid='" + pa4 + "',total_unpaid='" + up4 + "',Net_amount='" + tpnet + "',total_deduction='" + tot_ded + "'where Member_id='" + mem + "'and Month='" + m1 + "' and Year='" + y1 + "'", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                }
                else
                {
                    conn.Open();
                    cmd = new SqlCommand("insert into  tbl_master_deatails(sp_id,Member_id,Member_name,Bank_Name,Acct_number,Acct_holder,Total_binary,total_direct,total_deduction,TDS,Service,Net_amount,Month,Year,total_paid,Total_unpaid,remark)values('" + sid + "','" + userid + "','" + uname + "','" + bank + "','" + ac_num + "','" + ac_holder + "','" + tpb + "','" + tpd + "','" + tot_ded + "','" + tptds + "','" + tpad + "','" + tpnet + "','" + m1 + "','" + y1 + "','" + pa4 + "','" + up4 + "','Null')", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                
              }



            if (tb <= 200000)
            {
               string  m1 = (System.DateTime.Now.Month).ToString();
               string  y1 = (System.DateTime.Now.Year).ToString();

                tot_ded = 0;

                cmd = new SqlCommand("select * from  tbl_master_deatails where Member_id='" + mem + "' and Month = month(getdate()) and Year= year(GETDATE())", conn);
                ds.Clear();
                adp = new SqlDataAdapter(cmd);
                adp.Fill(ds, "md1");
                if (ds.Tables["md1"].Rows.Count > 0)
                {
                    conn.Open();
                    cmd = new SqlCommand("update  tbl_master_deatails set Total_binary='" + tb + "',Total_direct='" + td + "',TDS='" + tctds + "',Service='" + tcad + "',total_paid='" + pa3 + "',total_unpaid='" + up3 + "',Net_amount='" + tcnet + "'where member_id='" + mem + "'and Month='" + m1 + "' and Year='" + y1 + "'", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                }
                else
                {
                    conn.Open();
                    cmd = new SqlCommand("insert into  tbl_master_deatails(sp_id,Member_id,Member_name,Bank_Name,Acct_number,Acct_holder,Total_binary,total_direct,total_deduction,TDS,Service,Net_amount,Month,Year,total_paid,Total_unpaid,remark)values('" + sid + "','" + userid + "','" + uname + "','" + bank + "','" + ac_num + "','" + ac_holder + "','" + tb + "','" + td + "','" + tot_ded + "','" + tctds + "','" + tcad + "','" + tcnet + "','" + m1 + "','" + y1 + "','" + pa3 + "','" + up3 + "','Null')", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            
            }
            else
            {

               string  m1 = (System.DateTime.Now.Month).ToString();
               string  y1 = (System.DateTime.Now.Year).ToString();

                tot_ded = tb - 200000;
                tb = tb - tot_ded;
                tbd = tb + td;
                tctds = tbd * 10 / 100;
                tcad = tbd * 5 / 100;
                tcnet = tbd - tctds - tcad;

                cmd = new SqlCommand("select * from  tbl_master_deatails where Member_id='" + mem + "'and  Month = month(getdate()) and Year= year(GETDATE())", conn);
                ds.Clear();
                adp = new SqlDataAdapter(cmd);
                adp.Fill(ds, "md1");
                if (ds.Tables["md1"].Rows.Count > 0)
                {
                    conn.Open();
                    cmd = new SqlCommand("update  tbl_master_deatails set Total_binary='" + tb + "',Total_direct='" + td + "',TDS='" + tctds + "',Service='" + tpad + "',total_paid='" + pa3 + "',total_unpaid='" + up3 + "',Net_amount='" + tcnet + "'where Member_id='"+mem+"'and Month='"+m1+"' and Year='"+y1+"'", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                else
                {
                    conn.Open();
                    cmd = new SqlCommand("insert into  tbl_master_deatails(sp_id,Member_id,Member_name,Bank_Name,Acct_number,Acct_holder,Total_binary,total_direct,total_deduction,TDS,Service,Net_amount,Month,Year,total_paid,Total_unpaid,remark)values('" + sid + "','" + userid + "','" + uname + "','" + bank + "','" + ac_num + "','" + ac_holder + "','" + tb + "','" + td + "','" + tot_ded + "','" + tptds + "','" + tpad + "','" + tpnet + "','" + m1 + "','" + y1 + "','" + pa3 + "','" + up3 + "','Null')", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            
        }
        else
        { 
        result="No Data Found";
        }

        conn.Close();
            
    
    }


    public string fetch_binary(string mem)
    { 
        string b1="";
        if (conn.State == ConnectionState.Open)
        {
            conn.Close();
        }
        conn.Open();
        cmd = new SqlCommand("select sum(totalAmount) from tbl_Binarydetails where   (Member_id = '" + mem + "') AND (MONTH(Date) = MONTH(GETDATE())) AND (YEAR(Date) = YEAR(GETDATE()))", conn);
            ds = new DataSet();
            ds.Clear();
            adp = new SqlDataAdapter(cmd);
            adp.Fill(ds, "ch11");
            if (ds.Tables["ch11"].Rows.Count > 0)
            {
                b1 = ds.Tables["ch11"].Rows[0][0].ToString();
                //dpp = dcc / 2;
            }
            else
            {
                b1 = "0.00";
            }
            if (b1 == "")
            {
                b1 = "0.00";
            }

            conn.Close();


            return b1;
        }

       


    

    public string fetch_Refferel(string mem)
    {
        string r1 = "";
        if (conn.State == ConnectionState.Open)
        {
            conn.Close();
        }
        conn.Open();
        cmd = new SqlCommand("select sum(Refferel_income) from tbl_Refferel where  (Member_id = '"+mem+"') AND (MONTH(Income_Date) = MONTH(GETDATE())) AND (YEAR(Income_Date) = YEAR(GETDATE()))", conn);
        ds = new DataSet();
        ds.Clear();
        adp = new SqlDataAdapter(cmd);
        adp.Fill(ds, "ch12");
        if (ds.Tables["ch12"].Rows.Count > 0)
        {
            r1 = ds.Tables["ch12"].Rows[0][0].ToString();
            //dpp = dcc / 2;
        }
        else
        {
            r1 = "0.00";
        }
        if (r1 == "")
        {
            r1 = "0.00";
        }
        conn.Close();


        return r1;
    }

    public string fetch_Spilover(string mem)
    {
        string s1 = "";
        if (conn.State == ConnectionState.Open)
        {
            conn.Close();
        }
        conn.Open();
        cmd = new SqlCommand("select sum(Total_Income) from tbl_spilover where  (Member_id = '"+mem+"') AND (MONTH(Income_date) = MONTH(GETDATE())) AND (YEAR(Income_date) = YEAR(GETDATE()))", conn);
        ds = new DataSet();
        ds.Clear();
        adp = new SqlDataAdapter(cmd);
        adp.Fill(ds, "ch13");
        if (ds.Tables["ch13"].Rows.Count > 0)
        {
            s1 = ds.Tables["ch13"].Rows[0][0].ToString();
            //dpp = dcc / 2;
        }
        else
        {
            s1 = "0.00";
        }
        if (s1 == "")
        {
            s1 = "0.00";
        }
        conn.Close();
        
        return s1;
    }


    public string fetch_Prevbinary(string mem)
    {
        string pb1 = "";
        if (conn.State == ConnectionState.Open)
        {
            conn.Close();
        }
        conn.Open();
        cmd = new SqlCommand("select sum(totalAmount) from tbl_Binarydetails WHERE(Member_Id = '" + mem + "') AND(DATENAME(mm,Date) ) = DATENAME(mm, DATEADD(m, - 1, GETDATE())) AND YEAR(Date) = YEAR(GETDATE())", conn);
        ds = new DataSet();
        ds.Clear();
        adp = new SqlDataAdapter(cmd);
        adp.Fill(ds, "ch14");
        if (ds.Tables["ch14"].Rows.Count > 0)
        {
            pb1 = ds.Tables["ch14"].Rows[0][0].ToString();
            //dpp = dcc / 2;
        }
        else
        {
            pb1 = "0.00";
        }
        if (pb1 == "")
        {
            pb1 = "0.00";
        }
        conn.Close();


        return pb1;
    }






    public string fetch_prevRefferel(string mem)
    {
        string pr1 = "";
        if (conn.State == ConnectionState.Open)
        {
            conn.Close();
        }
        conn.Open();
        cmd = new SqlCommand("select sum(Refferel_income) from tbl_Refferel WHERE(Member_id = '" + mem + "') AND(DATENAME(mm, Income_Date)) = DATENAME(mm, DATEADD(m, - 1, GETDATE())) AND YEAR(Income_Date) = YEAR(GETDATE())", conn);
        ds = new DataSet();
        ds.Clear();
        adp = new SqlDataAdapter(cmd);
        adp.Fill(ds, "ch15");
        if (ds.Tables["ch15"].Rows.Count > 0)
        {
            pr1 = ds.Tables["ch15"].Rows[0][0].ToString();
            //dpp = dcc / 2;
        }
        else
        {
            pr1 = "0.00";
        }
        if (pr1 == "")
        {
            pr1 = "0.00";
        }
        conn.Close();
        return pr1;

    }

    public string fetch_prevSpilover(string mem)
    {
        string ps1 = "";
        if (conn.State == ConnectionState.Open)
        {
            conn.Close();
        }
        conn.Open();
        cmd = new SqlCommand("select sum(Total_Income) from tbl_spilover WHERE(Member_id = '" + mem + "')  AND (DATENAME(mm, Income_Date) = DATENAME(mm, DATEADD(m, - 1, GETDATE()))) AND (YEAR(Income_date) = YEAR(GETDATE()))", conn);
        ds = new DataSet();
        ds.Clear();
        adp = new SqlDataAdapter(cmd);
        adp.Fill(ds, "ch16");
        if (ds.Tables["ch16"].Rows.Count > 0)
        {
            ps1 = ds.Tables["ch16"].Rows[0][0].ToString();
            //dpp = dcc / 2;
        }
        else
        {
            ps1 = "0.00";
        }
        if (ps1 == "")
        {
            ps1 = "0.00";
        }
        conn.Close();


        return ps1;
    }


    public string totalBDPaidcurrent(string memb)
    {
        string tr = "0.00";
        cmd = new SqlCommand("select sum(Total_Paid) From tbls_transactionDetails where (Member_ID='" + memb + "') and transaction_type='BD' and Month(Date)=month(getdate()) and Year(Date)=year(getdate())", conn);
        ds = new DataSet();
        ds.Clear();
        adp = new SqlDataAdapter(cmd);
        adp.Fill(ds, "rr5");
        if (ds.Tables["rr5"].Rows.Count > 0)
        {
            string ss = ds.Tables["rr5"].Rows[0][0].ToString();
            if (ss == "")
            {
                tr = "0.00";

            }
            else
            {
                tr = ds.Tables["rr5"].Rows[0][0].ToString();
            }

        }
        return tr;

    }

    public string totalBDPaidPrevious(string memb)
    {
        string tr = "0.00";
        cmd = new SqlCommand("select sum(Total_Paid) From tbls_transactionDetails where (Member_ID='" + memb + "') and transaction_type='BD' AND (DATENAME(mm,Date)) = DATENAME(mm, DATEADD(m, - 1, GETDATE()))", conn);
        ds = new DataSet();
        ds.Clear();
        adp = new SqlDataAdapter(cmd);
        adp.Fill(ds, "rr5");
        if (ds.Tables["rr5"].Rows.Count > 0)
        {
            string ss = ds.Tables["rr5"].Rows[0][0].ToString();
            if (ss == "")
            {
                tr = "0.00";

            }
            else
            {
                tr = ds.Tables["rr5"].Rows[0][0].ToString();
            }

        }
        return tr;

    }


    public string totalBDUnPaidcurrent(string mem1)
    {
        decimal tup = 0;
        string tup1 = "0.00";
        if (conn.State == ConnectionState.Open)
        {
            cmd = new SqlCommand("select sum(Credit_Amount) From tbl_Accountdetails where (Member_Id = '" + mem1 + "') AND (Income_Type = 'Direct' OR Income_Type = 'Binary') AND (Status = 'Unpaid') and Month(Date)=month(getdate()) and Year(Date)=year(getdate())", conn);
            ds = new DataSet();
            ds.Clear();
            adp = new SqlDataAdapter(cmd);
            adp.Fill(ds, "rr2");
            if (ds.Tables["rr2"].Rows.Count > 0)
            {
                string s3 = ds.Tables["rr2"].Rows[0][0].ToString();
                if (s3 == "")
                {
                    tup = 0;
                }
                else
                {
                    tup = Convert.ToDecimal(s3);
                }
            }
            else
            {
                tup = 0;
            }
            conn.Close();
        }
        else
        {

           conn.Open();
           cmd = new SqlCommand("select sum(Credit_Amount) From tbl_Accountdetails where (Member_Id = '" + mem1 + "') AND (Income_Type = 'Direct' OR Income_Type = 'Binary') AND (Status = 'Unpaid')and Month(Date)=month(getdate()) and Year(Date)=year(getdate())", conn);
            ds = new DataSet();
            ds.Clear();
            adp = new SqlDataAdapter(cmd);
            adp.Fill(ds, "rr2");
            if (ds.Tables["rr2"].Rows.Count > 0)
            {
                string s4 = ds.Tables["rr2"].Rows[0][0].ToString();
                if (s4 == "")
                {
                    tup= 0;
                }
                else
                {
                   tup = Convert.ToDecimal(s4);
                }
            }
            else
            {
                tup = 0;
            }

            conn.Close();
        }
        tup1 = tup.ToString();

        return tup1;

    }

    public string totalBDUnPaidprevious(string mem1)
    {
        decimal tup = 0;
        string tup1 = "0.00";
        if (conn.State == ConnectionState.Open)
        {
            cmd = new SqlCommand("select sum(Credit_Amount) From tbl_Accountdetails where (Member_Id = '" + mem1 + "') AND (Income_Type = 'Direct' OR Income_Type = 'Binary') AND (Status = 'Unpaid') AND (DATENAME(mm, Date)) = DATENAME(mm, DATEADD(m, - 1, GETDATE()))", conn);
            ds = new DataSet();
            ds.Clear();
            adp = new SqlDataAdapter(cmd);
            adp.Fill(ds, "rr2");
            if (ds.Tables["rr2"].Rows.Count > 0)
            {
                string s3 = ds.Tables["rr2"].Rows[0][0].ToString();
                if (s3 == "")
                {
                    tup = 0;
                }
                else
                {
                    tup = Convert.ToDecimal(s3);
                }
            }
            else
            {
                tup = 0;
            }
            conn.Close();
        }
        else
        {

           conn.Open();
            cmd = new SqlCommand("select sum(Credit_Amount) From tbl_Accountdetails where (Member_Id = '" + mem1 + "') AND (Income_Type = 'Direct' OR Income_Type = 'Binary') AND (Status = 'Unpaid')AND (DATENAME(mm, Date)) = DATENAME(mm, DATEADD(m, - 1, GETDATE()))", conn);
            ds = new DataSet();
            ds.Clear();
            adp = new SqlDataAdapter(cmd);
            adp.Fill(ds, "rr2");
            if (ds.Tables["rr2"].Rows.Count > 0)
            {
                string s4 = ds.Tables["rr2"].Rows[0][0].ToString();
                if (s4 == "")
                {
                    tup= 0;
                }
                else
                {
                   tup = Convert.ToDecimal(s4);
                }
            }
            else
            {
                tup = 0;
            }

            conn.Close();
        }
        tup1 = tup.ToString();

        return tup1;

    }

}