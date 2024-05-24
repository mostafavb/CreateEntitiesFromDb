using System;
using System.Collections.Generic;

namespace CreateEntitiesFromDb.Entities;

public partial class Container
{
    public int Id { get; set; }

    public string? ContainerCode { get; set; }

    public int StatusId { get; set; }

    public string? BookingNumber { get; set; }

    public string? PaymentConfirmationNumber { get; set; }

    public int? RouteId { get; set; }

    public int? FreightForwarderId { get; set; }

    public string? Vessel { get; set; }

    public DateOnly? ShipDate { get; set; }

    public DateOnly? TerminalDate { get; set; }

    public DateOnly? PortDate { get; set; }

    public DateOnly? CustomsDate { get; set; }

    public DateOnly? DeliveryDate { get; set; }

    public DateOnly? EmptyReturnDate { get; set; }

    public DateOnly? PaymentDate { get; set; }

    public string? TelexRelease { get; set; }

    public virtual ICollection<ContainerLine> ContainerLines { get; set; } = new List<ContainerLine>();

    public virtual Route? Route { get; set; }
}
