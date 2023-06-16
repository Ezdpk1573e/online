<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Registeruser.aspx.cs" Inherits="online.Registeruser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:TextBox ID="Email" runat="server" placeholder="Enter your Email" ></asp:TextBox><br /><br />
    <asp:TextBox ID="Password" runat="server" placeholder="Enter your Password" ></asp:TextBox><br /><br />
    <asp:TextBox ID="Name" runat="server" placeholder="Enter your Name" ></asp:TextBox><br /><br />
    <asp:TextBox ID="Mobile" runat="server" placeholder="Enter your Mobile" ></asp:TextBox><br /><br />

     <asp:Button Id="RegisterBtn" runat="server" text="Register" OnClick="RegisterBt_Click"/>
</asp:Content>
