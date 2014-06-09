<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="TestWS._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
    <div>
        <p>
            Output from CheckZIP:
            <asp:TextBox ID="tbZIPOutput" runat="server" TextMode="SingleLine" Width="75px" Height="25px" BackColor="Black" ForeColor="Yellow" Font-Bold="true"></asp:TextBox>
        </p>
        <p>
            Output from UBH LeadCatcherWS:
             <asp:TextBox ID="tbOutput" runat="server" TextMode="SingleLine" Width="600px" Height="400px" BackColor="Black" ForeColor="Yellow" Font-Bold="true"></asp:TextBox>
        </p>
        <p>
            Output from German Cities:
            <asp:TextBox ID="tbGermanCities" runat="server" TextMode="MultiLine" Width="600px" Height="400px" BackColor="Black" ForeColor="Yellow" Font-Bold="true"></asp:TextBox>
        </p>
               
    </div>
    </form>
</body>
</html>
