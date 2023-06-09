﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Gantteszt.Models
{
    public partial class GanttAdat
    {
        public int GanttAdatId { get; set; }
        public int FejCsatolo { get; set; }
        public int MegbizasCsatolo { get; set; }
        public int TaskId { get; set; }
        public string TaskIdstring { get; set; }
        public string TaskName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Duration { get; set; }
        public int? Progress { get; set; }
        public int? ParentId { get; set; }
        public string Predecessor { get; set; }
        public int? Offset { get; set; }
        public string Notes { get; set; }
        public int? Tetelcsatolo { get; set; }
        public int? MunkaLapSsz { get; set; }
        public DateTime? BaseLineStartDate { get; set; }
        public DateTime? BaseLineEndDate { get; set; }
        public int? KoltseghelyCsatolo { get; set; }
        public double? WorkHour { get; set; }
        /// <summary>
        /// remain_qty_per_hr
        /// </summary>
        public double? EgyszerreDolgozokSzama { get; set; }
        public string TaskStatus { get; set; }
        public string SorrendString { get; set; }
        public bool Torolve { get; set; }
        public string Torolte { get; set; }
        public DateTime? TorlesDatuma { get; set; }
        public string TorlesMegjegyzes { get; set; }
        public DateTime? RogzitesDatuma { get; set; }
        public string Rogzitette { get; set; }
        public string TaskType { get; set; }
        public string WorkStr { get; set; }
        public double? RowIndex { get; set; }
        public string ResourceInfo { get; set; }
        public int? AlapTechnologiaCsatolo { get; set; }
        public int? Cikkszam { get; set; }
        public string ActivityAid { get; set; }
        public string Wbscode { get; set; }
        public string ResourceStr { get; set; }
        public string EquipmentName { get; set; }
        public string EquipmentType { get; set; }
        public string InstallationAre { get; set; }
        public string ProcessUnitId { get; set; }
        public int? Szintszam { get; set; }
        public string TaskNameMagyar { get; set; }
        public int? GyartasTetelCsatolo { get; set; }
        public int? GyartasTechnologiaCsatolo { get; set; }
        public double? Osszdbszam { get; set; }
        public double? KalkAnyagkoltseg { get; set; }
        public double? KalkMunkadij { get; set; }
        public double? KalkSzolgaltatasiDij { get; set; }
        public int GanttAdatTipus { get; set; }
        public int? FelelosCsoportCsatolo { get; set; }
        public int? FelelosCsatolo { get; set; }
        public bool? UtemtervbenMegjelenjen { get; set; }
    }
}