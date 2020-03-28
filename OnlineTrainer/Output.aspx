<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Output.aspx.cs" Inherits="OnlineTrainer.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Your fitness plan</h1></div>
    <p>
        Estimated Time Range:
        <asp:Label ID="TimeLabel" runat="server" Text="[Time Estimate]"></asp:Label>
    </p>
    <p>
        Daily Calorie Intake:
        <asp:Label ID="CalorieLabel" runat="server" Text="[Number of calories]"></asp:Label>
    </p>
    </form>
    </body>
</html>
