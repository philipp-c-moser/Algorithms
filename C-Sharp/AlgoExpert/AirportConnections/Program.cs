using System;
using System.Collections.Generic;

namespace AirportConnections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Airport Connections");

            var airports = new List<string> {
                "BGI",
                "CDG",
                "DEL",
                "DOH",
                "DSM",
                "EWR",
                "EYW",
                "HND",
                "ICN",
                "JFK",
                "LGA",
                "LHR",
                "ORD",
                "SAN",
                "SFO",
                "SIN",
                "TLV",
                "BUD"
            };

            var routes = new List<List<string>> {
                new List<string> {"DSM", "ORD"},
                new List<string> {"ORD", "BGI"},
                new List<string> {"BGI", "LGA"},
                new List<string> {"SIN", "CDG"},
                new List<string> {"CDG", "SIN"},
                new List<string> {"CDG", "BUD"},
                new List<string> {"DEL", "DOH"},
                new List<string> {"DEL", "CDG"},
                new List<string> {"TLV", "DEL"},
                new List<string> {"EWR", "HND"},
                new List<string> {"HND", "ICN"},
                new List<string> {"ICN", "JFK"},
                new List<string> {"JFK", "LGA"},
                new List<string> {"EYW", "LHR"},
                new List<string> {"LHR", "SFO"},
                new List<string> {"SFO", "SAN"},
                new List<string> {"SFO", "DSM"},
                new List<string> {"SAN", "EYW"}
            };

            var startingAirport = "LGA";


            var minNumberOfConnections = AirportConnection.AirportConnections(airports, routes, startingAirport);

            Console.WriteLine("The minimum number of airport connections, that need to be added in order for someone to be able to reach any airport in the list is: " + minNumberOfConnections);
            
        }
    }
}
