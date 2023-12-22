using Devices.Verifone.VIPA;
using Devices.Verifone.VIPA.Helpers;
using Devices.Verifone.VIPA.Interfaces;
using System;

namespace Devices.Verifone
{
    public class VerifoneDevice
    {
        private IVipa vipaDevice = new VipaImpl();

        public void DeviceHealth()
        {
            CardStatus cardStatus = vipaDevice.GetCardStatus();
            Console.WriteLine($"DEVICE: status={cardStatus}");

            cardStatus = vipaDevice.StartTransaction();
            Console.WriteLine($"DEVICE: GetPayment status={cardStatus}");

            cardStatus = vipaDevice.ContinueContactlessTransaction();
            Console.WriteLine($"DEVICE: GetPayment status={cardStatus}");
        }
    }
}
