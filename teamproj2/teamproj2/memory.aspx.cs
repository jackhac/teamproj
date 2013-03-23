using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace teamproj2
{
    public partial class memory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void displayId(int pid3)
        {
            RAM v3 = new RAM(pid3);
            Response.Write(v3.Id);
        }
        protected void displayPicture(int pid3)
        {
            RAM v3 = new RAM(pid3);
            Response.Write(v3.Picture);
        }
        protected void displayDesc(int pid3)
        {
            RAM v3 = new RAM(pid3);
            Response.Write(v3.Desc);
        }
        protected void displayName(int pid3)
        {
            RAM v3 = new RAM(pid3);
            Response.Write(v3.Name);
        }
        protected void displayPrice(int pid3)
        {
            RAM v3 = new RAM(pid3);
            Response.Write(String.Format("{0:C}", v3.Price));
        }
    }
}