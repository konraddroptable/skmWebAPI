using SKMTimetableWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SKMTimetableWebAPI.Parser;

namespace SKMTimetableWebAPI.Controllers
{
    public class TrainsController : ApiController
    {
        List<Train> trainList = new List<Train>();
        Timetable timetable = new Timetable();


        //Be Aware of using this! (loading full API takes up to 30-50 minutes)
        public IEnumerable<Train> GetAllTrains()
        {
            //trainList = timetable.Scraper(43,48, true);
            trainList = timetable.AllStationsData();
            
            return trainList;
        }

        public IHttpActionResult GetOneTrain(int idStart, int idEnd)
        {
            trainList = timetable.Scraper(idStart, idEnd, true);
            if (trainList == null)
                return NotFound();

            return Ok(trainList);
        }

        public IHttpActionResult GetOneTrain(int idStart, int idEnd, bool today)
        {
            trainList = timetable.Scraper(idStart, idEnd, today);
            if (trainList == null)
                return NotFound();

            return Ok(trainList);
        }

    }
}
