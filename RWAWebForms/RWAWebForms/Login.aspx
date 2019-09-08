<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="RWAWebForms.Forms.Login" %>

<%@ Register Src="~/UControls/ucLogin.ascx" TagPrefix="uc1" TagName="ucLogin" %>


<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
          Prijava
  
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">   
    <h1>Prijava</h1>
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="content" runat="server">
    <uc1:ucLogin runat="server" id="ucLogin" />
</asp:Content>
