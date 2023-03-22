using System.ComponentModel.DataAnnotations;

namespace ChapterInventory.Models
{
    public class RecordsTamplate
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [StringLength(100)]
        public string ProductDescription { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        [StringLength(50)]
        public string IssuedBy { get; set;}

        [Required]
        [StringLength(50)]
        public string VerifiedBy { get; set;}

        [Required]

        public DateTime DateSend { get; set;}
        [Required]
        public DateTime DateRecieved { get; set;}
        
    }
}
