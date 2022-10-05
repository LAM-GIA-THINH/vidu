<%@ Page Title="" Language="C#" MasterPageFile="~/USER.Master" AutoEventWireup="true" CodeBehind="page_DANHSACHSANPHAM.aspx.cs" Inherits="QUANLYBANHANG_00340.page_DANHSACHSANPHAM" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList1" runat="server">
        <ItemTemplate>
            <img alt="" src='IMAGES/<%# Eval("HINHANH") %>' width="200px" height="200px"/>
            <%# Eval("TENSANPHAM") %>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
