using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ChatbotPart1
{
    internal class Program
    {
        
         

class CybersecurityChatBot
    {
        static void Main()
        {
            // Play voice greeting when the application starts
            PlayVoiceGreeting();

            // Display ASCII Art logo
            DisplayAsciiArtLogo();

            // Ask for user's name
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            if (string.IsNullOrEmpty(userName))
            {
                userName = "User";
            }

            // Personalized greeting
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\nHello, {userName}! Welcome to the Cybersecurity Awareness Bot.");
            Console.ResetColor();

            // Start the interactive chat loop
            ChatLoop();
        }

        // Method to play voice greeting
        static void PlayVoiceGreeting()
        {
            try
            {
                SoundPlayer player = new SoundPlayer("welcome.wav"); // Make sure greeting.wav is in the correct location
                player.PlaySync(); // Play the greeting sound
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error playing greeting audio: {ex.Message}");
                Console.ResetColor();
            }
        }

        // Method to display the ASCII Art logo
        static void DisplayAsciiArtLogo()
        {
            string logo = @"
  : ""
.---------------------------------------------------------------------------.
|            _                     _                             _          |
|  ___ _   _| |__   ___ _ __    __| |_   _ _ __   __ _ _ __ ___ (_) ___ ___ |
| / __| | | | '_ \ / _ | '__|  / _` | | | | '_ \ / _` | '_ ` _ \| |/ __/ __||
|| (__| |_| | |_) |  __| |    | (_| | |_| | | | | (_| | | | | | | | (__\__ \|
| \___|\__, |_.__/ \___|_|     \__,_|\__, |_| |_|\__,_|_| |_| |_|_|\___|___/|
|      |___/                         |___/                                  |
'---------------------------------------------------------------------------'
""
        ";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(logo);
            Console.ResetColor();
        }

        // Method for handling the chat loop
        static void ChatLoop()
        {
            while (true)
            {
                // Ask the user for input
                Console.Write("\nHow can I help you today? ");
                string userInput = Console.ReadLine()?.ToLower();

                if (string.IsNullOrEmpty(userInput))
                {
                    Console.WriteLine("I didn't quite understand that. Could you rephrase?");
                    continue;
                }

                // Handle basic queries
                if (userInput.Contains("how are you"))
                {
                    Console.WriteLine("I'm doing great, thank you for asking! How can I assist you with cybersecurity today?");
                }
                else if (userInput.Contains("what's your purpose"))
                {
                    Console.WriteLine("I am here to help you stay safe online and provide cybersecurity awareness.");
                }
                else if (userInput.Contains("what can i ask you about"))
                {
                    Console.WriteLine("You can ask me about topics like password safety, phishing, and safe browsing.");
                }
                else if (userInput.Contains("password safety"))
                {
                    Console.WriteLine("To keep your password safe, ensure it's unique, long, and uses a mix of letters, numbers, and symbols.");
                }
                else if (userInput.Contains("phishing"))
                {
                    Console.WriteLine("Phishing attacks trick you into providing sensitive information. Always be cautious of unsolicited emails.");
                }
                else if (userInput.Contains("safe browsing"))
                {
                    Console.WriteLine("Always use secure websites (look for HTTPS in the URL) and avoid clicking on unknown links.");
                }
                else
                {
                    // Default response for unrecognized inputs
                    Console.WriteLine("Sorry, I didn't quite understand that. Could you please ask something else?");
                }

                // Give the option to exit the chat
                Console.Write("\nDo you want to continue chatting? (yes/no): ");
                string continueChat = Console.ReadLine()?.ToLower();
                if (continueChat != "yes")
                {
                    Console.WriteLine("Thank you for using the Cybersecurity Awareness Bot! Stay safe online.");
                    break;
                }
            }
        }
    }
        
        }
    }

