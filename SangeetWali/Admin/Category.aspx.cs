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
using System.Drawing;


public partial class Admin_Category : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myconnectionstring"].ConnectionString);

    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            bindcategory();
        }
    }
    protected void bindcategory()
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("Select * from Category order by category", con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        con.Close();
        if (ds.Tables[0].Rows.Count > 0)
        {
            gvDetails.DataSource = ds;
            gvDetails.DataBind();
        }
        else
        {
            ds.Tables[0].Rows.Add(ds.Tables[0].NewRow());
            gvDetails.DataSource = ds;
            gvDetails.DataBind();
            int columncount = gvDetails.Rows[0].Cells.Count;
            gvDetails.Rows[0].Cells.Clear();
            gvDetails.Rows[0].Cells.Add(new TableCell());
            gvDetails.Rows[0].Cells[0].ColumnSpan = columncount;
            gvDetails.Rows[0].Cells[0].Text = "No Records Found";
        }
    }
    protected void gvDetails_RowEditing(object sender, GridViewEditEventArgs e)
    {
        gvDetails.EditIndex = e.NewEditIndex;
        bindcategory();
    }
    protected void gvDetails_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        int id = Convert.ToInt32(gvDetails.DataKeys[e.RowIndex].Values["id"].ToString());
        TextBox txtUsrname = (TextBox)gvDetails.FooterRow.FindControl("txtftrusrname");
        con.Open();
        SqlCommand cmd = new SqlCommand("update Category set category='" + txtUsrname.Text + "' where id=" + id, con);
        cmd.ExecuteNonQuery();
        con.Close();
        lblresult.ForeColor = Color.Green;
        lblresult.Text =  " Details Updated successfully";
        gvDetails.EditIndex = -1;
        bindcategory();
    }
    protected void gvDetails_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        gvDetails.EditIndex = -1;
        bindcategory();
    }
    protected void gvDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int id = Convert.ToInt32(gvDetails.DataKeys[e.RowIndex].Values["id"].ToString());
        con.Open();
        SqlCommand cmd = new SqlCommand("delete from Category where id=" + id, con);
        int result = cmd.ExecuteNonQuery();
        con.Close();
        if (result == 1)
        {
            bindcategory();
            lblresult.ForeColor = Color.Red;
            lblresult.Text =" details deleted successfully";
        }
    }
    protected void gvDetails_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName.Equals("AddNew"))
        {
            TextBox txtUsrname = (TextBox)gvDetails.FooterRow.FindControl("txtftrusrname");
            
            con.Open();
            SqlCommand cmd =
            new SqlCommand(
            "insert into Category(category) values('" + txtUsrname.Text + "')", con);
            int result = cmd.ExecuteNonQuery();
            con.Close();
            if (result == 1)
            {
                bindcategory();
                lblresult.ForeColor = Color.Green;
                lblresult.Text = " Details Inserted Successfully";
            }
            else
            {
                lblresult.ForeColor = Color.Red;
                lblresult.Text =  " Details not Inserted";
            }
        }
    }
    protected void gvDetails_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}