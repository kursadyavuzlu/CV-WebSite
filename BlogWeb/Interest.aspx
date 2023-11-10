<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Interest.aspx.cs" Inherits="BlogWeb.Interest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form id="form1" runat="server">
    <table class="table table-bordered">
        <tr>
            <th>ID</th>
            <th>INTEREST</th>
            <th>PROCESSES</th>
        </tr>

        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>

                    <tr>
                        <th><%# Eval("ID") %></th>
                        <td><%# Eval("Interest") %></td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%# "InterestDelete.Aspx?ID=" + Eval("ID") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">Delete</asp:HyperLink>
                            <asp:HyperLink NavigateUrl='<%# "InterestUpdate.Aspx?ID=" + Eval("ID") %>' ID="HyperLink2" runat="server" CssClass="btn btn-warning">Update</asp:HyperLink>
                        </td>
                    </tr>

                </ItemTemplate>


            </asp:Repeater>
        </tbody>
    </table>
        <asp:HyperLink NavigateUrl="~/InterestAdd.aspx" ID="HyperLink3" runat="server" CssClass="btn btn-info">ADD INTEREST</asp:HyperLink>
        </form>

</asp:Content>
