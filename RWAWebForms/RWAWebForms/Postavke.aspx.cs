using RWAWebForms.RWAWebForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RWAWebForms.Forms
{
    public partial class Postavke : MyPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlTheme.SelectedIndex = ThemeIndexFromDdl;
                ddlRepo.SelectedIndex = RepoIndexFromDdl;
                ddlLanguage.SelectedIndex = LanguageIndexFromDdl;
            }
        }

        protected void ddlTheme_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ddlTheme.SelectedValue != "0")
            {
                //string theme = ddlTheme.SelectedValue;
                HttpCookie kuki = new HttpCookie(THEME_PROJECT_NAME_COOKIE);
                kuki.Expires.AddDays(10);
                kuki[THEME_COOKIE] = ddlTheme.SelectedValue;
                kuki[INDEX_COOKIE] = ((DropDownList)sender).SelectedIndex.ToString();
                Response.Cookies.Add(kuki);
                Response.Redirect(Request.Url.LocalPath);
            }

        }

        protected void ddlRepo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlRepo.SelectedValue != "0")
            {
                //string repo = ddlRepo.SelectedValue;
                HttpCookie kuki = new HttpCookie(REPO_PROJECT_NAME_COOKIE);
                kuki.Expires.AddDays(10);
                kuki[REPO_COOKIE] = ddlRepo.SelectedValue;
                kuki[INDEX_COOKIE] = ((DropDownList)sender).SelectedIndex.ToString();
                Response.Cookies.Add(kuki);
                Response.Redirect(Request.Url.LocalPath);
            }
        }

        protected void ddlLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlLanguage.SelectedValue != "0")
            {
                HttpCookie kuki = new HttpCookie(LANGUAGE_PROJECT_NAME_COOKIE);
                kuki.Expires.AddDays(10);
                kuki[LANGUAGE_COOKIE] = ddlLanguage.SelectedValue;
                kuki[INDEX_COOKIE] = ((DropDownList)sender).SelectedIndex.ToString();
                Response.Cookies.Add(kuki);
                Response.Redirect(Request.Url.LocalPath);
            }
        }
    }
}
