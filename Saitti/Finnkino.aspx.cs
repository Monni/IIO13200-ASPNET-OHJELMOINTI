using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Xml;

public partial class Finnkino : System.Web.UI.Page
{
    List<Theatre> theatres;
    List<Event> events;
    List<Show> shows;

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!Page.IsPostBack)
            {
                Initialize();
                GetTheatres();
                // GetEvents();
            }

        }
        catch (Exception ex)
        {
            ltFooter.Text = ex.Message;
        }
    }

    protected void Initialize()
    {
        try
        {
            theatres = new List<Theatre>();
            events = new List<Event>();
            shows = new List<Show>();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    protected void GetTheatres()
    {
        try
        {
            XmlDocument xmldoc = xdsTheatres.GetXmlDocument();
            XmlNodeList nodeList = xmldoc.SelectNodes("/TheatreAreas/TheatreArea");
            Theatre temp;

            foreach (XmlNode listNode in nodeList)
            {
                if (listNode["ID"].InnerText != "1029")
                {
                    temp = new Theatre();
                    temp.id = Int32.Parse(listNode["ID"].InnerText);
                    temp.name = listNode["Name"].InnerText;
                    theatres.Add(temp);
                }
            }

            lbTheatres.DataSource = theatres;
            lbTheatres.DataTextField = "name";
            lbTheatres.DataValueField = "id";
            lbTheatres.DataBind();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    protected void GetEvents()
    {
        try
        {
            XmlDocument xmldoc = xdsEvents.GetXmlDocument();
            XmlNodeList nodeList = xmldoc.SelectNodes("/Events/Event");
            Event temp;

            foreach (XmlNode listNode in nodeList)
            {
                temp = new Event();
                temp.id = Int32.Parse(listNode["ID"].InnerText);
                temp.title = listNode["Title"].InnerText;
                temp.shortSynopsis = listNode["ShortSynopsis"].InnerText;
                temp.eventUrl = listNode["EventURL"].InnerText;
                events.Add(temp);
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    protected void GetShows(int theatreId)
    {
        try
        {
            xdsShows.DataFile = @"http://www.finnkino.fi/xml/Schedule/?area=" + theatreId + "&dt=" + DateTime.Today.Day + "." + DateTime.Today.Month + "." + DateTime.Today.Year;
            XmlDocument xmldoc = xdsShows.GetXmlDocument();
            XmlNodeList nodeList = xmldoc.SelectNodes("/Schedule/Shows/Show");
            XmlNode images;

            ltPosters.Text = "<table>";
            int posterCount = 0;

            foreach (XmlNode listNode in nodeList)
            {
                if (posterCount == 0)
                {
                    ltPosters.Text += "<tr>";
                }

                images = listNode.SelectSingleNode("Images");
                ltPosters.Text += "<td><a href='" + listNode["EventURL"].InnerText + "'> <img src='" + images["EventSmallImagePortrait"].InnerText + "' alt=''/> </a></td>";

                if (posterCount == 10)
                {
                    ltPosters.Text += "</tr>";
                    posterCount = 0;
                }
                posterCount++;
            }

            ltPosters.Text += "</table>";
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    protected void lbTheatres_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            GetShows(Int32.Parse(lbTheatres.SelectedValue));
        }
        catch (Exception ex)
        {
            ltFooter.Text = ex.Message;
        }
    }
}