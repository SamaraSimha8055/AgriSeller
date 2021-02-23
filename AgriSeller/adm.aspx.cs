using System;
using System.Collections.Generic;
using System.Web.UI;
using System.IO;
using System.Text;
using System.Data;


using System.Net;
using System.Net.Mail;
using System.Activities.Expressions;
using System.Net.Mime;
using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;

public partial class adm : System.Web.UI.Page
{
    string randomNumber;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            Random generator = new Random();
            randomNumber = generator.Next(0, 1000000).ToString("D6");
            WebClient client = new WebClient();
            string baseurl = "https://www.txtguru.in/imobile/api.php?username=kgvgowrish&password=Thylak@123&source=VIDGAN&dmobile=" + 9182828678+ " &unicode=false&flash=false&message=" + "Admin OTP" + '\n' + randomNumber + '\n';

            Stream data = client.OpenRead(baseurl);
            StreamReader reader = new StreamReader(data);
            string s21 = reader.ReadToEnd();
            data.Close();
            reader.Close();
            Response.Write("<script>alert('OTP is sucessfully Generated ')</script>");
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('Please Refresh ')</script>");

        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        try
        {
            if (randomNumber != TextBox1.Text)
            {
                Response.Redirect("admpa.aspx");
            }
            else
            {
                Response.Write("<script>alert('invalid username  and  password')</script>");

            }

        }
        catch (Exception ex)
        {
            Response.Write("please refresh");
        }
    }
}