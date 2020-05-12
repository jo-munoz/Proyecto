using System;

namespace Proyecto.Web.Views.Index
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["sessionEmail"] == null)
            {
                Response.Redirect("../Login/Login.aspx");
            }            
        }
    }
}