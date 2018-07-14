using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using ProjectStructure.DAL.Models;


namespace ProjectStructure.BLL.DTOs
{
    public class CrewDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public Aviator aviator { get; set; }
        [Required]
        public List<Stewardess> stewardesses { get; set; }
    }
}
