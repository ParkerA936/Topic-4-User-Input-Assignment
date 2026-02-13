using System.Diagnostics;

namespace Topic_4___User_Input_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Parker
            Part5();
        }
        public static void Part1()
        {
            string name;
            int age;
            double income;
            Console.WriteLine("Hello, what is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hi, " + name + "! How old are you?");
            Int32.TryParse(Console.ReadLine(), out age);
            Console.WriteLine("So you're " + age + ", eh? That's not old at all How much do you make, " + name + "?");
            Double.TryParse(Console.ReadLine(), out income);
            Console.WriteLine(income.ToString("C") + "! Wow that's a lot more than I make.");



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
            Int32.TryParse(Console.ReadLine(), out studentID);

            Console.Write("Login Name:");
            loginName = Console.ReadLine();

            Console.Write("Average:");
            Double.TryParse(Console.ReadLine(), out average);

            Console.WriteLine("Your information:");
            Console.WriteLine("Login Name:\t\t" + loginName);
            Console.WriteLine("Student ID:\t\t" + studentID);
            Console.WriteLine("Full Name:\t\t" + firstName + "," + lastName);
            Console.WriteLine("Average:\t\t" + average + "%");
            Console.WriteLine("Grade:\t\t\t" + grade);

        }

        public static void Part3()
        {
            string name;
            int age, pastAge, futureAge;
            Console.WriteLine("Hello! What's your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hi, " +name+ "! How old are you?" );
            Int32.TryParse(Console.ReadLine(), out age);
            pastAge = age - 5;
            futureAge = age + 5;
            Console.WriteLine("Did you know that five years ago you were " +pastAge+ "? And in five years you will be " +futureAge+ "!");
        }

        public static void Part4()
        {
            double num1, num2, num3, calculated;
            Console.WriteLine("Type any number");
            Double.TryParse(Console.ReadLine(), out num1);
            Console.WriteLine("Type another number");
            Double.TryParse(Console.ReadLine(), out num2);
            Console.WriteLine("Type one last number");
            Double.TryParse(Console.ReadLine(), out num3);
            calculated = (num1 + num2 + num3) / 2;
            Console.WriteLine("Calculation Complete! You have " + calculated + ".");
        }
        public static void Part5()
        {
            string item1, item2;
            double price1, price2, totalPrice, discount, discountedtotal,tax , finalCost;
            Console.WriteLine("Hello! Give me the name of somthing you bought recently.");
            item1 = Console.ReadLine();
            Console.WriteLine("And how much does that item cost?");
            Double.TryParse(Console.ReadLine()  , out price1);
            Console.WriteLine("Hey again! Give me another name of somthing you bought recently.");
            item1 = Console.ReadLine();
            Console.WriteLine("And how much does that item cost?");
            Double.TryParse(Console.ReadLine(), out price2);
            totalPrice = price1 + price2;   
            Console.WriteLine("So, the cost of both items together is " + totalPrice.ToString("C") + ".");
            discount = totalPrice * 0.2;
            discountedtotal = totalPrice - discount;
            Console.WriteLine(" But, I'm feeling good today! So, I will give you a 20% discount. The new cost will be " + discountedtotal.ToString("C"));
            tax = discountedtotal * 0.13;
            finalCost = discountedtotal + tax;
            Console.WriteLine("With tax the final price comes too " +finalCost.ToString("C"));


        }
    }
}
