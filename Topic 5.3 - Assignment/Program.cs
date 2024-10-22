using System.ComponentModel.Design;
using System.Transactions;

namespace Topic_5._3___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age, guess;
            double money;
            string isWorking, password;

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
            Console.WriteLine("Hey are you working sometime later?");
            Console.Write("Enter your answer here: ");
            isWorking = Console.ReadLine();
            Console.WriteLine("Oh ok cool i guess, and another question, how much money you got?");
            Console.Write("Enter your answer here: ");
            double.TryParse(Console.ReadLine(), out money);
            if (isWorking.ToLower() == "no" && money >= 20)
            {
                Console.WriteLine("Ok sweet man lets go watch the new Spider-man movie at 6?");
            }
            else if (isWorking.ToLower() == "yes" && money < 20)
            {
                Console.WriteLine("AWWWWW MAAAAN BUT I WANNA WATCH THE NEW SPIDER-MAN MOVIE, why do you suck?");
            }
            else if (isWorking.ToLower() == "no" && money < 20)
            {
                Console.WriteLine("Man dude why are you broke?");
            }
            else if (isWorking.ToLower() == "yes" && money > 20)
            {
                Console.WriteLine("AWWWWWWW MAN THATS TERRIBLE, like paper lol :)");
            }
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Hey man i dare you to guess this password correctly, if you do i'll give you a billion dollars");
            Console.Write("Enter your answer here: ");
            password = Console.ReadLine();
            Console.WriteLine("How many guesses");

            Int32.TryParse(Console.ReadLine(), out guess);

            if (password.ToLower() == "santa" && guess < 5)
            {
                Console.WriteLine("WOWZA MAN YOU GOT IT I'M SUPER IMPRESSED");
            }
            else
            {
                Console.WriteLine("Oh too bad you suck LOL");
            }
            Console.WriteLine("");
        }
    }
}
