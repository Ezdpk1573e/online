<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.Master" AutoEventWireup="true" CodeBehind="Addcourse.aspx.cs" Inherits="online.Admin.Addcourse" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:TextBox ID="CoName" runat="server" placeholder="Name of Course"></asp:TextBox><br />
    <asp:TextBox ID="CoDesc" runat="server" placeholder="Description about Course"></asp:TextBox>
    <br />
    <br />
    <asp:TextBox ID="CoDuration" runat="server" placeholder="Duration of Course"></asp:TextBox>
    <br />
    <br />
    <asp:TextBox ID="CoPrice" runat="server" placeholder="Price of Course"></asp:TextBox>
    <br />
    <br />
    <asp:FileUpload ID="CoImage" runat="server" placeholder="Course Image"/>

    <asp:Button ID="AdCourseBtn" runat="server" OnClick="AdCourseBtn_Click" Text="Add Course" />
    <asp:Button ID="AllCourseBtn" runat="server" OnClick="AllCourseBtn_Click" Text=" All Course" />

</asp:Content>
