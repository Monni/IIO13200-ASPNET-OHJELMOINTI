using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JAMK.IT;
using System.Data;


public partial class SQLDataPage : System.Web.UI.Page
{
    DataTable dt;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            dt = DBDemoxOy.GetDataReal();
            gvCustomers2.DataSource = dt;
            gvCustomers2.DataBind();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}