﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace API.Models
{
    public class Campaigns
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CampaignId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [Precision(10,2)]
        public decimal Budget {  get; set; }
        [Precision(10, 2)]
        public decimal Spend { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public string TargetAudience { get; set; }
        public string Channel {  get; set; }
        public string Goals { get; set; }
        [Precision(10,2)]
        public decimal RevenueTarget { get; set; }
        [Precision(10, 2)]
        public decimal ActualRevenue {  get; set; }
        public long Impressions { get; set; }
        public long Clicks { get; set; }
        public int LeadsGenerated { get; set; }
        public int Conversions {  get; set; }
        [Precision(10, 2)]
        public decimal ROI { get; set; }

    }
}