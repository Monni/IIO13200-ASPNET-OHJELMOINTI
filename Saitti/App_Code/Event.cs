using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Event
/// </summary>
public class Event
{
    public int id { get; set; }
    public string title { get; set; }
    public string shortSynopsis { get; set; }
    public string eventUrl { get; set; }
    public string smallImagePortraitUrl { get; set; }

    public Event()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}