using Devices.Verifone.VIPA.Helpers;
using Devices.Verifone.VIPA.Interfaces;
using Devices.Verifone.VIPA.MiFare;
using System;
using System.Collections.Generic;

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
            // retrieve card data from card
            miFareCard.GetFileDataFromCard();

            Dictionary<FileTypes, byte[]> fileDataDictionary = miFareCard.GetMiFareFileData();
            foreach (var fileData in fileDataDictionary)
            {
                Console.WriteLine(string.Format("DEVICE: MiFare File={0} - DATA=[{1}]",
                              fileData.Key,
                              //ConversionHelper.ByteArrayToHexString(fileData)));
                              BitConverter.ToString(fileData.Value).Replace("-", ".")));
            }
            return CardStatus.CardData;
        }
    }
}
