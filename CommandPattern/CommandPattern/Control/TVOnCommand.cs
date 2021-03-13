using CommandPattern.Devices;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Control
{
    public class TVOnCommand : IControlCommand
    {

        private TV TV { get; set; }

        public TVOnCommand(TV tv)
        {
            TV = tv;
        }

        public void Execute()
        {
            TV.TurnOn();
            TV.SetChannel(5);
            TV.SetVolume(25);
        }

        public void Undo()
        {
            TV.TurnOff();
        }
    }
}
