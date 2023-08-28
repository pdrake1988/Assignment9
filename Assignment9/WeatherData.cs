using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    internal class WeatherData
    {
        public Tuple<int, int, int> NewData(int temp, int humidity, int windSpeed)
        {
            return Tuple.Create(temp, humidity, windSpeed);
        }
    }
}
