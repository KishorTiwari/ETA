using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETA.Data.Models
{
    public class Group
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(50)]
        [Display(Name = "Group Name")]
        public string GroupName { get; set; }

        [Display(Name = "Date Created")]
        public System.DateTime DateCreated { get; set; }

        public bool IsActive { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
