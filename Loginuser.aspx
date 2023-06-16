<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Loginuser.aspx.cs" Inherits="online.Loginuser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <asp:TextBox ID="Email" runat="server" placeholder="Enter your Email" ></asp:TextBox><br /><br />
    <asp:TextBox ID="Password" runat="server" type="Password" placeholder="Enter your Password" ></asp:TextBox><br /><br />
    <asp:Button Id="LoginBt" runat="server" text="Login" OnClick="LoginBt_Click" />


</asp:Content>
