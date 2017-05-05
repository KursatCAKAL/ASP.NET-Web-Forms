<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Defult.aspx.cs" Inherits="ASP.NET_POSTBACK.Defult" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div>
        <table>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Ad"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtAd" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Soyad"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtSoyad" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Cinsiyet"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlCinsiyet" runat="server"></asp:DropDownList>
                </td>
            </tr>
               <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Doğum Tarihi"></asp:Label>
                </td>
                <td>
                    <asp:Calendar CssClass="sd"  ID="cldDogum" runat="server"></asp:Calendar>
                </td>
               </tr>
        

               <tr>
                <td>
                </td>
                <td>
                    <asp:Button ID="Button2" runat="server" Text="Kaydet" OnClick="Button2_Click" />
                </td>
            </tr>
        </table>
      <%--  <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>--%>
    </div>
    </div>
    </form>
</body>
</html>
