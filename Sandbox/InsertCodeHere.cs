using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            // Create a new bank account with 25 % interest rate
            // (is that legal...?)
            BankAccount theAccount = null;

           
            try
            {
               theAccount = new BankAccount(19.0);
            }
            catch (IllegalInterestRateException)
            {

                Console.WriteLine("Illegal interest rate");
                return;
            }

            theAccount.Deposit(2000);

            // Should this be legal...?
            // It should not. This code will give you an error if you try to desposit a negative number.

            try
            {
                theAccount.Deposit(-1000);
            }
            catch (NegativeAmountException)
            {

                Console.WriteLine("Error. You have tried to desposit a negative amount");
                return;
            }
           

            // Try to withdraw...
            try
            {
                theAccount.Withdraw(500);
            }
            catch (WithdrawAmountTooLargeException)
            {
                Console.WriteLine("You tried to withdraw too much money!");
            }


            Console.WriteLine("Balance is now : " + theAccount.GetBalance());

            // The LAST line of code should be ABOVE this line
        }
    }
}
