<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Postavke.aspx.cs" Inherits="RWAWebForms.Forms.Postavke" Culture="auto" UICulture="auto" meta:resourcekey="PageResource4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Setup
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <h1>Postavke</h1>
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="content" runat="server">
    <div class="row">
        <div class="col-lg-4 col-md-4 col-sm-4"></div>
        <%--theme--%>
        <div class="col-lg-4 col-md-4 col-sm-4">
            <div class="form-group">
                <asp:Label ID="Label1" runat="server" Text="Theme:" meta:resourcekey="lblThemeResource" />
                <asp:DropDownList ID="ddlTheme" runat="server" OnSelectedIndexChanged="ddlTheme_SelectedIndexChanged" AutoPostBack="True" CssClass="form-control" meta:resourcekey="ddlThemeResource3">
                    <asp:ListItem Text="---choose---" Value="0" meta:resourcekey="ListItemResource21" />
                    <asp:ListItem Text="Default" Value="Default" meta:resourcekey="ListItemResource22" />
                    <asp:ListItem Text="Red" Value="Red" meta:resourcekey="ListItemResource23" />
                    <asp:ListItem Text="Blue" Value="Blue" meta:resourcekey="ListItemResource24" />
                </asp:DropDownList>

            </div>

            <%--language--%>

            <div class="form-group">
                <asp:Label ID="Label2" runat="server" Text="Language:" meta:resourcekey="Label2Resource3" />

                <asp:DropDownList ID="ddlLanguage" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="ddlLanguage_SelectedIndexChanged" meta:resourcekey="ddlLanguageResource3">
                    <asp:ListItem Text="---odaberi---" Value="0" meta:resourcekey="ListItemResource25" />
                    <asp:ListItem Text="Croatian" Value="hr" meta:resourcekey="ListItemResource26" />
                    <asp:ListItem Text="English" Value="en" meta:resourcekey="ListItemResource27" />
                </asp:DropDownList>
            </div>

            <%--repostiroy--%>
            <div class="form-group">
                <asp:Label ID="Label3" runat="server" Text="Repository:" meta:resourcekey="Label3Resource3" />

                <asp:DropDownList ID="ddlRepo" runat="server" CssClass="form-control" OnSelectedIndexChanged="ddlRepo_SelectedIndexChanged" AutoPostBack="True" meta:resourcekey="ddlRepoResource3">
                    <asp:ListItem Text="---odaberi---" Value="0" meta:resourcekey="ListItemResource28" />
                    <asp:ListItem Text="Text File" Value="RepoTextFile" meta:resourcekey="ListItemResource29" />
                    <asp:ListItem Text="DataBase" Value="RepoDatabase" meta:resourcekey="ListItemResource30" />
                </asp:DropDownList>
            </div>
        </div>

        <div class="col-lg-4 col-md-4 col-sm-4"></div>

    </div>
</asp:Content>
