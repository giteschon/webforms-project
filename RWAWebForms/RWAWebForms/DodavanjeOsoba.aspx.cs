using RWAWebForms.Models;
using RWAWebForms.Models.BL;
using RWAWebForms.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RWAWebForms.RWAWebForms
{
    public partial class DodavanjeOsoba : MyPage
    {
        //  private PersonBusiness repo = new PersonBusiness(new RepoTextFile());

        private int count = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                manager.LoadStatus(ddlStatus);
                manager.LoadCities(ddlCity);
                txtName.Focus();
            }


        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            p.Name = txtName.Text;
            p.Surname = txtSurname.Text;
            p.Telephone = txtTelephone.Text;
            p.City = manager.GetCity(int.Parse(ddlCity.SelectedItem.Value));
            p.Status = manager.GetStatus(int.Parse(ddlStatus.SelectedItem.Value));
            p.Password = txtPassword.Text;

            manager.AddPerson(p);

            AddEmail(txtEmail1.Text, p);

            if (txtEmail2.Text != "")
            {
                AddEmail(txtEmail2.Text, p);


            }
            if (txtEmail3.Text != "")
            {
                AddEmail(txtEmail3.Text, p);
            }


            if (IsPostBack)
            {
                resetForm();
            }
        }

        private void resetForm()
        {
            txtName.Text = "";
            txtSurname.Text = "";
            txtTelephone.Text = "";
            ddlCity.SelectedIndex = 0;
            ddlStatus.SelectedIndex = 0;
            txtPassword.Text = "";
            txtRepeatPassword.Text = "";

            txtEmail1.Text = "";
            txtEmail2.Text = "";
            txtEmail2.Visible = false;
            txtEmail3.Text = "";
            txtEmail3.Visible = false;
            btnAddMoreEmails.Visible = true;

        }

        private void AddEmail(string email, Person p)
        {
            Email e = new Email();
            e.EmailValue = email;
            e.Person = manager.GetPerson(p);
            manager.AddEmail(e);
        }


        protected void btnAddMoreEmails_Click(object sender, EventArgs e)
        {
            if (txtEmail2.Visible)
            {
                txtEmail3.Visible = true;
                btnAddMoreEmails.Visible = false;
            }

            txtEmail2.Visible = true;

        }
    }
}