using Devices.Verifone.VIPA.Helpers;
using Devices.Verifone.VIPA.MiFare.Interfaces;
using System.Collections.Generic;

namespace Devices.Verifone.VIPA.MiFare
{
    internal class MiFareCardImpl : IMiFareCard
    {
        private bool authenticated;

        private Dictionary<FileTypes, byte[]> fileDataDictionary = new Dictionary<FileTypes, byte[]>();

        public bool IsAuthenticated()
            => authenticated;

        public void SetAuthenticated()
            => authenticated = true;

        public void GetFileDataFromCard()
        {
            fileDataDictionary.Add(FileTypes.EnvironmentHolder, new byte[] { 0xDE, 0xAD });
            fileDataDictionary.Add(FileTypes.StandardDataFile, new byte[] { 0xBE, 0xEF });
        }
        public Dictionary<FileTypes, byte[]> GetMiFareFileData()
            => fileDataDictionary;
    }
}
