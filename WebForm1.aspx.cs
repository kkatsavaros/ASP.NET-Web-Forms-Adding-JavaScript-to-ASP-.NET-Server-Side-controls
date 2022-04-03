using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace s01.JavascriptToAspNetServerSideControls
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            ImageButton1.Attributes.Add("onmouseover", "this.src='/images/greenButton.png'");

            ImageButton1.Attributes.Add("onmouseout", "this.src='/images/blueButton.png'");

            ImageButton1.Attributes.Add("onClick", "return confirm('Are you sure you want to submit'); ");

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Write("Server side click event handled");
        }

    }
}
