using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    class DVD : Device
    {
        public DVD(int newDeviceState, int newMaxSetting)
        {
            DeviceState = newDeviceState;
            MaxSetting = newMaxSetting;
        }

        public override void ArrowRightButtonPressed()
        {
            Console.WriteLine("Skipped one scene");

            DeviceState--;
        }

        public override void ArrowLeftButtonPressed()
        {
            Console.WriteLine("Went back one scene");

            DeviceState--;
        }
    }
}
