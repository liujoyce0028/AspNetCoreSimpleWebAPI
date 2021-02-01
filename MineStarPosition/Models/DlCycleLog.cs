using System;
using System.Collections.Generic;

#nullable disable

namespace MineStarPosition.models
{
    public partial class DlCycleLog
    {
        public int UniqueId { get; set; }
        public int? MachineId { get; set; }
        public int? ConfigLogId { get; set; }
        public int? DigModeId { get; set; }
        public DateTime? StartTimeStamp { get; set; }
        public DateTime? EndTimeStamp { get; set; }
        public int? StartTime { get; set; }
        public int? EndTime { get; set; }
        public string PitName { get; set; }
        public string RampName { get; set; }
        public string StripName { get; set; }
        public string PassName { get; set; }
        public string BlastId { get; set; }
        public float? BlastProximity { get; set; }
        public string TubBlockId { get; set; }
        public string FillBlockId { get; set; }
        public string DumpBlockId { get; set; }
        public float? TubEastings { get; set; }
        public float? TubNorthings { get; set; }
        public float? TubAltitude { get; set; }
        public float? FillEastings { get; set; }
        public float? FillNorthings { get; set; }
        public float? FillAltitude { get; set; }
        public float? FillHeading { get; set; }
        public float? DumpEastings { get; set; }
        public float? DumpNorthings { get; set; }
        public float? DumpAltitude { get; set; }
        public float? DumpHeading { get; set; }
        public short? GpsFixQuality { get; set; }
        public short? GpsNumberOfSatellites { get; set; }
        public float? GpsHdop { get; set; }
        public byte? RepassCount { get; set; }
        public float? Digability { get; set; }
        public float? Payload { get; set; }
        public float? GrossWeight { get; set; }
        public float? Tsl { get; set; }
        public short? ChopFlag { get; set; }
        public float? FillTime { get; set; }
        public float? SwingTime { get; set; }
        public float? DumpTime { get; set; }
        public float? ReturnTime { get; set; }
        public float? SpotTime { get; set; }
        public float? CycleTime { get; set; }
        public short? FillAngle { get; set; }
        public float? HoistAngle { get; set; }
        public short? CarryAngle { get; set; }
        public short? DumpAngle { get; set; }
        public float? SwingAngle { get; set; }
        public float? ReturnSwingAngle { get; set; }
        public float? DumpReach { get; set; }
        public float? DumpHeight { get; set; }
        public float? StartFillHeight { get; set; }
        public float? StartFillReach { get; set; }
        public float? EndFillHeight { get; set; }
        public float? EndFillReach { get; set; }
        public float? FillLength { get; set; }
        public float? VerticalHoistHeight { get; set; }
        public float? HoistVectorLength { get; set; }
        public float? PercentFullHstRefInSwg { get; set; }
        public float? HoistVectorVelocity { get; set; }
        public float? DragArmIRms { get; set; }
        public float? FrontHoistArmIRms { get; set; }
        public float? HoistArmIRms { get; set; }
        public float? SwingArmIRms { get; set; }
        public float? AvgFillDragRef { get; set; }
        public float? AvgFillDragVelocity { get; set; }
        public float? AvgDragForceForSwing { get; set; }
        public float? AvgFrontForceForSwing { get; set; }
        public float? AvgRearForceForSwing { get; set; }
        public float? AvgHoistForceDifference { get; set; }
        public float? FillEnergy { get; set; }
        public float? FrontHoistEnergy { get; set; }
        public float? SpecificFrontHoistEnergy { get; set; }
        public float? HoistEnergy { get; set; }
        public float? SpecificHoistEnergy { get; set; }
        public float? PeakDragAmps { get; set; }
        public int? MachinePower { get; set; }
        public short? AcMotorEnabled { get; set; }
        public short? SwingTorqueMin { get; set; }
        public short? SwingTorqueMax { get; set; }
        public short? SwingRainfall { get; set; }
        public float? VibrationMetric { get; set; }
        public float? StressIndex { get; set; }
        public float? MachineGrade { get; set; }
        public float? TargetMachineElevation { get; set; }
    }
}
