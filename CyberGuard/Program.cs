using System;
using System.Media;

class CyberGuard
{
    public static void Main(string[] args)
    {

    }
    public void VoiceGreeting()
    {
       
    }
    //this will display the bot logo when application runs
    public void LogoDisplay()
    {
        Console.WriteLine("  ██████╗██╗   ██╗██████╗ ███████╗██████╗  ██████╗ ██╗   ██╗ █████╗ ██████╗ ██████╗ \r\n ██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗██╔════╝ ██║   ██║██╔══██╗██╔══██╗██╔══██╗\r\n ██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝██║  ███╗██║   ██║███████║██████╔╝██║  ██║\r\n ██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗██║   ██║██║   ██║██╔══██║██╔══██╗██║  ██║\r\n ╚██████╗   ██║   ██████╔╝███████╗██║  ██║╚██████╔╝╚██████╔╝██║  ██║██║  ██║██████╔╝\r\n  ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝ ╚═════╝  ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚═════╝ ");
    }
    public void UserInteraction()
    {
        while (true)
        {
            //this is for the text colour
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            //ask user for their name
            Console.Write("What is your name: ");
            string name = Console.ReadLine().Trim();

            //this code will validate the user input for name
            if (name.IsWhiteSpace())
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Please enter a valid name.");
                continue;
            }
            else if (name.Any(char.IsDigit))
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("A name cannot contain numeric values.");
                continue;
            }
            Console.WriteLine("welcome " + name + " nice to meet you!!\n");
            break;
        }

    }
    public void ResponseSystem()
    {

    }
}