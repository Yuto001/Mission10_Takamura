using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission10_Takamura.Data
{
    public class BowlingLeague
    {
        [Key]
        public int BowlerID { get; set; }
        [Required]
        public string BowlerLastName { get; set; }
        [Required]
        public string BowlerFirstName { get; set; }
        
        public string? BowlerMiddleInit { get; set; }
        [Required]
        public string BowlerAddress { get; set; }
        [Required]
        public string BowlerCity { get; set; }
        [Required]
        public string BowlerState { get; set; }
        [Required]
        public int BowlerZip {  get; set; }
        [Required]
        public string BowlerPhoneNumber { get; set; }
        [Required]
        public int TeamID { get; set; }
        public Team? Team { get; set; } // add this foreign key

    }
}
