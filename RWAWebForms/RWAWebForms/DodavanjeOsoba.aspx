<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="DodavanjeOsoba.aspx.cs" Inherits="RWAWebForms.RWAWebForms.DodavanjeOsoba" Culture="auto" meta:resourcekey="PageResource1" UICulture="auto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Add new person
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <h1>Dodavanje osoba</h1>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="content" runat="server">

    <div class="formContainer">
        <div class="col-lg-4 col-md-4 col-sm-4">

            <div class="form-group">
                <asp:Label ID="Label1" runat="server" Text="Name:" meta:resourcekey="Label1Resource1"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Name is required" ControlToValidate="txtName" ForeColor="Red" ValidationGroup="groupAddPerson" meta:resourcekey="RequiredFieldValidator1Resource1">*</asp:RequiredFieldValidator>

                <asp:TextBox ID="txtName" runat="server" CssClass="form-control" meta:resourcekey="txtNameResource1"></asp:TextBox>
            </div>

            <div class="form-group">
                <asp:Label ID="Label4" runat="server" Text="Surname:" meta:resourcekey="Label4Resource1"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Surname is required" ControlToValidate="txtSurname" ForeColor="Red" ValidationGroup="groupAddPerson" meta:resourcekey="RequiredFieldValidator4Resource1">*</asp:RequiredFieldValidator>
                <asp:TextBox ID="txtSurname" runat="server" CssClass="form-control" meta:resourcekey="txtSurnameResource1"></asp:TextBox>

            </div>

            <asp:Label ID="Label3" runat="server" Text="E-mail:" meta:resourcekey="Label3Resource1"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="E-mail is required" ControlToValidate="txtEmail1" ForeColor="Red" ValidationGroup="groupAddPerson" meta:resourcekey="RequiredFieldValidator3Resource1">*</asp:RequiredFieldValidator>
            <br />
            <asp:TextBox ID="txtEmail1" runat="server" CssClass="form-control" meta:resourcekey="txtEmail1Resource1" />
            <asp:TextBox ID="txtEmail2" runat="server" CssClass="form-control" Visible="False" meta:resourcekey="txtEmail2Resource1" />
            <asp:TextBox ID="txtEmail3" runat="server" CssClass="form-control" Visible="False" meta:resourcekey="txtEmail3Resource1" />

            <asp:Button ID="btnAddMoreEmails" runat="server" Text="Add more email addresses..." CssClass="btn btn-link" OnClick="btnAddMoreEmails_Click" meta:resourcekey="btnAddMoreEmailsResource1" />

        </div>


        <div class="col-lg-4 col-md-4 col-sm-4">

            <div class="form-group">
                <asp:Label ID="lbl1" runat="server" Text="Telephone:" meta:resourcekey="lbl1Resource1"></asp:Label>

                <asp:TextBox ID="txtTelephone" runat="server" CssClass="form-control" meta:resourcekey="txtTelephoneResource1"></asp:TextBox>


            </div>


            <div class="form-group">

                <asp:Label ID="Label7" runat="server" Text="City::" meta:resourcekey="Label7Resource1"></asp:Label>
                <br />
                <asp:DropDownList ID="ddlCity" runat="server" CssClass="form-control" meta:resourcekey="ddlCityResource1">
                </asp:DropDownList>
            </div>

            <div class="form-group">

                <asp:Label ID="Label8" runat="server" Text="Status:" meta:resourcekey="Label8Resource1"></asp:Label>
                <br />
                <asp:DropDownList ID="ddlStatus" runat="server" CssClass="form-control" meta:resourcekey="ddlStatusResource1">
                </asp:DropDownList>
            </div>
        </div>

        <div class="col-lg-4 col-md-4 col-sm-4">

            <div class="form-group">
                <asp:Label ID="Label5" runat="server" Text="Password:" meta:resourcekey="Label5Resource1"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Password is required" ControlToValidate="txtPassword" ForeColor="Red" ValidationGroup="groupAddPerson" meta:resourcekey="RequiredFieldValidator5Resource1">*</asp:RequiredFieldValidator>

                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control" meta:resourcekey="txtPasswordResource1"></asp:TextBox>

            </div>


            <div class="form-group">
                <asp:Label ID="Label6" runat="server" Text="Confirm password:" meta:resourcekey="Label6Resource1"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Password confirmation is required" ControlToValidate="txtRepeatPassword" ForeColor="Red" ValidationGroup="groupAddPerson" meta:resourcekey="RequiredFieldValidator6Resource1">*</asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtRepeatPassword" ControlToValidate="txtPassword" ErrorMessage="Potvrda lozinke ne odgovara unesenoj lozinki" ForeColor="Red" ValidationGroup="groupAddPerson" meta:resourcekey="CompareValidator1Resource1">*</asp:CompareValidator>

                <asp:TextBox ID="txtRepeatPassword" runat="server" TextMode="Password" CssClass="form-control" meta:resourcekey="txtRepeatPasswordResource1"></asp:TextBox>

            </div>

            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" CssClass="btn btn-primary" ValidationGroup="groupAddPerson" meta:resourcekey="btnAddResource1" />

        </div>

        <div class="col-lg-12 col-md-12 col-sm-12">

            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" meta:resourcekey="ValidationSummary1Resource1" />
        </div>



    </div>

</asp:Content>
