using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Bridge
{
    public interface ILedTv
    {
        void SwitchOn();
        void SwitchOff();
        void SetChannel(int channelNumber);
    }
}