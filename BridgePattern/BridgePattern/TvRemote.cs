using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public class TvRemote : Remote
    {
        public TvRemote(Device newDevice) : base(newDevice)
        {

        }

        public override void MiddleButtonPressed()
        {
            Console.WriteLine("TV was muted");
        }
    }
}
