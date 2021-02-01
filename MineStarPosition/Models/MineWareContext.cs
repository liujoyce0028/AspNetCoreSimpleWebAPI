using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MineStarPosition.models
{
    public partial class MineWareContext : DbContext
    {
        public MineWareContext()
        {
        }

        public MineWareContext(DbContextOptions<MineWareContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DlCycleLog> DlCycleLogs { get; set; }
        public virtual DbSet<MwMachine> MwMachines { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=10.80.4.108; database=MineWare; User Id=mwadmin; password=hmipw;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<DlCycleLog>(entity =>
            {
                entity.HasKey(e => e.UniqueId);

                entity.ToTable("dl_cycle_log");

                entity.HasIndex(e => new { e.MachineId, e.EndTimeStamp }, "IX_dl_cycle_log_2")
                    .HasFillFactor((byte)80);

                entity.Property(e => e.UniqueId)
                    .ValueGeneratedNever()
                    .HasColumnName("unique_id");

                entity.Property(e => e.AcMotorEnabled).HasColumnName("ac_motor_enabled");

                entity.Property(e => e.AvgDragForceForSwing).HasColumnName("avg_drag_force_for_swing");

                entity.Property(e => e.AvgFillDragRef).HasColumnName("avg_fill_drag_ref");

                entity.Property(e => e.AvgFillDragVelocity).HasColumnName("avg_fill_drag_velocity");

                entity.Property(e => e.AvgFrontForceForSwing).HasColumnName("avg_front_force_for_swing");

                entity.Property(e => e.AvgHoistForceDifference).HasColumnName("avg_hoist_force_difference");

                entity.Property(e => e.AvgRearForceForSwing).HasColumnName("avg_rear_force_for_swing");

                entity.Property(e => e.BlastId)
                    .HasMaxLength(16)
                    .HasColumnName("blast_id");

                entity.Property(e => e.BlastProximity).HasColumnName("blast_proximity");

                entity.Property(e => e.CarryAngle).HasColumnName("carry_angle");

                entity.Property(e => e.ChopFlag).HasColumnName("chop_flag");

                entity.Property(e => e.ConfigLogId).HasColumnName("config_log_id");

                entity.Property(e => e.CycleTime).HasColumnName("cycle_time");

                entity.Property(e => e.DigModeId).HasColumnName("dig_mode_id");

                entity.Property(e => e.Digability).HasColumnName("digability");

                entity.Property(e => e.DragArmIRms).HasColumnName("drag_arm_i_rms");

                entity.Property(e => e.DumpAltitude).HasColumnName("dump_altitude");

                entity.Property(e => e.DumpAngle).HasColumnName("dump_angle");

                entity.Property(e => e.DumpBlockId)
                    .HasMaxLength(16)
                    .HasColumnName("dump_block_id");

                entity.Property(e => e.DumpEastings).HasColumnName("dump_eastings");

                entity.Property(e => e.DumpHeading).HasColumnName("dump_heading");

                entity.Property(e => e.DumpHeight).HasColumnName("dump_height");

                entity.Property(e => e.DumpNorthings).HasColumnName("dump_northings");

                entity.Property(e => e.DumpReach).HasColumnName("dump_reach");

                entity.Property(e => e.DumpTime).HasColumnName("dump_time");

                entity.Property(e => e.EndFillHeight).HasColumnName("end_fill_height");

                entity.Property(e => e.EndFillReach).HasColumnName("end_fill_reach");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.EndTimeStamp)
                    .HasColumnType("datetime")
                    .HasColumnName("end_time_stamp");

                entity.Property(e => e.FillAltitude).HasColumnName("fill_altitude");

                entity.Property(e => e.FillAngle).HasColumnName("fill_angle");

                entity.Property(e => e.FillBlockId)
                    .HasMaxLength(16)
                    .HasColumnName("fill_block_id");

                entity.Property(e => e.FillEastings).HasColumnName("fill_eastings");

                entity.Property(e => e.FillEnergy).HasColumnName("fill_energy");

                entity.Property(e => e.FillHeading).HasColumnName("fill_heading");

                entity.Property(e => e.FillLength).HasColumnName("fill_length");

                entity.Property(e => e.FillNorthings).HasColumnName("fill_northings");

                entity.Property(e => e.FillTime).HasColumnName("fill_time");

                entity.Property(e => e.FrontHoistArmIRms).HasColumnName("front_hoist_arm_i_rms");

                entity.Property(e => e.FrontHoistEnergy).HasColumnName("front_hoist_energy");

                entity.Property(e => e.GpsFixQuality).HasColumnName("gps_fix_quality");

                entity.Property(e => e.GpsHdop).HasColumnName("gps_hdop");

                entity.Property(e => e.GpsNumberOfSatellites).HasColumnName("gps_number_of_satellites");

                entity.Property(e => e.GrossWeight).HasColumnName("gross_weight");

                entity.Property(e => e.HoistAngle).HasColumnName("hoist_angle");

                entity.Property(e => e.HoistArmIRms).HasColumnName("hoist_arm_i_rms");

                entity.Property(e => e.HoistEnergy).HasColumnName("hoist_energy");

                entity.Property(e => e.HoistVectorLength).HasColumnName("hoist_vector_length");

                entity.Property(e => e.HoistVectorVelocity).HasColumnName("hoist_vector_velocity");

                entity.Property(e => e.MachineGrade).HasColumnName("machine_grade");

                entity.Property(e => e.MachineId).HasColumnName("machine_id");

                entity.Property(e => e.MachinePower).HasColumnName("machine_power");

                entity.Property(e => e.PassName)
                    .HasMaxLength(16)
                    .HasColumnName("pass_name");

                entity.Property(e => e.Payload).HasColumnName("payload");

                entity.Property(e => e.PeakDragAmps).HasColumnName("peak_drag_amps");

                entity.Property(e => e.PercentFullHstRefInSwg).HasColumnName("percent_full_hst_ref_in_swg");

                entity.Property(e => e.PitName)
                    .HasMaxLength(16)
                    .HasColumnName("pit_name");

                entity.Property(e => e.RampName)
                    .HasMaxLength(16)
                    .HasColumnName("ramp_name");

                entity.Property(e => e.RepassCount).HasColumnName("repass_count");

                entity.Property(e => e.ReturnSwingAngle).HasColumnName("return_swing_angle");

                entity.Property(e => e.ReturnTime).HasColumnName("return_time");

                entity.Property(e => e.SpecificFrontHoistEnergy).HasColumnName("specific_front_hoist_energy");

                entity.Property(e => e.SpecificHoistEnergy).HasColumnName("specific_hoist_energy");

                entity.Property(e => e.SpotTime).HasColumnName("spot_time");

                entity.Property(e => e.StartFillHeight).HasColumnName("start_fill_height");

                entity.Property(e => e.StartFillReach).HasColumnName("start_fill_reach");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.StartTimeStamp)
                    .HasColumnType("datetime")
                    .HasColumnName("start_time_stamp");

                entity.Property(e => e.StressIndex).HasColumnName("stress_index");

                entity.Property(e => e.StripName)
                    .HasMaxLength(16)
                    .HasColumnName("strip_name");

                entity.Property(e => e.SwingAngle).HasColumnName("swing_angle");

                entity.Property(e => e.SwingArmIRms).HasColumnName("swing_arm_i_rms");

                entity.Property(e => e.SwingRainfall).HasColumnName("swing_rainfall");

                entity.Property(e => e.SwingTime).HasColumnName("swing_time");

                entity.Property(e => e.SwingTorqueMax).HasColumnName("swing_torque_max");

                entity.Property(e => e.SwingTorqueMin).HasColumnName("swing_torque_min");

                entity.Property(e => e.TargetMachineElevation).HasColumnName("target_machine_elevation");

                entity.Property(e => e.Tsl).HasColumnName("tsl");

                entity.Property(e => e.TubAltitude).HasColumnName("tub_altitude");

                entity.Property(e => e.TubBlockId)
                    .HasMaxLength(16)
                    .HasColumnName("tub_block_id");

                entity.Property(e => e.TubEastings).HasColumnName("tub_eastings");

                entity.Property(e => e.TubNorthings).HasColumnName("tub_northings");

                entity.Property(e => e.VerticalHoistHeight).HasColumnName("vertical_hoist_height");

                entity.Property(e => e.VibrationMetric).HasColumnName("vibration_metric");
            });

            modelBuilder.Entity<MwMachine>(entity =>
            {
                entity.HasKey(e => e.MachineId)
                    .HasName("PK__System_Config__3B75D760");

                entity.ToTable("mw_machine");

                entity.HasIndex(e => e.MachineId, "IX_mw_machine_1")
                    .HasFillFactor((byte)80);

                entity.Property(e => e.MachineId)
                    .ValueGeneratedNever()
                    .HasColumnName("machine_id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("ip_address");

                entity.Property(e => e.MachineName)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("machine_name");

                entity.Property(e => e.MachineTypeId).HasColumnName("machine_type_id");

                entity.Property(e => e.MineId).HasColumnName("mine_id");

                entity.Property(e => e.RfidUniqueId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("RfidUniqueID");

                entity.Property(e => e.ShiftDurationHrs).HasColumnName("shift_duration_hrs");

                entity.Property(e => e.ShiftStartTimeHr).HasColumnName("shift_start_time_hr");

                entity.Property(e => e.ShiftStartTimeMin).HasColumnName("shift_start_time_min");

                entity.Property(e => e.ShortCode)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("short_code");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
