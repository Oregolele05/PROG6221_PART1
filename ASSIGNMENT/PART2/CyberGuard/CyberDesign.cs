using System;
using System.Media;
using System.Windows.Forms;
using System.Drawing;

public class CyberDesign
{
    protected RichTextBox ChatDisplay {  get; set; }
    //this is for the voice greeting
    public void VoiceGreeting()
    {
        try
        {
            SoundPlayer player = new SoundPlayer(@"C:\\Users\\gmkin\\Documents\\second year\\PROG6221\\ASSIGNMENT\\PART1\\CyberGuard\\greet.wav");
            player.PlaySync();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error playing sound: " + ex.Message);
        }
    }
    // Bot response — cyan
    public void BotSay(string message)
        => DisplayMessage("🤖  " + message, Color.Cyan);

    // Warning or error — red
    public void BotWarn(string message)
        => DisplayMessage("⚠   " + message, Color.Tomato);

    // Section header — gold
    public void BotHeader(string message)
        => DisplayMessage("\n══════ " + message + " ══════", Color.Gold);

    // Info bullet point — light cyan
    public void BotInfo(string message)
        => DisplayMessage("     " + message, Color.LightCyan);

    // User's own message — green
    public void UserSay(string message)
        => DisplayMessage("👤  " + message, Color.LightGreen);

    // Separator line — dim gray
    public void BotLine()
        => DisplayMessage("─────────────────────────────────────────", Color.DimGray);


    //this is for the logo design
    public void LogoDisplay()
    {
        Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════╗\r\n║  ██████╗██╗   ██╗██████╗ ███████╗██████╗  ██████╗ ██╗   ██╗ █████╗ ██████╗ ██████╗ ║\r\n║ ██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗██╔════╝ ██║   ██║██╔══██╗██╔══██╗██╔══██╗║\r\n║ ██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝██║  ███╗██║   ██║███████║██████╔╝██║  ██║║\r\n║ ██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗██║   ██║██║   ██║██╔══██║██╔══██╗██║  ██║║\r\n║ ╚██████╗   ██║   ██████╔╝███████╗██║  ██║╚██████╔╝╚██████╔╝██║  ██║██║  ██║██████╔╝║\r\n║  ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝ ╚═════╝  ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚═════╝ ║\r\n╚════════════════════════════════════════════════════════════════════════════════════╝");
    }
    public void Box(string text)
    {
        int width = text.Length + 2;
        //this will wrap the users welcome message in a box
        Console.WriteLine("╔" + new string('═', width) + "╗");
        Console.WriteLine("║ " + text + " ║");
        Console.WriteLine("╚" + new string('═', width) + "╝");
    }
    public void DisplayMessage(string message, Color colour)
    {
        if(ChatDisplay == null)
        {
            return;
        }
        ChatDisplay.SelectionColor = colour;
        ChatDisplay.AppendText(message + "\n");
        ChatDisplay.ScrollToCaret();
    }
}
