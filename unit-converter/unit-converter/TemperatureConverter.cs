using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_converter
{
    class TemperatureConverter : Converter
    {
        override public double convert(String from, String to, double value)
        {
            double baseValue = getBaseValue(from, value);
            double convertedValue = convertTo(to, baseValue);
            return convertedValue;

        }
        private double getBaseValue(String from, double value)
        {
            switch (from)
            {
                case "celsius":
                    return value;
                case "farenheit":
                    return this.farToCel(value);
                case "kelvins":
                    return this.kelToCel(value);
                default:
                    return value;
            }
        }
        private double convertTo(String to, double value)
        {
            switch (to)
            {
                case "celsius":
                    return value;
                case "farenheit":
                    return this.celToFar(value);
                case "kelvins":
                    return this.celToKel(value);
                default:
                    return value;
            }
        }
        private double farToCel(double value)
        {
            return (value - 32) / 1.8; ;
        }
        private double celToFar(double value)
        {
            return value * 1.8 + 32;
        }
        private double kelToCel(double value)
        {
            return value - 272.15;
        }
        private double celToKel(double value)
        {
            return value + 272.15;
        }
    }
}
