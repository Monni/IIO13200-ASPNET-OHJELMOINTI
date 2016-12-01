using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Record
/// </summary>
public class Record
{
    public string ISBN { get; set; }
    public string artist { get; set; }
    public double price { get; set; }
    public string title { get; set; }
    public List<Track> tracks { get; set; }
    public Record()
    {
        tracks = new List<Track>();
    }

    public override string ToString()
    {
        // Syöpää, mutta listviewiin listatun objektin saa takaisin koodiin vain stringinä joten käytetään tostringiä
        string value = "";

        value += "<h1>" + artist + " : " + title + "</h1><p>" + price + "€</p>";

        foreach (Track track in tracks)
        {
            value += track.ToString();
        }

        return value;
    }

}