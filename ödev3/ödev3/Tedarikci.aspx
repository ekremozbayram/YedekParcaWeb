<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tedarikci.aspx.cs" Inherits="ödev3.Tedarikci" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 672px">
    <form id="form1" runat="server">
    <div style="height: 40px">
    
        <asp:Panel ID="Panel2" runat="server" HorizontalAlign="Right" BackColor="Black" Height="40px">
            <asp:Button ID="Button1" runat="server" PostBackUrl="~/Calisan.aspx" Text="GERİ" BackColor="Black" BorderColor="Black" Font-Bold="True" ForeColor="White" Height="40px" />
            <asp:Button ID="ptIndır" runat="server" Text="İNDİR" OnClick="ptIndır_Click" BackColor="Black" BorderColor="Black" Font-Bold="True" ForeColor="White" Height="40px" />
        </asp:Panel>
    
    </div>
        <asp:Panel ID="Panel1" runat="server" Height="509px">
            <br />
            <asp:GridView ID="tgGrd" runat="server" CellPadding="2" ForeColor="Black" GridLines="None" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px">
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
        <asp:Panel ID="Panel3" runat="server" BackColor="#CCCCCC" Height="138px" HorizontalAlign="Center">
            <br />
            <asp:ImageButton ID="ImageButton1" runat="server" Height="100px" ImageUrl="~/Resimler/adagroup.png" PostBackUrl="https://www.dinamikotomotiv.com.tr/" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton2" runat="server" Height="100px" ImageUrl="~/Resimler/arifoto.jpg" PostBackUrl="https://www.yedekparcacin.com/" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton3" runat="server" Height="100px" ImageUrl="~/Resimler/global.png" PostBackUrl="http://www.globalotomotiv.com/" />
            &nbsp;</asp:Panel>
    </form>
</body>
</html>
