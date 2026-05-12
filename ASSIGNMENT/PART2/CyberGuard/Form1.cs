using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace CyberGuard
{
    public partial class Form1 : Form
    {
        //the below declarations are for memory and recall
        private string username = string.Empty;
        private string lastTopic = string.Empty;
        private string favouriteTopic = string.Empty;

        //tracks topics the user has visited
        private List<string> topicsViewed = new List<string>();

        //tracks the number of times a user has visited a topic
        private Dictionary<string, int> topicVisitCount = new Dictionary<string, int>();

        private Random random = new Random();

        //the below is for keyword recognition and response
        private Dictionary<string, string> keywordResponses = new Dictionary<string, string>
        {
            //pasword safety keywords
            {"password", "Password safety refers to the practices and technologies used to protect passwords from being stolen, guessed, or compromised."},
            {"2fa", "Two-factor authentication (2FA) adds an extra layer of security by requiring not only a password but also a second factor, such as a text message code."},
            {"backup", "Backing up your data is crucial for preventing data loss. Regularly save copies of your important files to an external drive or cloud storage."},
            //phishing, spam and scam keywords
            {"phishing", "Phishing is a method of trying to gather personal information using deceptive emails and websites."},
            {"spam", "Spam refers to unsolicited and often irrelevant messages sent over the internet, typically to a large number of users."},
            {"scam", "A scam is a fraudulent scheme designed to con people out of their money or personal information."},
            //safety and security keywords  
            {"https", "HTTPS (Hypertext Transfer Protocol Secure) is an extension of HTTP that uses encryption to secure data transmitted over the internet."},
            {"malware", "Malware is software specifically designed to disrupt, damage, or gain unauthorized access to computer systems."},
            {"ransomware", "Ransomware is a type of malicious software that blocks access to a system or personal files and demands ransom payment."}
         };

        //Phishing tips for random selection
        private List<string> phishingTips = new List<string>()
        {
            "Be cautious of emails from unknown senders, especially those that ask for personal information or contain urgent requests.",
            "Hover over links in emails to see the actual URL before clicking. Avoid clicking on suspicious links.",
            "Check for spelling and grammar mistakes in emails, as these can be signs of phishing attempts.",
            "Verify the sender's email address to ensure it matches the official domain of the organization.",
            "Use two-factor authentication (2FA) to add an extra layer of security to your accounts."
        };

        //safe browsing tips for random selection
        private List<string> safeBrowsingTips = new List<string>()
        {
            "Use strong, unique passwords for each of your accounts.",
            "Keep your software and operating system up to date with the latest security patches.",
            "Be cautious when using public Wi-Fi networks, and avoid accessing sensitive information on them.",
            "Install and maintain reputable antivirus software to protect against malware.",
            "Regularly review your privacy settings on social media and other online accounts."
        };

        // password safety tips for random selection
        private List<string> passwordSafetyTips = new List<string>()
        {
            "Use a combination of uppercase and lowercase letters, numbers, and special characters in your passwords.",
            "Avoid using easily guessable information such as birthdays or common words in your passwords.",
            "Consider using a passphrase, which is a sequence of words that is easy for you to remember but difficult for others to guess.",
            "Use a reputable password manager to generate and store complex passwords securely.",
            "Change your passwords regularly and avoid reusing the same password across multiple accounts."
        };

        //rotate confused responses for random selection
        private List<string> confusedResponses = new List<string>()
        {
            "I'm not sure I understand. Could you please clarify?",
            "Sorry, I didn't catch that. Can you rephrase it?",
            "Hmm, that doesn't seem to match any of my topics. Can you try again?",
            "I'm a bit confused. Could you provide more details or ask about a specific topic?",
            "I don't have information on that topic. Can you ask about something else?"
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string userInput = txtUserInput.Text.ToLower().Trim();


        }

        private string Sentiment(string input)
        {
            if (input.Contains("worried") || input.Contains("scared") ||
                input.Contains("anxious") || input.Contains("afraid") ||
                input.Contains("nervous") || input.Contains("unsafe"))
                return "worried";

            if (input.Contains("confused") || input.Contains("lost") ||
                input.Contains("unsure") || input.Contains("help me") ||
                input.Contains("don't understand"))
                return "confused";

            if (input.Contains("frustated") || input.Contains("annoyed") ||
                input.Contains("angry") || input.Contains("sick of"))
                return "frustated";

            if (input.Contains("curious") || input.Contains("interested") ||
                input.Contains("want to know") || input.Contains("explain") ||
                input.Contains("tell me"))
                return "curious";

            return "neutral";
        }

        private string SentimentResponse(string sentiment)
        {
            switch (sentiment)
            {
                case "worried":
                    return "I understand that you might be feeling worried. Remember, I'm here to help you with any questions or concerns you have about online safety.";
                case "confused":
                    return confusedResponses[random.Next(confusedResponses.Count)];
                case "frustated":
                    return "I can see that you're feeling frustrated. Let's work together to find the information you need and make things easier for you.";
                case "curious":
                    return "It's great to see your curiosity! Feel free to ask me anything about online safety, and I'll do my best to provide you with helpful information.";
                default:
                    return "Here's what I found for you:";
            }
        }
    }
}
