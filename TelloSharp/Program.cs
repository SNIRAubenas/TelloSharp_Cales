using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using TelloLibrary;

namespace TelloSharp
{
    class Program
    {

        static void Main(string[] args)
        {
            //
            Console.WriteLine("Ouverture de connection vers Tello.....");
            var ipAddress = "127.0.0.1";
            Tello drone = new Tello(ipAddress);
            int cmdCode;
            //
            do
            {
                cmdCode = MenuPage();
                //
                switch (cmdCode)
                {
                    case 0:
                    drone.TakeOff();
                        break;
                    default:
                        break;
                }
            } while (cmdCode != 0);
            Console.WriteLine("Appuyez sur Return pour sortir.");
            Console.ReadLine();
            drone.Dispose();
        }

        private static int MenuPage()
        {
            Console.WriteLine("0. Quit");
            Console.WriteLine("1. Command");
            Console.WriteLine("2. Battery");
            Console.WriteLine("3. TakeOff");
            Console.WriteLine("4. Land");
            Console.WriteLine("5. Turn Clockwise");
            Console.WriteLine("6. Forward");
            Console.WriteLine("7. Left");
            Console.WriteLine("8. Right");
            Console.WriteLine("9. Backward");
            //
            string cmd = Console.ReadLine();
            int cmdCode;
            if (!int.TryParse(cmd, out cmdCode))
            {
                cmdCode = -1;
            }
            //
            return cmdCode;
        }


    }
}
