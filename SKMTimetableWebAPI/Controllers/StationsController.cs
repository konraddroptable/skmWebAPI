using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SKMTimetableWebAPI.Models;

namespace SKMTimetableWebAPI.Controllers
{
    public class StationsController : ApiController
    {
        StationsList stationList = new StationsList();
        List<Station> stations = new List<Station>();


        public IEnumerable<Station> GetAllTrains()
        {
            stations = stationList.GetStations();
            return stations;
        }

        public IHttpActionResult GetProduct(int id)
        {
            stations = stationList.GetStations();
            var train = stations.FirstOrDefault((p) => p.Id == id);
            if (train == null)
            {
                return NotFound();
            }
            return Ok(train);
        }
    }
}
