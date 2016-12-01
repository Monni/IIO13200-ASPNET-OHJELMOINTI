using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for t09BLTrain
/// </summary>
public class t09Train
{
    public string id { get; set; }
    public string trainNumber { get; set; }
    public string departureDate { get; set; }
    public string timestamp { get; set; }
    public string station { get; set; }
    public t09Train(string ID, string TrainNumber, string DepartureDate, string TimeStamp, string Station)
    {
        id = ID;
        trainNumber = TrainNumber;
        departureDate = DepartureDate;
        timestamp = TimeStamp;
        station = Station;
    }

    public override string ToString()
    {
        return id + "," + trainNumber + "," + departureDate + "," + timestamp + "," + station;
    }

}