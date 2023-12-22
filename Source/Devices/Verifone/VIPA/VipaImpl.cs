using Common.Helpers;
using Devices.Verifone.VIPA.Helpers;
using Devices.Verifone.VIPA.Interfaces;
using Devices.Verifone.VIPA.MiFare;
using System;
using System.Text;

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

        public CardStatus ContinueContactlessTransaction()
        {
            byte[] cardData = miFareImpl.MiFareFileData();
            Console.WriteLine(string.Format("DEVICE: MiFare DATA=[{0}]", 
                              //ConversionHelper.ByteArrayToHexString(cardData)));
                              BitConverter.ToString(cardData).Replace("-", ".")));
            return CardStatus.CardData;
        }
    }
}
