using Devices.Verifone.VIPA.Helpers;

namespace Devices.Verifone.VIPA.Interfaces
{
    interface IVipa
    {
        CardStatus GetCardStatus();
        CardStatus StartTransaction();
        CardStatus ContinueContactlessTransaction();
    }
}
