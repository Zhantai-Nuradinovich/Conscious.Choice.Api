﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Conscious.Choice.OnionApi.Domain.Entities
{
    public class MDeputy
    {
        public string Name { get; set; }
        public List<TVote> Votes { get; set; }
    }
}
