using System;

namespace usandoSwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string mes;
                Console.WriteLine("---------------");
                Console.WriteLine("Digite um mês:");
                Console.WriteLine("---------------");
                mes = Console.ReadLine();
            
            Console.WriteLine("");//Espaço
            
           switch (mes)
           {
               case "janeiro":
                Console.WriteLine("ESTE MÊS TEM 31 DIAS");
               break;

               case "fevereiro":
                Console.WriteLine("ESTE MÊS TEM 28 DIAS OU 29 DIAS");
               break;

               case "março":
                Console.WriteLine("ESTE MÊS TEM 31 DIAS");
               break;

               case "abril":
                Console.WriteLine("ESTE MÊS TEM 30 DIAS");
               break;

               case "maio":
                Console.WriteLine("ESTE MÊS TEM 31 DIAS");
               break;

               case "junho":
                Console.WriteLine("ESTE MÊS TEM 30 DIAS");
               break;

               case "julho":
                Console.WriteLine("ESTE MÊS TEM 31 DIAS");
               break;

               case "agosto":
                Console.WriteLine("ESTE MÊS TEM 31 DIAS");
               break;

               case "setembro":
                Console.WriteLine("ESTE MÊS TEM 30 DIAS");
               break;

               case "outubro":
                Console.WriteLine("ESTE MÊS TEM 31 DIAS");
               break;

               case "novembro":
                Console.WriteLine("ESTE MÊS TEM 30 DIAS");
               break;

               case "dezembro":
                Console.WriteLine("ESTE MÊS TEM 31 DIAS");
               break;

               default:
                Console.WriteLine("VOCÊ DIGITOU A PALAVRA ERRADA");
                break;
           }
        }
    }
}
