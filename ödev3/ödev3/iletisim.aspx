<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="iletisim.aspx.cs" Inherits="ödev3.iletisim" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 640px">
    <form id="form1" runat="server">
    <div style="height: 40px">
    
        <asp:Panel ID="Panel2" runat="server" BackColor="Black" Height="40px" HorizontalAlign="Right">
            <asp:Button ID="Button1" runat="server" Text="ANASAYFA" BackColor="Black" BorderColor="Black" Font-Bold="True" ForeColor="White" Height="40px" PostBackUrl="~/login.aspx" />
        </asp:Panel>
    
    </div>
        <asp:Panel ID="Panel1" runat="server" Height="400px" Width="1000px">
            <br />
            <asp:ImageMap ID="ImageMap1" runat="server" Height="400px" HotSpotMode="Navigate" ImageUrl="~/Resimler/harita.png" Width="1000px">
                <asp:CircleHotSpot NavigateUrl="https://unluoto.com.tr/" Radius="40" X="355" Y="140" />
            </asp:ImageMap>
        </asp:Panel>
        <asp:Panel ID="Panel3" runat="server" Height="158px" HorizontalAlign="Center">
            <br />
            <br />
            <br />
            ŞAHİNLER OTO YEDEK PARÇA<br /> ŞAŞMAZ SANAYİ BÖLGESİ<br /> ANKARA<br /> (0312) 278 7576</asp:Panel>
    </form>
</body>
</html>
