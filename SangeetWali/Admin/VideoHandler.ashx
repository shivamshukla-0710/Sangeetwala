<%@ WebHandler Language="C#" Class="VideoHandler" %>

using System;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public class VideoHandler : IHttpHandler 
{
    
    public void ProcessRequest (HttpContext context) 
    {
        string connectionString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;

        SqlConnection connection = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand("SELECT Video, Video_Name FROM Videos WHERE ID = @id", connection);
        cmd.Parameters.Add("@id", SqlDbType.Int).Value = context.Request.QueryString["id"];
        try
        {
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    context.Response.ContentType = reader["Video_Name"].ToString();
                    context.Response.BinaryWrite((byte[])reader["Video"]);
                }
            }
        }
        finally
        {
            connection.Close();
        }
    }
 
    public bool IsReusable 
    {
        get {
            return false;
        }
    }

}