using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Teht06_Levyinfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            ltRecord.Text = Session["record"].ToString();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}