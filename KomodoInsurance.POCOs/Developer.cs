using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsurance.POCOs
{
    public enum Employee { Developer = 1, Devteam}
    public class Developer
    {
        public Developer(); 
        public Developer(string firstName, string lastName)
        {

            FirstName = firstName;
            LastName = lastName;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
