using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ClassDemo03_tapa05 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Tsekataan tunnistaako edellisen sivun oikein
        var joku = PreviousPage;
        string msg = "";
        if (joku != null)
        {
            // Tehdään jotain
            msg = joku.Messu;
            target.InnerHtml = msg;
        }
        else
        {
            target.InnerHtml = "Ei aiempaa sivua?!";
        }
    }
}