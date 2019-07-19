using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public abstract class Device
    {
        public int DeviceState;
        public int MaxSetting;
        public int VolumeLevel = 0;

        public abstract void ArrowRightButtonPressed();
        public abstract void ArrowLeftButtonPressed();

        public void DeviceFeedback()
        {
            if (DeviceState > MaxSetting || DeviceState < 0)
            {
                DeviceState = 0;
                Console.WriteLine("On Channel: " + DeviceState);
            }
        }

        public void PlusButtonPressed()
        {
            VolumeLevel++;

            Console.WriteLine("Volume at: " + VolumeLevel);
        }

        public void MinusButtonPressed()
        {
            VolumeLevel--;

            Console.WriteLine("Volume at: " + VolumeLevel);
        }
    }
}
