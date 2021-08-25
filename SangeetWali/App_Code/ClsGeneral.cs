using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

/// <summary>
/// Summary description for ClsGeneral
/// </summary>
public class ClsGeneral
{
    
	public ClsGeneral()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    
    private string _ConStr;
    public string ConStr
    {
        get { return _ConStr; }
        set { _ConStr = value; }
    }
    private string _UserName;
    public string Username
    {
        get { return _UserName; }
        set { _UserName = value; }
    }
    private string _UserTypeKey;
    public string UserTypeKey
    {
        get { return _UserTypeKey; }
        set { _UserTypeKey = value; }
    }
    private Int16 _SellerKey;
    public Int16 Sellerkey
    { 
         get { return _SellerKey; }
         set { _SellerKey = value; }
    }
    private Int16 _Customerkey;
    public Int16 CustomerKey
    {
        get { return _Customerkey; }
        set { _Customerkey = value; }
    }
    public string GetConstr()
    {
        ConStr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
        return ConStr;
    }
    public void BindDDL(DropDownList ddlname, DataSet ds, string ValueMember, string DesplayMember)
    {
        ddlname.DataSource = ds;
        ddlname.DataValueField = ValueMember;
        ddlname.DataTextField = DesplayMember;
        ddlname.DataBind();
        ddlname.Items.Insert(0, new ListItem("Select..","0"));
    }
    public DataSet GetData(string Sqlstmnt)
    {
        try
        {
            SqlConnection con = new SqlConnection(GetConstr());
            SqlCommand cmd = new SqlCommand(Sqlstmnt, con);
            con.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            con.Close();
            return ds;
        }
        catch (Exception x)
        {
            throw x;
        }
    }
    public int ExNonQuery(string Sqlscrpt)
    {
        try
        {

            SqlConnection con = new SqlConnection(GetConstr());
            SqlCommand cmd = new SqlCommand(Sqlscrpt, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        catch (Exception x)
        {
            throw x;
        }
    }
    public string ExScaler(string Sqlscrpt)
    {
        try
        {

            SqlConnection con = new SqlConnection(GetConstr());
            SqlCommand cmd = new SqlCommand(Sqlscrpt, con);
            con.Open();
            string str = Convert.ToString(cmd.ExecuteScalar());
            con.Close();
            return str;
        }
        catch (Exception x)
        {
            throw x;
        }
    }
    public string GetException(Exception x)
    {
        if (x.ToString().ToLower().Contains("primary") == true)
            return "Duplicate Entry not allowed!";
        else
            return x.ToString();
    }
    public DataSet ValidateLogin(string UserName, string Password)
    {
        SqlConnection con = new SqlConnection(GetConstr());
        //string str = "";
        SqlCommand Cmd = new SqlCommand("DMP_GetLogin", con);
        Cmd.CommandType = CommandType.StoredProcedure;
        Cmd.Parameters.AddWithValue("@Action", 1);
        Cmd.Parameters.AddWithValue("@Username", UserName);
        Cmd.Parameters.AddWithValue("@Password", Password);
        DataSet ds = new DataSet();
        SqlDataAdapter ad = new SqlDataAdapter(Cmd);
        con.Open();
        ad.Fill(ds);
        con.Close();
        return ds;
    }
}

public class Checklist
{
    private Int16 ItemKey;
    public Int16 _ItemKey
    { get { return _ItemKey; }
        set { _ItemKey = value; }
    }
    private string ItemName;
    public string _ItemName
    {
        get { return _ItemName; }
        set { _ItemName = value; }
    }
    public string _ItemCode
    {
        get { return _ItemCode; }
        set { _ItemCode = value; }
    }
    public string _ItemPrice
    {
        get { return _ItemPrice; }
        set { _ItemPrice = value; }
    }
    public string _ItemDiscount
    {
        get { return _ItemDiscount; }
        set { _ItemDiscount = value; }
    }
}