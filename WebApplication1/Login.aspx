<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FlightBooking.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 39px;
            left: 312px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 182px;
            left: 312px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 257px;
            left: 348px;
            z-index: 1;
            height: 40px;
            width: 98px;
        }
        .auto-style4 {
            position: absolute;
            top: 90px;
            left: 308px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 137px;
            z-index: 1;
            left: 312px;
        }
    </style>
</head>
<body style="height: 618px; z-index: 1; width: 2583px; position: absolute; top: 0px; left: 0px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="username_txt" runat="server" CssClass="auto-style4"></asp:TextBox>
        <asp:Button ID="login_btn" runat="server" CssClass="auto-style3" OnClick="Button1_Click" Text="Login" />
        <asp:TextBox ID="password_txt" runat="server" CssClass="auto-style2"></asp:TextBox>
        <asp:Label ID="username_lbl" runat="server" CssClass="auto-style1" Text="Username"></asp:Label>
        <p>
            <asp:Label ID="password_lbl" runat="server" CssClass="auto-style5" Text="Password"></asp:Label>
        </p>
    </form>
</body>
</html>
