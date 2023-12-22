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
    }
}
