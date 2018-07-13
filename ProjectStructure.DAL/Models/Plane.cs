using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectStructure.DAL.Models
{
    public class Plane
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int TimeSpan { get; set; }
    }
}
