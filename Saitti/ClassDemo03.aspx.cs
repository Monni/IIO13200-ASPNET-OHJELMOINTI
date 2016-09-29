using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ClassDemo03 : System.Web.UI.Page
{
    public string Messu
    {
        get { return txtMessage.Text; }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        // Täällä tehdään yleensä kaikki sivun alustukseen liittyvät jutskut
        // HUOM mutta vain yhden kerran!
        if (!IsPostBack)
        {
            ddlMessages.Items.Add("Ping!");
            ddlMessages.Items.Add("Hello, handshake?");
            ddlMessages.Items.Add("Goodbye");
        }
    }

    protected void btnQueryString_Click(object sender, EventArgs e)
    {
        // Ohjataan pyyntö uudelle sivulle ja välitetään teksti kutsun mukana
        Response.Redirect("ClassDemo03_tapa01.aspx?Data=" + txtMessage.Text);
    }

    protected void btnHttpPost_Click(object sender, EventArgs e)
    {

    }

    protected void btnSession_Click(object sender, EventArgs e)
    {
        // Kirjoitetaan Sessioniin
        Session["viesti"] = txtMessage.Text;
        Response.Redirect("ClassDemo03_tapa03.aspx");
    }

    protected void btnCookie_Click(object sender, EventArgs e)
    {
        // Luodaan keksi ja kirjoitetaan siihen
        HttpCookie keksi = new HttpCookie("viesti", txtMessage.Text);
        keksi.Expires = DateTime.Now.AddMinutes(15);
        Response.Cookies.Add(keksi);
    }

    protected void btnProperty_Click(object sender, EventArgs e)
    {
        //Response.Redirect("ClassDemo03_tapa05.aspx");  - ei kelpaa, koska PreviousPage ei synny tjsp
        Server.Transfer("ClassDemo03_tapa05.aspx");
    }

    protected void ddlMessages_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtMessage.Text = ddlMessages.SelectedItem.ToString();
    }
}