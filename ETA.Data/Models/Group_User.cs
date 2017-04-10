using System.ComponentModel.DataAnnotations.Schema;

namespace ETA.Data.Models
{
    public class Group_User
    {
        public int Id { get; set; }

        [ForeignKey("Group")]
        public int GroupId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public bool IsAdmin { get; set; }

        public virtual Group Group { get; set; }
        public virtual User User { get; set; }
    }
}
