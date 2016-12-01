using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ClassDemo03_tapa04 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Tarkistetaan löytyykö haluttua keksiä, jos löytyy niin kirjoitetaan sen arvo
        foreach (string kex in Request.Cookies)
        {
            if (kex == "viesti")
                target.InnerHtml = "Keksissäsi lukee " + Request.Cookies["kex"].Value;
        }
    }
}