using Devices.Verifone.VIPA.Helpers;
using System.Collections.Generic;

namespace Devices.Verifone.VIPA.MiFare.Interfaces
{
    interface IMiFareCard
    {
        void SetAuthenticated();
        bool IsAuthenticated();
        void GetFileDataFromCard();
        Dictionary<FileTypes, byte[]> GetMiFareFileData();
    }
}
