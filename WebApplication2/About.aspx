<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebApplication2.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <% Title = "Koirarekisteri"; %>
    <h2><%= Title %>.</h2>
    <p>Haetaan tietoja tallennetuista koirista</p>

    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Hae nimellä" /><hr />
    <asp:TextBox ID="hakukenttanimi" runat="server"></asp:TextBox>
    Tähän täytyy saada SQL tietokanta, joka hakee tiedot
    Koirarekisteri? hakee koirien tiedot<hr />
    <asp:Label ID="Label1" runat="server" Text="0"></asp:Label> 

    Haku:<hr />
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Hae" />
    <asp:TextBox ID="hakukentta" runat="server"></asp:TextBox><hr />
    <asp:TextBox ID="hakutulokset" runat="server"></asp:TextBox><hr />

    <asp:ListBox ID="ListBox1" Rows="6"  Height="100" Width="100px" runat="server">
         <asp:ListItem>Item 1</asp:ListItem>
         <asp:ListItem>Item 2</asp:ListItem>
         <asp:ListItem>Item 3</asp:ListItem>
         <asp:ListItem>Item 4</asp:ListItem>
         <asp:ListItem>Item 5</asp:ListItem>
         <asp:ListItem>Item 6</asp:ListItem>
    </asp:ListBox>

   <asp:Panel ID="Panel1" runat="server" BorderColor="#990000" BorderStyle="Solid" 
   width ="1px" Height="116px" ScrollBars="Both" style="width:278px">
   
   This is a scrollable panel.
   <br />
   <br />

   <asp:Button ID="btnpanel" runat="server" Text="Button" style="width:82px" />
    </asp:Panel>
    <asp:View ID="View1" runat="server"></asp:View>

    <asp:Table ID="Table1" 
            runat="server" 
            Font-Size="X-Large" 
            Width="550" 
            Font-Names="Palatino"
            BackColor="Orange"
            BorderColor="DarkRed"
            BorderWidth="2"
            ForeColor="Snow"
            CellPadding="5"
            CellSpacing="5"
            >
            <asp:TableHeaderRow 
                runat="server" 
                ForeColor="Snow"
                BackColor="OliveDrab"
                Font-Bold="true"
                >
                <asp:TableHeaderCell>Serial</asp:TableHeaderCell>
                <asp:TableHeaderCell>Name</asp:TableHeaderCell>
                <asp:TableHeaderCell>Value</asp:TableHeaderCell>
            </asp:TableHeaderRow>
            <asp:TableRow 
                ID="TableRow1" 
                runat="server" 
                BackColor="OrangeRed"
                >
                <asp:TableCell>1</asp:TableCell>
                <asp:TableCell>Azure</asp:TableCell>
                <asp:TableCell>#F0FFFF</asp:TableCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow2" 
                runat="server" 
                BackColor="DarkOrange"
                >
                <asp:TableCell>2</asp:TableCell>
                <asp:TableCell>Beige</asp:TableCell>
                <asp:TableCell>#F5F5DC</asp:TableCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow3" 
                runat="server" 
                BackColor="OrangeRed"
                >
                <asp:TableCell>3</asp:TableCell>
                <asp:TableCell>Bisque</asp:TableCell>
                <asp:TableCell>#FFE4C4</asp:TableCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow4" 
                runat="server" 
                BackColor="DarkOrange"
                >
                <asp:TableCell>4</asp:TableCell>
                <asp:TableCell>Crimson</asp:TableCell>
                <asp:TableCell>#DC143C</asp:TableCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow5" 
                runat="server" 
                BackColor="OrangeRed"
                >
                <asp:TableCell>5</asp:TableCell>
                <asp:TableCell>Cyan</asp:TableCell>
                <asp:TableCell>#00FFFF</asp:TableCell>
            </asp:TableRow>
            <asp:TableFooterRow 
                runat="server" 
                BackColor="DarkOrange"
                >
                <asp:TableCell 
                    ColumnSpan="3" 
                    HorizontalAlign="Right"
                    Font-Italic="true"
                    >
                    Number of colors 5
                </asp:TableCell>
            </asp:TableFooterRow>
        </asp:Table>
    https://www.c-sharpcorner.com/UploadFile/7eb164/gridview-control-in-Asp-Net/ tutki tätä
    <asp:GridView ID="GridView1"  runat="server"></asp:GridView>
</asp:Content>
