<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sayfa2.aspx.cs" Inherits="SessionKullanımı.Sayfa2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <table>
           <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Kullanıcı"></asp:Label>
                </td>
                                <td>
                    <asp:Label ID="Label4" runat="server" Text="   "></asp:Label>
                </td>
            </tr>
            <tr>
                  <td>
                    <asp:Label ID="Label2" runat="server" Text="Ziyareçti Sayısı"></asp:Label>
                </td>
                <td></td>
                 <td>
                    <asp:Label ID="Label5" runat="server" Text="0"></asp:Label>
                </td>
              
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="İsim Alana"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click1">Default ASPX</asp:LinkButton>
                </td><td>--------------</td>
                
                <td>
                    <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click1">Sayfa1 ASPX</asp:LinkButton>
                </td><td>--------------</td>
                <td>
                    <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click1">Sayfa2 ASPX</asp:LinkButton>
                </td><td></td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
