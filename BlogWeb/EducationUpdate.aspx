﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="EducationUpdate.aspx.cs" Inherits="BlogWeb.EducationUpdate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form id="Form1" runat="server">


        <div class ="form-group">
            <asp:Label ID="Label5" runat="server" Text="ID"></asp:Label>
            <asp:TextBox ID="TxtID" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />

        <div class ="form-group">
            <asp:Label ID="Label1" runat="server" Text="TITLE"></asp:Label>
            <asp:TextBox ID="TxtTitle" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />

        <div class ="form-group">
            <asp:Label ID="Label2" runat="server" Text="SUBTITLE" ></asp:Label>
            <asp:TextBox ID="TxtSubtitle" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />

        <div class ="form-group">
            <asp:Label ID="Label3" runat="server" Text="EXPLANATION" ></asp:Label>
            <asp:TextBox ID="TxtExplanation" runat="server" CssClass="form-control" Height="100px" TextMode="MultiLine"></asp:TextBox>
        </div>
        <br />

        <div class ="form-group">
            <asp:Label ID="Label4" runat="server" Text="DATE" ></asp:Label>
            <asp:TextBox ID="TxtDate" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />

        <div class ="form-group">
            <asp:Label ID="Label6" runat="server" Text="GRADE AVARAGE" ></asp:Label>
            <asp:TextBox ID="TxtGradeAvarage" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />

        <asp:Button ID="BtnUpdate" runat="server" Text="Update" CssClass="btn btn-primary" OnClick="BtnUpdate_Click" />


    </form>

</asp:Content>
