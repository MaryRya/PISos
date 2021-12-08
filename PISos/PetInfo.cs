using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PISos
{
    public class PetInfo
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Gender { get; set; }
        public string Locality { get; set; }
        public DateTime Birthday { get; set; }
        public string Breed { get; set; }
        public long UserId { get; set; }
    }
}
