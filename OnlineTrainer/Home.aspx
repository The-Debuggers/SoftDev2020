<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="OnlineTrainer.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1> Online Trainer</h1>
            <p> &nbsp;</p>
        </div>
        <p>
            With this crazy Corona Virus, lets offer you a way to have a great workout from home! It is always important to stay healthy, so let us help with that.</p>
        <p>
            To get started, select whether you would like to get toned and lose weight, or rather build muscle and gain weight.</p>
        <p>
            &nbsp;</p>
        <p>
            Would you like to:</p>
        <p>
            <asp:Button ID="buttonLose" runat="server" Text="Lose Weight" OnClick="buttonLose_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="buttonGain" runat="server" Text="Gain Weight" OnClick="buttonGain_Click" style="height: 26px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <!-- So i thought this would be a quick way to add in that elelment of saving data over different pages that Han seemed to like, not sure what you guys will think of it,
                but we can change it up anytime. The idea is though, that you'll start on the home page (home.aspx) and then select your desired goal, then itll 
                lead you to the next page (Inputs.aspx) where you input your body characteristics.  -->
        </p>
    </form>
</body>
</html>
