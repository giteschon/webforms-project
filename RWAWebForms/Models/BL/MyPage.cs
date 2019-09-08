using RWAWebForms.Models;
using RWAWebForms.Models.BL;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RWAWebForms.RWAWebForms
{
    public class MyPage : System.Web.UI.Page
    {
        public const string THEME_PROJECT_NAME_COOKIE = "ThemeRWAWebForms";
        public const string REPO_PROJECT_NAME_COOKIE = "RepoRWAWebForms";
        public const string LANGUAGE_PROJECT_NAME_COOKIE = "LanguageRWAWebForms";
        public const string THEME_COOKIE = "theme";
        public const string INDEX_COOKIE = "index";
        public const string REPO_COOKIE = "repo";
        public const string LANGUAGE_COOKIE = "repo";


        public PersonBusiness manager = new PersonBusiness(new RepoDatabase());

        //za automatsko postavljanje ddl indexa na selektirani
        public int ThemeIndexFromDdl
        {
            get
            {
                if (Request.Cookies[THEME_PROJECT_NAME_COOKIE] != null)
                {
                    if (Request.Cookies[THEME_PROJECT_NAME_COOKIE][INDEX_COOKIE] != null)
                        return int.Parse(Request.Cookies[THEME_PROJECT_NAME_COOKIE][INDEX_COOKIE]);
                }
                return 0;
            }
            set
            {
                Request.Cookies[THEME_PROJECT_NAME_COOKIE][INDEX_COOKIE] = value.ToString();
            }
        }

        public int RepoIndexFromDdl
        {
            get
            {
                if (Request.Cookies[REPO_PROJECT_NAME_COOKIE] != null)
                {
                    if (Request.Cookies[REPO_PROJECT_NAME_COOKIE][INDEX_COOKIE] != null)
                        return int.Parse(Request.Cookies[REPO_PROJECT_NAME_COOKIE][INDEX_COOKIE]);
                }
                return 0;
            }
            set
            {
                Request.Cookies[REPO_PROJECT_NAME_COOKIE][INDEX_COOKIE] = value.ToString();
            }
        }

        public int LanguageIndexFromDdl
        {
            get
            {
                if (Request.Cookies[LANGUAGE_PROJECT_NAME_COOKIE] != null)
                {
                    if (Request.Cookies[LANGUAGE_PROJECT_NAME_COOKIE][INDEX_COOKIE] != null)
                        return int.Parse(Request.Cookies[LANGUAGE_PROJECT_NAME_COOKIE][INDEX_COOKIE]);
                }
                return 0;
            }
            set
            {
                Request.Cookies[LANGUAGE_PROJECT_NAME_COOKIE][INDEX_COOKIE] = value.ToString();
            }
        }


        protected override void OnPreInit(EventArgs e)
        {
            if (Request.Cookies[THEME_PROJECT_NAME_COOKIE] != null)
            {
                if (Request.Cookies[THEME_PROJECT_NAME_COOKIE][THEME_COOKIE] != null)
                    Theme = Request.Cookies[THEME_PROJECT_NAME_COOKIE][THEME_COOKIE];
            }

            base.OnPreInit(e);
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
        }

        protected override void OnInitComplete(EventArgs e)
        {
            if (Request.Cookies[REPO_PROJECT_NAME_COOKIE] != null)
            {
                if (Request.Cookies[REPO_PROJECT_NAME_COOKIE][REPO_COOKIE] != null)
                {
                    string repo = Request.Cookies[REPO_PROJECT_NAME_COOKIE][REPO_COOKIE];

                    if (repo == "RepoTextFile")
                    {
                        manager = new PersonBusiness(new RepoTextFile());
                        MasterPage master = (MasterPage)this.Page.Master;
                        Label lbl = (Label)master.FindControl("lblRepoInfo");
                        lbl.Text = "Repository - TextFile";
                    }

                    else
                    {
                        manager = new PersonBusiness(new RepoDatabase());
                        MasterPage master = (MasterPage)this.Page.Master;
                        Label lbl = (Label)master.FindControl("lblRepoInfo");
                        lbl.Text = "Repository - DataBase";
                    }
                }
            }

            base.OnInitComplete(e);
        }

        protected override void InitializeCulture()
        {
            if (Request.Cookies[LANGUAGE_PROJECT_NAME_COOKIE] != null)
            {
                if (Request.Cookies[LANGUAGE_PROJECT_NAME_COOKIE][LANGUAGE_COOKIE] != null)
                {
                    string culture = Request.Cookies[LANGUAGE_PROJECT_NAME_COOKIE][LANGUAGE_COOKIE];
                    Thread.CurrentThread.CurrentCulture = new CultureInfo(culture);
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
                }
            }

            base.InitializeCulture();
        }


        private void Page_Error(object sender, EventArgs e)
        {
           // Response.Redirect("Error.aspx");
        }

    }
}