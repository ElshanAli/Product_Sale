using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Chivas 12 years old ", 80, 50);
            Product product2 = new Product("Chivas 18 years old ", 160, 40);
            Product product3 = new Product("Black Label ", 120,70);
            Console.WriteLine("Welcome to Market");
           
            Order order = new Order();
            int selection;
            int selection2;
            do
            {
                Console.WriteLine("Please choose one of them");
                Console.WriteLine("1 - Chivas 12 years old 80 AZN");
                Console.WriteLine("2 - Chivas 18 years old 160 AZN");
                Console.WriteLine("3 - Black Label 120 AZN");
                Console.WriteLine("4 - Please indicate the Total Price");
                selection = int.Parse(Console.ReadLine());

                switch (selection)
                {
                    case 1:
                        Console.WriteLine(" Choose how much you want to buy:");
                        selection2 = int.Parse(Console.ReadLine());
                        order.Sale(product1, selection2);
                        break;
                    case 2:
                        Console.WriteLine(" Choose how much you want to buy:");
                        selection2 = int.Parse(Console.ReadLine());
                        order.Sale(product2, selection2);
                        break;
                    case 3:
                        Console.WriteLine(" Choose how much you want to buy:");
                        selection2 = int.Parse(Console.ReadLine());
                        order.Sale(product3, selection2);
                        break;
                    case 4:
                        order.Discount();
                        



                        break;


                    default:
                        break;
                }


            } while (selection > 0 && selection < 4);







        
    }
        }
}
