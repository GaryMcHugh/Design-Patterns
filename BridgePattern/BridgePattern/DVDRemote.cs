using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public class DVDRemote : Remote
    {
        private bool _play = true;

        public DVDRemote(Device newDevice) : base(newDevice)
        {
        }

        public override void MiddleButtonPressed()
        {
            _play = !_play;

            Console.WriteLine(_play == false ? "DVD was paused" : "DVD is playing");
        }
    }
}
