using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Show
/// </summary>
public class Show
{
    public int id { get; set; }
    public int theatreId { get; set; }
    public int eventId { get; set; }
    public string theatre { get; set; }
    public string title { get; set; }
    public string smallImagePortraitUrl { get; set; }
    public string eventUrl { get; set; }

    public Show()
    {

    }
}