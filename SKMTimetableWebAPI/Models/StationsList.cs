using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SKMTimetableWebAPI.Models
{
    public class StationsList
    {
        public List<Station> GetDirections()
        {
            List<Station> station = new List<Station>();

            station.Add(new Station { Id = 1, Name = "SŁUPSK", Latitude = 54.467735, Longitude = 17.016978 });
            station.Add(new Station { Id = 9, Name = "LĘBORK", Latitude = 54.534139, Longitude = 17.750333 });
            station.Add(new Station { Id = 15, Name = "WEJHEROWO", Latitude = 54.606423, Longitude = 18.22907 });
            station.Add(new Station { Id = 19, Name = "REDA", Latitude = 54.595044, Longitude = 18.353763 });
            station.Add(new Station { Id = 20, Name = "RUMIA", Latitude = 54.569103, Longitude = 18.386425 });
            station.Add(new Station { Id = 24, Name = "Gdynia Cisowa", Latitude = 54.5508, Longitude = 18.443958 });
            station.Add(new Station { Id = 25, Name = "GDYNIA CHYLONIA", Latitude = 54.545938, Longitude = 18.462941 });
            station.Add(new Station { Id = 44, Name = "Gdańsk Śródmieście", Latitude = 54.347256, Longitude = 18.643631 });
            station.Add(new Station { Id = 48, Name = "Pruszcz Gd.", Latitude = 54.25873, Longitude = 18.646861 });
            station.Add(new Station { Id = 54, Name = "TCZEW", Latitude = 54.097841, Longitude = 18.789523 });

            return station;
        }
        
        public List<Station> GetStations()
        {
            List<Station> station = new List<Station>();

            station.Add(new Station { Id = 1, Name = "SŁUPSK", Latitude = 54.467735, Longitude = 17.016978 });
            station.Add(new Station { Id = 2, Name = "Jezierzyce Słup.", Latitude = 54.504766, Longitude = 17.121836 });
            station.Add(new Station { Id = 3, Name = "Damnica", Latitude = 54.498032, Longitude = 17.270698 });
            station.Add(new Station { Id = 4, Name = "Strzyżyno Słup.", Latitude = 54.491411, Longitude = 17.37162 });
            station.Add(new Station { Id = 5, Name = "Głuszyno Pom.", Latitude = 54.489857, Longitude = 17.423735 });
            station.Add(new Station { Id = 6, Name = "Potęgowo", Latitude = 54.484933, Longitude = 17.486498 });
            station.Add(new Station { Id = 7, Name = "Pogorzelice", Latitude = 54.50068, Longitude = 17.622401 });
            station.Add(new Station { Id = 8, Name = "Leśnice", Latitude = 54.513211, Longitude = 17.667422 });
            station.Add(new Station { Id = 9, Name = "LĘBORK", Latitude = 54.534139, Longitude = 17.750333 });
            station.Add(new Station { Id = 10, Name = "Godętowo", Latitude = 54.582031, Longitude = 17.865021 });
            station.Add(new Station { Id = 11, Name = "Bożepole Wielkie", Latitude = 54.569623, Longitude = 17.967027 });
            station.Add(new Station { Id = 12, Name = "Strzebielino Morskie", Latitude = 54.563307, Longitude = 18.029339 });
            station.Add(new Station { Id = 13, Name = "Luzino", Latitude = 54.567326, Longitude = 18.102759 });
            station.Add(new Station { Id = 14, Name = "Gościcino Wejherowskie", Latitude = 54.605249, Longitude = 18.161156 });
            station.Add(new Station { Id = 15, Name = "WEJHEROWO", Latitude = 54.606423, Longitude = 18.22907 });
            station.Add(new Station { Id = 16, Name = "Wejherowo Nanice", Latitude = 54.604258, Longitude = 18.247071 });
            station.Add(new Station { Id = 17, Name = "Wejherowo Śmiechowo", Latitude = 54.601911, Longitude = 18.274329 });
            station.Add(new Station { Id = 18, Name = "Reda Pieleszewo", Latitude = 54.602788, Longitude = 18.317588 });
            station.Add(new Station { Id = 19, Name = "REDA", Latitude = 54.595044, Longitude = 18.353763 });
            station.Add(new Station { Id = 20, Name = "RUMIA", Latitude = 54.569103, Longitude = 18.386425 });
            station.Add(new Station { Id = 21, Name = "Rumia Janowo", Latitude = 54.558964, Longitude = 18.405731 });
            station.Add(new Station { Id = 24, Name = "Gdynia Cisowa", Latitude = 54.5508, Longitude = 18.443958 });
            station.Add(new Station { Id = 25, Name = "GDYNIA CHYLONIA", Latitude = 54.545938, Longitude = 18.462941 });
            station.Add(new Station { Id = 26, Name = "Gdynia Leszczynki", Latitude = 54.54162, Longitude = 18.478515 });
            station.Add(new Station { Id = 27, Name = "Gdynia Grabówek", Latitude = 54.535862, Longitude = 18.493102 });
            station.Add(new Station { Id = 28, Name = "Gdynia Stocznia", Latitude = 54.525412, Longitude = 18.5189 });
            station.Add(new Station { Id = 29, Name = "GDYNIA GŁÓWNA", Latitude = 54.521031, Longitude = 18.529184 });
            station.Add(new Station { Id = 30, Name = "G.Wzg.Św.Maksym.", Latitude = 54.507794, Longitude = 18.535152 });
            station.Add(new Station { Id = 31, Name = "Gdynia Redłowo", Latitude = 54.49125, Longitude = 18.538281 });
            station.Add(new Station { Id = 32, Name = "Gdynia Orłowo", Latitude = 54.478244, Longitude = 18.547401 });
            station.Add(new Station { Id = 33, Name = "Sopot Kam. Potok", Latitude = 54.459388, Longitude = 18.552982 });
            station.Add(new Station { Id = 34, Name = "SOPOT", Latitude = 54.441606, Longitude = 18.561781 });
            station.Add(new Station { Id = 35, Name = "Sopot Wyścigi", Latitude = 54.431063, Longitude = 18.564984 });
            station.Add(new Station { Id = 36, Name = "Gdańsk Żabianka", Latitude = 54.420636, Longitude = 18.568271 });
            station.Add(new Station { Id = 37, Name = "GDAŃSK OLIWA", Latitude = 54.410137, Longitude = 18.571666 });
            station.Add(new Station { Id = 38, Name = "Gd.Przym-Uniwer.", Latitude = 54.40142, Longitude = 18.575957 });
            station.Add(new Station { Id = 39, Name = "Gdańsk Zaspa", Latitude = 54.389064, Longitude = 18.592481 });
            station.Add(new Station { Id = 40, Name = "GDAŃSK WRZESZCZ", Latitude = 54.38186, Longitude = 18.605438 });
            station.Add(new Station { Id = 41, Name = "Gdańsk Politechnika", Latitude = 54.373935, Longitude = 18.627932 });
            station.Add(new Station { Id = 42, Name = "Gdańsk Stocznia", Latitude = 54.364791, Longitude = 18.64141 });
            station.Add(new Station { Id = 43, Name = "GDAŃSK GŁÓWNY", Latitude = 54.355518, Longitude = 18.643781 });
            station.Add(new Station { Id = 44, Name = "Gdańsk Śródmieście", Latitude = 54.347256, Longitude = 18.643631 });
            station.Add(new Station { Id = 46, Name = "Gdańsk Orunia", Latitude = 54.324324, Longitude = 18.634628 });
            station.Add(new Station { Id = 47, Name = "Gdańsk Lipce", Latitude = 54.301852, Longitude = 18.635803 });
            station.Add(new Station { Id = 48, Name = "Pruszcz Gd.", Latitude = 54.25873, Longitude = 18.646861 });
            station.Add(new Station { Id = 49, Name = "Cieplewo", Latitude = 54.232723, Longitude = 18.647641 });
            station.Add(new Station { Id = 50, Name = "Różyny", Latitude = 54.211386, Longitude = 18.66196 });
            station.Add(new Station { Id = 51, Name = "Skowarcz", Latitude = 54.185052, Longitude = 18.682262 });
            station.Add(new Station { Id = 52, Name = "Pszczółki", Latitude = 54.174253, Longitude = 18.702371 });
            station.Add(new Station { Id = 53, Name = "Miłobądz", Latitude = 54.146762, Longitude = 18.740799 });
            station.Add(new Station { Id = 54, Name = "TCZEW", Latitude = 54.097841, Longitude = 18.789523 });

            return (station);
        }
    }
}