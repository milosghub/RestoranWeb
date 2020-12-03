using BusinessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentationLayerWeb
{
    
    public partial class _Default : Page
    {
        private VetBusiness vetBusiness;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.vetBusiness = new VetBusiness();

            List<Veterinar> results = this.vetBusiness.GetAllVets();

            ListBoxVet.Items.Clear();
            foreach (Veterinar v in results)
            {
                ListBoxVet.Items.Add(v.Id + ", " + v.FullName + ", " + v.Speciality + ", " + v.Expirience);
            }

        }
    }
}