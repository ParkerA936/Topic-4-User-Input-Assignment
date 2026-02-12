namespace Topic_4___User_Input_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Parker
            Part2();
        }
        public static void Part1()
        {
            string name;
            int age;
            double income;
            Console.WriteLine("Hello, what is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hi, " + name + "! How old are you?");
            Console.WriteLine(Int32.TryParse(Console.ReadLine(), out age));
            Console.WriteLine("So you're " +age+  ", eh? That's not old at all How much do you make, " +name+ "?");
            Double.TryParse(Console.ReadLine(), out income);
            Console.WriteLine("$" + income + "! Wow that's a lot more than I make.");



        }
        public static void Part2()
        {
            string firstName, lastName, loginName;
            int studentID;
            double average, grade;

            Console.WriteLine("Please enter the following information so I can sell it for a profit!");
            Console.Write("First Name:");
            
            firstName = Console.ReadLine();
            Console.Write("Last Name:");
            
            lastName = Console.ReadLine();
            Console.Write("Grade:");
            Double.TryParse(Console.ReadLine(), out grade);

            Console.Write("Student ID:");
            Console.Write(Int32.TryParse(Console.ReadLine(), out studentID));

            Console.Write("Login Name:");
            loginName = Console.ReadLine();

            Console.Write("Average:");
            Double.TryParse(Console.ReadLine(), out average);

            Console.WriteLine("Your information:");
            Console.WriteLine("Login Name:\t\t" + loginName);
            Console.WriteLine("Student ID:\t\t" + studentID);
            Console.WriteLine("Full Name:\t\t" +firstName+ ","+lastName);
            Console.WriteLine("Average:\t\t" + average);
            Console.WriteLine("Grade:\t\t" + grade);
            









        }

    }
}
