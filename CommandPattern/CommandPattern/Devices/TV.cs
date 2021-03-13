using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Devices
{
    public class TV
    {
        public int Channel { get; set; }
        public int Volume { get; set; }
        public void TurnOn()
        {
            Console.WriteLine("TV ON!");
        }


        public void TurnOff()
        {
            Console.WriteLine("TV OFF!");
        }


        public void SetChannel(int channel)
        {
            Channel = channel;
            Console.WriteLine($"TV Channel set to: {channel}");
        }

        public void NextChannel()
        {
            Channel++;
            Console.WriteLine($"Next TV Channel: {Channel}");
        }

        public void PreviousChannel()
        {
            Channel--;
            Console.WriteLine($"Previous TV Channel: {Channel}");
        }

        public void SetVolume(int volume)
        {
            Volume = volume;
            Console.WriteLine($"TV Volume set to: {Volume}");
        }

        public void VolumeUp()
        {
            Volume++;
            Console.WriteLine($"TV Volume UP: {Volume}");
        }

        public void VolumeDown()
        {
            Volume--;
            Console.WriteLine($"TV Volume DOWN: {Volume}");
        }
    }
}
