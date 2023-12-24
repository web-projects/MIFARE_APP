using Devices.Verifone.VIPA.Helpers;
using Devices.Verifone.VIPA.Interfaces;
using Devices.Verifone.VIPA.MiFare;
using System;

namespace Devices.Verifone.VIPA
{
    internal class VipaImpl : IVipa
    {
        private MiFareCardImpl miFareCard = new MiFareCardImpl();

        public CardStatus GetCardStatus()
            => CardStatus.GetDeviceHealth;

        public CardStatus StartTransaction()
        {
            miFareCard.SetAuthenticated();
            Console.WriteLine($"DEVICE: MiFare authenticated={miFareCard.IsAuthenticated()}");
            return CardStatus.CardData;
        }

        public CardStatus ContinueContactlessTransaction()
        {
            byte[] cardData = miFareCard.MiFareFileData();
            Console.WriteLine(string.Format("DEVICE: MiFare DATA=[{0}]",
                              //ConversionHelper.ByteArrayToHexString(cardData)));
                              BitConverter.ToString(cardData).Replace("-", ".")));
            return CardStatus.CardData;
        }
    }
}
