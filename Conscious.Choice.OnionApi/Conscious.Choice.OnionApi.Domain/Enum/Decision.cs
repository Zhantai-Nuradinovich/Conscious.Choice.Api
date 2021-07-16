using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Conscious.Choice.OnionApi.Domain.Entities
{
    public enum Decision
    {
        Absent,
        Agreed,
        Rejected,
        Initiator
    }
}
