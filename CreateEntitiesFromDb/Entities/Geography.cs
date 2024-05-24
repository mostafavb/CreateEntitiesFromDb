using System;
using System.Collections.Generic;

namespace CreateEntitiesFromDb.Entities;

public partial class Geography
{
    public int GeographyId { get; set; }

    public string? ZipCode { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Country { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public virtual ICollection<Location> Locations { get; set; } = new List<Location>();
}
