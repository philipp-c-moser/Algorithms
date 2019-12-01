using System;
using System.Collections.Generic;
using System.Text;

namespace AirportConnections
{
    public class AirportNode
    {
        public string Airport;
        public List<string> Connections;
        public bool IsReachable;
        public List<string> UnreachableConnections;

        public AirportNode(string airport)
        {
            this.Airport = airport;
            Connections = new List<string>();
            IsReachable = true;
            UnreachableConnections = new List<string>();
        }
    }
}
