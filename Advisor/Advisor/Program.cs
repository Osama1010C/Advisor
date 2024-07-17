namespace Advisor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        public static void Menu()
        {
            while (true)
            {
                Console.WriteLine("================================");
                Console.WriteLine("*          Advisor App         *");
                Console.WriteLine("================================\n");
                Console.WriteLine("1] Today's Advise\n\n2] Exit\n");
                int select;
                while (true)
                {
                    try
                    {
                        select = Convert.ToInt32(Console.ReadLine());
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("Unknown Choice");
                        continue;
                    }
                    if (select < 1 || select > 2)
                    {
                        Console.WriteLine("Unknown Choice");
                        continue;
                    }
                    else break;
                }
                if(select == 1)
                {
                    Console.Clear();
                    string adviseInShape = $"Today's advise :\n=-=-=-=-=-=-=-=-=-=-=\n\n*] {Advise.GetAdvise()}";
                    Console.WriteLine(adviseInShape);
                    Console.WriteLine("\n\n< Click Enter To Back >");
                    string enter = Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    break;
                }
            }
        }
    }
}
