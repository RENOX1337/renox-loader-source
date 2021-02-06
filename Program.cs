using RENOX;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace RENOX
{
    class Program
    {

        public static object Unban { get; private set; }

        static void Main(string[] args)
        {
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Class2.Tester();
                Class2.Print(" Loading...", 40);
                Thread.Sleep(500);
                Console.Clear();
                Class2.Print(" © RenoxCheats.Inc");
                Console.WriteLine(" ");
                Class2.Print(" RENOX#1337", 40);
                Console.ForegroundColor = ConsoleColor.Red;
                Class2.Print(" | discord.gg/snEPn6F67Z", 40);
                Thread.Sleep(700);
                Console.Clear();
                Console.Clear();
            }
            //Header
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n");
            Console.WriteLine(@"                    ██████╗ ███████╗███╗   ██╗ ██████╗ ██╗  ██╗    ██╗   ██╗ █████╗ 
                    ██╔══██╗██╔════╝████╗  ██║██╔═══██╗╚██╗██╔╝    ██║   ██║██╔══██╗
                    ██████╔╝█████╗  ██╔██╗ ██║██║   ██║ ╚███╔╝     ██║   ██║╚██████║
                    ██╔══██╗██╔══╝  ██║╚██╗██║██║   ██║ ██╔██╗     ╚██╗ ██╔╝ ╚═══██║
                    ██║  ██║███████╗██║ ╚████║╚██████╔╝██╔╝ ██╗     ╚████╔╝  █████╔╝
                    ╚═╝  ╚═╝╚══════╝╚═╝  ╚═══╝ ╚═════╝ ╚═╝  ╚═╝      ╚═══╝   ╚════╝ 
                                                                ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("               - - - READ BEFORE USING - - - DONT DM SUPPORT BOT BEFORE YOU READ THIS - - -", 23);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n - your Fortnite Window must be on Windowed or Windowed Full (Fullscreen will crash when injecting)");
            Console.WriteLine(" - make sure you are on directx11 in your fn settings (directx12 crash)");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Thread.Sleep(1000);
            Class2.Print("\n Press enter to continue . . .");
            Console.ReadLine();
            Console.Clear();
            Process.Start("https://discord.gg/snEPn6F67Z");
        Home:
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n");
            Console.WriteLine(@" ██████╗ ███████╗███╗   ██╗ ██████╗ ██╗  ██╗    ██╗   ██╗ █████╗ 
 ██╔══██╗██╔════╝████╗  ██║██╔═══██╗╚██╗██╔╝    ██║   ██║██╔══██╗
 ██████╔╝█████╗  ██╔██╗ ██║██║   ██║ ╚███╔╝     ██║   ██║╚██████║
 ██╔══██╗██╔══╝  ██║╚██╗██║██║   ██║ ██╔██╗     ╚██╗ ██╔╝ ╚═══██║
 ██║  ██║███████╗██║ ╚████║╚██████╔╝██╔╝ ██╗     ╚████╔╝  █████╔╝
 ╚═╝  ╚═╝╚══════╝╚═╝  ╚═══╝ ╚═════╝ ╚═╝  ╚═╝      ╚═══╝   ╚════╝ 
                                                                ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" \n [1] Cheats");
            Console.WriteLine();
            Console.WriteLine(" [2] Unban");
            Console.WriteLine(" \n [3] Load Driver for Winver 1803 - 1909");
            Console.WriteLine();
            Console.WriteLine(" [4] Load Driver for Winver 1909 - 20H2");
            Console.WriteLine();
            Console.WriteLine(" [5] Join Discord");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" ");
            string option1 = Console.ReadLine();

            if (option1 == "1")
            {
                Console.Clear();
                goto Menu;
            }
            else if (option1 == "2")
            {
                Console.Clear();
                goto Unban;
            }
            else if (option1 == "3")
            {
                Console.Clear();
                            Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n");
                Console.WriteLine(@" ██████╗ ███████╗███╗   ██╗ ██████╗ ██╗  ██╗    ██╗   ██╗ █████╗ 
 ██╔══██╗██╔════╝████╗  ██║██╔═══██╗╚██╗██╔╝    ██║   ██║██╔══██╗
 ██████╔╝█████╗  ██╔██╗ ██║██║   ██║ ╚███╔╝     ██║   ██║╚██████║
 ██╔══██╗██╔══╝  ██║╚██╗██║██║   ██║ ██╔██╗     ╚██╗ ██╔╝ ╚═══██║
 ██║  ██║███████╗██║ ╚████║╚██████╔╝██╔╝ ██╗     ╚████╔╝  █████╔╝
 ╚═╝  ╚═╝╚══════╝╚═╝  ╚═══╝ ╚═════╝ ╚═╝  ╚═╝      ╚═══╝   ╚════╝ 
                                                                ");
                Class2.Print(" \n [+] Loading Driver for 1803 - 1909...");
                Cheats.Drive();
                Console.Clear();
                goto Home;
            }
            else if (option1 == "4")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n");
                Console.WriteLine(@" ██████╗ ███████╗███╗   ██╗ ██████╗ ██╗  ██╗    ██╗   ██╗ █████╗ 
 ██╔══██╗██╔════╝████╗  ██║██╔═══██╗╚██╗██╔╝    ██║   ██║██╔══██╗
 ██████╔╝█████╗  ██╔██╗ ██║██║   ██║ ╚███╔╝     ██║   ██║╚██████║
 ██╔══██╗██╔══╝  ██║╚██╗██║██║   ██║ ██╔██╗     ╚██╗ ██╔╝ ╚═══██║
 ██║  ██║███████╗██║ ╚████║╚██████╔╝██╔╝ ██╗     ╚████╔╝  █████╔╝
 ╚═╝  ╚═╝╚══════╝╚═╝  ╚═══╝ ╚═════╝ ╚═╝  ╚═╝      ╚═══╝   ╚════╝ 
                                                                ");
                Class2.Print(" \n [+] Loading Driver for 1909 - 20H2...");
                Cheats.prflog();
                Console.Clear();
                goto Home;
            }
            else if (option1 == "5")
            {
                Console.Clear();
                Process.Start("https://discord.gg/snEPn6F67Z");
                Console.Clear();
                goto Home;
            }

            else
            {
                Console.Clear();
                goto Home;
            }

        Menu:
            //Header
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n");
            Console.WriteLine(@" ██████╗ ███████╗███╗   ██╗ ██████╗ ██╗  ██╗    ██╗   ██╗ █████╗ 
 ██╔══██╗██╔════╝████╗  ██║██╔═══██╗╚██╗██╔╝    ██║   ██║██╔══██╗
 ██████╔╝█████╗  ██╔██╗ ██║██║   ██║ ╚███╔╝     ██║   ██║╚██████║
 ██╔══██╗██╔══╝  ██║╚██╗██║██║   ██║ ██╔██╗     ╚██╗ ██╔╝ ╚═══██║
 ██║  ██║███████╗██║ ╚████║╚██████╔╝██╔╝ ██╗     ╚████╔╝  █████╔╝
 ╚═╝  ╚═╝╚══════╝╚═╝  ╚═══╝ ╚═════╝ ╚═╝  ╚═╝      ╚═══╝   ╚════╝ 
                                                                ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" \n [1] Load Peaked for Winver 1909 - 20H2");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" Load First 1909 - 20H2 Driver [Status: Undetected]");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" [2] Load Peaked for Winver 1803 - 1909");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" Load First 1803 - 1909 Driver [Status: Undetected]");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" [3] Load Peaked for Winver 1803 - 1909 (2. Methode) (Use This If First One Dont Work) [Only For Winver 1803 - 1909]");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" Load First 1803 - 1909 Driver [Status: Undetected]");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" [4] go back to Home");
            Console.WriteLine();
            Console.Write(" ");
            string option = Console.ReadLine();

            if (option == "1")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n");
                Console.WriteLine(@" ██████╗ ███████╗███╗   ██╗ ██████╗ ██╗  ██╗    ██╗   ██╗ █████╗ 
 ██╔══██╗██╔════╝████╗  ██║██╔═══██╗╚██╗██╔╝    ██║   ██║██╔══██╗
 ██████╔╝█████╗  ██╔██╗ ██║██║   ██║ ╚███╔╝     ██║   ██║╚██████║
 ██╔══██╗██╔══╝  ██║╚██╗██║██║   ██║ ██╔██╗     ╚██╗ ██╔╝ ╚═══██║
 ██║  ██║███████╗██║ ╚████║╚██████╔╝██╔╝ ██╗     ╚████╔╝  █████╔╝
 ╚═╝  ╚═╝╚══════╝╚═╝  ╚═══╝ ╚═════╝ ╚═╝  ╚═╝      ╚═══╝   ╚════╝ 
                                                                ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Class2.Print("   [+] Loading Peaked for Winver 1909 - 20H2");
                Thread.Sleep(1000);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n");
                Console.WriteLine(@" ██████╗ ███████╗███╗   ██╗ ██████╗ ██╗  ██╗    ██╗   ██╗ █████╗ 
 ██╔══██╗██╔════╝████╗  ██║██╔═══██╗╚██╗██╔╝    ██║   ██║██╔══██╗
 ██████╔╝█████╗  ██╔██╗ ██║██║   ██║ ╚███╔╝     ██║   ██║╚██████║
 ██╔══██╗██╔══╝  ██║╚██╗██║██║   ██║ ██╔██╗     ╚██╗ ██╔╝ ╚═══██║
 ██║  ██║███████╗██║ ╚████║╚██████╔╝██╔╝ ██╗     ╚████╔╝  █████╔╝
 ╚═╝  ╚═╝╚══════╝╚═╝  ╚═══╝ ╚═════╝ ╚═╝  ╚═╝      ╚═══╝   ╚════╝ 
                                                                ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n   initializing", 40);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Thread.Sleep(1000);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n");
                Console.WriteLine(@" ██████╗ ███████╗███╗   ██╗ ██████╗ ██╗  ██╗    ██╗   ██╗ █████╗ 
 ██╔══██╗██╔════╝████╗  ██║██╔═══██╗╚██╗██╔╝    ██║   ██║██╔══██╗
 ██████╔╝█████╗  ██╔██╗ ██║██║   ██║ ╚███╔╝     ██║   ██║╚██████║
 ██╔══██╗██╔══╝  ██║╚██╗██║██║   ██║ ██╔██╗     ╚██╗ ██╔╝ ╚═══██║
 ██║  ██║███████╗██║ ╚████║╚██████╔╝██╔╝ ██╗     ╚████╔╝  █████╔╝
 ╚═╝  ╚═╝╚══════╝╚═╝  ╚═══╝ ╚═════╝ ╚═╝  ╚═╝      ╚═══╝   ╚════╝ 
                                                                ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n   Connecting", 40);
                Cheats.psmap();
                Thread.Sleep(2000);
                Environment.Exit(-1);
            }
            if (option == "2")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n");
                Console.WriteLine(@" ██████╗ ███████╗███╗   ██╗ ██████╗ ██╗  ██╗    ██╗   ██╗ █████╗ 
 ██╔══██╗██╔════╝████╗  ██║██╔═══██╗╚██╗██╔╝    ██║   ██║██╔══██╗
 ██████╔╝█████╗  ██╔██╗ ██║██║   ██║ ╚███╔╝     ██║   ██║╚██████║
 ██╔══██╗██╔══╝  ██║╚██╗██║██║   ██║ ██╔██╗     ╚██╗ ██╔╝ ╚═══██║
 ██║  ██║███████╗██║ ╚████║╚██████╔╝██╔╝ ██╗     ╚████╔╝  █████╔╝
 ╚═╝  ╚═╝╚══════╝╚═╝  ╚═══╝ ╚═════╝ ╚═╝  ╚═╝      ╚═══╝   ╚════╝ 
                                                                ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Class2.Print("   [+] Loading Peaked for Winver 1803 - 1909");
                Thread.Sleep(1000);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n");
                Console.WriteLine(@" ██████╗ ███████╗███╗   ██╗ ██████╗ ██╗  ██╗    ██╗   ██╗ █████╗ 
 ██╔══██╗██╔════╝████╗  ██║██╔═══██╗╚██╗██╔╝    ██║   ██║██╔══██╗
 ██████╔╝█████╗  ██╔██╗ ██║██║   ██║ ╚███╔╝     ██║   ██║╚██████║
 ██╔══██╗██╔══╝  ██║╚██╗██║██║   ██║ ██╔██╗     ╚██╗ ██╔╝ ╚═══██║
 ██║  ██║███████╗██║ ╚████║╚██████╔╝██╔╝ ██╗     ╚████╔╝  █████╔╝
 ╚═╝  ╚═╝╚══════╝╚═╝  ╚═══╝ ╚═════╝ ╚═╝  ╚═╝      ╚═══╝   ╚════╝ 
                                                                ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n   Initializing", 40);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Thread.Sleep(1000);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n");
                Console.WriteLine(@" ██████╗ ███████╗███╗   ██╗ ██████╗ ██╗  ██╗    ██╗   ██╗ █████╗ 
 ██╔══██╗██╔════╝████╗  ██║██╔═══██╗╚██╗██╔╝    ██║   ██║██╔══██╗
 ██████╔╝█████╗  ██╔██╗ ██║██║   ██║ ╚███╔╝     ██║   ██║╚██████║
 ██╔══██╗██╔══╝  ██║╚██╗██║██║   ██║ ██╔██╗     ╚██╗ ██╔╝ ╚═══██║
 ██║  ██║███████╗██║ ╚████║╚██████╔╝██╔╝ ██╗     ╚████╔╝  █████╔╝
 ╚═╝  ╚═╝╚══════╝╚═╝  ╚═══╝ ╚═════╝ ╚═╝  ╚═╝      ╚═══╝   ╚════╝ 
                                                                ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n   Connecting", 40);
                Cheats.pmodmap();
                Thread.Sleep(2000);
                Environment.Exit(-1);
            }
            if (option == "3")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n");
                Console.WriteLine(@" ██████╗ ███████╗███╗   ██╗ ██████╗ ██╗  ██╗    ██╗   ██╗ █████╗ 
 ██╔══██╗██╔════╝████╗  ██║██╔═══██╗╚██╗██╔╝    ██║   ██║██╔══██╗
 ██████╔╝█████╗  ██╔██╗ ██║██║   ██║ ╚███╔╝     ██║   ██║╚██████║
 ██╔══██╗██╔══╝  ██║╚██╗██║██║   ██║ ██╔██╗     ╚██╗ ██╔╝ ╚═══██║
 ██║  ██║███████╗██║ ╚████║╚██████╔╝██╔╝ ██╗     ╚████╔╝  █████╔╝
 ╚═╝  ╚═╝╚══════╝╚═╝  ╚═══╝ ╚═════╝ ╚═╝  ╚═╝      ╚═══╝   ╚════╝ 
                                                                ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Class2.Print("   [+] Loading Peaked for Winver 1803 - 1909 (2. Methode)");
                Thread.Sleep(1000);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n");
                Console.WriteLine(@" ██████╗ ███████╗███╗   ██╗ ██████╗ ██╗  ██╗    ██╗   ██╗ █████╗ 
 ██╔══██╗██╔════╝████╗  ██║██╔═══██╗╚██╗██╔╝    ██║   ██║██╔══██╗
 ██████╔╝█████╗  ██╔██╗ ██║██║   ██║ ╚███╔╝     ██║   ██║╚██████║
 ██╔══██╗██╔══╝  ██║╚██╗██║██║   ██║ ██╔██╗     ╚██╗ ██╔╝ ╚═══██║
 ██║  ██║███████╗██║ ╚████║╚██████╔╝██╔╝ ██╗     ╚████╔╝  █████╔╝
 ╚═╝  ╚═╝╚══════╝╚═╝  ╚═══╝ ╚═════╝ ╚═╝  ╚═╝      ╚═══╝   ╚════╝ 
                                                                ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n   Initializing", 40);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Thread.Sleep(1000);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n");
                Console.WriteLine(@" ██████╗ ███████╗███╗   ██╗ ██████╗ ██╗  ██╗    ██╗   ██╗ █████╗ 
 ██╔══██╗██╔════╝████╗  ██║██╔═══██╗╚██╗██╔╝    ██║   ██║██╔══██╗
 ██████╔╝█████╗  ██╔██╗ ██║██║   ██║ ╚███╔╝     ██║   ██║╚██████║
 ██╔══██╗██╔══╝  ██║╚██╗██║██║   ██║ ██╔██╗     ╚██╗ ██╔╝ ╚═══██║
 ██║  ██║███████╗██║ ╚████║╚██████╔╝██╔╝ ██╗     ╚████╔╝  █████╔╝
 ╚═╝  ╚═╝╚══════╝╚═╝  ╚═══╝ ╚═════╝ ╚═╝  ╚═╝      ╚═══╝   ╚════╝ 
                                                                ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n   Connecting", 40);
                Cheats.pmodmap2();
                Thread.Sleep(2000);
                Environment.Exit(-1);
            }

            if (option == "4")
            {
                Console.Clear();
                goto Home;
            }
            else
            {
                Console.Clear();
                goto Menu;
            }

        Unban:
            //Header
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n");
            Console.WriteLine(@" ██████╗ ███████╗███╗   ██╗ ██████╗ ██╗  ██╗    ██╗   ██╗ █████╗ 
 ██╔══██╗██╔════╝████╗  ██║██╔═══██╗╚██╗██╔╝    ██║   ██║██╔══██╗
 ██████╔╝█████╗  ██╔██╗ ██║██║   ██║ ╚███╔╝     ██║   ██║╚██████║
 ██╔══██╗██╔══╝  ██║╚██╗██║██║   ██║ ██╔██╗     ╚██╗ ██╔╝ ╚═══██║
 ██║  ██║███████╗██║ ╚████║╚██████╔╝██╔╝ ██╗     ╚████╔╝  █████╔╝
 ╚═╝  ╚═╝╚══════╝╚═╝  ╚═══╝ ╚═════╝ ╚═╝  ╚═╝      ╚═══╝   ╚════╝ 
                                                                ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" \n How to Fully Unban: Run Apple Cleaner, when it is finished Run Epic Games and FN whit Steam");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" [1] Apple Cleaner");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" 2. Methode! (only use if first dont work) Run Apple Cleaner, when it is finished Run Inverse Spoofer");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" [2] Inverse Spoofer");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" [3] go back to Home");
            Console.WriteLine();
            Console.Write(" ");
            string option2 = Console.ReadLine();

            if (option2 == "1")
            {
                Console.Clear();
                Class2.Print("[+] Runing Apple Cleaner... (if they ask you about Network Reset press: No) (for spoof mac click: Yes)");
                Cheats.AppleCleaner();
                Console.Clear();
                goto Home;
            }
            if (option2 == "2")
            {
                Console.Clear();
                Class2.Print("[+] Runing Inverse Spoofer...");
                Cheats.InverseSpoofer();
                Console.Clear();
                goto Home;
            }
            else if (option2 == "3")
            {
                Console.Clear();
                goto Home;
            }


            else
            {
                Console.Clear();
                goto Unban;
            }
        }
    }
}
