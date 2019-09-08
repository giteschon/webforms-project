using RWAWebForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace RWAWebForms.RWAWebForms
{
    public partial class PrikazOsoba : MyPage
    {
       // private RepoDatabase r = new RepoDatabase();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ShowGridData();
                ShowRepeaterData();
            }
        }

        private void ShowRepeaterData()
        {
            repeater.DataSource = manager.GetPersons();
            repeater.DataBind();
        }

        private void ShowGridData()
        {
            gridPeople.DataSource = manager.GetPersons();
            gridPeople.DataBind();
        }

        //protected void ddlStatus_DataBound(object sender, EventArgs e)
        //{
        //  //  Cursor.Current = Cursors.No;
        //}
    }
}