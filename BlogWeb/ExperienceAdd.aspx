<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="ExperienceAdd.aspx.cs" Inherits="BlogWeb.ExperienceAdd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">


    <form id="Form1" runat="server">


        <div class ="form-group">
            <asp:Label ID="Label1" runat="server" Text="TITLE"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />

        <div class ="form-group">
            <asp:Label ID="Label2" runat="server" Text="SUBTITLE" ></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />

        <div class ="form-group">
            <asp:Label ID="Label3" runat="server" Text="EXPLANATION" ></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" Height="100px" TextMode="MultiLine"></asp:TextBox>
        </div>
        <br />

        <div class ="form-group">
            <asp:Label ID="Label4" runat="server" Text="DATE" ></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />

        <asp:Button ID="Button1" runat="server" Text="SAVE" CssClass="btn btn-primary" OnClick="Button1_Click" />


    </form>

</asp:Content>
