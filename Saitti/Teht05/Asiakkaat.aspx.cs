using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Teht05_Asiakkaat : System.Web.UI.Page
{
    public static DemoxOyEntities ctx;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ctx = new DemoxOyEntities();
            FillControls();
        }
    }

    protected void FillControls()
    {
        var DropDownItems = (from c in ctx.asiakas orderby c.maa select c.maa).Distinct();
        ddlCountry.DataSource = DropDownItems.ToList();
        ddlCountry.DataBind();
    }

    protected void btnGetCustomersByCountry_Click(object sender, EventArgs e)
    {
        var customers = (from c in ctx.asiakas select c).ToList();
        ltrlCustomers.Text = "";

        for (int i = 0; i < ddlCountry.Items.Count; i++)
        {
            ltrlCustomers.Text += "<h3>" + ddlCountry.Items[i].Value + "</h3><p>";
            var customersFromCountry = from c in customers where c.maa == ddlCountry.Items[i].Value select c;
            foreach (asiakas customer in customersFromCountry)
            {
                ltrlCustomers.Text += customer.asnimi + "</br>";
            }
            ltrlCustomers.Text += "</p>";
        }

    }

    protected void btnGetFromCountry_Click(object sender, EventArgs e)
    {
        var customers = from c in ctx.asiakas where c.maa == ddlCountry.SelectedValue select c;
        gvCustomers.DataSource = customers.ToList();
        gvCustomers.DataBind();
    }

    protected void btnGetCustomers_Click(object sender, EventArgs e)
    {
        var customers = from c in ctx.asiakas select c;
        gvCustomers.DataSource = customers.ToList();
        gvCustomers.DataBind();
    }
}