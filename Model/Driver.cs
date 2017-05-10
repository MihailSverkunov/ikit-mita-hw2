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
                return DateTime.Now.Year - LicenceDate.Year;
            }
        }

        public List<Categories> CategoriesDr;

        public void OwnCar(Car c)
        {
            Car = c;
        }

        public Car Car { get; protected set; }

    }
}
