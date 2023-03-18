using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T8_DX_1118423
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            string binario = "";
           

            Console.WriteLine("Ingrese un numero ");
            num = Convert.ToInt32(Console.ReadLine());

            while (num > 0) { 
                binario = num % 2 + binario;

                num = num/ 2;
            }

            Console.WriteLine("El numero en binario es: " + binario);


            //Con numeros
            int num2;
            string hexadecimal = "";


            Console.WriteLine("Ingrese un numero ");
            num2 = Convert.ToInt32(Console.ReadLine());
          

            while (num2 > 0)
            {
                hexadecimal = num2 % 16 + hexadecimal;
                num2 = num2 / 16;


            }

            Console.WriteLine("El numero en hexadecimal es: " + hexadecimal);

            int num3;
            Console.WriteLine("Ingrese un numero ");
            num3 = Convert.ToInt32(Console.ReadLine());
            //Con letras
            Console.WriteLine(Convert.ToString(num3, 16).ToUpper());

        }
    }
}
