using System;
using System.Media;


class CyberGuard
{
    public static void Main(string[] args)
    {
        //This code is for the style of the text
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        //This is to call methods from the other classes
        CyberDesign.VoiceGreeting();
        CyberDesign.LogoDisplay();
        CyberSpace.UserInteraction();
        CyberSpace.ResponseSystem();
    }
}