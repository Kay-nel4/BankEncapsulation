namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account1 = new BankAccount();
            bool exitATM = false;
            do
            {
                Console.WriteLine("How can I help you today?");
                Console.WriteLine("1. Withdraw\n2. Deposit\n3. Check Balance\n4. Exit");
                string choice = Console.ReadLine();


                {
                    switch (choice)
                    {
                        case "1":
                            account1.Withdraw(100.00);
                            break;
                        case "2":
                            account1.Deposit(250.00);
                            break;
                        case "3":
                            account1.CheckBalance();
                            break;
                        case "4":
                            Console.WriteLine("Goodbye");
                            exitATM = true;
                            break;

                        default:
                            Console.WriteLine("That is not a valid choice");
                            break;
                    }

                    var checkBalance = account1.CheckBalance();
                    Console.WriteLine($"The Current Balance is ${checkBalance}.");
                }
                
                
            }
            while (!exitATM);
            

        }


    }
}
//I wanted to turn in and save my first attempt.
//This is a start now it is time to figure out how to not allow for negative withdraw.
//And also allow the user to put in their own choice for amount to deposit or withdraw.
//So I will turn this version in and then watch the video to understand another way to do it.
//Practice with tryparse to get valid user input.



