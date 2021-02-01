using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MineStarPosition.Cores
{
    public class Machine
    {
        public int Id { get; set; }
        public DateTime TimeStamp { get; set; }

        public int OriginatorId { get; set; }

        public int Handle { get; set; }

        public string MachineName { get; set; }
        public string MachineCategory { get; set; }
        public string Status { get; set; }

        public string MachineModel { get; set; }

        public string MachineMake { get; set; }


        public double MachineLength { get; set; }

        public double MachineWidth { get; set; }

        public double MachineHeight { get; set; }

    }
}
