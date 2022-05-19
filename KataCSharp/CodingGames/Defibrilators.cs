using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AlgorithmsSoftuni.CodingGames
{

    class Defibrilators
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            double userLongitude = Double.Parse(a.Replace(',', '.'), CultureInfo.InvariantCulture);
            double userLatitude = Double.Parse(b.Replace(',', '.'), CultureInfo.InvariantCulture);

            var currentDistance = Double.MaxValue;
            var closest = String.Empty;
            GFG gfg = new GFG();

            int numberOfDefibrilators = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfDefibrilators; i++)
            {
                string input = Console.ReadLine();
                var props = input.Split(';');

                var defibrilator = new Defibrilator()
                {
                    Id = props[0],
                    Name = props[1],
                    Address = props[2],
                    PhoneNumber = props[3],
                    Longitude = Double.Parse(props[4].Replace(',', '.'), CultureInfo.InvariantCulture),
                    Latitude = Double.Parse(props[5].Replace(',', '.'), CultureInfo.InvariantCulture),
                };

                var x = (defibrilator.Longitude - userLongitude) * Math.Cos((userLatitude + defibrilator.Latitude) / 2);
                var y = defibrilator.Latitude - userLatitude;
                var d = (x + y) * 6371;
                var res = gfg.distance(userLatitude, defibrilator.Latitude, userLongitude, defibrilator.Longitude);
                if (currentDistance > res) { currentDistance = res; closest = defibrilator.Name; }
            }

            // Write an answer using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            Console.WriteLine(closest);
        }

        class Defibrilator
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
            public string PhoneNumber { get; set; }
            public double Longitude { get; set; }
            public double Latitude { get; set; }
        }

        class GFG
        {
            static double toRadians(
                   double angleIn10thofaDegree)
            {
                // Angle in 10th
                // of a degree
                return (angleIn10thofaDegree *
                               Math.PI) / 180;
            }
            public double distance(double lat1,
                                   double lat2,
                                   double lon1,
                                   double lon2)
            {

                // The math module contains
                // a function named toRadians
                // which converts from degrees
                // to radians.
                lon1 = toRadians(lon1);
                lon2 = toRadians(lon2);
                lat1 = toRadians(lat1);
                lat2 = toRadians(lat2);

                // Haversine formula
                double dlon = lon2 - lon1;
                double dlat = lat2 - lat1;
                double a = Math.Pow(Math.Sin(dlat / 2), 2) +
                           Math.Cos(lat1) * Math.Cos(lat2) *
                           Math.Pow(Math.Sin(dlon / 2), 2);

                double c = 2 * Math.Asin(Math.Sqrt(a));

                // Radius of earth in
                // kilometers. Use 3956
                // for miles
                double r = 6371;

                // calculate the result
                return (c * r);
            }
        }
    }
}
