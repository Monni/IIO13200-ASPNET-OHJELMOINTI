using System;
using System.Collections.Generic;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class testJSON : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnGet_click(object sender, EventArgs e)
    {
        var data = GetJsonFromWeb("JsonTestP");
        ltResult.Text = data;
    }
    protected string GetJsonFromWeb(string filename)
    {
        string url = "http://student.labranet.jamk.fi/~salesa/mat/" + filename;
        using (WebClient wc = new WebClient())
        {
            var json = wc.DownloadString(url);
            return json;
        }
    }
}