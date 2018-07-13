using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectStructure.BLL.DTOs
{
    public class StewardessDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirthday { get; set; }
    }
}
