<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Catalog.aspx.cs" Inherits="LibraryCatalogWebApp.Catalog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 <%--  <div>
    <div>
        <asp:TextBox runat="server" ID="SearchAuthor"></asp:TextBox>
        <asp:Button runat="server" ID="button1" Text="Search Author" Width ="110px" CommandName="Select"/>
    </div>
        <asp:TextBox runat="server" ID="SearchBook"></asp:TextBox>
        <asp:Button runat="server" ID="button2" Text="Search Title" Width="110px" OnClick="getBooksByTitle"/>
   </div>--%>


        <asp:GridView runat="server" ID="booksGrid"
        ItemType="LibraryCatalogWebapp.Models.Book" DataKeyNames="BookID" 
        SelectMethod="booksGrid_GetData"
        UpdateMetho ="booksGrid_UpdateData"
        AllowPaging="true" PageSize="25"
        AutoGenerateColumns="false" HorizontalAlign="Center">
        <Columns>
            <asp:BoundField DataField="BookID" HeaderText="BookID"/>
            <asp:BoundField DataField="Title" HeaderText="Title"/>
            <asp:BoundField DataField="Author" HeaderText="Author"/>
            <asp:BoundField DataField="Pages" HeaderText="Pages"/>
            <asp:BoundField DataField="Year" HeaderText="Year"/>        
            <asp:BoundField DataField="Country" HeaderText="Country"/>        
            <asp:BoundField DataField="Language" HeaderText="Language"/>        
         </Columns>
            <HeaderStyle HorizontalAlign="Center"/>
    </asp:GridView>
</asp:Content>
