using System;

namespace Win11ClockToggler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (IsModifierOn(args, "help"))
            {
                Console.WriteLine(helpStr);
                Console.ReadKey(); 
                return;
            }

            //Check the success of the operation
            bool operationSucceeded = false;
            //Operation performed (hide or show)
            Helper.SWOperation operation;
            //Default value for the argument for which element to hide
            string hiddenElement = "notificationArea";

            //Try to hide the selected element
            if (IsModifierOn(args, "clock"))
            {
                hiddenElement = "clock";
                operationSucceeded = Helper.ShowOrHideTaskbarElementWindow(Helper.TaskbarElement.Clock, out operation);
            }
            else
            {
                //Select the correct area to hide (by default it hides only the clock)
                operationSucceeded = Helper.ShowOrHideTaskbarElementWindow(Helper.TaskbarElement.FullNotificationArea, out operation);
            }

            //Check success
            if (operationSucceeded)
            {
                //Check if it has been hidden or made visible to inform
                if (operation == Helper.SWOperation.Hide)
                { 
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("The Windows taskbar {0} has been hidden!", hiddenElement);
                    Console.ResetColor();
                    Console.WriteLine("Run this program again to show it back...");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("The Windows taskbar {0} has been shown again!", hiddenElement);
                    Console.ResetColor();
                    Console.WriteLine("Run this program again to hide it...");
                }
            }
            else    //If it fails
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("I can't find the Windows {0} to hide it!", hiddenElement);
                Console.ResetColor();
                Console.WriteLine("This program only works with Windows 11. " +
                    "If you're running it in Windows 11, please download the latest version from https://github.com/jmalarcon/Win11ClockToggler. " +
                    "If you already have the latest version, maybe a Windows 11 update has broken the compatibility. Please, open an issue to let me know!");
            }

            //If in batch mode, then don't wait for confirmation to end
            if (IsModifierOn(args, "batch"))
                return;

            Console.WriteLine("Press any key to end");
            Console.WriteLine("If you want to run this program in a batch, use the -b, /b or --batch argument at the time of running it.");
            Console.WriteLine("Use it with -h, /h or --help to see its options.");
            Console.ReadKey();
        }


        //Helper function to check if a modifier is present in the arguments
        //with a -, / in short form (1 letter) or -- in long form (complete word)
        internal static bool IsModifierOn(string[] args, string argName)
        {
            if (args.Length == 0) return false;
            argName = argName.Trim().ToLower();
            foreach (string arg in args)
            {
                if (arg == "-"+ argName.Substring(0,1) || arg == "/" + argName.Substring(0, 1) || arg == "--" + argName)
                    return true;
            }
            return false;
        }

        //Help string (aside to make the beginning clearer)
        static string helpStr = @"This program searches and hides the full notification area or just the clock in the Windows 11 taskbar, 
since this OS lacks this feature and this is a bummer for recording 
your screen for tutorials and other similar tasks.

Just run it and it'll hide the whole notification area by default. 
To show it again, just run the program again too. It will detect 
the previous stae and change it accordingly.
If you want to hide just the clock, use the appropiate switch (see below),
however, take into account that it'll hide the clock and the system icons too. 
This is due to how that area is build in the Windows 11 taskbar.

It works for Windows 10 too, but it will always hide the full notification area.
If you just want to hide the clock in Windows 10, you already have native support for it
in the notifications' configuration of the Windows Settings app

Arguments:
-h, /h, --help: this help
-n, /n, --notificationArea: hides the full notification area, not just the clock (cleaner. Default option)
-c, /c, --clock: hides just the clock (and system icons)
-b, /b, --batch: doesn't wait for a key to be pressed after running. Useful to include the tool in a script file.

More information and new versions at: https://github.com/jmalarcon/Win11ClockToggler

If you find any kind of problem, download the latest version or open a new issue in the repo.
";
    }
}
