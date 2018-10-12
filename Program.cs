using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            // LINQ to Object
            
            int[] number = {1, 5, 6, 4, 9, 8, 3 };
          
            //.Select(i => i + 1) işleminde dizinin elemanlarını i ye atıyoruz daha sonra 1 artırıyoruz.
            var number2 = number.Select(i => i + 1);
          
            
            //Where(i => i % 2 == 1).OrderBy(i => i) işleminde dizinin elemanlarını iye atıyoruz ve dizideki tek sayı elemanları sıralıyoruz.
            // var number2 = number.Where(i => i % 2 == 1).OrderBy(i => i);





            foreach (var  item in number2)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();



         

                
           



        }
    }
}
