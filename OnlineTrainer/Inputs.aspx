<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inputs.aspx.cs" Inherits="OnlineTrainer.Inputs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="font-family: 'Century Gothic'; font-size: 30px; font-weight: normal; color: #FFFF00">Input your infromation<br /></h1>
            <br />
            <br />
            Height:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="heightFT" runat="server" Width="60px"></asp:TextBox>ft
            <asp:TextBox ID="heightIN" runat="server" Width="60px"></asp:TextBox>in
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*Height in feet required" ForeColor="Red" ControlToValidate="heightFT"></asp:RequiredFieldValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="heightIN" ErrorMessage="*Height in inches required" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:CustomValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="heightFT" ErrorMessage="*Values must be a whole number" ForeColor="Blue" OnServerValidate="verifyNumber" ClientValidationFunction="verifyNumber"></asp:CustomValidator>
            <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="heightIN" ErrorMessage="*Values must be a whole number" ForeColor="Blue" OnServerValidate="verifyNumber" ClientValidationFunction="verifyNumber"></asp:CustomValidator>
            <br />
            <br />
            Weight:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="weight" runat="server"></asp:TextBox>
            lbs<asp:CustomValidator ID="CustomValidator2" runat="server" ErrorMessage="*Value must be a number" ForeColor="Blue" OnServerValidate="verifyNumber" ControlToValidate="weight"></asp:CustomValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="weight" ErrorMessage="*Weight required" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            Age:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="age" runat="server"></asp:TextBox>
            yrs
            <asp:CustomValidator ID="CustomValidator3" runat="server" ErrorMessage="*Value must be a whole number" ForeColor="Blue" OnServerValidate="verifyNumber" ControlToValidate="age"></asp:CustomValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="age" ErrorMessage="*Age required" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            Sex:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*Sex required" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;<asp:RadioButtonList ID="sex" runat="server" Width="113px">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:RadioButtonList>
            <br />
        </div>
        <p>
            <asp:Button ID="submitButton" runat="server" OnClick="submitButton_Click" Text="SEE YOUR PLAN!" />
        </p>
    </form>
</body>
</html>
