<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="OnlineTrainer.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Panel ID="Panel1" runat="server" BackColor="#252526" CssClass="auto-style1" Height="120px">
                <h1 style="font-family: 'Century Gothic'; font-size: 50px; font-weight: normal; color: #FFFF00">Please enter your username and password:<br /></h1>
            </asp:Panel>
        <div>
            <br />
            <font size="5">Username:</font><asp:TextBox ID="username" runat="server" Width="169px"></asp:TextBox>
            <br />
            <br />
            <font size="5">Password:</font><asp:TextBox ID="password" runat="server" TextMode="Password" Width="168px"></asp:TextBox>
        </div>
        <p>
            <asp:Button ID="loginButton" runat="server" Text="Login" BackColor="#3F3F46" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Font-Bold="False" Font-Names="Century Gothic" Font-Size="40pt" ForeColor="#F7FA25" Height="99px" Width="352px" />
        </p>
    </form>
</body>
</html>