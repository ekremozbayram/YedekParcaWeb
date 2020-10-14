<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Faturalarım.aspx.cs" Inherits="ödev3.Faturalarım" EnableEventValidation="False"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 1033px">
    <form id="form1" runat="server">
    <div style="height: 40px">
    
        <asp:Panel ID="Panel3" runat="server" Height="40px" HorizontalAlign="Right" BackColor="Black">
            <asp:Button ID="fYazBt" runat="server" OnClick="fYazBt_Click" Text="YAZDIR" BackColor="Black" BorderColor="Black" Font-Bold="True" ForeColor="White" Height="40px" />
            <asp:Button ID="fCıkBt" runat="server" Text="GERİ" PostBackUrl="~/Satis.aspx" BackColor="Black" BorderColor="Black" Font-Bold="True" ForeColor="White" Height="40px" />
        </asp:Panel>
    
    </div>
        <asp:Panel ID="Panel1" runat="server" Height="400px" HorizontalAlign="Center" OnLoad="Page_Load" BackColor="#CCCCCC" BorderColor="White">
            <br />
            <asp:GridView ID="GridView1" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None">
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
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Fatura ID Giriniz:"></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="fGorTb" runat="server"></asp:TextBox>
            &nbsp;&nbsp;
            <asp:Button ID="fGorBt" runat="server" OnClick="fGorBt_Click" Text="GÖSTER" />
            <br />
            <br />
            <br />
            <br />
            <br />
        </asp:Panel>
        <asp:Panel ID="fPa" runat="server" Height="400px" BackColor="#CCCCCC">
            <br />
            <asp:GridView ID="fGv" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None">
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
