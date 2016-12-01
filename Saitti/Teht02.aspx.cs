using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Teht02 : System.Web.UI.Page
{
    BLLotto bllotto = new BLLotto();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (rivit.Items.Count == 0)
        {
            for (int i = 0; i < 11; i++)
            {
                rivit.Items.Add(new ListItem(Convert.ToString(i)));
            }
        }
    }

    protected void haeRivit_Click(object sender, EventArgs e)
    {
        if (type.SelectedValue == "Lotto")
        {
            bllotto.ArvoRivi(1, Convert.ToInt32(rivit.SelectedValue));
            foreach (var list in bllotto.drawnNumbers)
            {
                foreach (var number in list)
                {
                    showResults.Text = showResults.Text + " " + number;
                }
                showResults.Text = showResults.Text + "<br />";
            }
        }
        else
        {
            bllotto.ArvoRivi(2, Convert.ToInt32(rivit.SelectedValue));
            foreach (var list in bllotto.drawnNumbers)
            {
                foreach (var number in list)
                {
                    showResults.Text = showResults.Text + " " + number;
                }
                showResults.Text = showResults.Text + "<br />";
            }
        }
    }
}