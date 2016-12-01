using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LuePalaute : System.Web.UI.Page
{
    DataSet ds;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ShowXMLFeedBack()
    {
        ds = new DataSet();
        lblFooter.Text = "";
        String filePath = @"~/App_Data/feedback.xml";
        if (File.Exists(MapPath(filePath)))
        {
            ds.ReadXml(MapPath(filePath));
            gvFeedback.DataSource = ds;
            gvFeedback.DataBind();
        }
        else
        {
            lblFooter.Text = "There is no feedback.";
        }
    }

    protected void ShowSQLFeedback()
    {
        try
        {
            lblFooter.Text = "";
            ds = new DataSet();

            using (MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Mysli"].ConnectionString))
            {
                conn.Open();
                using (MySql.Data.MySqlClient.MySqlDataAdapter da = new MySql.Data.MySqlClient.MySqlDataAdapter("SELECT opintojakso, tekija, opittu, haluanoppia, hyvaa, parannettavaa, muuta, pvm FROM palaute", conn))
                {
                    da.Fill(ds);
                }
            }
            gvFeedback.DataSource = ds;
            gvFeedback.DataBind();

        }
        catch (Exception ex)
        {
            lblFooter.Text = ex.Message;
        }
    }

    protected void btnShowXMLFeedback_Click(object sender, EventArgs e)
    {
        ShowXMLFeedBack();
    }

    protected void btnShowSQLFeedback_Click(object sender, EventArgs e)
    {
        ShowSQLFeedback();
    }
}