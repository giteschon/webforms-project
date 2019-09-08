<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucLogin.ascx.cs" Inherits="RWAWebForms.UControls.ucLogin" %>
<div class="row">

    <div class="col-lg-4 col-md-4 col-sm-4"></div>

    <div class="col-lg-4 col-md-4 col-sm-4">
        <%--email--%>
        <div class="formContainer">

            <div class="form-group">
                <asp:Label runat="server" ID="lblEmail">E-mail:</asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email is required" ForeColor="Red" ValidationGroup="valGroupLogin">*</asp:RequiredFieldValidator>
                <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="Wrong email address" OnServerValidate="CustomValidator1_ServerValidate" ForeColor="Red" ValidationGroup="valGroupLogin">*</asp:CustomValidator>


                <asp:TextBox runat="server" ID="txtEmail" TextMode="Email" CssClass="form-control"></asp:TextBox>
            </div>



            <%--password--%>
            <div class="form-group">

                <asp:Label runat="server" ID="lbPassword">Lozinka:</asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" ErrorMessage="Password is required" ForeColor="Red" ValidationGroup="valGroupLogin">*</asp:RequiredFieldValidator>

                <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" CssClass="form-control"></asp:TextBox>
            </div>


            <div class="form-group">
                <asp:CheckBox runat="server" ID="cbRemember" OnCheckedChanged="cbRemember_CheckedChanged" />
                <asp:Label runat="server">Remember me</asp:Label>
                <br />
            </div>
            <asp:Button runat="server" ID="btnLogin" Text="Enter" OnClick="btnLogin_Click" CssClass="btn btn-primary" ValidationGroup="valGroupLogin" />

            <%--validation summary--%>
        </div>

        <div class="form-group">
            <asp:Label runat="server" ID="lblInfoMessage" Visible="false" ForeColor="Red" />

            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
        </div>

        <div class="col-lg-4 col-md-4 col-sm-4"></div>
    </div>


</div>
