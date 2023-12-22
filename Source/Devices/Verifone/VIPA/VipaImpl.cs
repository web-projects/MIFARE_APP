using Devices.Verifone.VIPA.Helpers;
using Devices.Verifone.VIPA.Interfaces;
using Devices.Verifone.VIPA.MiFare;
using System;

namespace Devices.Verifone.VIPA
{
    internal class VipaImpl : IVipa
    {
        private MiFareImpl miFareImpl = new MiFareImpl();

        public CardStatus GetCardStatus()
            => CardStatus.GetDeviceHealth;

        public CardStatus StartTransaction()
        {
            miFareImpl.SetAuthenticated();
            Console.WriteLine($"DEVICE: MiFare authenticated={miFareImpl.IsAuthenticated()}");
            return CardStatus.CardData;
        }
    }
}
