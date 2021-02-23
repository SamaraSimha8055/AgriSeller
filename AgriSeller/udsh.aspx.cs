using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

public partial class udsh : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        MySqlConnection con = new MySqlConnection("Server=127.0.0.1;User id= root;Password=;Database=farm;");
        con.Open();
        MySqlCommand cmd = con.CreateCommand();
        cmd.CommandType = System.Data.CommandType.Text;
        cmd.CommandText = "select * from pr ";
        cmd.ExecuteNonQuery();
        DataTable dt = new DataTable();
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        da.Fill(dt);
        Repeater1.DataSource = dt;
        Repeater1.DataBind();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Write("<script>alert('You Sucessfully Placed Order ')</script>");
    }
}