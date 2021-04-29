using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nix_Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            long tick = DateTime.Now.Ticks;
            Task3 t = new Task3();
            Console.WriteLine(t.GetDistance("Valki", "Reshetylivka"));
            tick = DateTime.Now.Ticks - tick;
            Console.WriteLine($"Ticks - {tick}");
        }
    }
    struct City
    {
        public string Name;
        public int Distance;
    }

    class Task3
    {
        private Dictionary<string, int> cities;

        public Task3()
        {
            cities = new Dictionary<string,int>();
            cities.Add( "Kiev", 0 );
            cities.Add("Borispol", 38 );
            cities.Add("Piryatin",165 );
            cities.Add("Lubny" ,212 );
            cities.Add( "Horol", 253);
            cities.Add("Reshetylivka", 326 );
            cities.Add( "Poltava", 365 );
            cities.Add("Chutovo",  417 );
            cities.Add("Valki", 455 );
            cities.Add( "Lubotin",  492 );
            cities.Add( "Pisochyn", 507 );
            cities.Add( "Kharkov", 518 );
        }



        public int GetDistance(string cityFrom, string cityTo)
        {
            int res = -1;
            
            if (cities[cityFrom] != -1 && cities[cityTo] != -1)
            {
                res = Math.Abs(cities[cityFrom] - cities[cityTo]);
            }
            return res;
        } 
    }

}
