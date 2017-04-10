using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETA.Data.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name ="Email")]
        public string Email { get; set; }

        [Display(Name = "Password")]
        public string CurrentPassword { get; set; }

        public string OldPassword { get; set; }

        public DateTime PasswordModified { get; set; }

        public DateTime DateCreated { get; set; }

        public bool IsActive { get; set; }


        public virtual ICollection<Transaction> Transactions { get; set; }
        public virtual Group Group { get; set; }
    }
}
