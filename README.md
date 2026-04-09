# PROG6221
The assigment is about creating a cybersecurity awareness bot.
The bot will provide a user information about password safety, phishing and safe browsing

The project consists of three classes: Program.cs, CyberSpace.cs and CyberDesign.cs.

Program.cs consists of calling the methods in the other classes as it is the main class making use of OOP

CyberDesign.cs is the general look of the project and consists of three methods: VoiceGreeting(), Animation(), LogoDesign(), and Box()
1.VoiceGreeting will play a voice greeting when the application runs. However in order for this to work, you must first add the NUGet package System.Windows.Media. If not insalled the sound will not play.
2.Animation is for the text delay animation.
3.LogoDisplay will display the logo CYBERGUARD immediately after the voice greeting finishes.
4.Box will wrap the welcome text in a border.

CyberSpace.cs implements the cyberDesign, and it consists of these methods:UserInteraction(), and ResponseSystem().
1.UserInteraction will ask a user for their name until they give a valid input.
2.ResponseSystem will be where the user will get to know about the three topics Phishing, Password Safety and Safe Browsing.
2.1 Phishing will give the user information abouth its definition, the common types of phishing attacks,the risks of it, and how to recognize and avoid them.
2.2 Password Safety will provide its definition, tips on creating strong passwords common risks and dangers, best practices and how hackers crack passwords.
2.3 Safe Browsing will return its definition,the common risks, educate the user on how to navigate the internet safely, tools that help, and good habits for safe browsing.