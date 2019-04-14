using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_converter
{
    class WeightConverter : Converter
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
                case "tons":
                    return value;
                case "kilograms":
                    return value / 1000;
                case "grams":
                    return value / 1000000;
                default:
                    return value;
            }
        }
        private double convertTo(String to, double value)
        {
            switch (to)
            {
                case "tons":
                    return value;
                case "kilograms":
                    return value / 1000;
                case "grams":
                    return value / 1000000;
                default:
                    return value;
            }
        }
    }
}
