<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Silme.aspx.cs" Inherits="ödev3.Silme" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 822px">
    <form id="form1" runat="server">
    <div style="height: 40px">
    
        <asp:Panel ID="Panel4" runat="server" Height="40px" HorizontalAlign="Right" BackColor="Black">
            <asp:Button ID="Button1" runat="server" Text="GERİ" PostBackUrl="~/Calisan.aspx" BackColor="Black" BorderColor="Black" Font-Bold="True" ForeColor="White" Height="40px" />
        </asp:Panel>
    
    </div>
        <asp:Panel ID="Panel1" runat="server" Height="400px" HorizontalAlign="Center" BackColor="#CCCCCC">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
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
            <br />
            <asp:Label ID="Label1" runat="server" Text="Fatura ID Gir:"></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="fSilTb" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="fSilBt" runat="server" OnClick="fSilBt_Click" Text="FATURA SİL" Font-Bold="True" />
        </asp:Panel>
        <asp:Panel ID="Panel3" runat="server" Height="400px" HorizontalAlign="Center" BackColor="#CCCCCC" style="margin-top: 1px">
            <br />
            <asp:GridView ID="GridView2" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None">
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
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Çalışan ID Gir:"></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="cSilTb" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="cSilBt" runat="server" Text="ÇALIŞAN SİL" OnClick="cSilBt_Click" Font-Bold="True" />
        </asp:Panel>
    </form>
</body>
</html>
