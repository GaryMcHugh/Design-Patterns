using System;

namespace BridgePattern
{
    public class TV : Device
    {
        public TV(int newDeviceState, int newMaxSetting)
        {
            DeviceState = newDeviceState;
            MaxSetting = newMaxSetting;
        }

        public override void ArrowRightButtonPressed()
        {
            Console.WriteLine("Channel Up");

            DeviceState++;
        }

        public override void ArrowLeftButtonPressed()
        {
            Console.WriteLine("Channel Down");

            DeviceState--;
        }
    }
}
