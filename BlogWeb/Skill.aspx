﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Skill.aspx.cs" Inherits="BlogWeb.Skill" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form id="form1" runat="server">
    <table class="table table-bordered">
        <tr>
            <th>ID</th>
            <th>SKILL</th>
            <th>PROCESSES</th>
        </tr>

        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>

                    <tr>
                        <th><%# Eval("ID") %></th>
                        <td><%# Eval("Skill") %></td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%# "SkillDelete.Aspx?ID=" + Eval("ID") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">Delete</asp:HyperLink>
                            <asp:HyperLink NavigateUrl='<%# "SkillUpdate.Aspx?ID=" + Eval("ID") %>' ID="HyperLink2" runat="server" CssClass="btn btn-warning">Update</asp:HyperLink>
                        </td>
                    </tr>

                </ItemTemplate>


            </asp:Repeater>
        </tbody>
    </table>
        <asp:HyperLink NavigateUrl="~/SkillAdd.aspx" ID="HyperLink3" runat="server" CssClass="btn btn-info">ADD SKILL</asp:HyperLink>
        </form>

</asp:Content>
