namespace CreateEntitiesFromDb.Entities;

public partial class Location
{
    public int Id { get; set; }

    public string? LocationName { get; set; }

    public int? LocationTypeId { get; set; }

    public int? GeographyId { get; set; }

    public string? WarehouseCode { get; set; }

    public string? PortInternationalCode { get; set; }

    public virtual ICollection<Route> RouteLocationIdDestinationNavigations { get; set; } = new List<Route>();

    public virtual ICollection<Route> RouteLocationIdOriginNavigations { get; set; } = new List<Route>();

    public virtual ICollection<Route> RouteLocationIdViaNavigations { get; set; } = new List<Route>();

    public virtual Geography? Geography { get; set; }

    public virtual LocationType? LocationType { get; set; }
}
