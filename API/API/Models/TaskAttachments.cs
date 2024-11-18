using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class TaskAttachments
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TaskAttachmentId { get; set; }
        public int TaskId { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public int UploadedBy { get; set; }
        public DateTime UploadedDate { get; set; }
    }
}
