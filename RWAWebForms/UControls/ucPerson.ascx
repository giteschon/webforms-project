<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucPerson.ascx.cs" Inherits="RWAWebForms.UControls.ucPerson" %>

<div class="osoba">
    <table style="width: 100%;">

        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Name:" meta:resourcekey="Label1Resource1"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtName" runat="server" CssClass="form-control input-sm" Width="182px" meta:resourcekey="txtNameResource1"></asp:TextBox>
            </td>

        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Surname:" meta:resourcekey="Label2Resource1"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtSurname" runat="server" CssClass="form-control input-sm" meta:resourcekey="txtSurnameResource1"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:DropDownList ID="ddlEmail" runat="server" OnSelectedIndexChanged="ddlEmail_SelectedIndexChanged" CssClass="form-control input-sm" meta:resourcekey="ddlEmailResource1"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Email:" meta:resourcekey="Label3Resource1"></asp:Label>
            </td>
            <td>
                <div class="input-group">
                    <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" CssClass="form-control input-sm" meta:resourcekey="txtEmailResource1"></asp:TextBox>
                                        <span class="input-group-btn">
                        <asp:LinkButton runat="server" CssClass="btn btn-default btn-sm" ID="btnSetup" ForeColor="#0094FF" meta:resourcekey="btnSetupResource1"><span class="glyphicon glyphicon-save"></span></asp:LinkButton>
                    </span>
                </div>

            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Telephone:" meta:resourcekey="Label4Resource1"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtTelephone" runat="server" CssClass="form-control input-sm" meta:resourcekey="txtTelephoneResource1"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Password:" meta:resourcekey="Label5Resource1"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control input-sm" meta:resourcekey="txtPasswordResource1"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Status:" meta:resourcekey="Label6Resource1"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlStatus" runat="server" CssClass="form-control input-sm" meta:resourcekey="ddlStatusResource1">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
        
            <td>
                <asp:Label ID="Label7" runat="server" Text="City:" meta:resourcekey="Label7Resource1"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlCity" runat="server" CssClass="form-control input-sm" meta:resourcekey="ddlCityResource1">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnEdit" runat="server" Text="Edit" Width="85px" Height="30px" OnClick="btnEdit_Click" CssClass="btn btn-primary" meta:resourcekey="btnEditResource1" />
                <asp:Button ID="btnDelete" runat="server" Text="Delete" Width="85px" Height="30px" OnClick="btnDelete_Click" CssClass="btn btn-warning" meta:resourcekey="btnDeleteResource1" />
            </td>
        </tr>

    </table>


</div>

