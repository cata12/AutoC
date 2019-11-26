using System;

namespace MainProject
{
    public class Car: Car1
    {
        public Car(string make, string model, string registration, string year, double currentValue)
        {
            _carMake = make;
            _carMake = make;
            _carModel = model;
            _carModel = model;
            _carRegistrationNumber = registration;
            _carYear = year;
            _carCurrentValue = currentValue;
        }

        public double GetCarCurrentValue()
        {
            return _carCurrentValue;
        }

        public string GetCarCurrentYear()
        {
            return _carYear;
        }
        public override string ToString()
        {
            return String.Format("Car Make: {0}\n" +
                                 "Car Model: {1}\n" +
                                 "Car Registration: {2}\n" +
                                 "Car Year: {3}\n" +
                                 "Current Value: {4}", _carMake, _carModel, _carRegistrationNumber, _carYear, _carCurrentValue);
        }
    }
}
