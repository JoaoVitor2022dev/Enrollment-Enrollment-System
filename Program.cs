using System.ComponentModel;

namespace Exercicio_Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {

            HashSet<int> cursoA = new HashSet<int>();
            HashSet<int> cursoB = new HashSet<int>();
            HashSet<int> cursoC = new HashSet<int>();

            Console.Write("How many students for A? "); 
            int n = int.Parse(Console.ReadLine());

           
            for (int i = 0; i < n; i++)
            {
                int matricula = int.Parse(Console.ReadLine());

                cursoA.Add(matricula);
            }

            Console.Write("How many students for B? ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                int matricula = int.Parse(Console.ReadLine());

                cursoB.Add(matricula);
            }

            Console.Write("How many students for C? ");
            int y = int.Parse(Console.ReadLine());

            for (int i = 0; i < y; i++)
            {
                int matricula = int.Parse(Console.ReadLine());

                cursoC.Add(matricula);
            }

            HashSet<int> all = new HashSet<int>(cursoA);
            all.UnionWith(cursoB);
            all.UnionWith(cursoC);

            Console.WriteLine($"Total students: {all.Count}"); 
        }
    }
}
