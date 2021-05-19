﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Bridge
{
    public class SonyRemoteControl : AbstractRemoteControl
    {
        public SonyRemoteControl(ILedTv ledTv) : base(ledTv)
        {
        }

        public override void SwitchOn()
        {
            ledTv.SwitchOn();
        }

        public override void SwitchOff()
        {
            ledTv.SwitchOff();
        }

        public override void SetChannel(int channelNumber)
        {
            ledTv.SetChannel(channelNumber);
        }
    }
}