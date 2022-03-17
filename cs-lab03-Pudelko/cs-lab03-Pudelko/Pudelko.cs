using System;
namespace cs_lab03_Pudelko
{
    public sealed class Pudelko
    {
        public double A { get { return ConvertToMeters(a); } }
        public double B { get { return ConvertToMeters(b); } }
        public double C { get { return ConvertToMeters(c); } }

        private double a = 0.1;
        private double b = 0.1;
        private double c = 0.1;

        public Pudelko(double a = 0.1, double? b = null, double? c = null, UnitOfMeasure unitOfMeasure = UnitOfMeasure.meter)
        {

        }

        public double ConvertToMeters(double length = 0.1, UnitOfMeasure unitOfMeasure = UnitOfMeasure.meter)
        {
            return unitOfMeasure switch
            {
                UnitOfMeasure.meter => length,
                UnitOfMeasure.centimeter => Math.Truncate(length * 100) / 100,
                UnitOfMeasure.milimeter => Math.Truncate(length * 1000) / 1000,
                _ => throw new ArgumentException("ConvertToMeters went wrong :("),
            };
        }

        public double ConvertToMilimeters(double length = 0.1)


    }

    //TODO: To a separate class(?)
    public enum UnitOfMeasure
    {
        milimeter, centimeter, meter
    }


}
