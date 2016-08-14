using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainee
{
    class Program
    {
        static void Main(string[] args)
        {
            //var a=10;
            //var b = 30.2;
            //var s = "BITM";
            //var c = 'A';

            var aTrainer = new Trainer();
            aTrainer.Name = "ABC";
            aTrainer.SEID = "146250";

            //var array = new Object[] { a, b, s, c, aTrainer.Name ,aTrainer.SEID};

            //foreach (var arr in array)
            //{
            //    Console.WriteLine(arr);
            //}
            //Console.ReadKey();
            var trainer2 = new Trainer() {Name = "DEF"};
            trainer2.SEID = "145632";

            var trainers = new List<Trainer>() 
            {
                aTrainer,trainer2,new Trainer(){Name = "IJK",SEID = "1465632"}
            };

            foreach (var trainer1 in trainers) {
                Console.WriteLine(trainer1.Name+"  -  "+trainer1.SEID);
            }
            Console.ReadKey();



            var product = new {Name = "Mobile", Price = 12366};

        }
    }
}
