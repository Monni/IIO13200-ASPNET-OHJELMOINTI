using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;

public partial class Palaute : System.Web.UI.Page
{
    string name;
    string date;
    string other;
    string wantToLearn;
    string learned;
    string courseCode;
    string courseName;
    string positives;
    string negatives;

    protected void Page_Load(object sender, EventArgs e)
    {


    }

    protected void FillVariables()
    {
        courseCode = txtCourseCode.Text;
        courseName = txtCourseName.Text;
        name = txtName.Text;
        other = txtOther.Text;
        negatives = txtFaults.Text;
        positives = txtGoods.Text;
        wantToLearn = txtToLearn.Text;
        learned = txtLearned.Text;
        date = txtDate.Text;
    }

    protected void WriteVariablesToXml(string FilePath)
    {
        XDocument doc = XDocument.Load(FilePath);
        XElement feedback = doc.Element("feedback");
        XElement Item = new XElement("Item");
        XElement CourseCode = new XElement("CourseCode");
        CourseCode.Value = courseCode;
        XElement CourseName = new XElement("CourseName");
        CourseName.Value = courseName;
        XElement Name = new XElement("Name");
        Name.Value = name;
        XElement Date = new XElement("Date");
        Date.Value = date;
        XElement WishToLearn = new XElement("WishToLearn");
        WishToLearn.Value = wantToLearn;
        XElement Learned = new XElement("Learned");
        Learned.Value = learned;
        XElement Other = new XElement("Other");
        Other.Value = other;

        Item.Add(CourseCode, CourseName, Name, Date, WishToLearn, Learned, Other);
        feedback.Add(Item);
        doc.Save(FilePath);
    }

    protected void CreateXmlFile(string FilePath)
    {
        XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
        xmlWriterSettings.Indent = true;
        xmlWriterSettings.NewLineOnAttributes = true;
        using (XmlWriter xmlWriter = XmlWriter.Create(FilePath, xmlWriterSettings))
        {
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("feedback");
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();
            xmlWriter.Flush();
            xmlWriter.Close();
        }
    }

    protected void SaveToXml()
    {
        FillVariables();
        String filePath = HttpContext.Current.Server.MapPath("~/App_Data/feedback.xml");
        if (!File.Exists(filePath))
        {
            CreateXmlFile(filePath);
            WriteVariablesToXml(filePath);
        }
        else
        {
            WriteVariablesToXml(filePath);
        }
    }

    protected void SaveToSql()
    {
        FillVariables();
        int affectedRows = 0;
        using (MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["connStr"].ConnectionString))
        {
            conn.Open();
            string commandString = String.Format("INSERT INTO palaute (opintojakso, tekija, opittu, haluanoppia, hyvaa, parannettavaa, muuta, pvm) VALUES ({0},{1},{2},{3},{4},{5},{6},{7})", courseCode, name, learned, wantToLearn, positives, negatives, other, date);
            using (MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(commandString))
            {
                affectedRows = command.ExecuteNonQuery();
            }
        }
        lblFooter.Text = "Lisätty " + affectedRows + " tietuetta kantaan";
    }

    protected void btnSaveXml_Click(object sender, EventArgs e)
    {
        SaveToXml();
    }

    protected void btnSaveSql_Click(object sender, EventArgs e)
    {
        SaveToSql();
    }
}