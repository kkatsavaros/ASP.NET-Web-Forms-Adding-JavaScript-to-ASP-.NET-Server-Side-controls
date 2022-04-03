<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="s01.JavascriptToAspNetServerSideControls.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>


            <asp:ImageButton ID="ImageButton1" runat="server"
                ImageUrl="/Images/blueButton.png"
                OnClick="ImageButton1_Click" />

        </div>
    </form>
</body>
</html>
