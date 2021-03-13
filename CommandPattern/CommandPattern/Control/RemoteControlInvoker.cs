using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Control
{
    public class RemoteControlInvoker
    {

        private IControlCommand[] Commands;


        public RemoteControlInvoker()
        {
            Commands = new IControlCommand[2];
        }

        public void SetCommand(int index, IControlCommand command)
        {
            Commands[index] = command;
        }

        public void OnButtonPushed(int index)
        {
            Commands[index].Execute();
        }

    }
}
