using System;
using System.Security;

namespace Black_Jack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();


            Console.WriteLine("Välkommen");
            int altsvar = 0;
            string namn = "inget vinnare ännu";

            do
            {
                Console.WriteLine("Välj ett av nedastående alternativ");
                Console.WriteLine("x------------------------------x");
                Console.WriteLine("|  [1]  Spela Blackjack        |");
                Console.WriteLine("|  [2]  Visa senaste vinnaren  |");
                Console.WriteLine("|  [3]        Regler           |");
                Console.WriteLine("|  [4]   Avsluta programmet    |");
                Console.WriteLine("x------------------------------x");


                altsvar = int.Parse(Console.ReadLine());

                switch (altsvar)
                {
                    case 1:

                        Console.WriteLine("Du får nu två kort");

                        Random playerrandom = new Random();
                        int Spelare = playerrandom.Next(1, 11);
                        int kort2 = playerrandom.Next(1, 11);
                        Random pcrandom = new Random();
                        int Dator = pcrandom.Next(1, 11);
                        int PC2 = pcrandom.Next(1, 11);

                        int sumSpelare = Spelare + kort2;
                        int sumPC = Dator + PC2;

                        Console.WriteLine($"Du har {sumSpelare} poäng");
                        Console.WriteLine($"Datorn har {sumPC} poäng");
                        Thread.Sleep(200);
                        if (sumSpelare > 21)
                        {
                            Console.WriteLine("Du har förlorat");
                            namn = "datorn";
                            Console.WriteLine("");
                            break;
                        }
                        else if (sumPC > 21)
                        {
                            Console.WriteLine("Du har vunnit");
                            Console.WriteLine("Skriv in ditt namn");
                            namn = Console.ReadLine();
                            Console.WriteLine("");
                            break;
                        }

                        Console.WriteLine("Vill du dra ett till kort? j/n");
                        Console.WriteLine("");
                        string spelval = Console.ReadLine().ToLower();
                        while (spelval == "j")
                        {
                            int kort3 = playerrandom.Next(1, 11);
                            Console.WriteLine("Ditt nya kort är värt " + kort3);
                            sumSpelare += kort3;
                            Console.WriteLine($"Du har {sumSpelare} poäng");
                            Console.WriteLine($"Datorn har {sumPC} poäng");

                            if (sumSpelare > 21)
                            {
                                Console.WriteLine("Du har förlorat");
                                namn = "datorn";
                                Console.WriteLine("");
                                break;
                            }
                            Console.WriteLine("Vill du dra ett till kort? j/n");
                            Console.WriteLine("");
                            spelval = Console.ReadLine().ToLower();


                        }
                        while (sumPC < 17 && sumSpelare <= 21)
                        {
                            int PC3 = pcrandom.Next(1, 11);
                            Console.WriteLine("Datorns nya kort är värt " + PC3);
                            sumPC += PC3;
                            Console.WriteLine($"Datorn har {sumPC} poäng");
                            Console.WriteLine("");

                            if (sumPC > 21)
                            {
                                Console.WriteLine("Du har vunnit");
                                Console.WriteLine("Skriv in ditt namn");
                                namn = Console.ReadLine();
                                Console.WriteLine("");
                                break;
                            }
                        }
                        if (sumPC >= sumSpelare && sumPC <= 21 && sumSpelare <= 21)
                        {
                            Console.WriteLine("Du förlorade");
                            namn = Console.ReadLine();
                            Console.WriteLine("");
                            break;
                        }
                        else if (sumPC < sumSpelare && sumPC <= 21 && sumSpelare <= 21)
                        {
                            Console.WriteLine("Du har vunnit");
                            Console.WriteLine("Skriv in ditt namn");
                            namn = Console.ReadLine();
                            Console.WriteLine("");
                            break;
                        }
                        break;

                    case 2:

                        Console.WriteLine("");
                        Console.WriteLine($"Senaste vinnaren är {namn}");
                        Console.WriteLine("");
                        break;

                    case 3:

                        Console.WriteLine("");
                        Console.WriteLine(" * Ditt mål är att tvinga datorn att få mer än 21 poäng.");
                        Console.WriteLine(" * Du får poäng genom att dra kort, varje kort har 1 - 10 poäng.");
                        Console.WriteLine(" * Om du får mer än 21 poäng har du förlorat.");
                        Console.WriteLine(" * Både du och datorn får två kort i början. Därefter får du");
                        Console.WriteLine("   dra fler kort tills du är nöjd eller får över 21.");
                        Console.WriteLine(" * När du är färdig drar datorn kort till den som har");
                        Console.WriteLine("   mer poäng än dig eller över 21 poäng.");
                        Console.WriteLine("");
                        break;

                    case 4:

                        Console.WriteLine("");
                        Console.Write("Programmet avslutas");
                        Console.Write(".");
                        Thread.Sleep(400);
                        Console.Write(".");
                        Thread.Sleep(400);
                        Console.Write(".");
                        Thread.Sleep(400);
                        Console.WriteLine("");
                        break;

                    default:

                        Console.WriteLine("");
                        Console.WriteLine("Du valde inget av alternativen");
                        Console.WriteLine("");
                        break;
                }
            } while (altsvar != 4);
            Console.ReadKey();
        }
    }
}