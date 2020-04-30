<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OutputExist.aspx.cs" Inherits="OnlineTrainer.OutputExist" %>

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
            <p style="font-family: 'Century Gothic'; font-size: large; color: #000000; font-weight: normal; font-style: normal; font-variant: normal; text-transform: none; height: 5px;">Below is your tailored workout plan, built specifically for your needs! Perform each day either once per week or twice</p>
            <p style="font-family: 'Century Gothic'; font-size: large; color: #000000; font-weight: normal; font-style: normal; font-variant: normal; text-transform: none; height: 24px;">per week in a cycle that fits your schedule.</p>
            <p>BMI: 
                <asp:Label ID="bmiLabel" runat="server" Text="Label"></asp:Label>
            </p>
            <p><strong>Push Day</strong>:
                <asp:Label ID="push" runat="server" Text="Label"></asp:Label>
            </p>
            <p><strong>Pull Day</strong>:
                <asp:Label ID="pull" runat="server" Text="Label"></asp:Label>
            </p>
            <p><strong>Leg Day</strong>:
                <asp:Label ID="leg" runat="server" Text="Label"></asp:Label>
            </p>
            <p>&nbsp;</p>
        </div>
        <p>
            <asp:Button ID="logoutButton" runat="server" BackColor="#3F3F46" Font-Names="Century Gothic" ForeColor="Yellow" OnClick="logoutButton_Click" Text="Logout" />
        </p>
    </form>
    </body>
</html>

