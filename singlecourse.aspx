<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="singlecourse.aspx.cs" Inherits="online.singlecourse" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div id="cources-wrapper">

        <div class="row">

            <!--single course-->
            <div class="col-md-3 col-sm-6 col-xs-6">
                <div class="course">
                    <img src="image" class="course-img" id="COIMAGE" runat="server" style="height: 300px; width:300px;" />
                    <div>
                        <h3 class="course-details" id="CONAME" runat="server"> </h3>
                        <h4 class="course-details" id="CODESC" runat="server"> </h4>
                        <h3 class="course-details" id="COPRICE" runat="server"> </h3>
                        <h3 class="course-details" id="CODURATION" runat="server"></h3>
</div>
                </div>
                <asp:Button ID="BuyBtn" runat="server" Text="Buy Now!" CssClass="btn-danger" OnClick="BuyBtn_Click" />
            </div>
        </div>
    </div>

</asp:Content>
