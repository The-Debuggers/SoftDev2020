<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Output.aspx.cs" Inherits="OnlineTrainer.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {}
    </style>
</head>
<body>
    <form id="form1" runat="server" style="font-family: 'Century Gothic'; font-size: xx-large; font-weight: normal; font-style: normal; font-variant: normal; text-transform: none; color: #000000">
        <div>
            <asp:Panel ID="Panel1" runat="server" BackColor="#252526" CssClass="auto-style1" Height="120px">
                <h1 style="font-family: 'Century Gothic'; font-size: 70px; font-weight: normal; font-style: normal; color: #FFFF00">Your fitness plan</h1>
            </asp:Panel>
            <p style="font-family: 'Century Gothic'; font-size: large; color: #000000; font-weight: normal; font-style: normal; font-variant: normal; text-transform: none;">&nbsp;</p>
            <p style="font-family: 'Century Gothic'; font-size: large; color: #000000; font-weight: normal; font-style: normal; font-variant: normal; text-transform: none;">&nbsp;</p>
            <p style="font-family: 'Century Gothic'; font-size: large; color: #000000; font-weight: normal; font-style: normal; font-variant: normal; text-transform: none;">Below is your tailored workout plan, built specifically for your needs!</p>
            <p style="font-family: 'Century Gothic'; font-size: large; color: #000000; font-weight: normal; font-style: normal; font-variant: normal; text-transform: none;">&nbsp;</p></div>
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
