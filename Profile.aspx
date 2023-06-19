<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="online.Profile" %>
<%@ Import Namespace="online" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="col-sn-12">
            <div>
               <%-- <div>
                    <img src="/Admin/Image/" id="uimg" runat="server" style="height:200px;width:250px;" />
                </div>--%>
            
        
    <div>
        <h2 id="Name" runat="server"></h2>
        <h2 id="Email" runat="server"></h2>
        
    </div>
     <div>
        <h3 id="Password" runat="server"></h3>
        <h3 id="Mobile" runat="server"></h3>
        
    </div>
    </div>
            <h2>your courses</h2>
            <table border="1px">
                <thead>
                    <tr>
                        <th>Sr. no.</th>
                        <th>Course Image</th>
                        <th>Course name</th>
                        <th>Course price</th>
                        <th>Course duration</th>
                        <th>Course validity</th>

                       
                    </tr>
                </thead>

                <tbody>
                    <%
                        int Serial = 1;
                        DbWork db = new DbWork();
                        db.reader = db.orderdetail(Session["uid"].ToString());
                        while (db.reader.Read())
                        {
                            int dura = Convert.ToInt32(db.reader["coduration"].ToString());
                            DateTime start = Convert.ToDateTime(db.reader["orderdate"]);
                            DateTime end = DateTime.Now;

                            int diff = (end - start).Days;//create TimeSpan object
                            string Valid = "";
                            if (diff <= dura)
                            {
                                Valid =  " Course Is valid for " + ( dura-diff );
                            }
                            else
                            {
                                Valid =  " Course Is not valid Expired ";
                            }
                        %>
                    <tr>
                        <td><%=Serial++ %> </td>
                        <td><img src="/Admin/Image/<%=db.reader["coimage"]%>" style="height:100px; width:110px;"</td>
                        <td><%=db.reader["coname"] %></td>
                        <td><%=db.reader["coprice"] %></td>
                        <td><%=db.reader["coduration"] %></td>
                        <td><%=db.reader["orderdate"] %></td>
                        <td><%=Valid %></td>
                        <td></td>
                    </tr>
                    <%

                        }

                        %>
                </tbody>

            </table>
            </div>
        </div>
    


</asp:Content>
