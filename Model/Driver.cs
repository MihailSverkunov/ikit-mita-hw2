using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Driver
    {
        public Driver(string n, DateTime ld)
        {
            Name = n;
            LicenceDate = ld;
        }

        public string Name { get; }

        DateTime LicenceDate { get; }

        int Experience
        {
            get
            {
                if (DateTime.Now.Month < LicenceDate.Month ||
                    DateTime.Now.Month == LicenceDate.Month && DateTime.Now.Day < LicenceDate.Day)
                {
                    return DateTime.Now.Year - LicenceDate.Year - 1;
                }
                else
                {
                    return DateTime.Now.Year - LicenceDate.Year;
                }
            }
        }

        public List<Categories> CategoriesDr;

        public void OwnCar(Car c)
        {
            

            if (CategoriesDr.Contains(c.Category))
            {
                Car = c;
            }
            else
            {
                throw new Exception("У водителя нет категории для этой машины");
            }
        }

        public Car Car { get; protected set; }

    }
}
