using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectStructure.BLL.DTOs
{
    public class TypePlaneDTO
    {
        public int Id { get; set; }
        public string ModelOfPlane { get; set; }
        public int CountOfSeats { get; set; }
        public int CarryingCapacity { get; set; }
    }
}
