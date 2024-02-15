using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConTransaction
{
    internal class Program
    {
        //Deposit Method
        static void Deposit()
        {


            int deposit;

            Console.Write("Deposit: ");
            deposit = int.Parse(Console.ReadLine());

            if(deposit % 100 == 0)
            {
                Console.WriteLine("Account Deposit");
                Console.WriteLine("");
                Console.WriteLine($"Amount: {deposit}");
                Console.WriteLine();

            }

            else 
            {

                Console.WriteLine("Insuffecient Amount");
            
            }


        }

        // Balance Inquiry Method
        static void BalanceInquiry(String name, int accountNumber,int currentBalance)
        { 
        
            Console.WriteLine($"Account name: {name}");
            Console.WriteLine($"Account number: {accountNumber}");
            Console.WriteLine($"Current balance: {currentBalance}");
  
        }


        //Main Method
        static void Main(string[] args)
        {

            int pin;
            String name;
            int accountNumber;
            int currentBalance;
            int choose;

            Console.Write("Ask a PIN: ");
            pin = int.Parse(Console.ReadLine());

            Console.Write("Account name: ");
            name = Console.ReadLine();

            Console.Write("Account number: ");
            accountNumber = int.Parse(Console.ReadLine());

            Console.Write("Balance: ");
            currentBalance = int.Parse(Console.ReadLine());

            while (true) {

                

                Console.WriteLine("Transaction of an ATM");
                Console.WriteLine();
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Balance Inquiry");
                Console.WriteLine("3. Withdrawal");
                Console.WriteLine("4. Fast Cash");
                Console.WriteLine("5. Exit");
                Console.WriteLine();

                Console.WriteLine("Select: ");
                choose = int.Parse(Console.ReadLine());

                switch (choose)
                {

                    case 1:

                        Deposit();

                        break;
                    

                    case 2:

                        BalanceInquiry(name,accountNumber,currentBalance);

                        break;

                    case 5:

                        Environment.Exit(0);

                        break;

                }          
            
            }


        }
    }
}
