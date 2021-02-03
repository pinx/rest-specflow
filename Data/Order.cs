using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Order
    {
        public int Id { get; set; }
        public int StartLocation { get; set; }
        public int Destination { get; set; }
        public int StartAt { get; set; }
        public int DueAt { get; set; }
    }
}
