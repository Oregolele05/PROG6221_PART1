using System;
using System.Media;

class CyberGuard
{
    public static void Main(string[] args)
    {
        //This code is for the style of the text
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        VoiceGreeting();
        LogoDisplay();
        UserInteraction();
        ResponseSystem();

    }
    public static void VoiceGreeting()
    {
       
    }
    //this will display the bot logo when application runs
    public static void LogoDisplay()
    {
        Console.WriteLine("  ██████╗██╗   ██╗██████╗ ███████╗██████╗  ██████╗ ██╗   ██╗ █████╗ ██████╗ ██████╗ \r\n ██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗██╔════╝ ██║   ██║██╔══██╗██╔══██╗██╔══██╗\r\n ██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝██║  ███╗██║   ██║███████║██████╔╝██║  ██║\r\n ██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗██║   ██║██║   ██║██╔══██║██╔══██╗██║  ██║\r\n ╚██████╗   ██║   ██████╔╝███████╗██║  ██║╚██████╔╝╚██████╔╝██║  ██║██║  ██║██████╔╝\r\n  ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝ ╚═════╝  ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚═════╝ ");
    }
    public static void UserInteraction()
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
    public static void ResponseSystem()
    {
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Type (1) to continue. Type(2) to exit.");
            string options = Console.ReadLine().Trim();
            switch (options)
            {
                case "1":
                    Console.WriteLine("Great! Let's continue");
                    break;

                case "2":
                    Console.WriteLine("Goodbye! Stay safe online.");
                    return;

                default:
                    Console.WriteLine("I couldn't quite catch that. Please try again.");
                    continue;
            }

            Console.WriteLine("You can ask me the following: \n1.How are you? \n2.What is your purpose? \n3.What can I ask you about?");
            Console.Write("What would you like to now?: ");
            string question = Console.ReadLine().ToLower().Trim();

            if (question.Contains("how are you") || question == "1")
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("I am doing okay I guess. Thanks for asking\n");
                continue;

            }
            else if (question.Contains("purpose") || question == "2")
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("My purpose is to educate individuals and organizations to reognize, prevent, and respond to cyber threats, thereby reducing the risk of security breaches and protecting sensitive data.\n");
                continue;
            }
            else if (question.Contains("what can I ask you about") || question == "3")
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("You can ask me about the following topics: \n1.Phishing. \n2.Safe browsing. \n3.Password safety.");
                continue;
            }
            if (question.Contains("password"))
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Password safety refers to the practices and technologies used to protect passwords from being stolen, guessed, or compromised.");
                continue;
            }
            else if (question.Contains("phishing"))
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Phishing is a type of cyberattack where attackers impersonate trusted sourcs to trick people into revealing sensitive information or installing malware.");
                continue;
            }
            else if (question.Contains("safe browsing"))
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Safe browsing is the practice of navigating the internet securely to protect your devices, personal information, and identity from cyber threats.");
                continue;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("I didn't quite understand that. Could you rephrase?");
                continue;
            }
        }

    }
}