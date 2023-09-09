using System;

namespace ReportGenerator
{
    internal class ReportArguments
    {
        public string ReportName { get; set; }
        public string Username { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        
        public int? AircraftId { get; set; }
        public bool AllAircraft { get; set; }
        public bool OwnAircraftOnly { get; set; }
        
        public int? AirportId { get; set; }
        public string IATA { get; set; }
        
        public int? PilotId { get; set; }
        public int? RunId { get; set; }

        public bool HasSubreports { get; set; }

        public int? OperatorId { get; set; }
        public bool AllOperators { get; set; }

        public bool AircraftSelected => AllAircraft == false && OwnAircraftOnly == false;

        public int[] TicketIds { get; set; }

        public int? IDX { get; set; }
    }
}
