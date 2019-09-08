using RWAWebForms.Models;
using RWAWebForms.Models.BL;
using RWAWebForms.UControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RWAWebForms.RWAWebForms
{
    public partial class AzuriranjeOsoba : MyPage
    {
    //   private PersonBusiness repo = new PersonBusiness(new RepoTextFile());

        protected void Page_Load(object sender, EventArgs e)
        {
            //for (int i = 0; i < manager.GetPersons().Capacity; i++)
            //{
            //                                   ucPerson uc=(ucPerson) LoadControl("~/UControls/ucPerson.ascx");
            //    uc.Name = manager.get;
            //    phPersons.Controls.Add(uc);
            //}

            //ddl-ovi ne rade + dodat

            foreach (Person p in manager.GetPersons())
            {
                ucPerson uc = (ucPerson)LoadControl("~/UControls/ucPerson.ascx");

                uc.IDPerson = p.IDPerson;
                uc.Name = p.Name;
                uc.Surname = p.Surname;
                uc.Telephone = p.Telephone;
                uc.Password = p.Password;
                phPersons.Controls.Add(uc);
            }
        }
    }
}