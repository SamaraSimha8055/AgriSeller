<%@ Page Language="C#" AutoEventWireup="true" CodeFile="fdm.aspx.cs" Inherits="fdm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <meta http-equiv="content-language" content="de">
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
    <meta name="description" content="Your descrption" lang="de">
    <meta name="keywords" content="Your keywords" lang="de">
    <meta name="abstract" lang="de" content="Your abstract">
    <meta http-equiv="cleartype" content="on">
    <meta name="viewport" content="width=device-width, initial-scale=.96">
    <meta name="apple-mobile-web-app-capable" content="yes">
    <meta name="apple-mobile-web-app-status-bar-style" content="black">
    <meta name="apple-mobile-web-app-title" content="your app title">
    <meta http-equiv="content-type" content="text/html; charset=us-ascii">
    <meta http-equiv="expires" content="86400">
    <meta http-equiv="cache-control" content="no-cache">
    <meta name="pragma" content="cache">
    <meta name="cache-control" content="cache">
    <meta name="MSSmartTagsPreventParsing" content="true">
    <meta name="imagetoolbar" content="false">
    <meta name="format-detection" content="telephone=no">              
    <meta name="author" content="Your author">
    <meta name="publisher" content="Your publisher">
    <meta name="copyright" content="Your responsible">
    <meta name="date" content="2013-08-27">
    <meta name="robots" content="index, follow">
    <meta name="revisit-after" content="30 days">
    <meta http-equiv="content-script-type" content="text/javascript">
    <meta http-equiv="content-script-style" content="text/css">
    <link rev="made" href="mailto:Your email">
    <meta link="shortcut icon" href="favicon.ico">
    <link rel="shortcut icon" href="favicon.ico" type="image/x-icon">
    <link rel="icon" href="favicon.ico" type="image/x-icon">
    
    <meta name="geo.region" content="DE">
    <meta name="DC.title" content="Your website title">
    <title>
      Your website title</title>
    
    <link href="css/styles.css" rel="stylesheet" type="text/css">
    
    <!--[if lt IE 9]>
     <script src="js/html5shiv-printshiv.js"></script>
     <script src="js/css3-mediaqueries.js"></script>
   <![endif]-->
    </head>
  <body style="background-image:url('im/2.jpg');background-repeat: no-repeat;height:100%">
      <form runat="server">
  <br/>
    <a href="#content" class="sr-only"></a>
      <br />    <br />    <br />    <br />  
    <div class="container" id="content" align="center"><h1>
       WELCOME TO FARMER APPLICATION</h1>
       
          </div>
          <br /><br />
          
        
          </div>
      <div class="container" id="content" align="center">
        <table>

            
            <tr>

                <td>
               <asp:Label ID="Label1" runat="server" Text="Uername "></asp:Label> <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
               
            </tr>
            <tr>

                <td>
               <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label> <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    <br />
                    <br />
                </td>
                
            </tr>

        </table>
          </div>
          
        <div class="container" id="content" align="center">
        <table>

            
            <tr>

                <td>
                    <asp:Button ID="Button1" runat="server" Text="Login" BackColor="#339933" OnClick="Button1_Click" Width="138px" />
                    <br />
                    <br />
                    <br />
                    <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/freg.aspx">Registeration</asp:LinkButton>
                </td>
               
            </tr>
            

        </table>
          </div>
          
   <script src="http://code.jquery.com/jquery-1.10.1.min.js"></script>
   <script src="http://code.jquery.com/jquery-migrate-1.2.1.min.js"></script>
   <script>
      if (navigator.userAgent.match(/IEMobile\/10\.0/)) {
          var msViewportStyle = document.createElement("style")
          msViewportStyle.appendChild(
            document.createTextNode(
              "@-ms-viewport{width:auto!important}"
            )
          )
          document.getElementsByTagName("head")[0].appendChild(msViewportStyle)
      }
     if (navigator.userAgent.indexOf('iPhone') != -1) {
        addEventListener("load", function() {
        setTimeout(function() { window.scrollTo(0, 60); }, 0);
     }, false);
  }
        (function(a,b,c){if(c in b&&b[c]){var d,e=a.location,f=/^(a|html)$/i;a.addEventListener("click",function(a){d=a.target;while(!f.test(d.nodeName))d=d.parentNode;"href"in d&&(d.href.indexOf("http")||~d.href.indexOf(e.host))&&(a.preventDefault(),e.href=d.href)},!1)}})(document,window.navigator,"standalone")
   </script>
</form> </body>
</html>