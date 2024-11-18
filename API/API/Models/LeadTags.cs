using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class LeadTags
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LeadTagId { get; set; }
        public int LeadId { get; set; }
        public string TagName { get; set; }
    }
}
