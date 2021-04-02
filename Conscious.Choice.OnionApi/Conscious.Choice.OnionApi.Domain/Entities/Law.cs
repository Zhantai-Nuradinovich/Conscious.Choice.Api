using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Conscious.Choice.OnionApi.Domain.Entities
{
    public class Law : BaseEntity
    {
        public string LawName { get; set; }
        public DateTime OfferDate { get; set; }
    }
}
