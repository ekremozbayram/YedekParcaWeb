<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KullaniciEkle.aspx.cs" Inherits="ödev3.KullaniciEkle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Yedek Parça Satış</title>
</head>
<body style="height: 434px">
    <form id="form1" runat="server">
    <div style="height: 40px">
    
        <asp:Panel ID="Panel2" runat="server" Height="40px" HorizontalAlign="Right" BackColor="Black">
            <asp:Button ID="anasayfaB" runat="server" Text="ANASAYFA" Height="40px" PostBackUrl="~/login.aspx" BackColor="Black" BorderColor="Black" Font-Bold="True" ForeColor="White" />
        </asp:Panel>
    
    </div>
        <asp:Panel ID="Panel1" runat="server" Height="391px" HorizontalAlign="Center" BackColor="#CCCCCC">
            <br />
            <asp:Label ID="Label6" runat="server" Text="YENİ KULLANICI"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="TC NO:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="ykIdT" runat="server" TabIndex="1"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="ADI:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="ykAdiT" runat="server" TabIndex="2"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="SOYADI:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="ykSoyadiT" runat="server" TabIndex="3"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="TEL NO:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="ykNoT" runat="server" TabIndex="4"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="ŞİFRE:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="ykSifreT" runat="server" TabIndex="5"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="ykEkleB" runat="server" Height="36px" OnClick="ykEkleB_Click" Text="EKLE" Width="89px" Font-Bold="True" TabIndex="6" />
        </asp:Panel>
    </form>
</body>
</html>
