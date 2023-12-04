using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Track3_Squad2.Entities
{
    [Table("Accounts")]
    public class Account
    {
        [Key]
        [Required]
        [Column("account_id", TypeName = "VARCHAR(100)")]
        public int Id { get; set; }
        [Column("account_creationDate", TypeName = "VARCHAR(100)")]
        public DateTime? CreationDate { get; set; }
        [Required]
        [Column("account_money", TypeName = "VARCHAR(100)")]
        public decimal Money { get; set; }
        [Required]
        [Column("account_isBloqued", TypeName = "VARCHAR(100)")]
        public bool IsBloqued { get; set; }

        [Required]
        [Column("User_Id")]
        [ForeignKey("user_id")]
        public int UserId { get; set; }
        public User? User { get; set; }

    }
}
