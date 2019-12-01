using System;
using System.Collections.Generic;
using System.Text;

namespace AirportConnections
{
    public class AirportConnection
    {


        public static int AirportConnections(List<string> airports, List<List<string>> routes, string startingAirport)
        {

            var airportGraph = CreateAirportGraph(airports, routes);

            return 0;
        }


        private static Dictionary<string, AirportNode> CreateAirportGraph(List<string> airports, List<List<string>> routes)
        {
            var airportGraph = new Dictionary<string, AirportNode>();

            foreach(var airport in airports)
            {
                airportGraph.Add(airport, new AirportNode(airport));
            }

            foreach(var route in routes)
            {
                var airport = route[0];
                var connection = route[1];

                airportGraph[airport].Connections.Add(connection);
            }



            return airportGraph;
        }

    }
}
