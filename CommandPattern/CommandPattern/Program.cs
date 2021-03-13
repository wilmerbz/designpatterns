using CommandPattern.Control;
using CommandPattern.Devices;
using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            var tv = new TV();

            var remoteControl = new RemoteControlInvoker();

            var tvOnCOmmand = new TVOnCommand(tv);
            var tvOffCOmmand = new TVOffCommand(tv);

            //Configure commands
            remoteControl.SetCommand(0, tvOnCOmmand);
            remoteControl.SetCommand(1, tvOffCOmmand);


            //Execute commands
            remoteControl.OnButtonPushed(0);
            remoteControl.OnButtonPushed(1);

            Console.ReadKey();
        }
    }
}
