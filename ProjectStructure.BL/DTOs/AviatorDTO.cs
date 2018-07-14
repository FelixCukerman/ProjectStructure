using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectStructure.BLL.DTOs
{
    public class AviatorDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Surname { get; set; }
        [Required]
        public DateTime DateOfBirthday { get; set; }
        [Range(1, 50, ErrorMessage = "Uncorrect value")]
        [Required]
        public int Experience { get; set; }
    }
}
