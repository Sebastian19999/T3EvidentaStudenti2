using System;

namespace EvidentaStudenti2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Ionescu");
            string c;
            string noteCmd="";

           do
            {
                Console.Clear();
                Console.WriteLine("s: Citeste note de la tastatura ca un sir de caractere.");
                Console.WriteLine("t: Citeste note de la tastatura (cate o nota pe rand).");
                Console.WriteLine("c: Citeste note din linia de comanda");
                Console.WriteLine("a: Afisare note");
                Console.WriteLine("i: Info autor");
                Console.WriteLine("x: Iesire");
                {
                    switch (c = Console.ReadLine())
                    {
                        case "s":
                            Console.WriteLine("\n Citire tastatura ca un sir \n");
                            Console.Write("Introduceti sirul de note: ");
                            string sir = Console.ReadLine();
                            s.Setnote(sir);
                            Console.ReadLine();
                            break;
                        case "t":
                            Console.WriteLine("Citeste note de la tastatura (cate o nota pe rand).");
                            s.SetNote();

                            Console.ReadLine();
                            break;
                        case "c":
                            Console.WriteLine("c: Citeste note din linia de comanda");
                            if (args.Length == 0)
                                Console.Write("Linia de comanda nu contine argumente");
                            else
                            {
                                for (int ind = 0; ind < args.Length-1; ind++)
                                    noteCmd+=(string)(args[ind]+" ");
                                noteCmd += args[args.Length - 1];
                                s.Setnote(noteCmd);
                                Console.WriteLine("Citirea din linia de comanda a fost realizata cu succes!");
                            }
                                //s.SetNote();
                            Console.ReadLine();
                            break;
                        case "a":
                            s.ConversieLaSir();
                            Console.ReadLine();
                            break;
                        case "i":
                            Console.WriteLine("\n Informatii autor: Galan Calin Sebastian 3123b");
                            Console.ReadLine();
                            break;
                        case "x":
                            return;
                    }
                }
            } while (true);
        }
    }
}
