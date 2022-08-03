using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceReview1
{
    public class Persona
    {
        public Persona(string nombre, string email, DateTime birthday)
        {
            Nombre = nombre;
            Email = email;
            Birthday = birthday;
        }

        public string Nombre { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }

        
    }
    
  
}
