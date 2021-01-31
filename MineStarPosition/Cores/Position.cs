using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MineStarPosition.Cores
{
    public class Position
    {
        public int Id { get; set; }
        public DateTime? TimeStamp { get; set; }

        public int? OriginatorId { get; set; }

        public string MachineName { get; set; }

        public double? Eastings { get; set; }

        public double? Northings { get; set; }

        public double? Elevation { get; set; }

        public double? Heading { get; set; }

        public double? Speed { get; set; }
    }
}
