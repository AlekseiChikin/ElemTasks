using System;

namespace Task_2
{
    class Program
    {
        static Envelope CreateEnvelop(string sideA, string sideB)
        {
            double _sideA, _sideB;
            while (true)
            {
                Console.Write($"Envelop ({sideA},{sideB}) side {sideA} = ");
                if (!Double.TryParse(Console.ReadLine(), out _sideA))
                {
                    Console.WriteLine("invalid argument, try again");
                    continue;
                }
                Console.Write($"Envelop ({sideA},{sideB}) side {sideB} = ");
                if (!Double.TryParse(Console.ReadLine(), out _sideB))
                    continue;

                return new Envelope(_sideA, _sideB);
            }
        }
        static void Main()
        {
            Envelope env1 = CreateEnvelop("a", "b");
            Envelope env2 = CreateEnvelop("c", "d");

            Console.WriteLine(env1.CanBeInsertedIn(env2));

        }
    }
}
