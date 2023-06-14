namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Access Modifiers!!!\n");

            //-- for public modifiers
            Student student = new Student();

            Console.WriteLine("Name: "+student.name);

            student.print();

            //-- for private modifiers

            BankAccount obj = new BankAccount(1000);

            obj.Deposit(500);
            decimal balance1 = obj.GetBalance();
            Console.WriteLine("\nAfter deposit balance is: "+balance1);
            obj.Withdraw(100);
            decimal balance2 = obj.GetBalance();
            Console.WriteLine("After withdraw balance is: "+balance2);

            // -- for protected modifiers

            Derived derived = new Derived();

            derived.num2 = 100;
            int result = derived.Add();
            Console.WriteLine("\nSum of two nums is :"+result+"\n");

            //-- for internal modifiers

            InternalModifiers modifiers = new InternalModifiers();

            modifiers.SetData(25, 2);
            modifiers.DisplayData();

        }
    }
}