using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public abstract class Remote
    {
        private readonly Device _theDevice;

        protected Remote(Device newDevice)
        {
            _theDevice = newDevice;
        }

        public void ArrowRightButtonPressed()
        {
            _theDevice.ArrowRightButtonPressed();
        }
        public void ArrowLeftButtonPressed()
        {
            _theDevice.ArrowLeftButtonPressed();
        }

        public void DeviceFeedback()
        {
            _theDevice.DeviceFeedback();
        }

        public abstract void MiddleButtonPressed();
    }
}
