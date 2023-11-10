<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AboutMe.aspx.cs" Inherits="BlogWeb.AboutMe" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form id="Form1" runat="server">


        <div class ="form-group">
            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />

        <div class ="form-group">
            <asp:Label ID="Label2" runat="server" Text="Surname" ></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />

        <div class ="form-group">
            <asp:Label ID="Label3" runat="server" Text="Address" ></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />

        <div class ="form-group">
            <asp:Label ID="Label4" runat="server" Text="Mail" ></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />

        <div class ="form-group">
            <asp:Label ID="Label5" runat="server" Text="Phone" ></asp:Label>
            <asp:TextBox ID="TextBox5" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />

        <div class ="form-group">
            <asp:Label ID="Label6" runat="server" Text="About Me" ></asp:Label>
            <asp:TextBox ID="TextBox6" runat="server" CssClass="form-control" Height="100px" TextMode="MultiLine"></asp:TextBox>
        </div>
        <br />

        <div class ="form-group">
            <asp:Label ID="Label7" runat="server" Text="Photo" ></asp:Label>
            <asp:TextBox ID="TextBox7" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />

        <asp:Button ID="Button1" runat="server" Text="UPDATE" CssClass="btn btn-info" OnClick="Button1_Click1"/>


    </form>
</asp:Content>
