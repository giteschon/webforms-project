using RWAWebForms.Models;
using RWAWebForms.Models.BL;
using RWAWebForms.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RWAWebForms.UControls
{
    public partial class ucLogin : System.Web.UI.UserControl
    {
        private Person person;

        public Person Person
        {
            get { return person; }
            set { person = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtEmail.Focus();
            }
        }



        public void Reset()
        {
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtEmail.Focus();
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (UserExists())
            {
                Response.Redirect("~/RWAWebForms/PrikazOsoba.aspx");
            }

            else
            {
                lblInfoMessage.Visible = true;
                lblInfoMessage.Text = "Nepoznat korisnik.";
            }

        }

        public bool UserExists()
        {
            if (Statics.manager.CheckIfEmailExists(txtEmail.Text) != null)
            {
                Email email = Statics.manager.CheckIfEmailExists(txtEmail.Text);
                if (Statics.manager.GetLoginData(email.Person.IDPerson, txtPassword.Text) != null)
                {
                    person = Statics.manager.GetLoginData(email.Person.IDPerson, txtPassword.Text);
                    return true;
                }
            }

            return false;

        }

        protected void cbRemember_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = false;
        }


    }
}
