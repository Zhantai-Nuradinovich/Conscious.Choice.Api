using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Conscious.Choice.OnionApi.Domain.Entities
{
    public class Decision : BaseEntity
    {
        public string Result { get; set; }
    }
}
