using System.ComponentModel.Design;
using System.Transactions;

namespace Topic_5._3___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age, guess, temp;
            double money;
            string isWorking, password, pizza, fav, look;

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

            if (password.ToLower() == "jimmy" && guess < 5)
            {
                Console.WriteLine("WOWZA MAN YOU GOT IT I'M SUPER IMPRESSED");
            }
            else
            {
                Console.WriteLine("Oh too bad you suck LOL");
            }
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Hey man I dare you to guess what my fav pizza topping is. If you do i will give you a big ol bear hug");
            Console.Write("Enter your answer here: ");
            pizza = Console.ReadLine();
            if (pizza.ToLower().Contains("bacon") && pizza.ToLower().Contains("ham"))
            {
                Console.WriteLine("Good job man, now come on in here, ima give you a big ol bear hug!");
            }
            else
            {
                Console.WriteLine("You couln't be more wrong... *DEEEEEAAAAADDDDD* ");
            }
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Hello friends this is the bus driver, now it seems as tho you want a bus pass although i need to know whether or not you are a kid teen or elderly person.");
            Console.WriteLine("Now how old are you?");
            Console.Write("Enter your answer here: ");
            Int32.TryParse (Console.ReadLine(), out age);
            if (age <= 12 ||  age >= 60 )
            {
                Console.WriteLine("Your ticket is going to cost $2.00 :)");
            }
            else
            {
                Console.WriteLine("Your ticket is going to cost $3.50 :(");
            }
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Hey man whats your fav animal...                     their is only 1 correct answer btw");
            Console.Write("Enter your answer here: ");
            fav = Console.ReadLine();
            if (fav.ToLower() == "jimmy" || fav.ToLower() == "dog" || fav.ToLower() == "cats")
            {
                Console.WriteLine("W answers big man");
            }
            else
            {
                Console.WriteLine("Bro what the?");
            }
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Yo dude whats the temp outside right now, and how does it look, like is it sunny or cloudy?");
            Console.Write("Enter what the temp is here: ");
            Int32.TryParse(Console.ReadLine(), out temp);
            Console.Write("Also enter how it looks outside here: ");
            
            look = Console.ReadLine();
            if (temp >= 25 &&  look.ToLower() == "sunny")
            {
                Console.WriteLine("Oh cool man ima go swim with jimmy now... *Jimmy absorbed the all the oceans* ");
            }
            else
            {
                Console.WriteLine("Hmmmmmm yeaaa idk man i think ima go sleep now L O L.");

            }
            Console.Clear();
        }
    }
}
