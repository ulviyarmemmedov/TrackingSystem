using System;
using System.Collections.Generic;

namespace TrackingSystem.Models;

public partial class Country
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int CountryCode { get; set; }

    public bool Status { get; set; } = true;

    public virtual ICollection<Order> OrderDestinationCountries { get; set; } = new List<Order>();

    public virtual ICollection<Order> OrderStartCountries { get; set; } = new List<Order>();

    public virtual ICollection<Point> Points { get; set; } = new List<Point>();
}
