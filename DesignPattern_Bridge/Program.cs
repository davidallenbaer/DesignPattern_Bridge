﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Bridge
{
    public class Program
    {
        static void Main(string[] args)
        {
            SonyRemoteControl sonyRemoteControl = new SonyRemoteControl(new SonyLedTv());
            sonyRemoteControl.SwitchOn();
            sonyRemoteControl.SetChannel(101);
            sonyRemoteControl.SwitchOff();

            Console.WriteLine();
            SamsungRemoteControl samsungRemoteControl = new SamsungRemoteControl(new SamsungLedTv());
            samsungRemoteControl.SwitchOn();
            samsungRemoteControl.SetChannel(202);
            samsungRemoteControl.SwitchOff();

            Console.ReadKey();
        }
    }
}
