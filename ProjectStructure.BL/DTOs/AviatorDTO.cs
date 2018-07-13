using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectStructure.BLL.DTOs
{
    public class AviatorDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirthday { get; set; }
        public int Experience { get; set; }
    }
}
