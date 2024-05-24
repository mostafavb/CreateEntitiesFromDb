using System;
using System.Collections.Generic;

namespace CreateEntitiesFromDb.Entities;

public partial class ContainerLine
{
    public int ContainerLineId { get; set; }

    public int? ContainerId { get; set; }

    public int? QuantityInContainer { get; set; }

    public decimal? Fobprice { get; set; }

    public int? Gpid { get; set; }

    public int? Orderline { get; set; }

    public int? OrderNumber { get; set; }

    public DateOnly? SellableDate { get; set; }

    public virtual Container? Container { get; set; }
}
