using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HtmlAgilityPack;
using SKMTimetableWebAPI.Models;

namespace SKMTimetableWebAPI.Parser
{
    public class Timetable
    {

        public List<Train> Scraper(int idStart, int idEnd, bool today)
        {
            //output
            List<Train> list = new List<Train>();

            //prepare date for url
            DateTime date = new DateTime();
            if (today)
                date = DateTime.Now;
            else
                date = DateTime.Now.AddDays(1);

            string day, month, year;
            day = date.Year.ToString("dd");
            month = date.Month.ToString("MM");
            year = date.Year.ToString("yyyy");

            //string page = @"http://skm.trojmiasto.pl/rozklad.php?stacja_od=34&stacja_do=29&data=07%2F04%2F2015";
            string page = @"http://skm.trojmiasto.pl/rozklad.php?stacja_od=" + idStart.ToString() + @"&stacja_do=" + idEnd.ToString() + @"&data=" + day + "%2F" + month + "%2F" + year;

            //new webpage
            var webGet = new HtmlWeb();
            var doc = webGet.Load(page);

            //XPath formulas
            string stationsRow = @"//div[@class='station-row']";
            string singleStationRow = @"(//div[@class='station-row'])";
            string hours = @"/div[@class='hour']";
            string minutesCell = @"//div[@class='minutes-cell']";
            string minutes = @"/div[@class='minutes']";
            string tips = @"/div[@class='tips']";

            //page scraping
            if (doc != null && doc.DocumentNode != null &&
                doc.DocumentNode.SelectNodes(stationsRow) != null)
            {
                //get every single station-row in page
                for (int i = 1; i <= doc.DocumentNode.SelectNodes(stationsRow).Count; i++)
                {
                    //get minutes-cell of each station-row
                    for (int j = 1; j <= doc.DocumentNode.SelectNodes(singleStationRow + "[" + i + "]" + minutesCell).Count; j++)
                    {
                        list.Add(
                            new Train { 
                                Id = idStart.ToString() + "x" + idEnd.ToString() + "x" + date.ToString("dd"),
                                IdStart = idStart.ToString(),
                                IdEnd = idEnd.ToString(),
                                TimetableDate = date.ToString("yyyy-MM-dd"),
                                Hour = doc.DocumentNode.SelectSingleNode(singleStationRow + "[" + i + "]" + hours).InnerText.ToString(),
                                Minute = doc.DocumentNode.SelectSingleNode("(" + singleStationRow + "[" + i + "]" + minutesCell + ")[" + j + "]" + minutes).InnerText.ToString(),
                                //sometimes Tip is null
                                Tip = doc.DocumentNode.SelectSingleNode("(" + singleStationRow + "[" + i + "]" + minutesCell + ")[" + j + "]" + tips).InnerText.ToString().Trim()
                            });
                    }
                }
            }

            return list;
        }

        public List<Train> AllStationsData()
        {
            StationsList stationList = new StationsList(); //get lists of stations & directions id's

            List<Train> listTrain = new List<Train>(); //output
            List<Train> initialListTrain = new List<Train>(); //current output from Scraper(...)
            
            List<Station> listStation = new List<Station>(); //list with starting station id's
            List<Station> listDirection = new List<Station>(); //list with ending station id's
            

            bool flag;
            listStation = stationList.GetStations();
            listDirection = stationList.GetDirections();

            for (int i = 0; i < listStation.Count; i++)
            {
                for (int j = 0; j < listDirection.Count; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        flag = (k == 0) ? true : false;

                        if (i != j)
                        {
                            initialListTrain.Clear();
                            initialListTrain = Scraper(listStation[i].Id, listDirection[j].Id, flag);
                            listTrain.AddRange(initialListTrain);
                        }
                    }
                }
            }
            
            return listTrain;
        }


    }
}