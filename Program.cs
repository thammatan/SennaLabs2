using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SennaLabs2 {
    class People {
        public string f_name;
        public string l_name;
        public static People FromCsv(string csvLine) {
            string[] values = csvLine.Split(',');
            People peopleName = new People();
            peopleName.f_name = values[0];
            peopleName.l_name = values[1];
           
            return peopleName;
        }
    }
    class Program {
        static void Main(string[] args) {
            List<People> values = File.ReadAllLines("people.csv")
                                          .Skip(1)
                                          .Select(v => People.FromCsv(v))
                                          .OrderBy(v => v.l_name)
                                          .ToList();
            Console.WriteLine("start");
            foreach (var item in values) {
                Console.WriteLine("{0} {1}",item.f_name,item.l_name);
            }
            Console.ReadKey();
        }
    }
}
