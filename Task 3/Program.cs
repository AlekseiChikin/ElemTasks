using System;
using System.Collections;

namespace Task_3
{
    class Program
    {
        static Triangle CreateTriangle()
        {
            string[] tmp = new string[4];
            string name;
            double a, b, c;
            Triangle triangle;

            Console.WriteLine("Name = ");
            tmp = Console.ReadLine().Split(',');

            name = tmp[0].Trim().ToLower();
            Double.TryParse(tmp[1], out a);
            Double.TryParse(tmp[2], out b);
            Double.TryParse(tmp[3], out c);
            triangle = new Triangle(name, a, b, c);

            if (!triangle.isValid)
                return null;

            return triangle;
        }
        static void Main()
        {
            SortedList srtLst = new SortedList();

            Triangle trgl;

            while (true)
            {
                trgl = CreateTriangle();
                if (trgl == null)
                {
                    Console.WriteLine("Triangle uncorrect, try anothe one");
                    continue;
                }
                srtLst.Add(trgl.Area, trgl);
                Console.WriteLine("Triangle added!");
                Console.WriteLine("Anothe one ?");
                string userResponse = Console.ReadLine().ToLower();

                if (userResponse == "y" || userResponse == "yes")
                    continue;
                else
                    break;
            }

            Console.WriteLine("============= Triangles list: ===============");

            for (int i = 0; i < srtLst.Count; i++)
                Console.WriteLine($"{i}. [Triangle {srtLst.GetByIndex(i)}]: {srtLst.GetKey(i)} cm^3");


        }
    }
}

