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
            var unreachableAirportNodes = GetUnreachableAirportNodes(airportGraph, airports, startingAirport);

            MarkUnreachableConnections(airportGraph, unreachableAirportNodes);

            return GetMinNumberOfNewConnections(airportGraph, unreachableAirportNodes);
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


        private static List<AirportNode> GetUnreachableAirportNodes(Dictionary<string, AirportNode> airportGraph, List<string> airports, string startingAirport)
        {

            var visitedAirports = new Dictionary<string, bool>();

            DepthFirstTraverseAirports(airportGraph, startingAirport, visitedAirports);

            var unreachableAirportNodes = new List<AirportNode>();

            foreach(var airport in airports)
            {
                if(visitedAirports.ContainsKey(airport))
                {
                    continue;
                }

                var airportNode = airportGraph[airport];
                airportNode.IsReachable = false;
                unreachableAirportNodes.Add(airportNode);

            }

            return unreachableAirportNodes;

        }


        private static void DepthFirstTraverseAirports(Dictionary<string, AirportNode> airportGraph, string airport, Dictionary<string, bool> visitedAirports)
        {
            if(visitedAirports.ContainsKey(airport))
            {
                return;
            }

            visitedAirports.Add(airport, true);
            List<string> connections = airportGraph[airport].Connections;

            foreach(var connection in connections)
            {
                DepthFirstTraverseAirports(airportGraph, connection, visitedAirports);
            }


        }


        private static void MarkUnreachableConnections(Dictionary<string, AirportNode> airportGraph, List<AirportNode> unreachableAirportNodes)
        {

            foreach(var airportNode in unreachableAirportNodes)
            {
                var airport = airportNode.Airport;
                var unreachableConnections = new List<string>();
                var visitedAirports = new Dictionary<string, bool>();

                DepthFirstAddUnreachableConnections(airportGraph, airport, unreachableConnections, visitedAirports);

                airportNode.UnreachableConnections = unreachableConnections;
            }

        }


        private static void DepthFirstAddUnreachableConnections(Dictionary<string, AirportNode> airportGraph, string airport, List<string> unreachableConnections, Dictionary<string, bool> visitedAirports)
        {
            var isAirportReachableOrVisited = airportGraph[airport].IsReachable || visitedAirports.ContainsKey(airport);
            if (isAirportReachableOrVisited)
            {
                return;
            }

            visitedAirports.Add(airport, true);
            unreachableConnections.Add(airport);

            var connections = airportGraph[airport].Connections;

            foreach(var connection in connections)
            {
                DepthFirstAddUnreachableConnections(airportGraph, connection, unreachableConnections, visitedAirports);
            }

        }


        private static int GetMinNumberOfNewConnections(Dictionary<string, AirportNode> airportGraph, List<AirportNode> unreachableAirportNodes)
        {

            unreachableAirportNodes.Sort((airport1, airport2) => airport2.UnreachableConnections.Count - airport1.UnreachableConnections.Count);

            var numberOfNewConnections = 0;

            foreach(var airportNode in unreachableAirportNodes)
            {
                if(airportNode.IsReachable)
                {
                    continue;
                }

                numberOfNewConnections++;

                foreach(var connection in airportNode.UnreachableConnections)
                {
                    airportGraph[connection].IsReachable = true;
                }
            }


            return numberOfNewConnections;
        }

    }
}
