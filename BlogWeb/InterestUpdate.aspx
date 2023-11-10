<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="InterestUpdate.aspx.cs" Inherits="BlogWeb.InterestUpdate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form id="Form1" runat="server">


        <div class ="form-group">
            <asp:Label ID="Label1" runat="server" Text="ID"></asp:Label>
            <asp:TextBox ID="TxtID" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />

        <div class ="form-group">
            <asp:Label ID="Label2" runat="server" Text="Interest" ></asp:Label>
            <asp:TextBox ID="TxtInterest" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />

        

        <asp:Button ID="BtnSave" runat="server" Text="SAVE" CssClass="btn btn-primary" OnClick="BtnSave_Click"/>


    </form>

</asp:Content>
