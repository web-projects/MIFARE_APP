using Devices.Verifone.VIPA.MiFare.Interfaces;

namespace Devices.Verifone.VIPA.MiFare
{
    internal class MiFareCardImpl : IMiFareCard
    {
        private bool authenticated;

        public bool IsAuthenticated()
            => authenticated;

        public void SetAuthenticated()
            => authenticated = true;

        public byte[] MiFareFileData()
            => new byte[] { 0xDE, 0xAD, 0xBE, 0xEF };
    }
}
