<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CUS_Portal.aspx.cs" Inherits="CUS_Portal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server" align="left">
    <nav>
        <h2>Customer Portal Links:</h2>
        <h3>DataGrids:</h3>
        <ul>
            <li><a id="A3" runat="server" href="~/DataGrid/Tbl_CustInvoiceJour">CustInvoiceJour</a></li>
            <li><a id="A4" runat="server" href="~/DataGrid/Tbl_CustInvoiceTrans">CustInvoiceTrans</a></li>  
        </ul>
        <h3>Reports:</h3>
        <ul>
            <li><a id="A5" runat="server" href="~/Reports/Rpt_Customer">Customer Report</a></li>
        </ul>
    </nav>
</asp:Content>

