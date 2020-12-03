using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Veterinar
    {
        public int Id { get; set; }
        public String FullName { get; set; }
        public String Speciality { get; set; }
        public int Expirience { get; set; }
    }
}
