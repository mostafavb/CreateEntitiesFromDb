using System;
using System.Collections.Generic;

namespace CreateEntitiesFromDb.Entities;

public partial class LocationType
{
    public int LocationTypeId { get; set; }

    public string? LocationTypeName { get; set; }

    public virtual ICollection<Location> Locations { get; set; } = new List<Location>();
}
