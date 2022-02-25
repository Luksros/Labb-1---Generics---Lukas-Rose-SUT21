using System;

namespace Labb_1___Generics___Lukas_Rose_SUT21
{
    class Program
    {
        static void Main(string[] args)
        {
            LådaCollection lådor = new LådaCollection();

            Console.WriteLine("Skapa en Collection med Lådor, skapa fem Lådor och lägg till i Collection:");

            Låda l1 = new Låda(5, 6, 3);
            Låda l2 = new Låda(7, 3, 6);
            Låda l3 = new Låda(3, 3, 3);
            Låda l4 = new Låda(7, 4, 5);
            Låda l5 = new Låda(6, 5, 3);

            lådor.Add(l1);
            lådor.Add(l2);
            lådor.Add(l3);
            lådor.Add(l4);
            lådor.Add(l5);

            Display(lådor);

            Console.WriteLine("\nFörsök lägga till en låda med samma dimensioner som en existerande låda:");

            Låda l6 = new Låda(6, 5, 3);
            lådor.Add(l6);

            Console.WriteLine("\nTa bort låda l2 och iterera igenom igen:");
            lådor.Remove(l2);

            Display(lådor);

            Console.WriteLine($"\nKolla om låda l2 finns i Collection med Contains: {lådor.Contains(l2)}");
            Console.WriteLine($"Kolla om låda l3 finns i Collection med Contains: {lådor.Contains(l3)}");

            Låda l7 = new Låda(4, 5, 7);
            LådaSameVolume volComp = new LådaSameVolume();
            
            Console.WriteLine($"\nKolla om en låda med samma volym som l7 finns i Collection med overload av Contains: {lådor.Contains(l1, volComp)}");

            Console.ReadKey();
        }

        public static void Display(LådaCollection lådor)
        {
            int i = 0;
            foreach (Låda l in lådor)
            {
                i++;
                Console.WriteLine($"|Låda #{i}| Höjd: {l.höjd} Längd: {l.längd} Bredd: {l.bredd} Volym: {l.höjd * l.längd * l.bredd}");
            }
        }
    }
}
