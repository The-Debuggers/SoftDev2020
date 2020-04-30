﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Output.aspx.cs" Inherits="OnlineTrainer.WebForm1" %>

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
            <p style="font-family: 'Century Gothic'; font-size: large; color: #000000; font-weight: normal; font-style: normal; font-variant: normal; text-transform: none; height: 13px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label1" runat="server" BackColor="Red" ForeColor="White" Text="Pushday"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label2" runat="server" BackColor="#0066CC" ForeColor="White" Text="Pullday"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label3" runat="server" BackColor="#336600" ForeColor="White" Text="Legday"></asp:Label>
            </p>
            <p style="font-family: 'Century Gothic'; font-size: large; color: #000000; font-weight: normal; font-style: normal; font-variant: normal; text-transform: none; height: 26px;">&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label4" runat="server" BorderColor="#FF3300" BorderStyle="Solid" BorderWidth="1px" Text="Exercise"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label5" runat="server" BorderColor="#FF3300" BorderStyle="Solid" BorderWidth="1px" Text="Muscle Group"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label6" runat="server" BorderColor="#FF3300" BorderStyle="Solid" BorderWidth="1px" Text="Category"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label7" runat="server" BorderColor="#0066FF" BorderStyle="Solid" BorderWidth="1px" Text="Exercise"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label8" runat="server" BorderColor="#0066FF" BorderStyle="Solid" BorderWidth="1px" Text="Muscle Group"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label9" runat="server" BorderColor="#0066FF" BorderStyle="Solid" BorderWidth="1px" Text="Category"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label10" runat="server" BorderColor="#336600" BorderStyle="Solid" BorderWidth="1px" Text="Exercise"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label11" runat="server" BorderColor="#336600" BorderStyle="Solid" BorderWidth="1px" Text="Muscle Group"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label12" runat="server" BorderColor="#336600" BorderStyle="Solid" BorderWidth="1px" Text="Category"></asp:Label>
            </p>
            <p style="font-family: 'Century Gothic'; font-size: large; color: #000000; font-weight: normal; font-style: normal; font-variant: normal; text-transform: none; height: 40px;">&nbsp;</p>
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
