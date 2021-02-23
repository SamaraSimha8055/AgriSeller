using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
public partial class udm : System.Web.UI.Page
{
    string sss;
    protected void Page_Load(object sender, EventArgs e)
    {
        sss = "APROVED";
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            MySqlConnection con = new MySqlConnection("Server=127.0.0.1;User id= root;Password=;Database=farm;");
            con.Open();
            MySqlCommand ss = new MySqlCommand("select * from us where unam= '" + TextBox1.Text + "' and pass = '" + TextBox3.Text + "' and st='" + sss.ToString() + "' ", con);

            MySqlDataReader dr = ss.ExecuteReader();



            if (dr.Read())
            {

                Session["nam"] = TextBox1.Text;

                if (Session["nam"] != null)
                {
                    Response.Redirect("udsh.aspx");
                }

            }



            else
            {
                Response.Write("<script>alert('invalid login ')</script>");


            }
            con.Close();
        }
        catch (Exception ex)
        {

            Response.Write("<script>alert('Error in Server please refresh')</script>");

        }

    }

}
