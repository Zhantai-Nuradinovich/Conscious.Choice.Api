using Conscious.Choice.OnionApi.Service.Contract;
using System;

namespace Conscious.Choice.OnionApi.Service.Implementation
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}