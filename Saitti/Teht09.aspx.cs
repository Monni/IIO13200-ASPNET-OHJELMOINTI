using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;

public partial class Teht09 : System.Web.UI.Page
{
   
    private List<t09Station> stations;
    private List<t09Train> trains;
    protected void Page_Load(object sender, EventArgs e)
    {
        CallTrainStationFetcher();
    }

    private async void CallTrainStationFetcher()
    {
        try
        {
            stations = await GetStations();
            if (!Page.IsPostBack)
            {
                ddlStations.DataSource = stations;
                ddlStations.DataTextField = "stationName";
                ddlStations.DataValueField = "stationShortCode";
                ddlStations.DataBind();
            }
        } catch (Exception e)
        {
       //     throw e;
        }
    }

    protected void btnGetTrains_Click(object sender, EventArgs e)
    {
        try
        {
            CallTrainFetcher();
        } catch (Exception ex)
        {
            throw ex;
        }
    }

    private async void CallTrainFetcher()
    {
        try
        {
            trains = await GetTrains(ddlStations.SelectedValue);
            gvSchedule.DataSource = trains;
            gvSchedule.DataBind();
        }
        catch (Exception e)
        {
            throw e;
        }
    }

    private Task<List<t09Train>> GetTrains(String station)
    {
        List<t09Train> trains;
        string jsonData;
        string date;
        string day = DateTime.Today.Day.ToString();
        if (day.Length < 2)
        {
            day = "0" + day;
        }
        date = DateTime.Today.Year + "-" + DateTime.Today.Month + "-" + day;
        string urlString = "http://rata.digitraffic.fi/api/v1/train-tracking?station=" + station + "&departure_date=" + date;
        jsonData = GetJsonData(urlString);
        trains = ConvertJsonToTrains(jsonData);
        return Task.Run<List<t09Train>>(() => trains);
    }

    private List<t09Train> ConvertJsonToTrains(string jsonData)
    {
        try
        {
            List<t09Train> trains = JsonConvert.DeserializeObject<List<t09Train>>(jsonData);
            return trains;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }


    protected void ddlStations_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private Task<List<t09Station>> GetStations()
    {
        try
        {
            List<t09Station> stations;
            string urlString = "http://rata.digitraffic.fi/api/v1/metadata/stations";
            string jsonData = GetJsonData(urlString);
            stations = ConvertJsonToStations(jsonData);
            return Task.Run<List<t09Station>>(() => stations);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    private List<t09Station> ConvertJsonToStations(string jsonData)
    {
        try
        {
            List<t09Station> stations = JsonConvert.DeserializeObject<List<t09Station>>(jsonData);
            return stations;
        } catch (Exception e)
        {
            throw e;
        }
    }


    private static string GetJsonData(string url)
    {
        try
        {
            using (WebClient wc = new WebClient())
            {
                return wc.DownloadString(url);
            }
        } catch (Exception e)
        {
            throw e;
        }
    }




}


