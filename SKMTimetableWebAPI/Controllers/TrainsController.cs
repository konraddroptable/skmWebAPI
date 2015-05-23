using SKMTimetableWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SKMTimetableWebAPI.Parser;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.IO;
using System.Text;

namespace SKMTimetableWebAPI.Controllers
{

    public class TrainsController : ApiController
    {
        Timetable timetable = new Timetable();


        //Be Aware of using this! (loading full API takes up to 30-50 minutes)
        //public IEnumerable<Train> GetAllTrains()
        //{
        //    //trainList = timetable.Scraper(43,48, true);
        //    trainList = timetable.AllStationsData();
            
        //    return trainList;
        //}

        public IHttpActionResult GetOneTrain(int idStart, int idEnd)
        {
            var collection = new List<Train>();
            //trainList = timetable.Scraper(idStart, idEnd, true);
            collection = timetable.Scraper(idStart, idEnd, true);

            dynamic collectionWrapper = new
            {
                records = collection
            };

            //var output = JsonConvert.SerializeObject(collectionWrapper);


            if (collectionWrapper == null)
                return NotFound();

            return Ok(collectionWrapper);
        }

        public IHttpActionResult GetOneTrain(int idStart, int idEnd, int hour)
        {
            var collection = new List<Train>();
            

            //trainList = timetable.Scraper(idStart, idEnd, true);
            collection = timetable.Scraper(idStart, idEnd, true, hour);
            collection.AddRange(timetable.ScraperTommorowShort(idStart, idEnd, false, 1));

            dynamic collectionWrapper = new
            {
                records = collection
            };

            //var output = JsonConvert.SerializeObject(collectionWrapper);


            if (collectionWrapper == null)
                return NotFound();

            return Ok(collectionWrapper);
        }

        public IHttpActionResult GetOneTrain(int idStart, int idEnd, bool today, int hour)
        {
            var collection = new List<Train>();
            //trainList = timetable.Scraper(idStart, idEnd, true);
            collection = timetable.Scraper(idStart, idEnd, today, hour);

            dynamic collectionWrapper = new
            {
                records = collection
            };

            //var output = JsonConvert.SerializeObject(collectionWrapper);


            if (collectionWrapper == null)
                return NotFound();

            return Ok(collectionWrapper);
        }

        public IHttpActionResult GetOneTrain(int idStart, int idEnd, bool today)
        {
            var collection = new List<Train>();
            //trainList = timetable.Scraper(idStart, idEnd, true);
            collection = timetable.Scraper(idStart, idEnd, today);

            dynamic collectionWrapper = new
            {
                records = collection
            };

            //var output = JsonConvert.SerializeObject(collectionWrapper);


            if (collectionWrapper == null)
                return NotFound();


            return Ok(collectionWrapper);
        }


    }
}
