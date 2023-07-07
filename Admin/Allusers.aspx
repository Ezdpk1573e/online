<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.Master" AutoEventWireup="true" CodeBehind="Allusers.aspx.cs" Inherits="online.Admin.Allusers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Button ID="Button1" runat="server" Text="Users" OnClick="Button1_Click" />


    &nbsp;<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" style="margin-top: 8px" Width="685px">
        <Columns>
            <asp:BoundField HeaderText="Sr. No" DataField="id" ReadOnly="true" />
                                <asp:BoundField HeaderText="Email" DataField="Email" />
                                <asp:BoundField HeaderText="Password" DataField="Password" />
                                <asp:BoundField HeaderText="Name" DataField="Name" />
                                <asp:BoundField HeaderText="Mobile" DataField="Mobile" />
                                <asp:CommandField HeaderText="Operation"  />
        </Columns>
    </asp:GridView>
</asp:Content>