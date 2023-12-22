using Devices.Verifone.VIPA.MiFare.Interfaces;
using System;

namespace Devices.Verifone.VIPA.MiFare
{
    internal class MiFareImpl : IMiFare, IMiFareCard
    {
        private MiFareCardImpl miFareCardImpl = new MiFareCardImpl();

        public bool IsAuthenticated()
            => miFareCardImpl.IsAuthenticated();

        public void SetAuthenticated()
            => miFareCardImpl.SetAuthenticated();
    }
}
