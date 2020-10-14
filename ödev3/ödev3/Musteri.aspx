<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Musteri.aspx.cs" Inherits="ödev3.Musteri" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 510px;
        }
    </style>
</head>
<body style="height: 512px">
    <form id="form1" runat="server">
    <div style="height: 40px">
    
        <asp:Panel ID="Panel2" runat="server" Height="40px" HorizontalAlign="Right" BackColor="Black">
            <asp:Button ID="Button1" runat="server" PostBackUrl="~/Calisan.aspx" Text="GERİ" BackColor="Black" BorderColor="Black" Font-Bold="True" ForeColor="White" Height="40px" />
            <asp:Button ID="ındırBt" runat="server" Text="İNDİR" OnClick="ındırBt_Click" BackColor="Black" BorderColor="Black" Font-Bold="True" ForeColor="White" Height="40px" />
        </asp:Panel>
    
    </div>
        <asp:Panel ID="Panel1" runat="server" Height="463px">
            <br />
            <asp:GridView ID="mgGrd" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None">
                <AlternatingRowStyle BackColor="PaleGoldenrod" />
                <FooterStyle BackColor="Tan" />
                <HeaderStyle BackColor="Tan" Font-Bold="True" />
                <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                <SortedAscendingCellStyle BackColor="#FAFAE7" />
                <SortedAscendingHeaderStyle BackColor="#DAC09E" />
                <SortedDescendingCellStyle BackColor="#E1DB9C" />
                <SortedDescendingHeaderStyle BackColor="#C2A47B" />
            </asp:GridView>
        </asp:Panel>
    </form>
</body>
</html>
