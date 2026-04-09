using System;
using System.Media;

public class CyberDesign
{
    //this is for the voice greeting
    public static void VoiceGreeting()
    {
        try
        {
            SoundPlayer player = new SoundPlayer(@"C:\\Users\\gmkin\\Documents\\second year\\PROG6221\\CyberGuard\\greet.wav");
            player.PlaySync();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error playing sound: " + ex.Message);
        }
    }
    //this is for the text animation effect
    public static void Animation(string text, int delay = 50)
    {
        foreach(char c in text)
        {
            Console.Write(c);
            Thread.Sleep(delay);
        }
    }
    //this is for the logo design
    public static void LogoDisplay()
    {
        Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════╗\r\n║  ██████╗██╗   ██╗██████╗ ███████╗██████╗  ██████╗ ██╗   ██╗ █████╗ ██████╗ ██████╗ ║\r\n║ ██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗██╔════╝ ██║   ██║██╔══██╗██╔══██╗██╔══██╗║\r\n║ ██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝██║  ███╗██║   ██║███████║██████╔╝██║  ██║║\r\n║ ██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗██║   ██║██║   ██║██╔══██║██╔══██╗██║  ██║║\r\n║ ╚██████╗   ██║   ██████╔╝███████╗██║  ██║╚██████╔╝╚██████╔╝██║  ██║██║  ██║██████╔╝║\r\n║  ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝ ╚═════╝  ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚═════╝ ║\r\n╚════════════════════════════════════════════════════════════════════════════════════╝");
    }
    public static void Box(string text)
    {
        int width = text.Length + 2;
        //this will wrap the users welcome message in a box
        Console.WriteLine("╔" + new string('═', width) + "╗");
        Console.WriteLine("║ " + text + " ║");
        Console.WriteLine("╚" + new string('═', width) + "╝");
    }
}
