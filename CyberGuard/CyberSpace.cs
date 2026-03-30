using System;

public class CyberSpace : CyberDesign
{
    public static void Box(string text)
    {
        int width = text.Length + 2;

        Console.WriteLine("╔" + new string('═', width) + "╗");
        Console.Write("║ ");
        Console.WriteLine(text);
        Console.WriteLine(" ║");
        Console.WriteLine("╚" + new string('═', width) + "╝");


    }
    public static void UserInteraction()
        {
            while (true)
            {
                //this is for the text colour
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                //ask user for their name
                Animation("What is your name: ");
                string name = Console.ReadLine().Trim();

                //this code will validate the user input for name
                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Animation("Please enter a valid name.");
                    continue;
                }
                else if (name.Any(char.IsDigit))
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Animation("A name cannot contain numeric values.");
                    continue;
                }
                Box("welcome " + name + " nice to meet you!!");
                break;
            }

        }
        public static void ResponseSystem()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Animation("Type (1) to continue. Type(2) to exit.");
                string options = Console.ReadLine().Trim();
                switch (options)
                {
                    case "1":
                        Animation("Great! Let's continue");
                        break;

                    case "2":
                        Animation("Goodbye! Stay safe online.");
                        return;

                    default:
                        Animation("I couldn't quite catch that. Please try again.");
                        continue;
                }

                Animation("You can ask me the following: \n1.How are you? \n2.What is your purpose? \n3.What can I ask you about?");
                Animation("What would you like to now?: ");
                string question = Console.ReadLine().ToLower().Trim();

                if (question.Contains("how are you") || question == "1")
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Animation("I am doing okay I guess. Thanks for asking\n");
                    continue;

                }
                else if (question.Contains("purpose") || question == "2")
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Animation("My purpose is to educate individuals and organizations to reognize, prevent, and respond to cyber threats, thereby reducing the risk of security breaches and protecting sensitive data.\n");
                    continue;
                }
                else if (question.Contains("what can I ask you about") || question == "3")
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Animation("You can ask me about the following topics: \n1.Phishing. \n2.Safe browsing. \n3.Password safety.");
                    continue;
                }
                if (question.Contains("password"))
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Animation("Password safety refers to the practices and technologies used to protect passwords from being stolen, guessed, or compromised.");
                    continue;
                }
                else if (question.Contains("phishing"))
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Animation("Phishing is a type of cyberattack where attackers impersonate trusted sourcs to trick people into revealing sensitive information or installing malware.");
                    continue;
                }
                else if (question.Contains("safe browsing"))
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Animation("Safe browsing is the practice of navigating the internet securely to protect your devices, personal information, and identity from cyber threats.");
                    continue;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Animation("I didn't quite understand that. Could you rephrase?");
                    continue;
                }
            }
        }
    }

