using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsurance.Repos
{
    public class DeveloperPOCO
    {
     
       

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool PSaccess { get; set; }

        public DeveloperPOCO()
        {

        }
        public DeveloperPOCO(int id, string firstName, string lastName, bool psaccess )
        {

            FirstName = firstName;
            LastName = lastName;
            Id = id;
            PSaccess = psaccess;
        }
        public DeveloperPOCO( string firstName, string lastName, bool psaccess)
        {

            FirstName = firstName;
            LastName = lastName;
          
            PSaccess = psaccess;
        }
    }
}

