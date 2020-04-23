<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="OnlineTrainer.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            username:<asp:TextBox ID="username" runat="server"></asp:TextBox>
            <br />
            password:<asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        <p>
            <asp:Button ID="loginButton" runat="server" Text="Login" />
        </p>
    </form>
</body>
</html>
