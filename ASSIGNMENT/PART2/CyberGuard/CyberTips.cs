using System;
using System.Collections.Generic;


	public class CyberTips
	{
        // Generic List — every topic the user has visited this session
        private List<string> topicsViewed = new List<string>();

        private Dictionary<string, string> keywordResponses = new Dictionary<string, string>()
        {
            // Password Safety keywords
            { "password",  "Make sure to use strong, unique passwords for each account. Avoid using personal details in your passwords." },
            { "2fa",       "Two-Factor Authentication adds a second layer of security. Enable it on all your important accounts." },
            { "backup",    "Regular backups protect you from data loss. Always store a copy somewhere safe and offline." },

            // Phishing keywords
            { "phishing",  "Phishing emails often create urgency. Always verify the sender before clicking any links." },
            { "scam",      "Scammers often disguise themselves as trusted organisations. Never send money or share personal info with unverified contacts." },
            { "spam",      "Never click links or open attachments in spam emails. Mark them and delete immediately." },

            // Safe Browsing keywords
            { "browser",   "Keep your browser updated and avoid clicking suspicious links or pop-up ads." },
            { "https",     "Always check for HTTPS and a padlock icon in the address bar before entering personal info." },
            { "vpn",       "A VPN encrypts your internet connection and hides your IP address. Use one on public Wi-Fi." },
            { "wifi",      "Avoid using public Wi-Fi for sensitive tasks. Use a VPN to encrypt your connection." },
            { "cookie",    "Clear your cookies and cache regularly to protect your browsing privacy." },
            { "malware",   "Malware can enter your device through downloads and email attachments. Keep your antivirus updated." },
        };

        
        private List<string> phishingTips = new List<string>()
        {
            "Be cautious of emails asking for personal information. Scammers disguise themselves as trusted organisations.",
            "Always hover over links before clicking — the real URL often reveals a fake site.",
            "Legitimate companies will never ask for your password via email.",
            "Check for spelling mistakes in email addresses — 'paypa1.com' is not PayPal.",
            "If an email creates urgency like 'Act now or your account closes', treat it as suspicious."
        };

        private List<string> passwordTips = new List<string>()
        {
            "Use a passphrase like 'Coffee@Sunrise!2024' — it is stronger than random strings.",
            "Never reuse passwords across multiple sites. A breach on one exposes all your accounts.",
            "Enable two-factor authentication wherever possible.",
            "A password manager like Bitwarden generates and stores strong passwords for you.",
            "Change passwords immediately if a service you use gets breached."
        };

        private List<string> safeBrowsingTips = new List<string>()
        {
            "Always check for HTTPS and a padlock icon before entering any personal info.",
            "Avoid clicking pop-up ads — they are a common way to install malware.",
            "Use a reputable browser like Chrome, Firefox, or Edge and keep it updated.",
            "Install an ad blocker to reduce your exposure to malicious advertisements.",
            "Log out of accounts when done, especially on shared or public computers."
        };

        private List<string> confusedResponses = new List<string>()
        {
            "I'm not sure I understand. Can you try rephrasing?",
            "Hmm, I didn't quite catch that. Could you ask differently?",
            "I don't have info on that yet. Try asking about phishing, passwords, or safe browsing.",
            "That's outside what I know right now. Ask me about a cybersecurity topic!"
        };
    }

