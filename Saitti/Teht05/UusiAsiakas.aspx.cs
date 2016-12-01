using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Teht05_UusiAsiakas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSaveCustomer_Click(object sender, EventArgs e)
    {
        SaveCustomer();
    }

    protected void SaveCustomer()
    {
        using (DemoxOyEntities entities = new DemoxOyEntities())
        {
            asiakas uusiAsiakas = new asiakas();
            uusiAsiakas.asnimi = txtNimi.Text;
            uusiAsiakas.astunnus = txtTunnus.Text;
            uusiAsiakas.asvuosi = short.Parse(txtVuosi.Text);
            uusiAsiakas.maa = txtMaa.Text;
            uusiAsiakas.ostot = double.Parse(txtOstot.Text);
            uusiAsiakas.postinro = txtPostinr.Text;
            uusiAsiakas.postitmp = txtPostitmp.Text;
            uusiAsiakas.yhteyshlo = txtYht.Text;
            entities.asiakas.Add(uusiAsiakas);
            entities.SaveChanges();
            lblFooter.Text = "Asiakas " + uusiAsiakas.asnimi + " tallennettu onnistuneesti!";
        }
    }
}