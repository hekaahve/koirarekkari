<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebApplication2.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>
    jou

    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    Tähän täytyy saada SQL tietokanta, joka hakee tiedot
    Koirarekisteri? hakee koirien tiedot
    <asp:Label ID="Label1" runat="server" Text="0"></asp:Label> 
    <asp:Login ID="Login1" runat="server"></asp:Login>
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
    <asp:TextBox ID="hakukentta" runat="server"></asp:TextBox>


    <asp:View ID="View1" runat="server"></asp:View>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>

    <asp:DataList ID="DataList1" runat="server"></asp:DataList>
</asp:Content>
