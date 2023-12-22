using Common.Helpers;

namespace Devices.Verifone.VIPA.Helpers
{
    public enum CardStatus : int
    {
        [StringValue("VIPA: GET DEVICE INFO")]
        GetDeviceInfo, 
        [StringValue("VIPA: GET DEVICE HEALTH")]
        GetDeviceHealth,
        [StringValue("VIPA: GET CARD DATA")]
        CardData,
    }
}
