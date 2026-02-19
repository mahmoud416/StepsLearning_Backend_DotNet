using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = 10000.0;
            bool exit = false;
            Console.WriteLine("=== Welcome to ATM program ===");

            while (!exit) {
                Console.WriteLine("\nPlease choose on option");
                Console.WriteLine("1. Show Balance");
                Console.WriteLine("2. Deppsit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter your choice (1-4): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine($"\n Your current balance is : {balance} EGP");
                        break;

                    case "2":
                        Console.WriteLine("\n Enter debosit amount :");
                        double debosit = double.Parse(Console.ReadLine());
                        if (debosit > 0)
                        {
                            balance += debosit;
                            Console.WriteLine($"Deposit successful! New balance :{balance} EGP");
                        }
                        else
                        {
                            Console.WriteLine("Invalid amount. Deposit must be grater than 0");
                        }
                        break;
                    case "3":
                        Console.WriteLine("\nEnter withdrawa amount: ");
                        double withdraw = double.Parse(Console.ReadLine());
                        if(withdraw <= 0)
                        {
                            Console.WriteLine("Invalid amount.Withdrawal must be greater than 0.");
                        }
                        else if (withdraw > balance)
                        {
                            Console.WriteLine("Insufficient funds!");
                        }
                        else
                        {
                            balance -= withdraw;
                            Console.WriteLine($"Withdrawal successful! New balance: {balance} EGP");
                        }
                        break;

                    case "4":
                        Console.WriteLine("\nThank you for using our ATM. Goodbye!");
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("\nInvalid choice, please try again.");
                        break;
                }
            }
        }
    }
}
