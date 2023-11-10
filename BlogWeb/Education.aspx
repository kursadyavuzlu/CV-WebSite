<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Education.aspx.cs" Inherits="BlogWeb.Education" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

     <form id="form1" runat="server">
    <table class="table table-bordered">
        <tr>
            <th>ID</th>
            <th>TITLE</th>
            <th>SUBTITLE</th>
            <th>EXPLANATION</th>
            <th>GRADE AVARAGE</th>
            <th>DATE</th>
            <th>PROCESSES</th>
        </tr>

        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>

                    <tr>
                        <th><%# Eval("ID") %></th>
                        <td><%# Eval("Title") %></td>
                        <td><%# Eval("Subtitle") %></td>
                        <td><%# Eval("Explanation") %></td>
                        <td><%# Eval("GradeAvarage") %></td>
                        <td><%# Eval("Date") %></td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%# "EducationDelete.Aspx?ID=" + Eval("ID") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">Delete</asp:HyperLink>
                            <asp:HyperLink NavigateUrl='<%# "EducationUpdate.Aspx?ID=" + Eval("ID") %>' ID="HyperLink2" runat="server" CssClass="btn btn-warning">Update</asp:HyperLink>
                        </td>
                    </tr>

                </ItemTemplate>


            </asp:Repeater>
        </tbody>
    </table>
        <asp:HyperLink NavigateUrl="~/EducationAdd.aspx" ID="HyperLink3" runat="server" CssClass="btn btn-info">ADD EDUCATION</asp:HyperLink>
        </form>

</asp:Content>
