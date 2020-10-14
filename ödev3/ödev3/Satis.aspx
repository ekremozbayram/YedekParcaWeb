<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Satis.aspx.cs" Inherits="ödev3.Satis" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 726px;
        }
    </style>
</head>
<body style="height: 692px">
    <form id="form1" runat="server">
    <div style="height: 40px">
    
        <asp:Panel ID="Panel2" runat="server" Height="40px" HorizontalAlign="Right" BackColor="Black">
            <asp:Button ID="fgB" runat="server" Text="FATURA GÖRÜNTÜLE" Height="40px" PostBackUrl="~/Faturalarım.aspx" BackColor="Black" BorderColor="Black" Font-Bold="True" ForeColor="White" />
            <asp:Button ID="scB" runat="server" Text="ÇIKIŞ" Height="40px" PostBackUrl="~/login.aspx" Width="80px" BackColor="Black" BorderColor="Black" Font-Bold="True" ForeColor="White" />
        </asp:Panel>
    
    </div>
        <asp:Panel ID="Panel1" runat="server" Height="425px" HorizontalAlign="Center" BackColor="#CCCCCC">
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="MARKA"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="MODEL"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="PARÇA"></asp:Label>
            <br />
            <br />
            <asp:DropDownList ID="masDDL" runat="server" OnLoad="Page_Load"  style="margin-left: 0px" Width="150px" AutoPostBack="true" OnSelectedIndexChanged="masDDL_SelectedIndexChanged" >
            </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="mosDDL" runat="server" Width="150px" EnablAutoPostBack="true" AutoPostBack="true" OnSelectedIndexChanged="mosDDL_SelectedIndexChanged" >
            </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="pasDDL" runat="server" Width="150px" EnableAutoPostBack="true" OnLoad="pasDDL_SelectedIndexChanged" OnSelectedIndexChanged="pasDDL_SelectedIndexChanged" AutoPostBack="true">
            </asp:DropDownList>
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Font-Bold="True" Text="Adet Fiyatı:"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="fiyatTb" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Adet Giriniz:" Font-Bold="True"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="satTb" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="satBt" runat="server" Text="SATIŞ" OnClick="satBt_Click" />
        </asp:Panel>
        <asp:Panel ID="Panel3" runat="server" Height="186px" HorizontalAlign="Center">
            <br />
            <br />
            <asp:ImageButton ID="ImageButton1" runat="server" Height="100px" ImageUrl="~/Resimler/fiat.jpg" PostBackUrl="http://www.fiat.com.tr/Sayfalar/Anasayfa.aspx" />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton2" runat="server" Height="100px" ImageUrl="~/Resimler/renault.jpg" PostBackUrl="https://www.renault.com.tr/?utm_campaign=TR-r-t-brand-renault_brand//renault-Feb-2017&amp;utm_medium=cpc&amp;utm_source=google&amp;CAMPAIGN=TR-r-t-brand-renault_brand//renault-Feb-2017&amp;ORIGIN=SEA&amp;pRefStr=google|cpc|TR-r-t-brand-renault_brand//renault-Feb-2017|&amp;gclid=EAIaIQobChMIyOTEwJL_1wIVgYKyCh32FwRNEAAYASAAEgJc7vD_BwE" />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton3" runat="server" Height="100px" ImageUrl="~/Resimler/skoda.png" PostBackUrl="http://www.skoda.com.tr/" />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton4" runat="server" Height="100px" ImageUrl="~/Resimler/volkswagen.png" PostBackUrl="http://www.vw.com.tr/?&amp;mkwid=sI0tTHBmi|pcrid|176407128360|pkw|volkswagen|pmt|e|pdv|c|slid||&amp;gclid=EAIaIQobChMIkamHlJL_1wIVAuAYCh2CTAz5EAAYASAAEgJm__D_BwE" />
        </asp:Panel>
    </form>
</body>
</html>
