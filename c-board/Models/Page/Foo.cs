using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace c_board.Models.Page
{
    public class Foo : System.Web.UI.Page
    {
        protected String shopCode;
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            if (!Page.RouteData.Values.ContainsKey("shop_code"))
            {
                shopCode = "Not Found";
            }
            else
            {
                shopCode = Page.RouteData.Values["shop_code"] as String;
            }

            
        }
    }
}