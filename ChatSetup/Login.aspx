<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Login.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
        <asp:Label ID="Label5" runat="server" BackColor="DimGray" BorderColor="#404040" BorderStyle="Solid"
            BorderWidth="1px" Font-Bold="True" Font-Names="Verdana" Font-Size="Small" ForeColor="White"
            Height="20px" Style="vertical-align: middle; text-align: left" Text="Welcome to Online Library Management"
            Width="948px"></asp:Label><br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    <table>
      <tr>
        <td colspan =2 style="width: 376px">
            <asp:Label ID="Label4" runat="server" BackColor="DimGray" BorderColor="#404040" BorderStyle="Solid"
                BorderWidth="1px" Font-Bold="True" Font-Names="Verdana" Font-Size="Small" ForeColor="White"
                Text="Login" Width="391px" style="vertical-align: middle; text-align: left"></asp:Label></td>
      </tr>
      <tr>
        <td style="text-align: center">
            &nbsp;<asp:Label ID="Label1" runat="server" Font-Names="Verdana" Font-Size="Small"
            Text="Domain Name" Width="105px" style="vertical-align: middle; text-align: left"></asp:Label>
            <asp:TextBox ID="txtDomainName" runat="server" Width="240px" Height="17px"></asp:TextBox>
        </td>
      </tr>
      <tr>
        <td style="text-align: center">               
            &nbsp;<asp:Label ID="Label2" runat="server" Font-Names="Verdana" Font-Size="Small"
            Text="User Name" Width="105px" style="vertical-align: middle; text-align: left"></asp:Label>
            <asp:TextBox ID="txtUserName" runat="server" Width="240px"></asp:TextBox>
        </td>
      </tr>
      <tr>  
        <td style="text-align: center">
            &nbsp;<asp:Label ID="Label3" runat="server" Font-Names="Verdana" Font-Size="Small"
            Text="Password" Width="105px" style="vertical-align: middle; text-align: left"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="240px"></asp:TextBox>
        </td>
      </tr>
      <tr>
        <td style="text-align: right">      
        <asp:Button ID="btnLogon" runat="server" OnClick="btnLogon_Click" Text="Logon" />&nbsp;&nbsp;&nbsp;
        </td>
      </tr>
    </table>
        </div>
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server" Font-Names="Verdana" Font-Size="Small" ForeColor="Red"
            Width="947px" style="vertical-align: middle; text-align: center"></asp:Label>
    </form>
</body>
</html>
