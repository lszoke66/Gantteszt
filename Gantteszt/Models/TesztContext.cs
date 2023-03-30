﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Gantteszt.Models
{
    public partial class TesztContext : DbContext
    {
        public TesztContext()
        {
        }

        public TesztContext(DbContextOptions<TesztContext> options)
            : base(options)
        {
        }

        public virtual DbSet<GanttAdat> GanttAdat { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=10.34.10.14\\erp,1533;Initial Catalog=Teszt;Persist Security Info=True;User ID=szokel;Password=Dev1loper");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GanttAdat>(entity =>
            {
                entity.HasIndex(e => e.FejCsatolo, "FejcsatoloAdattipus");

                entity.HasIndex(e => new { e.FejCsatolo, e.TaskId }, "NonClusteredIndex-20230313-221512")
                    .IsUnique();

                entity.HasIndex(e => e.TaskId, "TeskId");

                entity.HasIndex(e => e.GanttAdatTipus, "adattipusFejcsatoloTaskid");

                entity.Property(e => e.GanttAdatId).HasColumnName("GanttAdatID");

                entity.Property(e => e.ActivityAid)
                    .HasMaxLength(50)
                    .HasColumnName("ActivityAID");

                entity.Property(e => e.BaseLineEndDate).HasColumnType("datetime");

                entity.Property(e => e.BaseLineStartDate).HasColumnType("datetime");

                entity.Property(e => e.Duration).HasMaxLength(50);

                entity.Property(e => e.EgyszerreDolgozokSzama).HasComment("remain_qty_per_hr");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.EquipmentName).HasMaxLength(250);

                entity.Property(e => e.EquipmentType).HasMaxLength(250);

                entity.Property(e => e.GanttAdatTipus).HasDefaultValueSql("((1))");

                entity.Property(e => e.InstallationAre)
                    .HasMaxLength(250)
                    .HasColumnName("installation_are");

                entity.Property(e => e.MegbizasCsatolo).HasColumnName("Megbizas_csatolo");

                entity.Property(e => e.Notes).HasMaxLength(400);

                entity.Property(e => e.Predecessor).HasMaxLength(255);

                entity.Property(e => e.ProcessUnitId)
                    .HasMaxLength(50)
                    .HasColumnName("process_unit_id");

                entity.Property(e => e.ResourceInfo).HasMaxLength(150);

                entity.Property(e => e.ResourceStr).HasMaxLength(150);

                entity.Property(e => e.RogzitesDatuma)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Rogzitette).HasMaxLength(100);

                entity.Property(e => e.SorrendString).HasMaxLength(400);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Szintszam).HasColumnName("szintszam");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.TaskIdstring)
                    .HasMaxLength(20)
                    .HasColumnName("TaskIDString")
                    .IsFixedLength();

                entity.Property(e => e.TaskName).HasMaxLength(255);

                entity.Property(e => e.TaskNameMagyar)
                    .HasMaxLength(400)
                    .HasColumnName("Task_Name_magyar");

                entity.Property(e => e.TaskStatus)
                    .HasMaxLength(100)
                    .HasColumnName("Task_status");

                entity.Property(e => e.TaskType).HasMaxLength(50);

                entity.Property(e => e.TorlesDatuma).HasColumnType("datetime");

                entity.Property(e => e.TorlesMegjegyzes).HasMaxLength(250);

                entity.Property(e => e.Torolte).HasMaxLength(100);

                entity.Property(e => e.UtemtervbenMegjelenjen)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Wbscode)
                    .HasMaxLength(50)
                    .HasColumnName("WBSCode");

                entity.Property(e => e.WorkStr).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}