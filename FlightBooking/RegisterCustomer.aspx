<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterCustomer.aspx.cs" Inherits="FlightBooking.RegisterCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 583px;
            width: 384px;
            position: absolute;
            top: 122px;
            left: 253px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 14px;
            left: 12px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 112px;
            left: 13px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 215px;
            left: 18px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 371px;
            left: 81px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 62px;
            left: 21px;
            z-index: 1;
        }
        .auto-style7 {
            position: absolute;
            top: 165px;
            left: 22px;
            z-index: 1;
        }
        .auto-style8 {
            position: absolute;
            top: 272px;
            left: 16px;
            z-index: 1;
        }
        .auto-style9 {
            position: absolute;
            top: 332px;
            left: 14px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <asp:Label ID="name_lbl" runat="server" CssClass="auto-style2" Text="Name"></asp:Label>
            <asp:Label ID="register_username_lbl" runat="server" CssClass="auto-style3" Text="Username"></asp:Label>
            <asp:Label ID="register_password_lbl" runat="server" CssClass="auto-style4" Text="Password"></asp:Label>
            <asp:Button ID="register_btn" runat="server" CssClass="auto-style5" OnClick="register_btn_Click" Text="Register" />
            <asp:TextBox ID="register_name_txt" runat="server" CssClass="auto-style6"></asp:TextBox>
            <asp:TextBox ID="register_username_txt" runat="server" CssClass="auto-style7"></asp:TextBox>
            <asp:TextBox ID="register_password_txt" runat="server" CssClass="auto-style8"></asp:TextBox>
            <asp:Label ID="error_lbl" runat="server" CssClass="auto-style9"></asp:Label>
        </div>
    </form>
</body>
</html>
