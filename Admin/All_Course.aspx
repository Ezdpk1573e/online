<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.Master" AutoEventWireup="true" CodeBehind="All_Course.aspx.cs" Inherits="online.Admin.All_Course" %>
<%@ Import Namespace="online" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <table>
                <thead>
                    <tr>
                        <th>Sr No.</th>
                        <th>Course Image</th>
                        <th>Course Name</th>
                        <th>Course Duration</th>
                        <th>Course Price</th>
                        <th>Course Description</th>
                        <th>Edit</th>
                        <th>Delete</th>
                    </tr>
                </thead>
                <tbody>
                    <%
                        int SrNo=1;
                        DbWork db = new DbWork();
                        db.reader = db.getcourseinfo();

                        while (db.reader.Read())
                        {

                        %>
                    <tr>
                        <td><%=SrNo++ %></td>
                        <td><img src="/admin/image/courseimg<%=db.reader["coimage"] %>"style="height:100px; width:250px;" /></td>
                        <td><%=db.reader["coname"] %></td>
                        <td><%=db.reader["coduration"] %></td>
                        <td><%=db.reader["coprice"] %></td> 
                        <td><%=db.reader["codesc"] %></td>


                        <td><a href="Edit_Course.aspx?coid=<%=db.reader["coid"] %>">Edit</a></td>
                        <td><a href="Delete_Course.aspx?coid=<%=db.reader["coid"] %>" onclick="return confirm(are you agree to delete?')">Delete</a>"</td>

                    </tr>
                    </tbody>
                <%
                        }

                    %>
                    
            </table>
            </div>
        </div>
            
            
</asp:Content>
