<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calisan.aspx.cs" Inherits="ödev3.Calisan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 583px">
    <form id="form1" runat="server">
    <div style="height: 40px">
    
        <asp:Panel ID="Panel1" runat="server" Height="40px" HorizontalAlign="Right" BackColor="Black">
            <asp:Button ID="silBt" runat="server" Height="40px" PostBackUrl="~/Silme.aspx" Text="SİL" Width="80px" BackColor="Black" BorderColor="Black" Font-Bold="True" ForeColor="White" />
            <asp:Button ID="mgBt" runat="server" PostBackUrl="~/Musteri.aspx" Text="MÜŞTERİLER" BackColor="Black" BorderColor="Black" Font-Bold="True" ForeColor="White" Height="40px" />
            <asp:Button ID="tGBt" runat="server" Height="40px" PostBackUrl="~/Tedarikci.aspx" Text="TEDARİKÇİLER" BackColor="Black" BorderColor="Black" Font-Bold="True" ForeColor="White" />
            <asp:Button ID="EkleB" runat="server" Text="EKLE" Height="40px" PostBackUrl="~/EKLE.aspx" style="margin-left: 0px" Width="80px" BackColor="Black" BorderColor="Black" Font-Bold="True" ForeColor="White" />
            <asp:Button ID="Button2" runat="server" Height="40px" PostBackUrl="~/login.aspx" Text="ÇIKIŞ" Width="80px" BackColor="Black" BorderColor="Black" Font-Bold="True" ForeColor="White" />
        </asp:Panel>
        <asp:Panel runat="server" Height="281px" HorizontalAlign="Center" BackColor="#CCCCCC">
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
            <asp:DropDownList ID="maDDL" runat="server" OnLoad="Page_Load" OnSelectedIndexChanged="maDDL_SelectedIndexChanged" style="margin-left: 0px" Width="150px" AutoPostBack="true" >
            </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="moDDL" runat="server" Width="150px" EnablAutoPostBack="true" AutoPostBack="true" OnSelectedIndexChanged="moDDL_SelectedIndexChanged" >
            </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="paDDL" runat="server" Width="150px" EnableAutoPostBack="true">
            </asp:DropDownList>
            <br />
            <br />
            <br />
            <asp:RadioButton ID="sGuRb" runat="server" Text="STOK" />
            &nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="fGuRb" runat="server" Text="FİYAT" />
            <br />
            <br />
            <asp:TextBox ID="gunTb" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="gunBt" runat="server" OnClick="gunBt_Click" Text="GÜNCELLE" />
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
