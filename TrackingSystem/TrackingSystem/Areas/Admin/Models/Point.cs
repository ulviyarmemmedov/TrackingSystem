using System;
using System.Collections.Generic;

namespace TrackingSystem.Models;

public partial class Point
{
    public int Id { get; set; }

    public int CountryId { get; set; }

    public string Description { get; set; } = null!;

    public DateTime ApproximateDate { get; set; }

    public bool Status { get; set; }

    public int OrderId { get; set; }

    public DateTime? FactDate { get; set; }

    public virtual Country Country { get; set; } = null!;

    public virtual Order Order { get; set; } = null!;
}
