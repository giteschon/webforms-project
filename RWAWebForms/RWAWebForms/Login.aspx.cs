using RWAWebForms.Models;
using RWAWebForms.Models.BL;
using RWAWebForms.RWAWebForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RWAWebForms.Forms
{
    public partial class Login : MyPage
    {

        protected void Page_Load(object sender, EventArgs e)
        {

            MasterPage master = (MasterPage)this.Page.Master;
            LinkButton btnUser = (LinkButton)master.FindControl("btnUser");
            btnUser.Visible = false;

            LinkButton btnLogout = (LinkButton)master.FindControl("btnLogout");
            btnLogout.Visible = false;

            DisableButton("btnAddNewPerson");
            DisableButton("btnEdit");
            DisableButton("btnPersonList");
            DisableButton("btnSetup");

        }

        private void DisableButton(string button)
        {
            MasterPage master = (MasterPage)this.Page.Master;
            LinkButton btn = (LinkButton)master.FindControl(button);
            btn.Enabled = false;
        }




    }
}