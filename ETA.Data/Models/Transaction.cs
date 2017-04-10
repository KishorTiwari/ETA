using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETA.Data.Models
{
    public class Transaction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int UserId { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        public DateTime DateOfPurchase { get; set; }

        public DateTime DateOfEntry { get; set; }

        public double Price { get; set; }

        public virtual User User { get; set; }
    }
}
