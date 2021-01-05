using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopersBank
{
    class Program
    {
        static void Main(string[] args)
        {
            String Choise;
            double j;
            BankTrans Bt1 = new BankTrans();
            Account a1= new Account();
            for (j = 0; j < 21324567890; j++)
            {
                Console.WriteLine("              Welcome to the Developers Bank Limited");
                Console.WriteLine("*********************************************************************");
                Console.WriteLine("Please,Select any option from below");
                Console.WriteLine("     Open a Bank account");
                Console.WriteLine("     Perform transactions for an account");
                Console.WriteLine("     Exit from the application");

                Console.WriteLine("Your Choise:");
                Choise = Console.ReadLine();
                switch (Choise)
                {
                    case "open":
                        Console.Write("Enter your Account Number:");
                        a1.accountNumber = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter your Account Name:");
                        a1.accountName = Console.ReadLine();
                        Console.Write("Enter your Email:");
                        a1.email = Console.ReadLine();
                        Console.Write("Enter Balance you want to load now:");
                        a1.balance = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("**********************************************");
                        Console.WriteLine("     Open Saving Account");
                        Console.WriteLine("     Open Checking Account");
                        Console.WriteLine("     Exit from the application");
                        Console.Write("Your Choise:");
                        String ChooseOpen = Console.ReadLine();
                        switch (ChooseOpen)
                        {
                            case "savings":
                                Console.WriteLine("Your account has been created");
                                a1.ShowAccountInfo();
                                Console.WriteLine("***************************************");
                                break;

                            case "checking":
                                Console.WriteLine("Your account has been created");
                                a1.ShowAccountInfo();
                                Console.WriteLine("************************************");
                                break;
                            case "quit":
                                Console.WriteLine("Bye!!");
                                break;

                            default:
                                Console.WriteLine("Invalid Input,Try again");
                                Console.WriteLine("********************************************");
                                break;
                        }
                        break;

                    case "account":
                        Console.WriteLine("**********************************************");
                        Console.WriteLine("     Deposit money in the account");
                        Console.WriteLine("     Withdraw money from the account");
                        Console.WriteLine("     Transfer money to another account");
                        Console.WriteLine("     Change the owner name");
                        Console.WriteLine("     Display the number of transactions and closing balance");
                        Console.WriteLine("     Exit from the application");
                        Console.Write("Your Choise:");
                        String ChooseOpen1 = Console.ReadLine();
                        switch (ChooseOpen1)
                        {

                            case "deposit":
                             
                                Console.WriteLine("Enter your amount you want to deposit:");
                                a1.amount = Convert.ToInt64(Console.ReadLine());
                                a1.Deposit(a1.amount);
                                Console.WriteLine("**********************************");
                                break;

                            case "withdraw":
                                
                                Console.WriteLine("Enter your amount you want to withdraw:");
                                a1.amount = Convert.ToInt64(Console.ReadLine());
                                Console.WriteLine("Choose your account type:");
                                Console.WriteLine("1.Savings Account");
                                Console.WriteLine("2.Checking Account");
                                Console.Write("Your Choise:");
                                int Choose1 = Convert.ToInt32(Console.ReadLine());
                                switch (Choose1)
                                {
                                    case 1:
                                        a1.SavingsWithdraw(a1.amount);
                                        break;
                                    case 2:
                                        a1.CheckingWithdraw(a1.amount);
                                        break;
                                    default:
                                        Console.WriteLine("Invalid Input,Try again");
                                        Console.WriteLine("********************************************");
                                        break;
                                }
                                break;

                            case "transfer":
                                
                                Console.WriteLine("Enter your Balance you want to transfer:");
                                a1.amount = Convert.ToInt64(Console.ReadLine());
                                a1.Transfer(a1.amount, a1);
                                Console.WriteLine("**********************************");
                                break;

                            case "change":
                                Console.WriteLine("Edit your name:");
                                a1.accountName = Console.ReadLine();
                                Console.WriteLine("**********************************");
                                break;

                            case "show":
                                
                                a1.Deposit(a1.amount);
                                a1.SavingsWithdraw(a1.amount);
                                a1.CheckingWithdraw(a1.amount);
                                a1.Transfer(a1.amount, a1);
                                break;

                            case "quit":
                                Console.WriteLine("Bye!!");
                                break;

                            default:
                                Console.WriteLine("Invalid Input,Try again");
                                Console.WriteLine("********************************************");
                                break;
                        }
                        break;
                    case "quit":
                        Console.WriteLine("Bye!!");
                        break;
                    default:
                        Console.WriteLine("Invalid Input,Try again");
                        Console.WriteLine("********************************************");
                        break;
                }
            }
        }
    }
}