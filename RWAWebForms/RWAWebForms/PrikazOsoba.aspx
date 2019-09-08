<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="PrikazOsoba.aspx.cs" Inherits="RWAWebForms.RWAWebForms.PrikazOsoba" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Person list
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <h1>Prikaz osoba</h1>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="content" runat="server">
  

    <div class="panel-group" id="accordion">

        <div class="panel panel-default">
            <div class="panel-heading" role="tab">
                <h4 class="panel-title">
                    <asp:LinkButton runat="server">Grid View</asp:LinkButton>

                </h4>

            </div>
            <div class="panel-collapse collapse in">
                <div class="panel-body">

                    <asp:GridView ID="gridPeople" runat="server" AutoGenerateColumns="False" Style="color: Black; background-color: White; border-color: #CCCCCC; border-width: 1px; border-style: None; border-collapse: collapse;">
                        <Columns>
                            <asp:BoundField DataField="Name" HeaderText="Name" ItemStyle-Width="130px" ItemStyle-Height="30px" >
<ItemStyle Height="30px" Width="130px"></ItemStyle>
                            </asp:BoundField>
                            <asp:BoundField DataField="Surname" HeaderText="Surname" ItemStyle-Width="130px" >
<ItemStyle Width="130px"></ItemStyle>
                            </asp:BoundField>
                            <asp:TemplateField HeaderText="E-mail addresses" ItemStyle-Width="130px">
                               <%-- <EditItemTemplate>
                                    <asp:TextBox ID="txtEmail" runat="server" Text='<%# Bind("Email") %>'></asp:TextBox>
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" Display="Dynamic" ErrorMessage="Krivo upisana E-mail adresa!" Font-Bold="True" ForeColor="Yellow" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                                </EditItemTemplate>                                  
                                <ItemTemplate>
                                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("Email") %>'></asp:Label>
                                </ItemTemplate>
                           
<ItemStyle Width="130px"></ItemStyle>
                           --%>
                            </asp:TemplateField>
                            <asp:BoundField DataField="Telephone" HeaderText="Telephone" ItemStyle-Width="130px" >
<ItemStyle Width="130px"></ItemStyle>
                            </asp:BoundField>

                            <asp:BoundField DataField="Status" HeaderText="Status" ItemStyle-Width="130px">
                                <ItemStyle Width="130px"></ItemStyle>
                            </asp:BoundField>
                            
                          <%--  <asp:TemplateField HeaderText="" ItemStyle-Width="130px" >
                               
                                    <ItemTemplate>
                <asp:DropDownList ID="ddlStatus" runat="server" AutoPostBack="true" OnDataBound="ddlStatus_DataBound" ></asp:DropDownList>
            </ItemTemplate>
                                </asp:TemplateField>--%>
                          
                     
                          <%--  <asp:ButtonField ButtonType="Button" CommandName="Edit" Text="Edit" ControlStyle-CssClass="btn btn-link" />--%>
                        </Columns>

                        <HeaderStyle BackColor="#333333" ForeColor="White" Height="30px" />




                    </asp:GridView>
                </div>
            </div>
        </div>
    
        <div class="panel panel-default">
            <div class="panel-heading" role="tab">
                <h4 class="panel-title">
                    <asp:LinkButton runat="server">Repeater</asp:LinkButton>

                </h4>

            </div>
            <div class="panel-collapse collapse in">
                <div class="panel-body">


                    <asp:Repeater ID="repeater" runat="server">
                        <HeaderTemplate>
                            <table>
                                <tr>
                                    <th>Name</th>
                                    <th>Surname</th>
                                    <th>Email addresses</th>
                                    <th>Telephone</th>
                                    <th>&nbsp;</th>
                                    <th>&nbsp;</th>
                                </tr>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <tr>
                                <td><%# Eval("Name") %></td>
                                <td><%# Eval("Surname") %></td>
                                <td><%# Eval("City") %></td>
                                <td><%# Eval("Telephone") %></td>
                                <td><%# Eval("Status") %></td>
                                <td>
                            
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>

                </div>
            </div>
        </div>

    </div>

    <div class="clearfix"></div>

    
</asp:Content>
