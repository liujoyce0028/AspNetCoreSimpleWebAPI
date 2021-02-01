using System;
using System.Collections.Generic;

#nullable disable

namespace MineStarPosition.Models
{
    public partial class MwMachine
    {
        public int MachineId { get; set; }
        public int MachineTypeId { get; set; }
        public string ShortCode { get; set; }
        public string MachineName { get; set; }
        public bool? Active { get; set; }
        public string IpAddress { get; set; }
        public short MineId { get; set; }
        public int ShiftStartTimeHr { get; set; }
        public int ShiftStartTimeMin { get; set; }
        public int ShiftDurationHrs { get; set; }
        public string RfidUniqueId { get; set; }
    }
}
