using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PISos.Db
{
    public class MyPet
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string PetName { get; set; }
        public string Gender { get; set; }
        public string Locality { get; set; }
        public string Category { get; set; }
        public DateTime Birthday { get; set; }
        public string Breed { get; set; }
        public string Sterilization { get; set; }
        public string Number { get; set; }
        public string Registration { get; set; }
        public string FIO { get; set; }

    }
}
