using System.ComponentModel.DataAnnotations;

namespace Mission10_Takamura.Data
{
    public class Team
    {
        [Key]
        public int TeamID { get; set; }
        [Required]
        public string TeamName { get; set; }
        [Required]
        public string CaptainID { get; set; }
    }
}
