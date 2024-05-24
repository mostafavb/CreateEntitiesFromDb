using System;
using System.Collections.Generic;

namespace CreateEntitiesFromDb.Entities;

public partial class Route
{
    public int Id { get; set; }

    public int? LocationIdOrigin { get; set; }

    public int? LocationIdDestination { get; set; }

    public int? LocationIdVia { get; set; }

    public int? OceanTransitDays { get; set; }

    public int? DwellDays { get; set; }

    public int? IntermodalTransitDays { get; set; }

    public int? DrayageDays { get; set; }

    public int? UnloadDays { get; set; }

    public int? ReceivingProcessingDays { get; set; }

    public int? ContingencyDays { get; set; }

    public string? LandCostId { get; set; }

    public virtual ICollection<Container> Containers { get; set; } = new List<Container>();

    public virtual Location? LocationIdDestinationNavigation { get; set; }

    public virtual Location? LocationIdOriginNavigation { get; set; }

    public virtual Location? LocationIdViaNavigation { get; set; }
}
