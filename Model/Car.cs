using System;
using System.Drawing;

namespace Model
{
    public class Car
    {
        public Car(string m, Categories c)
        {
            Model = m;
            if (c != Categories.A)
            {
                Category = c;
            }
            else
            {
                throw new Exception("Нельзя присвоить машине категорию А, категория А - для мотоциклов!");
            }
            CarPassport = new CarPassport(this);
        }

        public string Model { get; }

        private Color _carColor;
        public Color CarColor
        {
            get
            {
                if (_carColor == null)
                {
                    return Color.Blue;
                }
                else
                {
                    return _carColor;
                }
            }
            set
            {
                _carColor = value;
            }
        }

        public string CarNumber { get; protected set; }
        
        public Categories Category { get; }

        public CarPassport CarPassport { get; }

        public void ChangeOwner(string newNumber, Driver newDriver)
        {
            newDriver.OwnCar(this);
            CarPassport.Owner = newDriver;
            CarNumber = newNumber;
        }
    }
}
