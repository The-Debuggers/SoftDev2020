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
            <p style="font-family: 'Century Gothic'; font-size: large; color: #000000; font-weight: normal; font-style: normal; font-variant: normal; text-transform: none; height: 5px;">Below is your tailored workout plan, built specifically for your needs! Perform each day either once per week or twice</p>
            <p style="font-family: 'Century Gothic'; font-size: large; color: #000000; font-weight: normal; font-style: normal; font-variant: normal; text-transform: none; height: 24px;">per week in a cycle that fits your schedule.</p>
            <p>BMI: 
                <asp:Label ID="bmiLabel" runat="server" Text="Label"></asp:Label>
            </p>
            <p>Pushday:
                <asp:Label ID="push" runat="server" Text="Label"></asp:Label>
            </p>
            <p>Pullday:
                <asp:Label ID="pull" runat="server" Text="Label"></asp:Label>
            </p>
            <p>Legday:
                <asp:Label ID="leg" runat="server" Text="Label"></asp:Label>
            </p>
        </div>
    <p>
        Username:
        <asp:TextBox ID="username" runat="server" Height="19px" Width="140px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="username" ErrorMessage="Username required" ForeColor="Red"></asp:RequiredFieldValidator>
    </p>
    <p>
        Password:
        <asp:TextBox ID="password1" runat="server" Height="19px" Width="140px" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="password1" ErrorMessage="Password required" ForeColor="Red"></asp:RequiredFieldValidator>
    </p>
    <p>
        Confirm Password:
        <asp:TextBox ID="password2" runat="server" Height="19px" Width="140px" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="password2" ErrorMessage="Please confirm password" ForeColor="Red"></asp:RequiredFieldValidator>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="password1" ControlToValidate="password2" ErrorMessage="Passwords must match" ForeColor="Blue"></asp:CompareValidator>
    </p>
        <asp:Button ID="accountButton" runat="server" Text="Submit" OnClick="accountButton_Click" />
    </form>
    </body>
</html>
