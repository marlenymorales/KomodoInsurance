using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsurance.Repos
{
    public class DeveloperRepo
    {
        private readonly List<DeveloperPOCO> _developers = new List<DeveloperPOCO>();
        
        private int _count = 0;

        //C
        public bool CreateDeveloper(DeveloperPOCO developer)
        {
            if (developer == null)
            {
                return false;
            }

            _count++;
            developer.Id = _developers.Count() + 1;
            _developers.Add(developer);
            return true;
        }

        //R
        public List<DeveloperPOCO> GetDevelopers()
        {
            return _developers;
        }
        public DeveloperPOCO GetDeveloperById(int id)
        {
            var dev = _developers.Find(d => d.Id == id);

            return dev;
        }

        //U
        public bool UpdateDeveloper(DeveloperPOCO newdev)
        {
            var oldDev = GetDeveloperById(newdev.Id);
            oldDev.FirstName = newdev.FirstName;
            oldDev.LastName = newdev.LastName;
            oldDev.PSaccess = newdev.PSaccess;

            if (oldDev != newdev) return false;
            else return true;
            
        }


        //D
        public bool RemoveDeveloper(int id)
        {
            var dev = GetDeveloperById( id);
            if (dev == null) return false;
            else
            {
                _developers.Remove(dev);
                return true;
            }
        }
    }
}
