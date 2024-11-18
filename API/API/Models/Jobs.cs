using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Jobs
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int JobId { get; set; }
        public int CustomerId { get; set; }
        public Customers Customer { get; set; }
        public string JobTitle { get; set; }
        public string JobDescription { get; set; } = string.Empty;
        public string JobStatus { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int AssignedTo { get; set; }
        public string Priority { get; set; }
        [Precision(10,2)]
        public decimal EstimatedCost { get; set; }
        [Precision(10,2)]
        public decimal ActualCost { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int LastUpdatedBy { get; set; }
        public DateTime LastUpdatedDate { get; set; }
    }
}
