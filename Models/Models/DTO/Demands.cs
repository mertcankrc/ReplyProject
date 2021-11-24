using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Models.DTO
{
    public class Demands
    {
        public int Id { get; set; }
        public int CheckOutPlace { get; set; }
        public DateTime CheckOutTime { get; set; }
        public int CheckInPlace { get; set; }
        public DateTime CheckInTime { get; set; }
        public string DesiredModel { get; set; }
        public string DesiredEngine { get; set; }
        public string DesiredInfotainmentSystem { get; set; }
        public string DesiredDesign { get; set; }
    }
}
