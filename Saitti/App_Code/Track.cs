using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Track
/// </summary>
public class Track
{
    public string number { get; set; }
    public string name { get; set; }
    public string lyrics { get; set; }
    public Track()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public override string ToString()
    {
        string returnString = "<h3>" + number + ". " + name + "</h3><p>" + lyrics + "</p>";

        return returnString;
    }
}