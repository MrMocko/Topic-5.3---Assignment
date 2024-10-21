using System.ComponentModel.Design;
using System.Transactions;

namespace Topic_5._3___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            double money;
            string isWorking;

            Console.WriteLine("Hello firend this is OTZ and today i will be asking you what your age is, so how old are you?");
            Console.Write("Enter age here : ");
            Int32.TryParse(Console.ReadLine(), out age);
            if (age >= 13 && age < 19)
            {
                Console.WriteLine("Yea man you are a teen, and probably watch my content, because my viewer base is between 13 and 19 obvy");
            }
            else 
            {
                Console.WriteLine("You are a different specimen, you are out of the ordinary viewerbase");
            }
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Hey are you working somtime later?");
            Console.Write("Enter your answer here :");
            isWorking = Console.ReadLine();
            Console.WriteLine("Oh ok cool i guess, and another question, how much money do you got?");
            Console.Write("Enter your answer here :");
            double.TryParse(Console.ReadLine(), out money);


        }
    }
}
