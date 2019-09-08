<%--<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="proba.aspx.cs" Inherits="RWAWebForms.proba" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">

    tekst
</asp:Content>
<%--<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server" Visible="false">
tekst2 koji se ne bi trebao vidit
</asp:Content>--%>
<asp:content id="Content3" contentplaceholderid="content" runat="server">
    ovaj se opet vidi
</asp:content>
--%>





<!DOCTYPE html>

<html>
<head>
    <title>Login
    </title>
    
</head>
<body>
    

      
        <div class="container mainContainer">
            <header>
                <div class="row">
                    <div class="col-lg-6 col-md-6 col-sm-6 text-left">
                        <span id="lblTitle" class="title">Login</span>
                    </div>
                    <div class="col-lg-6 col-md-6 col-sm-6 text-right" style="padding-top: 5px;">
                    </div>
                </div>
                <hr style="margin-top: 3px;" />
                <nav>
                    <ul>
                        <li>
                            <a id="lb1" href="javascript:__doPostBack(&#39;ctl00$lb1&#39;,&#39;&#39;)"><span class="glyphicon glyphicon-floppy-save"></span>Add new person</a>
                        </li>
                        <li>
                            <a id="lb2" href="javascript:__doPostBack(&#39;ctl00$lb2&#39;,&#39;&#39;)"><span class="glyphicon glyphicon-share"></span>Edit data</a>
                        </li>
                        <li>
                            <a id="lb3" href="javascript:WebForm_DoPostBackWithOptions(new WebForm_PostBackOptions(&quot;ctl00$lb3&quot;, &quot;&quot;, false, &quot;&quot;, &quot;PrikazOsoba.aspx&quot;, false, true))"><span class="glyphicon glyphicon-list"></span>Person list</a>
                        </li>
                        <li>
                            <a id="lb4" href="javascript:__doPostBack(&#39;ctl00$lb4&#39;,&#39;&#39;)"><span class="glyphicon glyphicon-cog"></span>Setup</a>
                        </li>
                    </ul>
                </nav>
                <hr />
            </header>
            <div class="content">

                <div class="row">
                    <div class="col-lg-4 col-md-4 col-sm-4"></div>
                    <div class="col-lg-4 col-md-4 col-sm-4">
                        <div class="formContainer">
                            <div class="form-group">
                                <span id="content_lblEmail">E-mail:</span>
                                <span id="content_RequiredFieldValidator1" class="validatori" style="display: none;">*</span>
                                <span id="content_RegularExpressionValidator1" class="validatori" style="display: none;">*</span>
                                <input name="ctl00$content$txtEmail" type="text" id="content_txtEmail" class="form-control" />
                            </div>
                            <div class="form-group">
                                <span id="content_lblLozinka">Password:</span>
                                <span id="content_RequiredFieldValidator2" class="validatori" style="visibility: hidden;">*</span>
                                <input name="ctl00$content$txtLozinka" type="password" id="content_txtLozinka" class="form-control" autocomplete="off" />
                            </div>
                            <div class="checkbox">
                                <label>
                                    <input id="content_cbRememberMe" type="checkbox" name="ctl00$content$cbRememberMe" />
                                    Zapamti me
                                </label>
                            </div>
                            <input type="submit" name="ctl00$content$btnLogin" value="Enter" onclick="javascript: WebForm_DoPostBackWithOptions(new WebForm_PostBackOptions(& quot; ctl00$content$btnLogin & quot;, & quot;& quot;, true, & quot; grupa & quot;, & quot;& quot;, false, false))" id="content_btnLogin" class="btn btn-primary" />
                            <div style="margin-top: 20px;">
                                <span id="content_lblInfo" style="color: red; font-weight: normal;"></span>
                            </div>
                            <div>
                                <div id="content_ValidationSummary1" class="validatori" style="font-weight: normal; display: none;">
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-4 col-md-4 col-sm-4"></div>
                </div>

            </div>
            <hr />
            <footer>
                <div>


                    <p>
                        02 February 2019 | <span id="lblAppName">RWA -<span style="color: red;"> WebForms</span> - Project</span>
                    </p>
                    <p class="badge repoInfo">
                        <span id="lblRepoInfo">...</span>
                    </p>
                </div>
            </footer>
        </div>


    </form>
</body>
</html>
