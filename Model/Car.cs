using System;
using System.Drawing;

namespace Model
{
    public enum Categories { A, B, C, D, E, F }


    public class Car
    {
        public Car(string m, Categories c)
        {
            Model = m;
            Category = c;
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

            CarPassport.Owner = newDriver;
            CarNumber = newNumber;

            newDriver.OwnCar(this);

        }
    }
}
