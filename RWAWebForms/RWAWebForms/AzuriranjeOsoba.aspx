<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="AzuriranjeOsoba.aspx.cs" Inherits="RWAWebForms.RWAWebForms.AzuriranjeOsoba" %>

<%@ Register Src="~/UControls/ucPerson.ascx" TagPrefix="uc1" TagName="ucPerson" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Edit data
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <h1>Ažuriranje osoba</h1>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="content" runat="server">

    <%--napraviti border na tablici, ne znam dal direktno u kontroli ili tu vani . . ., a vidjet ccemo--%>
    <div style="overflow:hidden">
        <div class="row">
    <%--<div class="col-lg-4 col-md-4 col-sm-4">--%>
    <%--<uc1:ucPerson runat="server" id="ucPerson" />--%>

            <asp:PlaceHolder runat="server" ID="phPersons" />
  <%--      </div>--%>



            </div>
    </div>
</asp:Content>
