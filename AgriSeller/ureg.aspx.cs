using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;


public partial class ureg : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            MySqlConnection con = new MySqlConnection("Server=127.0.0.1;User id= root;Password=;Database=farm;");
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = " insert into us(unam,pass,mob) values (@nam,@unam, @pass)";
            cmd.Parameters.AddWithValue("@nam", TextBox1.Text);
            cmd.Parameters.AddWithValue("@unam", TextBox2.Text);
            cmd.Parameters.AddWithValue("@pass", TextBox3.Text);


            cmd.ExecuteNonQuery();
            Response.Write("<script>alert('user is sucessfully registered ')</script>");
            con.Close();
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('your are Entering Duplicate value please check it')</script>");

        }
    }


    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("udm.aspx");
    }
}