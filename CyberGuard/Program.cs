using System;
using System.Media;
using System.Threading; 


class CyberGuard
{
    public static void Main(string[] args)
    {
        CyberSpace space = new CyberSpace();
        CyberDesign design = new CyberDesign();
        //This code is for the style of the text
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        //This is to call methods from the other classes
        design.VoiceGreeting();
        design.LogoDisplay();
        space.UserInteraction();
        space.ResponseSystem();
    }
}