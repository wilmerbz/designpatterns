using CommandPattern.Devices;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Control
{
    public class TVOffCommand : IControlCommand
    {
        private TV TV { get; set; }

        private int _currentVolume;
        private int _currentChannel;

        public TVOffCommand(TV tv)
        {
            TV = tv;
        }

        public void Execute()
        {
            _currentVolume = TV.Volume;
            _currentChannel = TV.Channel;
            TV.SetVolume(0);
            TV.SetChannel(0);
            TV.TurnOff();
        }

        public void Undo()
        {
            TV.TurnOn();
            TV.SetVolume(_currentVolume);
            TV.SetChannel(_currentChannel);
        }
    }
}
