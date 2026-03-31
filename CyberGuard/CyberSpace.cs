using System;

public class CyberSpace : CyberDesign
{
    public static void Box(string text)
    {
        int width = text.Length + 2;
        //this will wrap the users welcome message in a box
        Console.WriteLine("╔" + new string('═', width) + "╗");
        Console.WriteLine("║ " + text + " ║");
        Console.WriteLine("╚" + new string('═', width) + "╝");
    }
    public static void UserInteraction()
        {
            while (true)
            {
                //this is for the text colour
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                //ask user for their name
                Animation("\nWhat is your name: ");
                string name = Console.ReadLine().Trim();

                //this code will validate the user input for name
                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Animation("\nPlease enter a valid name.");
                    continue;
                }
                else if (name.Any(char.IsDigit))
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Animation("\nA name cannot contain numeric values.");
                    continue;
                }
                Box("Welcome " + name + " nice to meet you!!");
                break;
            }

        }
        public static void ResponseSystem()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Animation("\nType (1) to continue. Type(2) to exit.");
                string options = Console.ReadLine().Trim();
                switch (options)
                {
                    case "1":
                        Animation("\nGreat! Let's continue");
                        break;

                    case "2":
                        Animation("\nGoodbye! Stay safe online.");
                        return;

                    default:
                        Animation("\nI couldn't quite catch that. Please try again.");
                        continue;
                }

                Animation("\nYou can ask me the following: \n1.How are you? \n2.What is your purpose? \n3.What can I ask you about?");
                Animation("\nWhat would you like to now?: ");
                string question = Console.ReadLine().ToLower().Trim();

                if (question.Contains("how are you") || question == "1")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Animation("\nI am doing okay I guess. Thanks for asking");
                    continue;

                }
                else if (question.Contains("purpose") || question == "2")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Animation("\nMy purpose is to educate individuals and organizations to reognize, prevent, and respond to cyber threats, thereby reducing the risk of security breaches and protecting sensitive data.");
                    continue;
                }
                else if (question.Contains("what can I ask you about") || question == "3")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Animation("\nYou can ask me about the following topics:");
                    Animation("\n1.Password safety. \n2. Phishing. \n3.Safe browsing.");
                    Animation("\nWhich topic would you like to know about?: ");
                    string topic = Console.ReadLine().ToLower().Trim();

                    if (topic.Contains("password") || topic == "1" || topic == "one")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Animation("Password safety refers to the practices and technologies used to protect passwords from being stolen, guessed, or compromised.");
                        continue;
                    }
                    else if (topic.Contains("phishing") || topic == "2" || topic == "two")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Animation("Phishing is a type of cyberattack where attackers impersonate trusted sourcs to trick people into revealing sensitive information or installing malware.");
                        continue;
                    }
                    else if (topic.Contains("safe browsing") || topic == "3" || topic == "three")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Animation("Safe browsing is the practice of navigating the internet securely to protect your devices, personal information, and identity from cyber threats.");
                        continue;
                    }
                    else 
                    {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Animation("\nI didn't catch the topic you asked.");
                    return;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Animation("\nI didn't quite understand that. Could you rephrase?");
                    continue;
                }
            }
        }
    }

