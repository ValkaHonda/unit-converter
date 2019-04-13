using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_converter
{
    public class LengthConverter : Converter
    {
        override public double convert(String from, String to, double value)
        {
            double baseValue = getBaseValue(from, value);
            double convertedValue = convertTo(to, baseValue);
            return convertedValue;

        }
        public double getBaseValue(String from, double value)
        {
            switch(from){
                case "meters":
                    return value;
                case "centimeters":
                    return value / 100;
                case "millimeters":
                    return value / 1000;
                default:
                    return value;
            }
        }
        public double convertTo(String to, double baseValue)
        {
            switch (to)
            {
                case "meters":
                    return baseValue;
                case "centimeters":
                    return baseValue * 100;
                case "millimeters":
                    return baseValue * 1000;
                default:
                    return baseValue;
            }
        }
    }
}
