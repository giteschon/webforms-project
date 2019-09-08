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
    public partial class ucPerson : System.Web.UI.UserControl
    {
        public string Name
        {
            get => txtName.Text;
            set
            {
                txtName.Text = value;
            }
        }

        public string Surname
        {
            get => txtSurname.Text;
            set
            {
                txtSurname.Text = value;
            }
        }

        public string Telephone
        {
            get => txtTelephone.Text;
            set
            {
                txtTelephone.Text = value;
            }
        }

        public string Password
        {
            get => txtPassword.Text;
            set
            {
                txtPassword.Text = value;
            }
        }

        public string Email
        {
            get => txtEmail.Text;
            set
            {
                //ddlEmail.SelectedItem.Text = value;
                //ddlEmail.SelectedItem.Text = value;
                txtEmail.Text = ddlEmail.SelectedItem.Text; ;

            }
        }

        private int id;
        public int IDPerson { get => id;

            set {
                id = value;
            } }

       



        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            if (!IsPostBack)
            {
                Statics.manager.LoadCities(ddlCity);
                Statics.manager.LoadStatus(ddlStatus);
                Statics.manager.LoadEmailsPerPerson(ddlEmail, IDPerson);
            }


        }


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddEmail_Click(object sender, ImageClickEventArgs e)
        {
            if (txtEmail.Text != "")
            {
                Statics.manager.EditEmail(ddlCity.SelectedItem.Value, txtEmail.Text);


            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            City city = Statics.manager.GetCity(int.Parse(ddlCity.SelectedItem.Value));
            Status status = Statics.manager.GetStatus(int.Parse(ddlStatus.SelectedItem.Value));
            Person p = new Person(IDPerson, Name, Surname, city, Password,status);
            Statics.manager.EditPerson(p);
            if (txtEmail.Text != "")
            {
                Statics.manager.EditEmail(ddlEmail.SelectedItem.Text, txtEmail.Text);
            }

            Response.Redirect(Request.RawUrl);
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Statics.manager.DeletePerson(IDPerson);
            Response.Redirect(Request.RawUrl);
        }

        protected void ddlEmail_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEmail.Text = ddlEmail.SelectedItem.Text;
        }
    }
}