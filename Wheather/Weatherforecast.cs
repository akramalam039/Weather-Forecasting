using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wheather
{
    class Weatherforecast
    {

        public class Rootobject
        {
            public float lat { get; set; }
            public float lon { get; set; }
            public string timezone { get; set; }
            public int timezone_offset { get; set; }
            public Daily[] daily { get; set; }
        }

        public class Daily
        {
            public long dt { get; set; }
            public int sunrise { get; set; }
            public int sunset { get; set; }
            public int moonrise { get; set; }
            public int moonset { get; set; }
            public float moon_phase { get; set; }
            public Temp temp { get; set; }
            public Feels_Like feels_like { get; set; }
            public int pressure { get; set; }
            public int humidity { get; set; }
            public float dew_point { get; set; }
            public float wind_speed { get; set; }
            public int wind_deg { get; set; }
            public float wind_gust { get; set; }
            public Weather[] weather { get; set; }
            public int clouds { get; set; }
            public float pop { get; set; }
            public float snow { get; set; }
       
        }

        public class Temp
        {
            public float day { get; set; }
            public float min { get; set; }
            public float max { get; set; }
            public float night { get; set; }
            public float eve { get; set; }
            public float morn { get; set; }
        }

        public class Feels_Like
        {
            public float day { get; set; }
            public float night { get; set; }
            public float eve { get; set; }
            public float morn { get; set; }
        }

        public class Weather
        {
            public int id { get; set; }
            public string main { get; set; }
            public string description { get; set; }
            public string icon { get; set; }
        }
        public class ForecastInfo
        {
            public List<Daily> daily { get; set; }
            
        }

    }
}
