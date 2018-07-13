using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectStructure.BLL.DTOs
{
    public class PlaneDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int TimeSpan { get; set; }
    }
}
