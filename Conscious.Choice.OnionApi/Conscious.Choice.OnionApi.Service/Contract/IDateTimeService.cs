using System;

namespace Conscious.Choice.OnionApi.Service.Contract
{
    public interface IDateTimeService
    {
        DateTime NowUtc { get; }
    }
}
