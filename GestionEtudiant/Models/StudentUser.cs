using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionEtudiant.Models
{
    public class StudentUser : IdentityUser
    {
        //public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CIN { get; set; }
    }
}
