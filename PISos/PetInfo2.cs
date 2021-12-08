using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PISos.Db
{
    public class PetInfo2
    {
        public long Id { get; set; }

        public string Gender { get; set; }
        public DateTime Date { get; set; }
        public string Locality { get; set; }
        public string Category { get; set; }       
        public string Discription { get; set; }
        public string Phone { get; set; }
        public long UserId { get; set; }
        public string Photo { get; set; }
    }
}
