using System;

namespace AboutMe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey you! Welcome to my quiz!");
            Console.WriteLine("It's a fun little questionnaire that tells you a little about myself");

            int counter = 0;
            //Have an array of answers that holds true or false. Increment counter if true, meaning that the user got the question right.
            bool[] quizlet = new bool[] { FavoriteActivity(), FavoriteConsole(), FavoriteAnimal() };
            for (int i = 0; i < quizlet.Length;i++)
            {
                if (quizlet[i])
                {
                    //Invoke Tally method that increments counter variable, then store it for later use.
                    counter = Tally(counter);
                }
            }
            Console.WriteLine($"Sweet! Thanks for taking my quiz! Your total is {counter} out of 5. :)");

        }

        static bool FavoriteActivity()
        {
            Console.WriteLine("So let's get started! Which activity do you think I gravitate towards, Music or Sports?");
            string input = Console.ReadLine();
            switch (input.ToLower())
            {
                case "music":
                    Console.WriteLine("Good guess, I really like to play all sorts of instruments. My favorite music genre is rock!");
                    return true;
                case "sports":
                    Console.WriteLine("Yup! I love to do all sorts of activities. My most recent muse is rock climbing!");
                    return true;
                default:
                    Console.WriteLine("The least you could've done is answer the question...");
                    return false;
            }
        }

        static bool FavoriteConsole()
        {
            Console.WriteLine("I'm also an avid gamer. Can you guess which one I like better? Switch or Playstation?");
            string input = Console.ReadLine();
            switch (input.ToLower())
            {
                case "playstation":
                    Console.WriteLine("Good guess, I actually really liked my playstation until I got the switch. That thing is just way more awesome in my opinion.");
                    return false;
                case "switch":
                    Console.WriteLine("Yup! I love to do all sorts of activities. My most recent muse is rock climbing!");
                    return true;
                default:
                    Console.WriteLine("Errr... I didn't quite understand that.. Well, moving on...");
                    return false;
            }
        }

        static bool FavoriteAnimal()
        {
            Console.WriteLine("I love animals! Would you please try to guess what my favorite animal is?");
            string input = Console.ReadLine();
            switch (input.ToLower())
            {
                case "dog":
                    Console.WriteLine("You would be correct! I love dogs, and I currently have a little pyscho labrador living with me :).");
                    return true;
                case "cat":
                    Console.WriteLine("Yup, I definitely love cats, though they come in as a close second to doggos. But I'll still give you the point!");
                    return true;
                default:
                    Console.WriteLine("Sure! But my absolute favorite animal is a person's best friend, doggo doggo. Bark bark!");
                    return false;
            }
        }
        static bool FavoriteGame(int answer)
        {
            Console.WriteLine("Follow up question! What game genre is my favorite? Fighting, RPG, roguelikes, etc..");
            string input = Console.ReadLine();
            switch (input.ToLower())
            {
                case "fighting":
                    Console.WriteLine("Ya! Though I'm sad about the dwindling playerbase, I still love all sorts of fighting games. I'm currently playing Street Fighter V!");
                    return true;
                case "rpg":
                    Console.WriteLine("That's a sweet, tried and true game genre. My favorite RPG so far is the Witcher series. Really looking forward to Cyberpunk 2077!");
                    return true;
                default:
                    Console.WriteLine("Sure that might sound fun, but my absolute favorites are fighting and RPG games.");
                    return false;
            }
        }

        static string MyBackground(int answer)
        {
            return "something";
        }

        static int Tally(int score)
        {
            score++;
            return score;
        }
    }
}
