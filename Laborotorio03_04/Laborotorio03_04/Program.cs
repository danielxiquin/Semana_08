using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Laborotorio03_04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("a. Sumatoria");
            Console.WriteLine("b. Tablas de multiplicar");
            Console.WriteLine("c. Numeros perfectos");

            char opcion = Convert.ToChar(Console.ReadLine());

            switch (opcion)
            {
                case 'a':
                    Console.WriteLine("ingrese un numero");
                    int num = Convert.ToInt32(Console.ReadLine());
                    int resultado = 0;
                    //primera forma
                    /* while (i <= num)
                     {
                         resultado = resultado + i;
                         i++;
                     }
                     Console.WriteLine("Sumatoria igual" + resultado);
                     //segunda forma
                     do
                     {
                         resultado = resultado + i;
                         i++;
                     }while (i <= num);
                     Console.WriteLine("Sumatoria igual" + resultado);*/

                    //tercera forma
                    do
                    {
                        resultado = resultado + num;
                        num--;
                    } while (num > 0);
                    Console.WriteLine("Sumatoria igual" + resultado);
                    break;


                case 'b':
                    for (int i = 1; i < 11; i++)
                    {
                        Console.Write(i+ ": ");
                        for(int j=1; j< 11; j++)
                        {
                            Console.Write((i*j)+"\t");
                        }
                        Console.Write("\n");
                    }
                    
                    break;

                case 'c':
                    Console.WriteLine("ingrese un numero");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    int suma = 0;
                  

                    for (int i = 1; i <num2; i++)
                    {

                        if (num2 % i == 0)
                        {
                            suma = suma + i;
                            
                        }

                    }
                    if (num2 == suma)
                    {
                        Console.WriteLine("Numero Perfecto");
                    }else
                    {
                        Console.WriteLine("Numero Imperfetco");
                    }

                    

                    break;


            }

            

        }
    }
}
