﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace teamproj2
{
    public partial class ultrabooks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void displayId(int pid3)
        {
            Ultrabook l3 = new Ultrabook(pid3);
            Response.Write(l3.Id);
        }
        protected void displayPicture(int pid3)
        {
            Ultrabook l3 = new Ultrabook(pid3);
            Response.Write(l3.Picture);
        }
        protected void displayDesc(int pid3)
        {
            Ultrabook l3 = new Ultrabook(pid3);
            Response.Write(l3.Desc);
        }
        protected void displayName(int pid3)
        {
            Ultrabook l3 = new Ultrabook(pid3);
            Response.Write(l3.Name);
        }
        protected void displayPrice(int pid3)
        {
            Ultrabook l3 = new Ultrabook(pid3);
            Response.Write(String.Format("{0:C}", l3.Price));
        }
    }
}