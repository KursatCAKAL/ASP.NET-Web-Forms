<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sayfa1.aspx.cs" Inherits="SessionKullanımı.Sayfa1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 184px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label3" runat="server" Text="Kullanıcı"></asp:Label>
                </td>
                                <td>
                    <asp:Label ID="Label4" runat="server" Text="   "></asp:Label>
                </td>
            </tr>
            <tr>
                  <td class="auto-style1">
                    <asp:Label ID="Label1" runat="server" Text="Ziyareçti Sayısı"></asp:Label>
                </td>
                <td></td>
                 <td>
                    <asp:Label ID="Label2" runat="server" Text="0"></asp:Label>
                </td>
              
            </tr>
            <tr>
                <td class="auto-style1">
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
