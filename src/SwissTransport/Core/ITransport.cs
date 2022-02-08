using System;

namespace SwissTransport.Core
{
    using System.Threading.Tasks;
    using SwissTransport.Models;

    public interface ITransport
    {
        Stations GetStations(string query);

        Stations GetStationsAutoComplete(string query, int limit);

        StationBoardRoot GetStationBoard(string station, string id);

        Connections GetConnections(string fromStation, string toStation);

        Connections GetConnections(string fromStation, string toStation, DateTime date);
    }
}