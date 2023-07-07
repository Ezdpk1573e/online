<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.Master" AutoEventWireup="true" CodeBehind="Default_Admin.aspx.cs" Inherits="online.Admin.Default_Admin" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <asp:Button ID="aloginBtn" runat="server" Text="Login" OnClick="aloginBtn_Click" />

    <asp:Button ID="Addcourse" runat="server" Text="AddCourse" OnClick="Addcourse_Click" />
    <asp:Button ID="EditCourse" runat="server" Text="EditCourse" OnClick="EditCourse_Click" />
    <asp:Button ID="AllCourse" runat="server" Text="AllCourse" OnClick="AllCourse_Click"/>
    <asp:Button ID="Allusers" runat="server" Text="AllUsers" OnClick="Allusers_Click"/>




</asp:Content>
