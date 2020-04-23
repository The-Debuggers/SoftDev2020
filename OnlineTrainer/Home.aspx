<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="OnlineTrainer.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {}
        .auto-style3 {
            width: 1669px;
        }
        .auto-style5 {}
        .auto-style6 {
            margin-left: 40px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server" BackColor="#252526" BorderStyle="None" BorderWidth="0px" CssClass="auto-style1" ForeColor="Silver" GroupingText="The Debuggers" Height="150px" HorizontalAlign="Left" Width="1287px">
                <h1 style="font-family: 'Century Gothic'; font-size: 70px; font-weight: normal; font-style: normal; color: #FFFF00; width: 1288px; text-transform: uppercase;">Online Trainer</h1>
            </asp:Panel>
            <p> &nbsp;</p>
            <p> &nbsp;</p>
        </div>
        <p style="font-size: xx-large; color: #000000; font-family: 'Century Gothic'; empty-cells: show; margin-left: 40px;">
            To get started, select whether you would like to get toned and lose weight, or rather build muscle and gain weight.</p>
        <p style="font-family: 'Century Gothic'; font-size: x-large; font-weight: normal; color: #000000; margin-left: 40px;">
            With this dangerous Corona Virus, lets offer you a way to have a great workout from home! It is always important to stay healthy, so let us help with that.</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p style="font-family: 'Century Gothic'; font-size: xx-large; font-style: italic; color: #000000">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            Would you like to:</p>
        <p aria-hidden="False" hidden="hidden">
            &nbsp;&nbsp;</p>
        <p hidden="hidden">
            &nbsp;</p>
        <asp:Panel ID="Panel2" runat="server" BackColor="#252526" CssClass="auto-style5" Height="29px" Width="1287px">
        </asp:Panel>
        <p class="auto-style6">
            <asp:Button ID="buttonLose" runat="server" Text="Lose Weight" OnClick="buttonLose_Click" BackColor="#3F3F46" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" CssClass="auto-style3" Font-Bold="False" Font-Names="Century Gothic" Font-Size="40pt" Font-Underline="False" ForeColor="Yellow" Height="100px" Width="600px" />
            <asp:Button ID="buttonGain" runat="server" Text="Gain Weight" OnClick="buttonGain_Click" BackColor="#3F3F46" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Font-Bold="False" Font-Names="Century Gothic" Font-Size="40pt" ForeColor="#F7FA25" Height="100px" Width="600px" />
        </p>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
