using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Teht03 : System.Web.UI.Page
{
    DateTime currentDate;
    DateTime selectedDate;
    protected void Page_Load(object sender, EventArgs e)
    {
        currentDate = calendar.TodaysDate;
        lblCurrentDate.Text = currentDate.Day + "." + currentDate.Month + "." + currentDate.Year;
    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        if (calendar.VisibleDate == DateTime.MinValue)
        {
            calendar.VisibleDate = DateTime.Now;
        }
        calendar.VisibleDate = calendar.VisibleDate.AddYears(-1);
    }

    protected void btnForward_Click(object sender, EventArgs e)
    {
        if (calendar.VisibleDate == DateTime.MinValue)
        {
            calendar.VisibleDate = DateTime.Now;
        }
        calendar.VisibleDate = calendar.VisibleDate.AddYears(1);
    }

    protected void calendar_SelectionChanged(object sender, EventArgs e)
    {
        selectedDate = calendar.SelectedDate;
        lblChosenDate.Text = selectedDate.Day + "." + selectedDate.Month + "." + selectedDate.Year;
        lblDifference.Text = (selectedDate - currentDate).TotalDays.ToString() + " Päivää";
    }
}