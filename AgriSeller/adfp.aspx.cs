using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

public partial class adfp : System.Web.UI.Page
{
    string s11, s12;
    protected void Page_Load(object sender, EventArgs e)
    {
        string ss = "pending";
        MySqlConnection con = new MySqlConnection("Server=127.0.0.1;User id= root;Password=;Database=farm;");
        con.Open();
        MySqlCommand cmd = con.CreateCommand();
        cmd.CommandType = System.Data.CommandType.Text;
        cmd.CommandText = "select * from far where st='" + ss + "'";
        cmd.ExecuteNonQuery();
        DataTable dt = new DataTable();
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        da.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
    protected void onrow(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "sroll")
        {
            try
            {


                s11 = "APROVED";
                int crow;
                crow = Convert.ToInt32(e.CommandArgument.ToString());
                string v = GridView1.Rows[crow].Cells[2].Text;

                MySqlConnection con = new MySqlConnection("Server=127.0.0.1;User id= root;Password=;Database=farm;");
                con.Open();


                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "update far SET st='" + s11 + "' where fn='" + v + "'";
                cmd.ExecuteNonQuery();



                con.Close();

            }
            catch (Exception ex)
            {

                Response.Write("<script>alert('your are Entering Duplicate value please check it')</script>");

            }


        }
        if (e.CommandName == "sname")
        {
            try
            {


                s12 = "REJECT";
                int crow;
                crow = Convert.ToInt32(e.CommandArgument.ToString());
                string v = GridView1.Rows[crow].Cells[2].Text;


                MySqlConnection con = new MySqlConnection("Server=127.0.0.1;User id= root;Password=;Database=farm;");
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "update far SET st='" + s12 + "' where fn='" + v + "'";
                cmd.ExecuteNonQuery();
                con.Close();
            }


            catch (Exception ex)
            {

                Response.Write("<script>alert('your are Entering Duplicate value please check it')</script>");
            }

        }
    }
}