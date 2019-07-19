using System;

namespace BridgePattern
{
    public class smartTvRemote : Remote
    {
        public smartTvRemote(Device newDevice) : base(newDevice)
        {

        }

        public override void MiddleButtonPressed()
        {
            Console.WriteLine("TV was paused");
        }
    }
}
