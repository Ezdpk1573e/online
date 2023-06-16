<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="online.Admin.Login" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <asp:TextBox ID="aEmail" runat="server" placeholder="Enter your Email" ></asp:TextBox>
    <asp:TextBox ID="Password" runat="server" placeholder="Enter your Password" ></asp:TextBox>

    <asp:Button Id="LoginBtn" runat="server" text="Login" OnClick="LoginBtn_Click"/>

</asp:Content>
