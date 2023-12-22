namespace Devices.Verifone.VIPA.MiFare.Interfaces
{
    interface IMiFareCard
    {
        void SetAuthenticated();
        bool IsAuthenticated();
    }
}
