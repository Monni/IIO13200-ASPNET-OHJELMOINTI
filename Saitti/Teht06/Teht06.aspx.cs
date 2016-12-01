using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Serialization;

public partial class Teht06_Teht06 : System.Web.UI.Page
{
    XmlDocument xmlDoc;
    List<Record> records;

    protected void Page_Load(object sender, EventArgs e)
    {

        try
        {
            Initialize();
            GetRecords();
            ListRecords();
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
            records = new List<Record>();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    protected void ListRecords()
    {
        try
        {
            lvAlbums.DataSource = records;
            lvAlbums.DataBind();
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }

    protected void GetRecords()
    {
        try
        {
            xmlDoc = xdsAlbums.GetXmlDocument();
            XmlNodeList recordNodeList = xmlDoc.GetElementsByTagName("record");
            XmlNodeList trackNodeList;
            Record tempRecord;
            Track tempTrack;
            foreach (XmlNode recordNode in recordNodeList)
            {
                tempRecord = new Record();
                tempRecord.artist = recordNode.Attributes["Artist"].InnerText;
                tempRecord.title = recordNode.Attributes["Title"].InnerText;
                tempRecord.ISBN = recordNode.Attributes["ISBN"].InnerText;
                tempRecord.price = Double.Parse(recordNode.Attributes["Price"].InnerText);

                trackNodeList = recordNode.SelectNodes("song");

                foreach (XmlNode trackNode in trackNodeList)
                {
                    tempTrack = new Track();
                    tempTrack.name = trackNode.Attributes["name"].InnerText;
                    tempTrack.number = trackNode.Attributes["num"].InnerText;
                    tempTrack.lyrics = trackNode.InnerText;
                    tempRecord.tracks.Add(tempTrack);
                }

                records.Add(tempRecord);
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    protected void ShowRecord(object sender, CommandEventArgs e)
    {
        try
        {
            Session["record"] = e.CommandArgument;
            Response.Redirect("Levyinfo.aspx");
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}