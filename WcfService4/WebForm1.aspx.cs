using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WcfService4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLoad_Click(object sender, EventArgs e)
        {
            LuuProducts.Luu_ProductClient client = new LuuProducts.Luu_ProductClient();
            grvProduct.DataSource = client.ReturnProducts();
            grvProduct.DataBind();
        }
    }
}