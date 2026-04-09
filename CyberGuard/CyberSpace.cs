using System;
using System.Runtime.CompilerServices;

public class CyberSpace : CyberDesign
{
    
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
            //this will ask the user what they would like to know and also validate the user input for the questions
            Animation("\nYou can ask me the following: \n1.How are you? \n2.What is your purpose? \n3.What can I ask you about?");
            Animation("\nWhat would you like to now?: ");
            string question = Console.ReadLine().ToLower().Trim();

            //this will return how the chatbot is doing and also validate the user input for the how are you question
            if (question.Contains("how are you") || question == "1" || question == "one")
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Animation("\nI am doing okay I guess. Thanks for asking");
                continue;

            }
            //this will return the purpose of the chatbot and also validate the user input for the purpose question
            else if (question.Contains("purpose") || question == "2" || question == "two")
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Animation("\nMy purpose is to educate individuals and organizations to reognize, prevent, and respond to cyber threats, thereby reducing the risk of security breaches and protecting sensitive data.");
                continue;
            }
            //This will return what the user can ask about and will also validate the user input for the topics
            else if (question.Contains("about") || question == "3" || question == "three")
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Animation("\nYou can ask me about the following topics:");
                Animation("\n1.Password safety. \n2.Phishing. \n3.Safe browsing.");
                Animation("\nWhich topic would you like to know about?: ");
                string topic = Console.ReadLine().ToLower().Trim();
                //this will return information about password safety
                if (topic.Contains("password") || topic == "1" || topic == "one")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Animation("\nYou have chosen password safety.");
                    Animation("\nWhat would you like to know about it.");
                    while (true)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Animation("\n1.Definition. \n2.Common risks. \n3.What makes a strong password. \n4.Best practices. \n5.How hackers crack password. \n6.Go back. \n");
                        string option = Console.ReadLine().ToLower().Trim();
                        //this will return the definition of password safety
                        if (option.Contains("definition") || option.Contains("what is") || option == "1")
                        {
                            Console.WriteLine("Password safety refers to the practices and technologies used to protect passwords from being stolen, guessed, or compromised.");
                            continue;
                        }
                        //these are the common risks or dangers
                        else if (option.Contains("common risks") || option.Contains("dangers") || option == "2")
                        {
                            Console.WriteLine("1.Brute Force Attacks: Hackers try every possible combination until they succeed.");
                            Console.WriteLine("2.Credential Stuffing: Using leaked passwords from one site to access others.");
                            Console.WriteLine("3.Keyloggers: Malware that records everything you type");
                            Console.WriteLine("4.Shoulder Surfing: Someone physically watching you type your password.");
                            Console.WriteLine("5.Data Breaches: Your password being exposed when a company is hacked.");
                            continue;
                        }
                        //this is how to make a strong password
                        else if (option.Contains("strong") && option.Contains("password") || option == "3")
                        {
                            Console.WriteLine("1.At least 12 characters long");
                            Console.WriteLine("2.Mix of uppercase, lowercase, numbers and symbols.");
                            Console.WriteLine("3.No personal info like your name, birthday or pet's name.");
                            Console.WriteLine("4.Not a common word or sequence");
                            continue;
                        }
                        //these are the best practices of password safety
                        else if (option.Contains("best") || option.Contains("practices") || option == "4")
                        {
                            Console.WriteLine("1.Use a unique password for every account.");
                            Console.WriteLine("2.Enable Multi-Factor Authentication wherever possible.");
                            Console.WriteLine("3.Use a password manager to store them securely.");
                            Console.WriteLine("4.Change passwords immediately if you suspect a breach.");
                            Console.WriteLine("5.Never share your password with anyone, even IT support.");
                        }
                        //these is how hackers crack passwords
                        else if (option.Contains("hackers") || option.Contains("crack") || option == "5")
                        {
                            Console.WriteLine("1.Dictionary attacks using common words and phrases.");
                            Console.WriteLine("2.Buying leaked credentials from the dark web.");
                            Console.WriteLine("3.Social engineering - tricking you into revealing it yourself.");
                            continue;
                        }
                        //this will go back to the main menu
                        else if (option.Contains("go back") || option == "6")
                        {
                            Animation("\nReturning to the topic menu...");
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Animation("\nI didn't catch the topic you asked. Choose from 1 to 6");
                            continue;
                        }
                    }
                }
                //this will return information about phishing
                else if (topic.Contains("phishing") || topic == "2" || topic == "two")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Animation("\nYou have chosen phishing.");
                    Animation("\nWhat would you like to know about it.");
                    while (true)
                    {
                        Animation("\n1.Definition. \n2.Common types. \n3.Risk. \n4.How to spot it. \n5.How to stay safe. \n6.Go back. \n");
                        string option = Console.ReadLine().ToLower().Trim();

                        //this is the definition of phishing
                        if (option.Contains("definition") || option.Contains("what is") || option == "1")
                        {
                            Console.WriteLine("Phishing is a type of cyberattack where attackers impersonate trusted sources to trick people into revealing sensitive information or installing malware.");
                            continue;
                        }
                        //these are the common types of phishing
                        else if (option.Contains("common types") || option.Contains("types") || option == "2")
                        {
                            Console.WriteLine("1.Email Phishing: Fraudulent emails that appear to be from reputable sources.");
                            Console.WriteLine("2.Spear Phishing: Targeted attacks aimed at specific individuals or organizations.");
                            Console.WriteLine("3.Smishing: Phishing attempts via SMS text messages.");
                            Console.WriteLine("4.Vishing: Voice phishing over phone calls.");
                            Console.WriteLine("5.Clone Phishing: Creating a nearly identical copy of a legitimate email with malicious links.");
                            continue;
                        }
                        //these are the risks of phishing
                        else if (option.Contains("risk") || option.Contains("dangers") || option == "3")
                        {
                            Console.WriteLine("1.Identity Theft: Stealing personal information to commit fraud.");
                            Console.WriteLine("2.Financial Loss: Gaining access to bank accounts or credit cards.");
                            Console.WriteLine("3.Data Breaches: Compromising sensitive company data.");
                            Console.WriteLine("4.Malware Infection: Installing harmful software on your device.");
                            continue;
                        }
                        //this is how to spot phishing attacks
                        else if (option.Contains("spot") || option == "4")
                        {
                            Console.WriteLine("1.Check the sender's email address for legitimacy.");
                            Console.WriteLine("2. Look for spelling and grammar mistakes in the message.");
                            Console.WriteLine("3.Hover over links to see the actual URL before clicking.");
                            Console.WriteLine("4.Be cautious of urgent or threatening language.");
                            continue;
                        }
                        //this is how to stay safe from phishing attacks
                        else if (option.Contains("stay safe") || option == "5")
                        {
                            Console.WriteLine("1.Never click on links or download attachments from unknown senders.");
                            Console.WriteLine("2.Use anti-phishing software and keep it updated.");
                            Console.WriteLine("3.Verify requests for sensitive information through a separate channel.");
                            Console.WriteLine("4.Educate yourself and others about common phishing tactics.");
                            continue;
                        }
                        //this will go back to main menu
                        else if (option.Contains("go back") || option.Contains("back")|| option == "6")
                        {
                            Animation("\nReturning to the topic menu...");
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Animation("\nI didn't catch the topic you asked. Choose from 1 to 6");
                            continue;
                        }
                    }
                }
                else if (topic.Contains("safe browsing") || topic == "3" || topic == "three")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Animation("\nYou have chosen safe browsing.");
                    Animation("\nWhat would you like to know about it.");
                    while (true)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Animation("\n1.Definition. \n2.Common risks online. \n3.How to browse safely. \n4.Tools that help. \n5.Good habits \n6.Go back. \n");
                        string option = Console.ReadLine().ToLower().Trim();
                        //this will return the definition of safe browsing
                        if (option.Contains("definition") || option == "1")
                        {
                            Animation("\n• Safe browsing is the practice of navigating the internet securely to protect your devices, personal information, and identity from cyber threats.");
                            continue;
                        }
                        //this will return the common risks of browsing online
                        else if (option.Contains("common risks") || option == "2")
                        {
                            Console.WriteLine("1.Malicious websits that download malware automatically.");
                            Console.WriteLine("2.Fake shopping sites designed to steal payment details.");
                            Console.WriteLine("3.Unsecured public Wi-Fi allowing hackers to intercept your your data.");
                            Console.WriteLine("4.Browser extensions that spy on your activity.");
                            Console.WriteLine("5.Pop-up scams pretending to be virus warnings.");
                            continue;

                        }
                        //this will return how to browse safely online
                        else if (option.Contains("how to") && option.Contains("safely") || option == "3")
                        {
                            Console.WriteLine("1.Always check for HTTPS and a padlock icon in the address bar.");
                            Console.WriteLine("2.Avoid clicking pop-up ads or suspicious links.");
                            Console.WriteLine("3.Use a reputable browser like Chrome, Firefox, or Edge.");
                            Console.WriteLine("4.Keep your browser and plugins updated.");
                            Console.WriteLine("5.Use a VPN on public Wi-Fi networks.");
                            continue;
                        }
                        //this will return tools that can help with safe browsing
                        else if (option.Contains("tools") || option.Contains("help") || option == "4")
                        {
                            Console.WriteLine("1.VPN (virtual private network): Encrypts your internet connection.");
                            Console.WriteLine("2.Pasword Manager: Autofills only on legitimate sites.");
                            Console.WriteLine("3.Antivirus software: Blocks known malicious sites.");
                            Console.WriteLine("4.Browser safe browsing mode: Warns yu before visiting dangerous sites.");
                            continue;
                        }
                        //this will return good habits for safe browsing
                        else if (option.Contains("good") && option.Contains("habits") || option == "5")
                        {
                            Console.WriteLine("1.Log out of accounts when done, especially on shared devices.");
                            Console.WriteLine("2.Clear cookies and cache regularly.");
                            Console.WriteLine("3.Never save passwords in your browser on a shared computer");
                            continue;
                        }
                        else if (option.Contains("go back") || option == "6")
                        {
                            Animation("\nReturning to the topic menu...");
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Animation("\nI didn't catch the topic you asked. Choose from 1 to 6");
                            continue;
                        }
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
}