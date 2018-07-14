using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectStructure.BLL.DTOs
{
    public class PlaneDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 2)]
        public string Name { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 1)]
        public string Type { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        [Required]
        public int TimeSpan { get; set; }
    }
}
