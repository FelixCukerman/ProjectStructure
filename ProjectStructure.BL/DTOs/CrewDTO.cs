using System;
using System.Collections.Generic;
using System.Text;
using ProjectStructure.DAL.Models;

namespace ProjectStructure.BLL.DTOs
{
    public class CrewDTO
    {
        public int Id { get; set; }
        public Aviator aviator { get; set; }
        public List<Stewardess> stewardesses { get; set; }
    }
}
