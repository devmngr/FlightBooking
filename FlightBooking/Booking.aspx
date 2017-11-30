<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Booking.aspx.cs" Inherits="FlightBooking.Booking" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 194px;
            left: 832px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 63px;
            left: 54px;
            z-index: 1;
            width: 722px;
            height: 363px;
        }
        .auto-style3 {
            position: absolute;
            top: 283px;
            left: 839px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 451px;
            left: 152px;
            z-index: 1;
            width: 371px;
            height: 43px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="book_flight_btn" runat="server" CssClass="auto-style1" OnClick="book_flight_btn_Click" Text="Book Flight" />
        <asp:ListBox ID="flights_list_box" runat="server" CssClass="auto-style2"></asp:ListBox>
        <asp:Button ID="logout_btn" runat="server" CssClass="auto-style3" OnClick="Button1_Click" Text="Log Out" />
        <asp:Label ID="info_lbl" runat="server" CssClass="auto-style4"></asp:Label>
    </form>
</body>
</html>
