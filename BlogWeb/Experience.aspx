<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Experience.aspx.cs" Inherits="BlogWeb.Experience" %>

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
                        <td><%# Eval("Date") %></td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%# "ExperienceDelete.Aspx?ID=" + Eval("ID") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">Delete</asp:HyperLink>
                            <asp:HyperLink NavigateUrl='<%# "ExperienceUpdate.Aspx?ID=" + Eval("ID") %>' ID="HyperLink2" runat="server" CssClass="btn btn-warning">Update</asp:HyperLink>
                        </td>
                    </tr>

                </ItemTemplate>


            </asp:Repeater>
        </tbody>
    </table>
        <asp:HyperLink NavigateUrl="~/ExperienceAdd.aspx" ID="HyperLink3" runat="server" CssClass="btn btn-info">ADD EXPERIENCE</asp:HyperLink>
        </form>



</asp:Content>
