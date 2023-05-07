using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Problema_das_sequências_alternadas
{
    class Program
    {
        public static void Mostrarcrescente(int begin, List<int> numeros)
        {
            int[] n = new int[5];
            int conta = 0;
            for(int cont=begin; cont<numeros.Count; cont++)
            {
                if (conta < 5)
                {
                    n[conta]=(numeros[cont]);
                }
                else
                {
                    break;
                }
                conta++;
            }

            Array.Sort(n);
            foreach(var a in n)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine("");
        }

        public static void MostrarDecresente(int begin, List<int> numeros)
        {
            int[] n = new int[5];
            int conta = 0;
            for (int cont = begin; cont < numeros.Count; cont++)
            {
                if (conta < 5)
                {
                    n[conta] = (numeros[cont]);
                }
                else
                {
                    break;
                }
                conta++;
            }

            Array.Sort(n);
            for (int i = n.Length-1; i >=0; i--)
            {
                Console.Write(n[i] + " ");
            }
            Console.WriteLine("");
        }

        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            
            int n = int.Parse(Console.ReadLine());
            List<int> numeros = new List<int>();
            int cont = 1;
            int contar = 0;
            stopwatch.Start();
            while (cont <= n)
            {
                
                numeros.Add(int.Parse(Console.ReadLine()));
                contar++;
                if (contar == 5)
                {
                    cont++;
                    contar = 0;
                }

            }

            int c = 0;
            while (c < numeros.Count)
            {
                Mostrarcrescente(c, numeros);
                c += n + 1;
                MostrarDecresente(c, numeros);
                c += n + 1;

            }
            Console.WriteLine("o Algoritmo levou " + stopwatch.Elapsed.TotalMilliseconds / 1000);

        }
    }
}
